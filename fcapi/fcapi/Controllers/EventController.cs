using fcapi.DTO;
using fcapi.Models;
using fcapi.ViewModel.Event;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace fcapi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EventController : ControllerBase
    {
        private readonly FcMRPComp01Context _fcMRPComp01Context;
        public EventController(FcMRPComp01Context fcMRPComp01Context)
        {
            _fcMRPComp01Context = fcMRPComp01Context;
        }
        /// <summary>
        /// 取得全部Event
        /// </summary>
        [HttpGet("GetAllEvent")]
        public IActionResult GetAllEvent()
        {
            var result = new Result();
            try
            {
               

                var data = from i in _fcMRPComp01Context.Events
                           join c in _fcMRPComp01Context.Employees on i.EmployeeId equals c.EmployeeId
                           join d in _fcMRPComp01Context.Departments on c.DeptId equals d.DeptId
                           where i.IsDelete == false 

                           select new reviewFormDto
                           {
                               ID =i.Id,
                               arrivalDate = i.StartTime,
                               createdDate = i.CreateTime,
                               department = new department
                               {
                                   name = d.DeptName,
                                   type = ""
                               },
                               employee = new employee
                               {
                                   name = c.Name,
                                   number = c.EmployeeId
                               },
                               eventItems = (from b in _fcMRPComp01Context.EventItems
                                             where b.EventId == i.Id && b.IsDelete==false
                                             select new eventItem
                                             {
                                                 topic = b.Topic,
                                                 type = b.Type,
                                                 sort = b.Sort,
                                                 isattendance = b.Isattendance,
                                                 scores =new scores
                                       {
                                   ceoScore = b.CeoScore,
                                   selfScore = b.SelfScore,
                                   supervisorScore = b.SupervisorScore
                               },
                                                 attendance = new attendance
                                       {
                                           absence =b.Absence,
                                           late =b.Late,
                                           sick =b.Sick,
                                           special =b.Special
                                       }
                                             }

                               ).ToList()
                               //new eventItem
                               //{
                               //    topic =b.Topic,
                               //    type =b.Type,
                               //    sort =b.Sort,
                               //    isattendance =b.Isattendance,
                               //    scores =
                               //    {
                               //        ceoScore =b.CeoScore,
                               //        selfScore =b.SelfScore,
                               //        supervisorScore =b.SupervisorScore
                               //    },
                               //    attendance =
                               //    {
                               //        absence =b.Absence,
                               //        late =b.Late,
                               //        sick =b.Sick,
                               //        special =b.Special
                               //    }
                               //}
                               ,
                               eventId = i.Id,
                               eventName = i.EventName,
                               jobTitle = d.DeptName,
                               reviewDateRange = new reviewDateRange
                               {
                                   starttime = i.ReviewStartDate,
                                   endtime = i.ReviewEndDate
                               }


                           };

                result.issucess = true;
                result.response = "成功";
                result.Data = data;
                          
                    
            }
            catch (Exception ex)
            {
                result.issucess = false;
                result.response = ex.Message;
                result.Data = null;
            }
            return Ok(result);
        }
        /// <summary>
        /// 新增Event
        /// </summary>
        [HttpPost("CreateEvent")]
        public IActionResult CreateEvent(reviewFormDto reviewFormDto)
        {
            var result = new Result();
            try
            {
                var newevent = new Event
                {
                    CreateTime = DateTime.Now,
                    StartTime = reviewFormDto.createdDate,
                    EndTime =reviewFormDto.arrivalDate,
                    EventName =reviewFormDto.eventName,
                    ReviewStartDate =reviewFormDto.reviewDateRange.starttime,
                    ReviewEndDate =reviewFormDto.reviewDateRange.endtime,
                    IsDelete =false,
                    EmployeeId =reviewFormDto.employee.number
                };
                _fcMRPComp01Context.Add(newevent);
                _fcMRPComp01Context.SaveChanges();
                foreach (var item in reviewFormDto.eventItems)
                {
                    var neweventitem = new EventItem
                    {
                        EventId = reviewFormDto.eventId,
                        Sort = item.sort,
                        CeoScore = item.scores.ceoScore,
                        SelfScore = item.scores.selfScore,
                        SupervisorScore = item.scores.supervisorScore,
                        Topic = item.topic,
                        Type = item.type,
                        IsDelete = false,
                        Createtime = DateTime.Now,
                        Isattendance = item.isattendance,
                        Absence = item.attendance.absence,
                        Late = item.attendance.late,
                        Sick = item.attendance.sick,
                        Special = item.attendance.special
                    };
                    _fcMRPComp01Context.Add(neweventitem);
                }
                _fcMRPComp01Context.SaveChanges();
                result.issucess = true;
                result.response = "新增成功";
                result.Data = null;


            }
            catch (Exception ex)
            {
                result.issucess = false;
                result.response = ex.Message;
                result.Data = null;
            }
            return Ok(result);
        }

        /// <summary>
        /// 修改Event
        /// </summary>
        [HttpPost("AlternetEvent")]
        public IActionResult AlternetEvent(reviewFormDto reviewFormDto)
        {
            var result = new Result();
            try
            {
                var oldevent = from i in _fcMRPComp01Context.Events
                               where i.Id == reviewFormDto.ID
                               select i;
                foreach(var item in oldevent.ToList())
                {
                    item.StartTime = reviewFormDto.createdDate;
                    item.EndTime = reviewFormDto.arrivalDate;
                    item.EventName = reviewFormDto.eventName;
                    item.ReviewStartDate = reviewFormDto.reviewDateRange.starttime;
                    item.ReviewEndDate = reviewFormDto.reviewDateRange.endtime;
                    item.EmployeeId = reviewFormDto.employee.number;
                    _fcMRPComp01Context.SaveChanges();
                }
                foreach (var item in reviewFormDto.eventItems)
                {
                    var oldeventitem = from i in _fcMRPComp01Context.EventItems
                                       where i.Id == item.ID
                                       select i;
                    foreach(var items in oldeventitem.ToList())
                    {

                        items.Sort = item.sort;
                         items.CeoScore = item.scores.ceoScore;
                        items.SelfScore = item.scores.selfScore;
                        items.SupervisorScore = item.scores.supervisorScore;
                        items.Topic = item.topic;
                        items.Type = item.type;
                        items.Isattendance = item.isattendance;
                        items.Absence = item.attendance.absence;
                        items.Late = item.attendance.late;
                        items.Sick = item.attendance.sick;
                        items.Special = item.attendance.special;
                        _fcMRPComp01Context.SaveChanges();
                    }
                    _fcMRPComp01Context.SaveChanges();
                }
                _fcMRPComp01Context.SaveChanges();
                result.issucess = true;
                result.response = "修改成功";
                result.Data = null;


            }
            catch (Exception ex)
            {
                result.issucess = false;
                result.response = ex.Message;
                result.Data = null;
            }
            return Ok(result);
        }

        /// <summary>
        /// 刪除Event
        /// </summary>
        [HttpPost("deleteEvent")]
        public IActionResult deleteEvent(reviewFormDto reviewFormDto)
        {
            var result = new Result();
            try
            {
                var oldevent = from i in _fcMRPComp01Context.Events
                               where i.Id == reviewFormDto.ID
                               select i;
                foreach (var item in oldevent.ToList())
                {
                    item.IsDelete = true;
                    _fcMRPComp01Context.SaveChanges();
                }
                foreach (var item in reviewFormDto.eventItems)
                {
                    var oldeventitem = from i in _fcMRPComp01Context.EventItems
                                       where i.Id == item.ID
                                       select i;
                    foreach (var items in oldeventitem.ToList())
                    {

                        items.IsDelete = true;

                        _fcMRPComp01Context.SaveChanges();
                    }
                    _fcMRPComp01Context.SaveChanges();
                }
                _fcMRPComp01Context.SaveChanges();
                result.issucess = true;
                result.response = "修改成功";
                result.Data = null;


            }
            catch (Exception ex)
            {
                result.issucess = false;
                result.response = ex.Message;
                result.Data = null;
            }
            return Ok(result);
        }

    }
}

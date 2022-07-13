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
                                             where b.EventId == i.Id
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
                foreach(var item in reviewFormDto.eventItems)
                {
                    var neweventitem = new EventItem
                    {
                        EventId =reviewFormDto.eventId,
                        Sort =item.sort,

                    };
                }
                

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

    }
}

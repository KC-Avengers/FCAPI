using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using fcapi.Models;
using fcapi.DTO;
using Microsoft.AspNetCore.Cors;

namespace fcapi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ScheduleEventsController : Controller
    {
        private readonly FcMRPComp01Context _context;

        public ScheduleEventsController(FcMRPComp01Context context)
        {
            _context = context;
        }


        /// <summary>
        /// 取得個人行事曆Event
        /// </summary>
        /// <param name="userID"></param>
        /// <returns></returns>
        [HttpGet]
        [EnableCors()]
        [Route("Get/{userID}")]
        public IActionResult ScheduleEvent_GetByUserID(string userID)
        {
            var result = new Result();

            List<DTO_ScheduleEvent> dto_scheduleEvents = new List<DTO_ScheduleEvent>();
            var obj = _context.ScheduleEvents.Where(item => item.UserId.ToString().Equals(userID)).ToList();
            obj.ForEach(item =>
            {
                var start = item.Start.ToString().Split(" ")[0].Split("/");
                var end = item.End.ToString().Split(" ")[0].Split("/");

                var start_month = start[1].Length == 1 ? "0" + start[1] : start[1];
                var end_month = end[1].Length == 1 ? "0" + end[1] : end[1];

                dto_scheduleEvents.Add(new DTO_ScheduleEvent
                {
                    id = item.Id,
                    title = item.Title,
                    start = String.Format("{0}-{1}-{2}", start[0], start_month, start[2]),
                    end = String.Format("{0}-{1}-{2}", end[0], end_month, end[2]),
                    fullDay = item.FullDay,
                });
            });

            result.Data = dto_scheduleEvents;
            result.response = "搜尋成功";
            result.issucess = true;

            return Ok(result);
        }

        /// <summary>
        /// 新增ScheduleEvent
        /// </summary>
        [HttpPost]
        [EnableCors()]
        [Route("CreateScheduleEvent")]
        public IActionResult ScheduleEvent_Create(ScheduleEvent scheduleEvent)
        {
            var result = new Result();
            result.issucess = true;
            result.response = "新增成功";
            result.Data = null;
            try
            {
                _context.ScheduleEvents.Add(scheduleEvent);
                _context.SaveChanges();
            }
            catch (Exception e)
            {
                result.issucess = false;
                result.response = e.Message;
            }
            return Ok(result);
        }

        /// <summary>
        /// 更新個人行事曆Event
        /// </summary>
        /// <param name="scheduleEvent"></param>
        /// <returns></returns>
        [HttpPut]
        [EnableCors()]
        [Route("Update")]
        public IActionResult ScheduleEvent_Update(ScheduleEvent scheduleEvent)
        {
            var result = new Result();
            result.issucess = true;
            result.response = "更新成功";
            result.Data = null;

            try
            {
                var target = _context.ScheduleEvents.Where(item => item.Id == scheduleEvent.Id).FirstOrDefault();
                if (target != null)
                {
                    target.Title = scheduleEvent.Title;
                    target.Start = scheduleEvent.Start;
                    target.End = scheduleEvent.End;
                    target.FullDay = scheduleEvent.FullDay;
                    _context.SaveChanges();
                }
                else
                {
                    result.issucess = false;
                    result.response = "找不到對應物件";
                }
            }
            catch (Exception e)
            {
                result.issucess = false;
                result.response = "更新失敗";
            }

            return Ok(result);
        }
        /// <summary>
        /// 刪除個人行事曆Event
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpDelete]
        [EnableCors()]
        [Route("Delete/{id}")]
        public IActionResult ScheduleEvent_Delete(string id)
        {
            var result = new Result();
            result.issucess = true;
            result.response = "刪除成功";
            result.Data = null;

            try
            {
                var target = _context.ScheduleEvents.Where(item => item.Id.ToString().Equals(id)).FirstOrDefault();
                if (target != null)
                {
                    _context.ScheduleEvents.Remove(target);
                    _context.SaveChanges();
                }
                else
                {
                    result.issucess = false;
                    result.response = "找不到對應物件";
                }

            }
            catch (Exception e)
            {
                result.issucess = false;
                result.response = "刪除失敗";
            }

            return Ok(result);
        }
    }
}

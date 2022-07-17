using fcapi.DTO;
using fcapi.Models;
using fcapi.ViewModel.Acting;
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
    public class ActingController : ControllerBase
    {
        private readonly FcMRPComp01Context _fcMRPComp01Context;
        public ActingController(FcMRPComp01Context fcMRPComp01Context)
        {
            _fcMRPComp01Context = fcMRPComp01Context;
        }
        /// <summary>
        ///新增該員工簽核設定
        /// </summary>
        [HttpPost("openActing")]
        public IActionResult openActing(Alteracting alteracting)
        {
            var result = new Result();
            try
            {
                
                var emp = from i in _fcMRPComp01Context.Employees
                          where i.EmployeeId == alteracting.EmployeeID
                          select i;
                emp.FirstOrDefault().ActingIsOpen = alteracting.isopen;
                _fcMRPComp01Context.SaveChanges();
                if (alteracting.isopen == false)
                {

                }
                else
                {
                    var chakeold = from i in _fcMRPComp01Context.ActingMaps
                                   where i.EmployeeactingId == alteracting.SettingEmployeeID && i.EmployeeId == alteracting.EmployeeID && i.IsDelete == false
                                   select i;
                    if (chakeold.Count() > 0)
                    {
                        foreach(var item in chakeold)
                        {
                            item.Starttime = alteracting.Starttime;
                            item.Endtime = alteracting.Endtime;
                            _fcMRPComp01Context.SaveChanges();
                        }
                    }
                    else
                    {
                        var newacting = new ActingMap
                        {
                            Createtime = DateTime.Now,
                            IsDelete = false,
                            EmployeeId = alteracting.EmployeeID,
                            EmployeeactingId = alteracting.SettingEmployeeID,
                            Starttime = alteracting.Starttime,
                            Endtime = alteracting.Endtime

                        };
                        _fcMRPComp01Context.Add(newacting);
                        _fcMRPComp01Context.SaveChanges();
                    }
                    
                }

                result.issucess = true;
                result.response = "成功";
                result.Data = "";


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
        /// 取得該員工簽核設定
        /// </summary>
        [HttpGet("GetActing")]
        public IActionResult GetActing(string EmployeeID)
        {
            var result = new Result();
            try
            {
                var data = from i in _fcMRPComp01Context.Employees
                           join b in _fcMRPComp01Context.ActingMaps on i.EmployeeId equals b.EmployeeId
                           where b.IsDelete == false && i.EmployeeId == b.EmployeeactingId
                           select new
                           {
                               name =i.Name,
                               starttime =b.Starttime,
                               endtime =b.Endtime
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
    }
}

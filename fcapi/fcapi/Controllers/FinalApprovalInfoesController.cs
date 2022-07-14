using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using fcapi.Models;
using Microsoft.AspNetCore.Cors;
using fcapi.DTO;

namespace fcapi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class FinalApprovalInfoesController : Controller
    {
        private readonly FcMRPComp01Context _context;

        public FinalApprovalInfoesController(FcMRPComp01Context context)
        {
            _context = context;
        }




        /// <summary>
        /// 新增簽核決定
        /// </summary>
        /// <param name="finalApproval"></param>
        /// <returns></returns>
        [HttpPost]
        [EnableCors()]
        [Route("CreateFinalApproval")]
        public IActionResult FinalApproval_Insert(FinalApprovalInfo finalApproval)
        {
            var result = new Result();
            result.issucess = true;
            result.response = "新增成功";
            result.Data = null;
            try
            {
                _context.FinalApprovalInfos.Add(finalApproval);
                _context.SaveChanges();
            }catch (Exception ex)
            {
                result.issucess = false;
                result.response = "新增失敗";
            }

            return Ok(result);
        }


    }
}

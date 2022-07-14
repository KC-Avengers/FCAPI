using System;
using Microsoft.AspNetCore.Mvc;
using fcapi.Models;
using Microsoft.AspNetCore.Cors;
using fcapi.DTO;
using System.IO;
using System.Drawing;

namespace fcapi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class SignatureInfoesController : Controller
    {
        private readonly FcMRPComp01Context _context;

        public SignatureInfoesController(FcMRPComp01Context context)
        {
            _context = context;
        }


        /// <summary>
        /// 新增簽章資訊
        /// </summary>
        /// <param name="signatureInfo"></param>
        /// <returns></returns>
        [HttpPost]
        [Route("CreateSignatureInfo")]
        [EnableCors()]
        public IActionResult SignatureInfo_Create([FromForm] SignatureInfo signatureinfo)
        {
            var result = new Result();
            result.issucess = true;
            result.response = "新增成功";
            result.Data = null;
            try
            {
                var photostr = signatureinfo.SignaturePath.Split(",")[1];
                byte[] bytes = Convert.FromBase64String(photostr);
                MemoryStream ms = new MemoryStream(bytes, 0, bytes.Length);
                Image image = Image.FromStream(ms);
                image.Save("SignatureImg/"+signatureinfo.CompanyName+".png");

                signatureinfo.Sid = 0;
                signatureinfo.SignaturePath = signatureinfo.CompanyName + ".png";
                _context.SignatureInfos.Add(signatureinfo);
                _context.SaveChanges();
            }
            catch (Exception ex)
            {
                result.issucess = true;
                result.response = "新增失敗";
            }

            return Ok(result);
        }

        [HttpPost]
        [EnableCors()]
        [Route("test")]
        public string justtest()
        {
            return "sss";
        }



    }
}

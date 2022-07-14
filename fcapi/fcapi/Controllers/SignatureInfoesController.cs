using System;
using Microsoft.AspNetCore.Mvc;
using fcapi.Models;
using Microsoft.AspNetCore.Cors;
using fcapi.DTO;
using System.IO;
using System.Drawing;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.Dynamic;

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

        //[HttpGet]
        //[EnableCors()]
        //[Route("changeAPI")]
        //public string changeAPI()
        //{

        //    var appSettingsPath = Path.Combine(System.IO.Directory.GetCurrentDirectory(), "appsettings.json");
        //    var json = System.IO.File.ReadAllText(appSettingsPath);
        //    var jsonSettings = new JsonSerializerSettings();
        //    jsonSettings.Converters.Add(new ExpandoObjectConverter());
        //    jsonSettings.Converters.Add(new StringEnumConverter());
        //    dynamic config = JsonConvert.DeserializeObject<ExpandoObject>(json, jsonSettings);

        //    var connstr1 = "Server=.;Database=FcMRPComp01;Trusted_Connection=True;MultipleActiveResultSets=true";
        //    var connstr2 = "Server=.;Database=FcMRPComp02;Trusted_Connection=True;MultipleActiveResultSets=true";
        //    config.ConnectionStrings.HomeMoney =connstr2;
        //    //"Server=.;Database=FcMRPComp01;Trusted_Connection=True;MultipleActiveResultSets=true"
        //    //"Server=.;Database=FcMRPComp02;Trusted_Connection=True;MultipleActiveResultSets=true"



        //    var newJson = JsonConvert.SerializeObject(config, Formatting.Indented, jsonSettings);
        //    System.IO.File.WriteAllText(appSettingsPath, newJson);
        //    return "FINISH";
        //}



    }
}

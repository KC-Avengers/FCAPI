using fcapi.DTO;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;

namespace fcapi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class MainController : Controller
    {
        private readonly MyDbContext _context;

        public MainController(MyDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        [EnableCors()]
        [Route("ScheduleEvent/Get/{userID}")]
        public IActionResult ScheduleEvent_GetByUserID(string userID)
        {
            List<DTO_ScheduleEvent> dto_scheduleEvents = new List<DTO_ScheduleEvent>();

            var obj = _context.ScheduleEvent.Where(item => item.UserId.ToString().Equals(userID)).ToList();
            obj.ForEach(item =>
            {
                var start = item.start.ToString().Split(" ")[0].Split("/");
                var end = item.end.ToString().Split(" ")[0].Split("/");

                var start_month = start[1].Length==1? "0"+start[1]:start[1] ;
                var end_month = end[1].Length == 1 ? "0" + end[1] : end[1];

                dto_scheduleEvents.Add(new DTO_ScheduleEvent
                {
                    id = item.id,
                    title = item.title,
                    start =String.Format("{0}-{1}-{2}",start[0],start_month,start[2]),
                    end = String.Format("{0}-{1}-{2}", end[0], end_month, end[2]),
                    fullDay = item.fullDay,
                });
            });
            //var json = JsonConvert.SerializeObject(dto_scheduleEvents);

            //return json;
            return Ok(dto_scheduleEvents);
        }

        [HttpPost]
        [EnableCors()]
        [Route("ScheduleEvent/Insert")]
        public ActionResult<string> ScheduleEvent_Insert(ScheduleEvent scheduleEvent)
        {

            try
            {
                _context.ScheduleEvent.Add(scheduleEvent);
                _context.SaveChanges();
            }catch(Exception e)
            {
                return StatusCode((int)HttpStatusCode.InternalServerError, new
                {
                    message = "Insert Failed!"
                });
            }
            return StatusCode((int)HttpStatusCode.OK, new
            {
                message = "Insert Success!"
            });
        }

        [HttpPut]
        [EnableCors()]
        [Route("ScheduleEvent/Update")]
        public ActionResult<string> ScheduleEvent_Update(ScheduleEvent scheduleEvent)
        {
            
            try
            {
                var target = _context.ScheduleEvent.Where(item => item.id==scheduleEvent.id).FirstOrDefault();
                if (target != null)
                {
                    target.title= scheduleEvent.title;
                    target.start= scheduleEvent.start;
                    target.end= scheduleEvent.end;
                    target.fullDay= scheduleEvent.fullDay;
                    _context.SaveChanges();
                }
                else
                {
                    return StatusCode((int)HttpStatusCode.NotFound, new
                    {
                        message = "Can't find anything to update!"
                    });
                }
            }
            catch (Exception e)
            {
                return StatusCode((int)HttpStatusCode.InternalServerError, new
                {
                    message = "Update Failed!"
                });
            }
            //return response;
            return StatusCode((int)HttpStatusCode.OK, new
            {
                message = "Update Ok"
            });
        }

        [HttpDelete]
        [EnableCors()]
        [Route("ScheduleEvent/Delete/{id}")]
        public ActionResult<string> ScheduleEvent_Delete(string id)
        {
            try
            {
                var target = _context.ScheduleEvent.Where(item=>item.id.ToString().Equals(id) ).FirstOrDefault();
                if (target != null)
                {
                _context.ScheduleEvent.Remove(target);
                _context.SaveChanges();
                }
                else
                {
                    return StatusCode((int)HttpStatusCode.NotFound, new
                    {
                        message = "Can't find anything to delete!"
                    });
                }

            }
            catch (Exception e)
            {
                return StatusCode((int)HttpStatusCode.InternalServerError, new
                {
                    message = "Delete Failed!"
                });
            }
            return StatusCode((int)HttpStatusCode.OK, new
            {
                message = "Delete Success!"
            });
        }

        [HttpPost]
        [EnableCors()]
        [Route("Signature_Insert")]
        public ActionResult<string> Signature_Insert(SignatureInfo signatureInfo)
        {

            try
            {
                _context.SignatureInfo.Add(signatureInfo);
                _context.SaveChanges();
            }
            catch (Exception e)
            {
                return StatusCode((int)HttpStatusCode.InternalServerError, new
                {
                    message = "Insert Failed!"
                });
            }
            return StatusCode((int)HttpStatusCode.OK, new
            {
                message = "Insert Success!"
            });
        }


        /*
        [HttpGet]
        [Route("Form/SelectAll")]
        public List<Form> Select_Form_All()
        {
            return _context.Form.ToList();
        }

        [HttpGet]
        [Route("Form/Find/{id}")]
        // GET: MainController
        public List<Form> Find_Form(string id)
        {
            var result = _context.Form.Where(x => x.id.ToString().Equals(id)).ToList();
            return result;
        }

        [HttpPost]
        [Route("Form/Insert")]
        public string Insert_Form_Post(Form form)
        {
            var target = new Form
            {
                Name = form.Name,
                CreateTime = form.CreateTime,
                UpdateTime = form.UpdateTime,
                IsDelete = form.IsDelete,
                CreateMemberID = form.CreateMemberID
            };
            _context.Form.Add(target);
            _context.SaveChanges();
            return "finish";
        }

        [HttpDelete]
        [Route("Form/Remove/{id}")]
        public void Remove_Form(int id)
        {
            var obj = _context.Form.Where(x => x.id == id).FirstOrDefault();
            _context.Form.Remove(obj);
            _context.SaveChanges();
        }

        [HttpGet]
        [Route("FormEvent/SelectAll")]
        public List<FormEvent> Select_FormEvent_All()
        {
            return _context.FormEvent.ToList();
        }
        [HttpGet]
        [Route("FormEvent/Find/{id}")]
        public List<FormEvent> Find_FormEvent(string id)
        {
            return _context.FormEvent.Where(x => x.id.ToString().Equals(id)).ToList();
        }

        [HttpPost]
        [Route("FormEvent/Insert")]
        // GET: MainController
        public string Insert_FormEvent(FormEvent formevent)
        {
            _context.FormEvent.Add(new FormEvent
            {
                Formid = formevent.Formid,
                Name = formevent.Name,
                Value = formevent.Value,
                Selfpoint = formevent.Selfpoint,
                managerpoint = formevent.managerpoint,
                partmentpoint = formevent.partmentpoint
            });
            _context.SaveChanges();
            return "finish";
        }

        [HttpDelete]
        [Route("FormEvent/Remove/{id}")]
        public void Remove_FormEvent(int id)
        {
            var obj = _context.FormEvent.Where(x => x.id == id).FirstOrDefault();
            _context.FormEvent.Remove(obj);
            _context.SaveChanges();
        }

        [HttpGet]
        [Route("signature/SelectAll")]
        public List<signature> Select_signature_All()
        {
            return _context.signature.ToList();
        }

        [HttpGet]
        [Route("signature/Find/{id}")]
        // GET: MainController
        public List<signature> Find_signature(string id)
        {
            return _context.signature.Where(x => x.id.ToString().Equals(id)).ToList();
        }

        [HttpPost]
        [Route("signature/Insert")]
        public string Insert_signature(signature signature)
        {
            _context.signature.Add(new signature
            {
                EmployeeID = signature.EmployeeID,
                Image = signature.Image,
                ImageTrueName = signature.ImageTrueName,
                Createtime = signature.Createtime,
                Updatetime = signature.Updatetime,
                IsDelete = signature.IsDelete
            });
            _context.SaveChanges();
            return "finish";
        }

        [HttpDelete]
        [Route("signature/Remove/{id}")]
        public void Remove_signature(int id)
        {
            var obj = _context.signature.Where(x => x.id == id).FirstOrDefault();
            _context.signature.Remove(obj);
            _context.SaveChanges();
        }

        [HttpGet]
        [Route("ActingSetting/SelectAll")]
        public List<ActingSetting> Select_ActingSetting_All()
        {
            return _context.ActingSetting.ToList();
        }

        [HttpGet]
        [Route("ActingSetting/Find/{id}")]
        // GET: MainController
        public List<ActingSetting> Find_ActingSetting(string id)
        {
            return _context.ActingSetting.Where(x => x.id.ToString().Equals(id)).ToList();
        }

        [HttpPost]
        [Route("ActingSetting/Insert")]
        // GET: MainController
        public string Insert_ActingSetting(ActingSetting actinsetting)
        {
            _context.ActingSetting.Add(new ActingSetting
            {
                EmployeeID = actinsetting.EmployeeID,
                IsEnable = actinsetting.IsEnable,
                Createtime = actinsetting.Createtime,
                Updatetime = actinsetting.Updatetime,
                IsDelete = actinsetting.IsDelete
            });
            _context.SaveChanges();
            return "finish";
        }

        [HttpDelete]
        [Route("ActingSetting/Remove/{id}")]
        public void Remove_ActingSetting(int id)
        {
            var obj = _context.ActingSetting.Where(x => x.id == id).FirstOrDefault();
            _context.ActingSetting.Remove(obj);
            _context.SaveChanges();
        }

        [HttpGet]
        [Route("ActingEmployeeMap/SelectAll")]
        public List<ActingEmployeeMap> Select_ActingEmployeeMap_All()
        {
            return _context.ActingEmployeeMap.ToList();
        }

        [HttpGet]
        [Route("ActingEmployeeMap/Find/{id}")]
        // GET: MainController
        public List<ActingEmployeeMap> Find_ActingEmployeeMap(string id)
        {
            return _context.ActingEmployeeMap.Where(x => x.id.ToString().Equals(id)).ToList();
        }

        [HttpPost]
        [Route("ActingEmployeeMap/Insert")]
        // GET: MainController
        public string Insert_ActingEmployeeMap(ActingEmployeeMap actinemployeemap)
        {
            _context.ActingEmployeeMap.Add(new ActingEmployeeMap
            {
                EmployeeID = actinemployeemap.EmployeeID,
                IsDelete = actinemployeemap.IsDelete,
                ActingEmployeeID = actinemployeemap.EmployeeID,
                Createtime = actinemployeemap.Createtime,
                Updatetime = actinemployeemap.Updatetime,
                Starttime = actinemployeemap.Starttime,
                endtime= actinemployeemap.endtime
            });
            _context.SaveChanges();
            return "finish";
        }

        [HttpDelete]
        [Route("ActingEmployeeMap/Remove/{id}")]
        public void Remove_ActingEmployeeMap(int id)
        {
            var obj = _context.ActingEmployeeMap.Where(x => x.id == id).FirstOrDefault();
            _context.ActingEmployeeMap.Remove(obj);
            _context.SaveChanges();
        }*/
        /*
        // GET: MainController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: MainController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: MainController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: MainController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: MainController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: MainController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: MainController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
        */
    }
}

using fcapi.EFModel;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;

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
        }
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

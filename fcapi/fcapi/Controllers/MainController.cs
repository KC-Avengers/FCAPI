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
        [Route("Form/InsertExample")]
        // GET: MainController
        public string Insert_Form_example()
        {
            _context.Form.Add(new Form { Name = "test2" });
            _context.SaveChanges();
            return "finish";
        }

        [HttpGet]
        [Route("Form/Remove/{id}")]
        public void Remove_Form_example(int id)
        {
            var obj = _context.Form.Where(x=>x.id == id).FirstOrDefault();
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
        [Route("FormEvent/InsertExample")]
        // GET: MainController
        public string Insert_FormEvent_example()
        {
            _context.FormEvent.Add(new FormEvent { Formid=1,Name="test2",Value="test2",Selfpoint=10,managerpoint=20, partmentpoint=30});
            _context.SaveChanges();
            return "finish";
        }

        [HttpGet]
        [Route("FormEvent/Remove/{id}")]
        public void Remove_FormEvent_example(int id)
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
        [Route("signature/InsertExample")]
        // GET: MainController
        public string Insert_signature_example()
        {
            _context.signature.Add(new signature{EmployeeID=1,IsDelete=true});
            _context.SaveChanges();
            return "finish";
        }

        [HttpGet]
        [Route("signature/Remove/{id}")]
        public void Remove_signature_example(int id)
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
        [Route("ActingSetting/InsertExample")]
        // GET: MainController
        public string Insert_ActingSetting_example()
        {
            _context.ActingSetting.Add(new ActingSetting { EmployeeID=1,IsEnable=true});
            _context.SaveChanges();
            return "finish";
        }

        [HttpGet]
        [Route("ActingSetting/Remove/{id}")]
        public void Remove_ActingSetting_example(int id)
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
        [Route("ActingEmployeeMap/InsertExample")]
        // GET: MainController
        public string Insert_ActingEmployeeMap_example()
        {
            _context.ActingEmployeeMap.Add(new ActingEmployeeMap { EmployeeID = 1, IsDelete = true });
            _context.SaveChanges();
            return "finish";
        }

        [HttpGet]
        [Route("ActingEmployeeMap/Remove/{id}")]
        public void Remove_ActingEmployeeMap_example(int id)
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

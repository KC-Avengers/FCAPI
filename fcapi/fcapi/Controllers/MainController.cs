using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

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
        [Route("Insert_Form_example")]
        // GET: MainController
        public string Insert_Form_example()
        {
            _context.Form.Add(new Form { Name = "test2" });
            _context.SaveChanges();
            return "finish";
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

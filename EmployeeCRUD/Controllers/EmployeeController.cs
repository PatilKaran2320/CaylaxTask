using EmployeeCRUD.Models;
using Microsoft.AspNetCore.Mvc;

namespace EmployeeCRUD.Controllers
{
    public class EmployeeController : Controller
    {
        AppDbContext _db;
        public EmployeeController(AppDbContext db)
        {
            _db= db;
        }
        public IActionResult Index()
        {
            var empList=  _db.Employees.ToList();
            return View(empList);
        }
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(Employee emp)
        {
            if (ModelState.IsValid)
            {
                _db.Employees.Add(emp);

                 _db.SaveChanges();
                return RedirectToAction("Index");
            }
     
            return View("Index");
        }
        public IActionResult Details(int id)
        {
            var emp = _db.Employees.Find(id);
            return View(emp);
        }
        [HttpGet]
        public IActionResult Edit(int id)
        {
            var e = _db.Employees.Find(id);
            return View(e);
        }
        [HttpPost]
        public IActionResult Edit(Employee emp)
        {
            if (ModelState.IsValid)
            {
                _db.Employees.Update(emp);

                _db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View("Index");
        }
        [HttpGet]
        public IActionResult Delete(int id)
        {
            var e= _db.Employees.Find(id);
            return View(e);
        }
        [HttpPost]
        [ActionName("Delete")]
        public IActionResult Delete_C(int id)
        {

            var e = _db.Employees.Find(id);
                _db.Employees.Remove(e);

                _db.SaveChanges();
                return RedirectToAction("Index");
            

            
        }
    }
}

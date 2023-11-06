using BVietHung.Models;
using Microsoft.AspNetCore.Mvc;

namespace BVietHung.Controllers
{
    public class StudentController : Controller 
    {
          public IActionResult Index()
            {
                return View();

            }
            [HttpPost]
         public IActionResult Index(Student std)
            {
                string str = "Hello " + std.StudentID + "-" + std.FullName + "-" + std.address + "-" + std.Age;
                ViewBag.thongBao = str;
                return View();
            }
    }
}
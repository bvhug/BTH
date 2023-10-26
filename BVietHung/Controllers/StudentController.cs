using Microsoft.AspNetCore.Mvc;
using DemoMVC.Models;
namespace DemoMVC.Controllers
{
    public class StudentController:Controller
{
    public IActionResult Index()
    {
        return View();

    }

    [HttpPost]
    public IActionResult Index(Student std)
    {
        string str = "hello " +  std.StudentID + " " + std.FullName;
        ViewBag.ThongBao = str;
        return View();
    }
//Bui Viet Hung -1921050280
}
}
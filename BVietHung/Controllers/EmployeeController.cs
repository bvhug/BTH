using Microsoft.AspNetCore.Mvc;
using BVietHung.Models;
namespace BVietHung.Controllers
{
    public class EmployeeController : Controller 
    {
      public IActionResult Index()
            {
                return View();
            }
            //BuiVietHung-1921050280
             [HttpPost]
         public IActionResult Index(Employee emp)
         {
             string str = emp.FullName + "_" + emp.EmployeeID + "_" + emp.SoDienThoai +"_"+ emp.Address; 
                ViewBag.KetQua = str;
                return View();
         }
     }
}
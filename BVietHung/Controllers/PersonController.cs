using Microsoft.AspNetCore.Mvc;

namespace BVietHung.Controllers;
public class PersonController : Controller 
{
    public IActionResult Index()
    {
        return View();
    }
    [HttpPost]
     public IActionResult Index(Person prs)
        {
            string str = prs.PersonID +"_" + prs.FullName;
            ViewBag.thongBao = str;
            return View();
        }
    //BuiVietHung -1921050280
}
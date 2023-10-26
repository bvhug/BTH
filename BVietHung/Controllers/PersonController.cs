using Microsoft.AspNetCore.Mvc;

namespace BVietHung.Controllers;
public class PersonController : Controller 
{
    public IActionResult Index()
    {
        return View();
    }
    [HttpPost]
    public IActionResult Index(string PersonID, string FullName)
    {
        string strResult = "Hello" + PersonID + FullName;
        ViewBag.thongbao = strResult ;
        return View();
    }
    //BuiVietHung -1921050280
}
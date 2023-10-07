using Microsoft.AspNetCore.Mvc;

namespace BVietHung.Controllers;
public class DemoController : Controller
{
    //Khai bao cac phuong thuc
    public IActionResult Index()
    {
        return View();
    }
    [HttpPost]
    public IActionResult Index(string Ten, string Sdt)
    {
        string strResult = "XinChao" + Ten + "-" +  Sdt ;
        ViewBag.hienthi = strResult;
        return View();
    }
}

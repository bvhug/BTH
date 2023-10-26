using System.Diagnostics.Contracts;
using System.Security.Cryptography.X509Certificates;
using BVietHung.Models;
using Microsoft.AspNetCore.Mvc;
public class EmployeeController : Controller
{
    public IActionResult IndexEmployee()
    {
        return View();
    }
    [HttpPost]

    public IActionResult IndexEmployee(string HoTen, decimal LuongCoBan, decimal HeSoLuong, decimal PhuCap)
    {
        decimal luong = LuongCoBan * HeSoLuong + PhuCap;
        string tl = HoTen + "-" + luong;
        ViewBag.thongbao = tl;
        return View();
    }
  
//BuiVietHung-1921050280
}
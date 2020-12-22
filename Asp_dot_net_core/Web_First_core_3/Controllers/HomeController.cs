using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Web_First_core_3.Models;

namespace Web_First_core_3.Controllers
{
    [Route("KhachHang")]
    public class HomeController : Controller
    {
        [Route("phong")]
        public IActionResult Index()
        {
            return View();
        }
        [ActionName("Privacy2")]
        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
        [Route("Vip/{id:int?}")]
        public string Vip(int id)
        {
            return "Khach Hang Vip " + id;
        }
        [Route("Vip/{id:alpha?}")]
        public string Thuong(string id)
        {
            return "Khach Hang Thuong " + id;
        }
    }
}

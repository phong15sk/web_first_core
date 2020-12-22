using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Web_first_core_2.Controllers
{
    [Route("Khach")]
    public class AdminController : Controller
    {
        [Route("")]
        public IActionResult Index()
        {
            return View();
        }
        [Route("Vip")]
        public string Vip()
        {
            return "Khách Hàng vip";
        }
        [Route("Thuong")]
        public string nomal()
        {
            return "Khách Hàng thường";
        }
    }
}

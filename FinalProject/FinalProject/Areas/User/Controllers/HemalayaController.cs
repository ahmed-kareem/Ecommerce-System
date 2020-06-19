using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace FinalProject.Areas.User.Controllers
{
    [Area("User")]
    public class HemalayaController : Controller
    {
        [Route("Hemalaya")]
        public IActionResult Index()
        {
            return View();
        }
    }
}

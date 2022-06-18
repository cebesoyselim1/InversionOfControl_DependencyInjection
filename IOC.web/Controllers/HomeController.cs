using IOC.web.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IOC.web.Controllers
{
    public class HomeController : Controller
    {
        private readonly ISignletonDateService _signletonDateService;
        private readonly IScopeDateService _scopeDateService;
        private readonly ITransientDateService _transientDateService;

        public HomeController(ISignletonDateService signletonDateService, IScopeDateService scopeDateService, ITransientDateService transientDateService)
        {
            _signletonDateService = signletonDateService;
            _scopeDateService = scopeDateService;
            _transientDateService = transientDateService;
        }

        public IActionResult Index([FromServices] ISignletonDateService signletonDateServiceMethod, [FromServices] IScopeDateService scopeDateServiceMethod, [FromServices] ITransientDateService transientDateServiceMehod)
        {
            /*
                Outputs are the same until application ends.
                ViewBag.time1 = _signletonDateService.GetDateTime.TimeOfDay.ToString();
                ViewBag.time2 = signletonDateServiceMethod.GetDateTime.TimeOfDay.ToString();
            */

            /*
                Outputs are the same until new request.
                ViewBag.time1 = _scopeDateService.GetDateTime.TimeOfDay.ToString();
                ViewBag.time2 = scopeDateServiceMethod.GetDateTime.TimeOfDay.ToString(); 
            */

            // Outputs are different on every injection.
            ViewBag.time1 = _transientDateService.GetDateTime.TimeOfDay.ToString();
            ViewBag.time2 = transientDateServiceMehod.GetDateTime.TimeOfDay.ToString();

            return View();
        }
    }
}

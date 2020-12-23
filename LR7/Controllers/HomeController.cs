using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using LR7.Models;
using Microsoft.Extensions.Localization;
using Microsoft.Extensions.Logging;


namespace LR7.Controllers
{
    public class HomeController : Controller
    {
        private readonly IStringLocalizer _localizer;
        public HomeController(IStringLocalizer localizer)
        {
            _localizer = localizer;
        }
        public IActionResult Index()
        {
            ViewData["Header"] = _localizer["Header"];
            ViewData["Title"] = _localizer["Title"];
            ViewData["Title2"] = _localizer["Title2"];
            ViewData["Title3"] = _localizer["Title3"];
            ViewData["Name"] = _localizer["Name"];
            ViewData["Name2"] = _localizer["Name2"];
            ViewData["Name3"] = _localizer["Name3"];
            ViewData["Name4"] = _localizer["Name4"];
            ViewData["Category"] = _localizer["Category"];
            ViewData["Category2"] = _localizer["Category2"];
            ViewData["Category3"] = _localizer["Category3"];
            ViewData["Category4"] = _localizer["Category4"];

            ViewData["Price"] = _localizer["Price"];
            ViewData["Price2"] = _localizer["Price2"];
            ViewData["Price3"] = _localizer["Price3"];
            ViewData["Price4"] = _localizer["Price4"];
            return View();
        }

    }
}

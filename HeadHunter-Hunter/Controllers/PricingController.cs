using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HeadHunter_Hunter.Models;
using Microsoft.AspNetCore.Mvc;

namespace HeadHunter_Hunter.Controllers
{
    public class PricingController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Example()
        {
            List<PricingOption> PricingOptions = new List<PricingOption>();
            PricingOptions.Add(new PricingOption("Name", 0.5));
            PricingOptions.Add(new PricingOption("Birthday", 0.5));
            PricingOptions.Add(new PricingOption("Location", 0.5 ));
            return View(PricingOptions);
        }
    }
}
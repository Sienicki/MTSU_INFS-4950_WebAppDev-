using Ch02Quotation.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace Ch02Quotation.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            ViewBag.Discount = 0;
            ViewBag.Total = 0;
            return View();
        }
        [HttpPost]
        public IActionResult Index(PriceQuotationModel model)
        {
            if (ModelState.IsValid)
            {
                ViewBag.Discount = model.CalculateDiscountAmount();
                ViewBag.Total = model.CalculateTotal();
            }
            else
            {
                ViewBag.Discount = 0;
                ViewBag.Total = 0;
            }

            return View(model);
        }

    }
}

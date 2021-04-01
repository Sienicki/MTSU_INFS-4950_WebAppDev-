﻿using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SportsPro.Models;

namespace SportsPro.Controllers
{
    public class IncidentController : Controller
    {
        private SportsProContext context { get; set; }

        public IncidentController(SportsProContext ctx)
        {
            context = ctx;
        }
        [Route("[controller]s")]
        public IActionResult List()
        {
            List<Incident> incidents = context.Incidents
                .Include(i => i.Customer)
                .Include(i => i.Product)
                .OrderBy(i => i.DateOpened)
                .ToList();

            return View(incidents);
        }

        public void StoreListsInViewBag()
        {
            ViewBag.Customers = context.Customers
                .OrderBy(c => c.FirstName)
                .ToList();

            ViewBag.Products = context.Products
                .OrderBy(c => c.Name)
                .ToList();

            ViewBag.Technicians = context.Technicians
                .OrderBy(c => c.Name)
                .ToList();
        }

        [HttpGet]
        public IActionResult Add()
        {
            ViewBag.Action = "Add";

            StoreListsInViewBag();

            return View("AddEdit", new Incident());
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            ViewBag.Action = "Edit";

            StoreListsInViewBag();

            var product = context.Incidents.Find(id);

            return View("AddEdit", product);
        }

        [HttpPost]
        public IActionResult Save(Incident incident)
        {
            if (ModelState.IsValid)
            {
                if (incident.IncidentID == 0)
                {
                    context.Incidents.Add(incident);
                }
                else
                {
                    context.Incidents.Update(incident);
                }
                context.SaveChanges();
                return RedirectToAction("List");
            }
            else
            {
                StoreListsInViewBag();
                if (incident.IncidentID == 0)
                {
                    ViewBag.Action = "Add";
                }
                else
                {
                    ViewBag.Action = "Edit";
                }

                return View("AddEdit", incident);
            }
        }

        [HttpGet]
        public IActionResult Delete(int id)
        {
            var product = context.Incidents.Find(id);
            return View(product);
        }

        [HttpPost]
        public IActionResult Delete(Incident incident)
        {
            context.Incidents.Remove(incident);
            context.SaveChanges();
            return RedirectToAction("List");
        }
    }
}
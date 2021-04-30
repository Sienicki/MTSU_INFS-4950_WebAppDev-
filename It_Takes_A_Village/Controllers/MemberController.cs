using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using It_Takes_A_Village.Models;

namespace It_Takes_A_Village.Controllers
{
    public class MemberController : Controller
    {
        private MemberContext context { get; set; }
        public MemberController(MemberContext ctx)
        {
            context = ctx;
        }
        [HttpGet]
        public IActionResult Add()
        {
            ViewBag.Action = "Add";
            ViewBag.Professions = context.Professions.OrderBy(p => p.Title).ToList();
            var model = new Member();
            return View("AddEdit", model);
        }
        [HttpGet]
        public IActionResult Edit(int id)
        {
            ViewBag.Action = "Edit";
            ViewBag.Professions = context.Professions.OrderBy(p => p.Title).ToList();
            var model = context.Members.Find(id);
            return View("AddEdit", model);
        }
        [HttpPost]
        public IActionResult Save(Member contact)
        {
            if (ModelState.IsValid)
            {
                if (contact.MemberId == 0)
                {
                    contact.DateAdded = DateTime.Now;
                    context.Members.Add(contact);
                }
                else
                {
                    context.Members.Update(contact);
                }
                context.SaveChanges();
                return RedirectToAction("Index", "Home");
            }
            else
            {
                ViewBag.Action = (contact.MemberId == 0) ? "Add" : "Edit";
                ViewBag.Action = context.Professions.OrderBy(p => p.Title).ToList();
                return View("AddEdit", contact);
            }
        }
        [HttpGet]
        public IActionResult Delete(int id)
        {
            var model = context.Members.Find(id);
            return View("Delete", model);
        }
        [HttpPost]
        public IActionResult Delete(Member contact)
        {
            context.Members.Remove(contact);
            context.SaveChanges();
            return RedirectToAction("Index", "Home");
        }
        [HttpGet]
        public IActionResult Details(int id)
        {
            ViewBag.Professions = context.Professions.OrderBy(p => p.Title).ToList();
            var model = context.Members.Find(id);
            return View("Details", model);
        }
    }
}

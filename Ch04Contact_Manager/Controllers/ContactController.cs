using Ch04ContactManager.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ch04ContactManager.Controllers
{
    public class ContactController : Controller
    {
        private ContactContext context { get; set; }
        public ContactController(ContactContext ctx)
        {
            context = ctx;
        }
        //Get Add
        [HttpGet]
        public IActionResult Add()
        {
            ViewBag.Action = "Add";
            ViewBag.Categories = context.Categories.OrderBy(c => c.Name).ToList();
            var model = new Contact();
            return View("AddEdit", model);
        }
        //Get Edit
        [HttpGet]
        public IActionResult Edit(int id)
        {
            ViewBag.Action = "Edit";
            ViewBag.Categories = context.Categories.OrderBy(c => c.Name).ToList();
            var model = context.Contacts.Find(id);
            return View("AddEdit", model);
        }
        //Post Save
        [HttpPost]
        public IActionResult Save(Contact contact)
        {
            if (ModelState.IsValid)
            {
                if (contact.ContactId == 0)
                {
                    contact.DateAdded = DateTime.Now;
                    context.Contacts.Add(contact);
                }
                else
                {
                    context.Contacts.Update(contact);
                }
                context.SaveChanges();
                return RedirectToAction("Index", "Home");
            }
            else
            {
                ViewBag.Action = (contact.ContactId == 0) ? "Add" : "Edit";
                ViewBag.Action = context.Categories.OrderBy(c => c.Name).ToList();
                return View("AddEdit", contact);
            }
        }
        //Get delete
        [HttpGet]
        public IActionResult Delete(int id)
        {
            var model = context.Contacts.Find(id);
            return View("Delete", model);
        }
        //Post Delete
        [HttpPost]
        public IActionResult Delete(Contact contact)
        {
            context.Contacts.Remove(contact);
            context.SaveChanges();
            return RedirectToAction("Index", "Home");
        }
        //Get Details
        [HttpGet]
        public IActionResult Details(int id)
        {
            ViewBag.Action = "Details";
            ViewBag.Categories = context.Categories.OrderBy(c => c.Name).ToList();
            var model = context.Contacts.Find(id);
            return View("Details", model);
        }
    }
}

using It_Takes_A_Village.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace It_Takes_A_Village.Controllers
{
    public class HomeController : Controller
    {
        private MemberContext context { get; set; }
        public HomeController(MemberContext ctx)
        {
            context = ctx;
        }

        public IActionResult Index()
        {
            var members = context.Members
                .Include(p => p.Profession)
                .OrderBy(m => m.MemberId)
                .ToList();
            return View(members);
        }
        public IActionResult Index(string searchBy, string search)
        {
            if(searchBy == "Profession")
            {
                return View(db.Members.Where(x => x.Profession.StartsWith(search)).ToList());
            }
            else if(searchBy == "Name")
            {
                return View(db.Member.Where(x => x.Name.StartsWith(search)).ToList());
            }
        }

        
    }
}

using AptechProject.Models;
using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AptechProject.Controllers
{
    [Authorize(Roles = "admin")]
    public class RoleController : Controller
    {
        ApplicationDbContext db = new ApplicationDbContext();
        [Authorize(Roles = "admin")]
        public ActionResult RoleList()
        {
            var roleList = db.Roles.ToList();
            return View(roleList);
        }
        
        [HttpGet]
        public ActionResult CreateRole()
        {
            var role = new IdentityRole();
            return View(role);
        }

        [HttpPost]
        public ActionResult CreateRole(IdentityRole identity)
        {
            db.Roles.Add(identity);
            db.SaveChanges();
            return RedirectToAction("RoleList");
        }
    }
}
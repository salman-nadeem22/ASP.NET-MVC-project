using AptechProject.Models;
using AptechProject.ViewModels;
using Microsoft.Ajax.Utilities;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Runtime.Remoting.Contexts;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using Context = System.Runtime.Remoting.Contexts.Context;

namespace AptechProject.Controllers
{
    public class HomeController : Controller
    {
        ApplicationDbContext _context;
        
        public HomeController()
        {
            _context = new ApplicationDbContext();
        }

        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }

        public ActionResult Index()
        {
            return View();
        }

        [Authorize(Roles ="admin")]
        public ActionResult ViewUsers()
        {
            var usersWithRoles = (from user in _context.Users
                                  select new
                                  {
                                      UserId = user.Id,
                                      Username = user.UserName,
                                      AuthenticationType = user.AuthenticationType,
                                      Email = user.Email,
                                      RoleNames = (from userRole in user.Roles
                                                   join role in _context.Roles on userRole.RoleId
                                                   equals role.Id
                                                   select role.Name).ToList()
                                  }).ToList().Select(p => new Users_in_Role_ViewModel()

                                  {
                                      UserId = p.UserId,
                                      Username = p.Username,
                                      AuthenticationType = p.AuthenticationType,
                                      Email = p.Email,
                                      Role = string.Join(",", p.RoleNames)
                                  });


            return View(usersWithRoles);
        }
        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }
        
        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}
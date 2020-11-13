using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SpaDay.Models;


// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace SpaDay.Controllers
{
    public class UserController : Controller
    {
        // GET: /<controller>/
        public IActionResult Index()
        {
            //ViewBag.title = "what";
            //ViewBag.user = farts.username;          
            return View();
        }

        public IActionResult Add()
        {
            return View();
        }

        [HttpPost]
        [Route("/User/Add")]
        public IActionResult SubmitAddUserForm(User newUser, string verify)
        //public IActionResult SubmitAddUserForm(string username, string email, string password, string verify)
        {
            ViewBag.name = newUser.Username;
            ViewBag.email = newUser.Email;
            ViewBag.date = newUser.Date;
            if (newUser.Password == verify)
            {
                //ViewBag.name = newUser.Username;
                return View("Index");
            }
            else
            {
                ViewBag.error = "Form could not submit, the passwords do not match";
                //return Redirect("/User/Add"); This did not work
                return View("Add");

            }

        }
    }
}

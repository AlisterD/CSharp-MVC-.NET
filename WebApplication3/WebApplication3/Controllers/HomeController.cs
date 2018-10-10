using System.Web;
using System.Web.Mvc;
using System.Data.SqlTypes;
using System.Data.SqlClient;
using System.Data.Sql;
using WebApplication3.Models;
using System.Data;
using System.Collections.Generic;
using WebApplication3.ViewModels;


namespace WebApplication3.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {


            return View();
        }
        [HttpPost]
        public ActionResult Signup(string firstName, string lastName, string emailAddress)
        {
            if (string.IsNullOrEmpty(firstName) || string.IsNullOrEmpty(lastName) || string.IsNullOrEmpty(emailAddress))
            {
                return View("~/Views/Shared/Error.cshtml");
            }
            else
            {
                using (NewsletterEntities db = new NewsletterEntities())
                {
                    var signup = new signup();
                    signup.FirstName = firstName;
                    signup.LastName = lastName;
                    signup.EmailAddress = emailAddress;

                    db.signups.Add(signup);
                    db.SaveChanges();
                }

                    return View("Success");
            }  

        }

    }
} 
     
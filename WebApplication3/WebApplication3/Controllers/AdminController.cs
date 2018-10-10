using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication3.Models;
using WebApplication3.ViewModels;

namespace WebApplication3.Controllers
{
    public class AdminController : Controller
    {
        // GET: Admin
        public ActionResult Index()
        {
            using (NewsletterEntities db = new NewsletterEntities())
            {
                // var signups = db.signups.Where(x => x.Removed == null).ToList(); *filter - removing the ones that have unsubscribed*
                var signups = (from c in db.signups
                               where c.Removed == null
                               select c).ToList();
                var SignupVms = new List<SignupVm>();
                foreach (var signup in signups)
                {
                    var signupVm = new SignupVm();
                    signupVm.Id = signup.Id;
                    signupVm.FirstName = signup.FirstName;
                    signupVm.LastName = signup.LastName;
                    signupVm.Emailaddress = signup.EmailAddress;
                    SignupVms.Add(signupVm);

                }

                return View(SignupVms);
            }
        }

        public ActionResult Unsubscribe(int Id)
        {
            using (NewsletterEntities db = new NewsletterEntities())
            {
                var signup = db.signups.Find(Id);
                signup.Removed = DateTime.Now;
                db.SaveChanges();

            }
            return RedirectToAction("Index");
        }
    }
}
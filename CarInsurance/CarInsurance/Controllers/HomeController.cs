using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data.SqlClient;
using System.Data;
using CarInsurance.Models;
using CarInsurance.ViewModels;

namespace CarInsurance.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Quote(string firstName, string lastName, string emailAddress, DateTime DOB, int carYear, string carMake, string carModel, int tickets, Boolean fullCoverage = false, bool dui = false, int quote = 1)
        {

            List<QuoteSubmission> submission = new List<QuoteSubmission>();
            var adminVms = new List<AdminVm>();
            foreach (var signup in submission)
            {
                var adminVm = new AdminVm();
                adminVm.Id = signup.Id;
                adminVm.FirstName = signup.FirstName;
                adminVm.LastName = signup.LastName;
                adminVm.EmailAddress = signup.EmailAddress;
                adminVm.DOB = signup.Dob.Date;
                adminVm.CarYear = signup.CarYear;
                adminVm.CarMake = signup.CarMake;
                adminVm.CarModel = signup.CarModel;
                adminVm.Dui = signup.Dui;
                adminVm.Tickets = signup.Tickets;
                adminVm.FullCoverabe = signup.FullCoverage;
                adminVm.QuotedPrice = signup.QuotedPrice;

                adminVms.Add(adminVm);
                return View(adminVms);
            }
          
          

                QuoteSubmission quoteApp = new QuoteSubmission();

                if (string.IsNullOrEmpty(firstName) || string.IsNullOrEmpty(lastName) || DOB.Equals(null) || string.IsNullOrEmpty(carMake) || string.IsNullOrEmpty(carModel))
                {
                    return View("~/Views/Shared/Error.cshtml");
                }
                else if (carYear < 0 || tickets < 0)
                {
                    return View("~/Views/Shared/Error.cshtml");
                }
                else
                {
                    quoteApp.FirstName = firstName;
                    quoteApp.LastName = lastName;
                    quoteApp.EmailAddress = emailAddress;
                    quoteApp.Dob = DOB;
                    quoteApp.CarMake = carMake;
                    quoteApp.CarModel = carModel;
                    quoteApp.CarYear = carYear;
                    quoteApp.Dui = dui;
                    quoteApp.Tickets = tickets;
                    quoteApp.FullCoverage = fullCoverage;


                using (QuoteSubmission db = new QuoteSubmission())
                {

                    var signup = new Table();
                    signup.FirstName = firstName;
                    signup.LastName = lastName;
                    signup.EmailAddress = emailAddress;
                    signup.DateofBirth = DOB;
                    signup.CarMake = carMake;
                    signup.CarModel = carModel;
                    signup.CarYear = carYear;
                    signup.DUI = dui;
                    signup.SpeedingTickets = tickets;
                    signup.CoverageType = fullCoverage;

                    quoteApp.QuotedPrice = Calculator.CalculateQuote(quoteApp);
                    signup.QUOTE = quoteApp.QuotedPrice;

                    db.Tables.Add(signup);
                    db.SaveChanges();
                }

                    return View(new QuoteVm(quoteApp.QuotedPrice));
                }


            }
        }
}
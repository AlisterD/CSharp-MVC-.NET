using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data.SqlClient;
using System.Data;
using CarInsurance.Models;
using CarInsurance.ViewModels;
using MVCPractical.Models;

namespace CarInsurance.Controllers
{
    public class HomeController : Controller
    {
       
        public ActionResult Index()
        {
            return View();
        }
        
        [HttpPost]
        public ActionResult Quote(string firstName, string lastName, string emailAddress, DateTime DOB, int carYear, string carMake, string carModel, int tickets, Boolean fullCoverage = false, bool dui = false, int quote = 42069)
        {
            QuoteSubmission quoteApp = new QuoteSubmission();
            if (string.IsNullOrEmpty(firstName)|| string.IsNullOrEmpty(lastName) || DOB.Equals(null) || string.IsNullOrEmpty(carMake) || string.IsNullOrEmpty(carModel))
            {
                return View("~/Views/Shared/Error.cshtml");
            }
          else if (carYear < 0 || tickets < 0)
            {
                return View("~/Views/Shared/Error.cshtml");
            }
                else
            {
              
                using (InsuranceEntities db = new InsuranceEntities())
                {
                    quoteApp.quotedPrice = Calculator.CalculateQuote(quoteApp);
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
                    signup.QUOTE = quote;

                    db.Tables.Add(signup);
                    db.SaveChanges();
                }

                return View(new QuoteVm(quoteApp.quotedPrice));

            }
            


        }
    }
}
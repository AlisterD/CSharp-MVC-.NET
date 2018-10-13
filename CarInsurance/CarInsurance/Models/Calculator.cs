using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CarInsurance.Models
{
    public abstract class Calculator
    {

        public static decimal CalculateQuote(QuoteSubmission application)
        {
            decimal quotePrice = 50.00m;


            //If the user is under 25, add $25 to the monthly total.
            if (GetAge(application) < 25)
                quotePrice += 25.00m;

            //If the user is under 18, add $100 to the monthly total.
            if (GetAge(application) < 18)
                quotePrice += 100.00m;

            //If the user is over 100, add $25 to the monthly total.
            if (GetAge(application) > 100)
                quotePrice += 25.00m;

            //If the car's year is before 2000, add $25 to the monthly total.
            if (application.CarYear < 2000)
                quotePrice += 25.00m;

            //If the car's year is after 2015, add $25 to the monthly total.
            if (application.CarYear > 2015)
                quotePrice += 25.00m;

            //If the car's Make is a Porsche, add $25 to the price.
            if (application.CarMake == "Porsche")
                quotePrice += 25.00m;


            //If the car's Make is a Porsche and its model is a 911 Carrera, add an additional $25 to the price.
            if (application.CarModel == "911 Carrera" && application.CarMake == "Porsche")
                quotePrice += 25.00m;


            //Add $10 to the monthly total for every speeding ticket the user has.
            quotePrice += 10.00m * application.Tickets;

            //If the user has ever had a DUI, add 25% to the total.
            if (application.Dui)
                quotePrice += quotePrice * .25m;

            //If it's full coverage, add 50% to the total.
            if (application.FullCoverage)
                quotePrice += quotePrice * .5m;

            return quotePrice;

        }

        
        public static int GetAge(QuoteSubmission app)
        {


            var age = 2018 - app.Dob.Year;
           
            return age;
        }


    }
}
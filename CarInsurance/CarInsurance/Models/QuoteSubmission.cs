using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CarInsurance.Models
{
    public partial class QuoteSubmission
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string EmailAddress { get; set; }
        public DateTime Dob { get; set; }
        public int CarYear { get; set; }
        public string CarMake { get; set; }
        public string CarModel { get; set; }
        public int Tickets { get; set; }
        public bool Dui { get; set; }
        public bool FullCoverage { get; set; }
        public decimal QuotedPrice { get; set; }
    }
}
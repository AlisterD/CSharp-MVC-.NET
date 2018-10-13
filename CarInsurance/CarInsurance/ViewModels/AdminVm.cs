using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CarInsurance.ViewModels
{
    //public class AdminVm
    public class AdminVm
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string EmailAddress { get; set; }
        public DateTime DOB { get; set; }
        public int CarYear { get; set; }
        public string CarModel{ get; set; }
        public string CarMake { get; set; }
        public bool Dui { get; set; }
        public int Tickets { get; set; }
        public bool  FullCoverabe { get; set; }
        public decimal QuotedPrice { get; set; }

        public AdminVm()
        {

        }
    }

   
}
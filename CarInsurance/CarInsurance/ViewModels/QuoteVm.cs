using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CarInsurance.Models
{
    public class QuoteVm
    {
        public string QuotedPrice { get; set; }
        public QuoteVm(decimal quotedPrice)
        {
            this.QuotedPrice = string.Format("{0:C2}", quotedPrice);
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace LoansApp.Folders
{
    public class Product
    {
        public string ProductNumber { get; set; } 
        public string ProductType { get; set; }
        public string DateReceived { get; set; }
        public string Note { get; set; }
        public string User { get; set; }
        public string UserId { get; set; }
        public string SupporterName { get; set; }
        public string StartDate { get; set; }
        public string EndDate { get; set; }
        public string Reason { get; set; }
    }
}
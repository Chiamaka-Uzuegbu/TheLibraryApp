using System;
using System.Collections.Generic;
using System.Text;

namespace LibraryApp.Core.Entities
{
    public class CheckOutDetails
    {
    //    public CheckOutDetails()
    //    {
    //        ListOfBooks = new List<BookDetails>();
    //    }
        public int CheckOutDetailsId { get; set; }
        public string FullName { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public string NationalIdentityNumber { get; set; }
        public DateTime Date { get; set; }

        //public int ExpectedDateofReturn { get; set; }
        public List<BookDetails> ListOfBooks { get; set; } 
    }
}

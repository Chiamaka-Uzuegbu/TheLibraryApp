using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace LibraryApp.Infrastructure.DTOs.Request_DTO
{
   public class BookDTO
    {
        public int BookDetailsId { get; set; }
        public string Title { get; set; }
        public string ISBN { get; set; }
        public DateTime PublishYear { get; set; }

        [Column(TypeName = "decimal(18, 6)")]
        public decimal CoverPrice { get; set; }
        public bool AvailabilityStatus { get; set; }
    }
}

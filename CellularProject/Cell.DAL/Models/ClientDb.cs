using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Cell.DAL.Models
{
    public class ClientDb
    {
        [Key]
        public string ClientId { get; set; }
        //[Index(IsUnique = true)]
        public string FirstName { get; set; }
        public string LastName { get; set; }
        [ForeignKey("ClientType")]
        public int ClientTypeId { get; set; }
        public ClientTypeDb ClientType { get; set; }
        public string Address { get; set; }
        public int CallsToCenter { get; set; }
        public int? LineId { get; set; }

        public ICollection<PaymentDb> Payments { get; set; }
        public ICollection<LineDb> Lines { get; set; }

        public ClientDb()
        {
            Payments = new HashSet<PaymentDb>();
            Lines = new HashSet<LineDb>();
        }
    }
}

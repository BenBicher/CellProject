using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Cell.DAL.Models
{
    public class LineDb
    {
        [Key]
        public int Id { get; set; }
        [ForeignKey("Client")]
        public string ClientId { get; set; }
        public ClientDb Client { get; set; }
        public string Number { get; set; }
        public bool Status { get; set; }
        [ForeignKey("Packages")]
        public int PackageId { get; set; }

        public ICollection<CallDb> Calls { get; set; }
        public ICollection<PackageDb> Packages { get; set; }
        public ICollection<SMSDb> SMSs { get; set; }

        public LineDb()
        {
            Calls = new HashSet<CallDb>();
            Packages = new HashSet<PackageDb>();
            SMSs = new HashSet<SMSDb>();

        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cell.DAL.Models
{
    public class SMSDb
    {
        [Key]
        public int Id { get; set; }
        public double ExternalPrice { get; set; }
        public string DestinationNumber { get; set; }
        [ForeignKey("Line")]
        public int LineId { get; set; }
        public LineDb Line { get; set; }
    }
}

using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Cell.DAL.Models
{
    public class PaymentDb
    {
        [Key]
        public int Id { get; set; }
        [ForeignKey("Client")]
        public string ClientId { get; set; }
        public ClientDb Client { get; set; }
        [ForeignKey("Line")]
        public int LineId { get; set; }
        public LineDb Line { get; set; }
        public DateTime Month { get; set; }
        public double TotalPayment { get; set; }
    }
}

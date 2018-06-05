using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cell.DAL.Models
{
    // todo : add / remove / edit properties to allow the making of an invoice from the model => update ModelExtensions
    public class PackageIncludeDb
    {
        [Key, ForeignKey("Package")]
        public int Id { get; set; }
        public string IncludeName { get; set; }
        public int? MaxMinute { get; set; }
        public double? FixedPrice { get; set; }
        public double? DiscountPrecentage { get; set; }
        [ForeignKey("SelectedNumbers")]
        public int? SelectedNumbersId { get; set; }
        [Required]
        public virtual SelectedNumbersDb SelectedNumbers { get; set; }
        public bool MostCalledNumber { get; set; }
        public bool InsideFamilyCalls { get; set; }
        public PackageDb Package { get; set; }
    }
}

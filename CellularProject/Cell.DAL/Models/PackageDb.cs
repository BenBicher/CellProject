using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cell.DAL.Models
{
    public class PackageDb
    {
        [Key]
        public int Id { get; set; }
        public string PackageName { get; set; }
        public double PackageTotalPrice { get; set; }
        [ForeignKey("Line")]
        public int? LineId { get; set; }
        public LineDb Line { get; set; }
        [ForeignKey("PackageIncludes")]
        public int? PackageIncludesId { get; set; }
        public PackageIncludeDb PackageIncludes { get; set; }
    }
}

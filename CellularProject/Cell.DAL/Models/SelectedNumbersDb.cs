using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Cell.DAL.Models
{
    public class SelectedNumbersDb
    {
        [Key, ForeignKey("PackageIncludes")]
        public int Id { get; set; }
        public string FirstNumber { get; set; }
        public string SecondNumber { get; set; }
        public string ThirdNumber { get; set; }
        public virtual PackageIncludeDb PackageIncludes { get; set; }
    }
}

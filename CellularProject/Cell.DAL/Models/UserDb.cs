using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Cell.Models.Entities
{
    public class UserDb
    {
        [Key]
        public int Id { get; set; }
        //[Index(IsUnique = true)]
        public string FullName { get; set; }
        public string Password { get; set; }
    }
}

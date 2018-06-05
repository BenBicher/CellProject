using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cell.DAL.Models
{
    public class ClientTypeDb
    {
        [Key]
        public int Id { get; set; }
        public string TypeName { get; set; }
        public double MinutePrice { get; set; }
        public double SmsPrice { get; set; }
        //1-n
        public ICollection<ClientDb> Clients { get; set; }
        public ClientTypeDb()
        {
            Clients = new HashSet<ClientDb>();
        }
    }
}

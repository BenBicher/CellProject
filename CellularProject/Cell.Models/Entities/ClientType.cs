using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Cell.Models.Entities
{
    [DataContract]
    public class ClientType
    {
        [DataMember]
        public int Id { get; set; }
        [DataMember]
        public string TypeName { get; set; }
        [DataMember]
        public double MinutePrice { get; set; }
        [DataMember]
        public double SmsPrice { get; set; }
        [DataMember]
        public IEnumerable<Client> Clients { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Cell.Models.Entities
{
    [DataContract]
    public class Line
    {
        [DataMember]
        public int Id { get; set; }
        [DataMember]
        public string ClientId { get; set; }
        [DataMember]
        public Client Client { get; set; }
        [DataMember]
        public string Number { get; set; }
        [DataMember]
        public bool Status { get; set; }
        [DataMember]
        public int PackageId { get; set; }

        [DataMember]
        public IEnumerable<Call> Calls { get; set; }
        [DataMember]
        public IEnumerable<Package> Packages { get; set; }
        [DataMember]
        public IEnumerable<SMS> SMSs { get; set; }
    }
}

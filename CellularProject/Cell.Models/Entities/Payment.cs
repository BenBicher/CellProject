using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Cell.Models.Entities
{
    [DataContract]
    public class Payment
    {
        [DataMember]
        public int Id { get; set; }
        [DataMember]
        public string ClientId { get; set; }
        [DataMember]
        public Client Client { get; set; }
        [DataMember]
        public int LineId { get; set; }
        [DataMember]
        public Line Line { get; set; }
        [DataMember]
        public DateTime Month { get; set; }
        [DataMember]
        public double TotalPayment { get; set; }
    }
}

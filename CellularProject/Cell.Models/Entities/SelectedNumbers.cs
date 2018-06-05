using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Cell.Models.Entities
{
    [DataContract]
    public class SelectedNumbers
    {
        [DataMember]
        public int Id { get; set; }
        [DataMember]
        public string FirstNumber { get; set; }
        [DataMember]
        public string SecondNumber { get; set; }
        [DataMember]
        public string ThirdNumber { get; set; }
        [DataMember]
        public int PackageIncludesId { get; set; }
        [DataMember]
        public PackageIncludes PackageIncludes { get; set; }
    }
}

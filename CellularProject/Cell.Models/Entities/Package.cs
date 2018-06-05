using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Cell.Models.Entities
{
    [DataContract]
    public class Package
    {
        [DataMember]
        public int Id { get; set; }
        [DataMember]
        public string PackageName { get; set; }
        [DataMember]
        public double PackageTotalPrice { get; set; }
        [DataMember]
        public int LineId { get; set; }
        [DataMember]
        public Line Line { get; set; }
        [DataMember]
        public int? PackageIncludesId { get; set; }
        [DataMember]
        public PackageIncludes PackageIncludes { get; set; }
    }
}

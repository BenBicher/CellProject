using System.Runtime.Serialization;

namespace Cell.Models.Entities
{
    [DataContract]
    public class PackageIncludes
    {
        [DataMember]
        public int Id { get; set; }
        [DataMember]
        public string IncludeName { get; set; }
        [DataMember]
        public int? MaxMinute { get; set; }
        [DataMember]
        public double? FixedPrice { get; set; }
        [DataMember]
        public double? DiscountPrecentage { get; set; }
        [DataMember]
        public int? SelectedNumbersId { get; set; }
        [DataMember]
        public SelectedNumbers SelectedNumbers { get; set; }
        [DataMember]
        public bool MostCalledNumber { get; set; }
        [DataMember]
        public bool InsideFamilyCalls { get; set; }
        [DataMember]
        public int PackageId { get; set; }
        [DataMember]
        public Package Package { get; set; }
    }
}
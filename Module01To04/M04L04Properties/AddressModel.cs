using System;

namespace M04L04Properties
{
    public class AddressModel {
        public string StreetAddress { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string ZipCode { get; set; }
        public string FullAddress
        {
            get {
                return $"{StreetAddress}, {City}, {State}, {ZipCode}";
            }
        }
        
    }
}
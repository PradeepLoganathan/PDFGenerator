using System;
namespace BestCV.JobSeeker.Models.Location
{
    public sealed class Address
    {
        public string Line1 { get; set; }
        public string Line2 { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Zip { get; set; }
        public string Country { get; set; }
        public GeographicCoordinate GeoCode { get; set; }
        public Guid AddressId { get;  set; }
        public bool IsVerified { get; set; }
    }

}

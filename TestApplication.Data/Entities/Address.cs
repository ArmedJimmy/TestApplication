using System;
using System.Collections.Generic;
using System.Text;

namespace TestApplication.Data.Entities
{
    public class Address : BaseEntity
    {
        public string HouseNumber { get; set; }

        public string HouseName { get; set; }

        public string StreetName { get; set; }

        public string City { get; set; }

        public string Postcode { get; set; }
    }
}

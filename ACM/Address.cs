﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM
{
    public class Address
    {

        public Address()
        {

        }

        public Address(int addressId)
        {
            AddressId = addressId;
        }

        public int AddressId { get; private set; }
        public int AddressType { get; set; }
        public string City { get; set; }
        public string PostalCode { get; set; }
        public string State { get; set; }
        public string StreetLine1 { get; set; }
        public string StreetLine2 { get; set; }
        public string Country { get; set; }

        /// <summary>
        /// Validates the address data.
        /// </summary>
        /// <returns></returns>
        public bool Validate()
        {
            var IsValid = true;

            if (PostalCode == null) IsValid = false;

            return IsValid;
        }
    }
}

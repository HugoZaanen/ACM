﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM
{
    public class CustomerRepository
    {
        public CustomerRepository()
        {
            AddressRepository = new AddressRepository();
        }

        private AddressRepository AddressRepository { get; set; }

        /// <summary>
        /// Retrieve one customer.
        /// </summary>
        /// <param name="customerId"></param>
        /// <returns></returns>
        public Customer Retrieve(int customerId)
        {
            //Create the instance of the Customer class
            //Pass in the requested id
            Customer customer = new Customer(customerId);

            //Code that retrieves the defined customer

            //temporary hard-coded values to return
            //a populated customer
            if(customerId == 1)
            {
                customer.EmailAddress = "fbaggins@Hobbiton.me";
                customer.FirstName = "Frodo";
                customer.LastName = "Baggins";
                customer.AddressList = AddressRepository.RetrieveByCustomerId(customerId).ToList();
            }

            return customer;
        }

        /// <summary>
        /// Saves the current customer.
        /// </summary>
        /// <param name="customer"></param>
        /// <returns></returns>
        public bool Save(Customer customer)
        {
            //Code that saves the passed in customer

            return true;
        }
    }
}

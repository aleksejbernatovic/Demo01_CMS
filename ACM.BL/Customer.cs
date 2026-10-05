using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMS.BusinessLayer
{
    public class Customer
    {
        public Customer()
        {

        }
        public Customer(int customerId)
        {
            this.CustomerId = customerId;
        }
        public static int InstanceCount { get; set; }
        
        private string _lastName;
        public string LastName
        {
            get
            {
                // Any code here
                return _lastName;
            }
            set
            {
                // Any code here
                _lastName = value;
            }
        }
        public string FirstName { get; set; }
        public string EmailAddress { get; set; }
        public Address HomeAddress { get; set; }
        public Address WorkAddress { get; set; }
        public int CustomerId { get; private set; }
        public string FullName
        {
            get
            {
                string fullName = LastName;
                if (!string.IsNullOrWhiteSpace(FirstName))
                {
                    if (!string.IsNullOrWhiteSpace(fullName))
                    {
                        fullName += ", ";
                    }
                    fullName += FirstName;
                }
                return fullName;
            }
        }

        public bool Validate()
        {
            var isValid = true;

            if (string.IsNullOrWhiteSpace(LastName)) isValid = false;
            if (string.IsNullOrWhiteSpace(EmailAddress)) isValid = false;

            return isValid;
        }
    }
}

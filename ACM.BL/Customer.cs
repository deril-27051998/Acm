using System.Collections.Generic;

namespace ACM.BL
{
    public class Customer
    {
        public Customer():this(0)//initializing the value of parameterd constructor
        {

        }
        public Customer(int customerid)
        {
            this.CustomerId = customerid;
            AddressList = new List<Address>();
        }
        public int CustomerType { get; set; }
        public int CustomerId { get; private set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string EmailAddress { get; set; }
        public string FullName
        {
            get
            {
               string fullName = LastName;
                if(!string.IsNullOrWhiteSpace(FirstName))
                {
                    if(!string.IsNullOrWhiteSpace(LastName))
                    {
                        fullName += ", ";
                    }
                    fullName += FirstName;
                }
                return fullName;
            }
        }
        public List<Address> AddressList { get; set; }
        public bool Validate()
        {
            var isValid = true;

            if (string.IsNullOrWhiteSpace(LastName)) isValid = false;
            if (string.IsNullOrWhiteSpace(EmailAddress)) isValid = false;

            return isValid;

        }

       


    }
}

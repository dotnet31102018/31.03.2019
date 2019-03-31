using System;
using System.Collections.Generic;

namespace HW3103
{
    public class Customer
    {
        public Int64 Id { get; set; }
        public Int64 Age { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string AddressCity { get; set; }
        public string AddressStreet { get; set; }
        public string PhNumber { get; set; }

        public override int GetHashCode()
        {
            return (int)Id;
        }

        public override string ToString()
        {
            return $"{Id} {Age} {FirstName} {LastName} {LastName} {AddressCity} {AddressStreet} {PhNumber}";
        }

        public override bool Equals(object obj)
        {
            if (obj == null)
                return false;

            Customer other = obj as Customer;
            if (other == null)
                return false;

            return this.Id == other.Id;
        }

    }
}
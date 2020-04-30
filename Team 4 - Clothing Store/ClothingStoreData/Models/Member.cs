using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClothingStoreData.Models
{
    public class Member
    {
        public int MemberID { get; }
        public string Email { get; }
        public string FirstName { get; }
        public string LastName { get; }
        public string Phone { get; }
        public string BillingAddress { get; }
        public float Points { get; }
        public string Status { get; }

        internal Member(int id, string email, string firstName,
           string lastName, string phone, string billingAddress, float points, string status)
        {
            MemberID = id;
            Email = email;
            FirstName = firstName;
            LastName = lastName;
            Phone = phone;
            BillingAddress = billingAddress;
            Points = points;
            Status = status;
        }

    }
}

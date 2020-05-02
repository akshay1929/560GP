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
        public int Points { get; }
        public string Status { get; }

        internal Member(int id, string email, string firstName,
           string lastName, string phone, string billingAddress, int points, string status)
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
        internal Member(string firstName,
           string lastName, int points, string status)
        {
            
            FirstName = firstName;
            LastName = lastName;
         
            Points = points;
            Status = status;
        }

    }
}

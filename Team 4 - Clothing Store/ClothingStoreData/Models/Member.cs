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
        public DateTimeOffset JoinedOn { get; }
        public DateTimeOffset BirthDate { get; }
        public string Status { get; }

        internal Member(int id, string email, string firstName,
           string lastName, string phone, string billingAddress, int points, DateTimeOffset joinedon, DateTimeOffset birthdate, string status)
        {
            MemberID = id;
            Email = email;
            FirstName = firstName;
            LastName = lastName;
            Phone = phone;
            BillingAddress = billingAddress;
            Points = points;
            JoinedOn = joinedon;
            BirthDate = birthdate;
            Status = status;
        }

        internal Member(int id, string firstName,
           string lastName, int points, string status)
        {
            MemberID = id;
            FirstName = firstName;
            LastName = lastName;
         
            Points = points;
            Status = status;
        }

    }
}

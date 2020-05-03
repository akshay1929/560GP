using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClothingStoreData.Models
{
    public class MemberStatus
    {
        public int MemberID { get; }
        public string FirstName { get; }
        public string LastName { get; }
        public int Points { get; }
        public string Status { get; }

        internal MemberStatus(int id, string firstName,
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

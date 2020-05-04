using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClothingStoreData.Models;
using DataAccess;
using System.Data;
using System.Data.SqlClient;


namespace ClothingStoreData.Delegate
{
    internal class UpdateMemberDataDelegate : DataDelegate
    {
        public readonly int memberid;
        public readonly string email;
        public readonly string firstname;
        public readonly string lastname;
        public readonly string phone;
        public readonly string billingaddress;
        public readonly int points;
        public readonly DateTimeOffset joinedon;
        public readonly DateTimeOffset birthdate;
        public readonly string status;

        public UpdateMemberDataDelegate(int memberid, string email, string firstname, string lastname, string phone,
           string billingaddress, int points, DateTimeOffset joinedon, DateTimeOffset birthdate, string status)
           : base("Users.UpdateMember")
        {
            this.memberid = memberid;
            this.email = email;
            this.firstname = firstname;
            this.lastname = lastname;
            this.phone = phone;
            this.billingaddress = billingaddress;
            this.points = points;
            this.joinedon = joinedon;
            this.birthdate = birthdate;
            this.status = status;
        }

        public override void PrepareCommand(SqlCommand command)
        {
            base.PrepareCommand(command);

            command.Parameters.AddWithValue("GivenMemberID", memberid);
            command.Parameters.AddWithValue("GivenEmail", email);
            command.Parameters.AddWithValue("GivenFirstName", firstname);
            command.Parameters.AddWithValue("GivenLastName", lastname);
            command.Parameters.AddWithValue("GivenPhone", phone);
            command.Parameters.AddWithValue("GivenBillingAddress", billingaddress);
            command.Parameters.AddWithValue("GivenPoints", points);
            command.Parameters.AddWithValue("GivenJoinedOn", joinedon);
            command.Parameters.AddWithValue("GivenBirthDate", birthdate);
            command.Parameters.AddWithValue("GivenStatus", status);
        }
    }
}

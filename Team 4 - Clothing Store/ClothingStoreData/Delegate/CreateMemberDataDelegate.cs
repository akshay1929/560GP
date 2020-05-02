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
    internal class CreateMemberDataDelegate : NonQueryDataDelegate<Member>
    {
        public readonly string email;
        public readonly string firstname;
        public readonly string lastname;
        public readonly string phone;
        public readonly string billingaddress;
        public readonly int points;
        public readonly DateTimeOffset joinedon;
        public readonly DateTimeOffset birthdate;
        public readonly string status;

        public CreateMemberDataDelegate(string email, string firstname,
           string lastname, string phone, string billingaddress, int points, DateTimeOffset joinedon, DateTimeOffset birthdate, string status)
           : base("Users.CreateMember")
        {
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

            var p = command.Parameters.Add("Email", SqlDbType.NVarChar);
            p.Value = email;

            p = command.Parameters.Add("FirstName", SqlDbType.NVarChar);
            p.Value = firstname;

            p = command.Parameters.Add("LastName", SqlDbType.NVarChar);
            p.Value = lastname;

            p = command.Parameters.Add("Phone", SqlDbType.NVarChar);
            p.Value = phone;

            p = command.Parameters.Add("BillingAddress", SqlDbType.NVarChar);
            p.Value = billingaddress;

            p = command.Parameters.Add("Points", SqlDbType.Int);
            p.Value = points;

            p = command.Parameters.Add("JoinedOn", SqlDbType.DateTimeOffset);
            p.Value = joinedon;

            p = command.Parameters.Add("BirthDate", SqlDbType.DateTimeOffset);
            p.Value = birthdate;

            p = command.Parameters.Add("Status", SqlDbType.NVarChar);
            p.Value = status;

            p = command.Parameters.Add("MemberID", SqlDbType.Int);
            p.Direction = ParameterDirection.Output;
        }

        public override Member Translate(SqlCommand command)
        {
            return new Member((int)command.Parameters["MemberID"].Value, email, firstname, lastname, phone, billingaddress, points, joinedon, birthdate, status);
        }

    }
}

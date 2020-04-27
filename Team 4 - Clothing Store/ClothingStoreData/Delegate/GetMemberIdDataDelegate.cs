using ClothingStoreData.Models;
using DataAccess;
using System.Data;
using System.Data.SqlClient;

namespace ClothingStoreData.Delegate
{
    class GetMemberIdDataDelegate : DataReaderDelegate<Member>
    {
        private readonly string email;

        public GetMemberIdDataDelegate(string email)
           : base("Users.GetMemberId")
        {
            this.email = email;
        }

        public override void PrepareCommand(SqlCommand command)
        {
            base.PrepareCommand(command);

            command.Parameters.AddWithValue("Email", email);
        }

        public override Member Translate(SqlCommand command, IDataRowReader reader)
        {
            if (!reader.Read())
                return null;

            return new Member(
               email,
               reader.GetString("FirstName"),
               reader.GetString("LastName"),
               reader.GetString("Phone"),
               reader.GetString("BillingAddress"),
               reader.GetFloat("Points"),
               reader.GetString("Status"));
        }
    }
}

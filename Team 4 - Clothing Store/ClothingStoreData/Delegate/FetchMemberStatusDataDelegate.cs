using ClothingStoreData.Models;
using DataAccess;
using System.Data;
using System.Data.SqlClient;

namespace ClothingStoreData.Delegate
{
    class FetchMemberStatusDataDelegate : DataReaderDelegate<Member>
    {
        private readonly int MemberID;

        public FetchMemberStatusDataDelegate(int MemberID)
           : base("Users.FetchMemberStatus")
        {
            this.MemberID = MemberID;
        }

        public override void PrepareCommand(SqlCommand command)
        {
            base.PrepareCommand(command);

            command.Parameters.AddWithValue("MemberID", MemberID);
        }

        public override Member Translate(SqlCommand command, IDataRowReader reader)
        {
            if (!reader.Read())
                return null;

            return new Member(
               MemberID,
               reader.GetString("Email"),
               reader.GetString("FirstName"),
               reader.GetString("LastName"),
               reader.GetString("Phone"),
               reader.GetString("BillingAddress"),
               reader.GetInt32("Points"),
               reader.GetDateTimeOffset("JoinedOn"),
               reader.GetDateTimeOffset("BirthDate"),
               reader.GetString("Status")
               );
        }
    }
}

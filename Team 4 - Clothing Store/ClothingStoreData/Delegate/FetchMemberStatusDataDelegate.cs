using ClothingStoreData.Models;
using DataAccess;
using System.Data;
using System.Data.SqlClient;

namespace ClothingStoreData.Delegate
{
    class FetchMemberStatusDataDelegate : DataReaderDelegate<MemberStatus>
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

            command.Parameters.AddWithValue("GivenMemberid", MemberID);
        }

        public override MemberStatus Translate(SqlCommand command, IDataRowReader reader)
        {
            if (!reader.Read())
                return null;

            return new MemberStatus(
               MemberID,
               reader.GetString("FirstName"),
               reader.GetString("LastName"),
               reader.GetInt32("Points"),
               reader.GetString("Status")
               );
        }
    }
}

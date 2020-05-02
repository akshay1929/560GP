using ClothingStoreData.Models;
using DataAccess;
using System.Data;
using System.Data.SqlClient;
using System.Collections.Generic;

namespace ClothingStoreData.Delegate
{
    class RetrieveMemberPointsDataDelegate : DataReaderDelegate<IReadOnlyList<Member>>
    {

        public RetrieveMemberPointsDataDelegate()
           : base("Users.RetrieveMemberPoints")
        {
        }

        public override IReadOnlyList<Member> Translate(SqlCommand command, IDataRowReader reader)
        {
            var members = new List<Member>();

            while (reader.Read())
            {
                members.Add(new Member(
                   
                    reader.GetString("FirstName"),
                    reader.GetString("LastName"),
                    reader.GetInt32("Points"),
                    reader.GetString("Status")
                    ));
            }

            return members;
        }
    }
}

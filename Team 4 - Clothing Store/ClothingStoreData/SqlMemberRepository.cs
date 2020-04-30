using System;
using ClothingStoreData.Delegate;
using ClothingStoreData.Models;
using DataAccess;
using System.Collections.Generic;

namespace ClothingStoreData
{
    public class SqlMemberRepository : IMemberRepository
    {
        private readonly SqlCommandExecutor executor;

        public SqlMemberRepository(string connectionString)
        {
            executor = new SqlCommandExecutor(connectionString);
        }

        public Member FetchMemberStatus(int memberid)
        {
            var d = new FetchMemberStatusDataDelegate(memberid);
            return executor.ExecuteReader(d);
        }

        public Member GetMemberId(string email)
        {
            var d = new GetMemberIdDataDelegate(email);
            return executor.ExecuteReader(d);
        }
        public IReadOnlyList<Member> RetrieveMember()
        {
            return executor.ExecuteReader(new RetrieveMembersDataDelegate());
        }
    }
}

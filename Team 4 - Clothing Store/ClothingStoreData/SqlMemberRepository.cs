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

        public Member CreateMember(string email, string firstName, string lastName, string phone, string billingAddress, int points, DateTimeOffset joinedOn, DateTimeOffset birthDate, string status)
        {
            if (string.IsNullOrWhiteSpace(email))
                throw new ArgumentException("The parameter cannot be null or empty.", nameof(email));

            if (string.IsNullOrWhiteSpace(firstName))
                throw new ArgumentException("The parameter cannot be null or empty.", nameof(firstName));

            if (string.IsNullOrWhiteSpace(lastName))
                throw new ArgumentException("The parameter cannot be null or empty.", nameof(lastName));

            if (string.IsNullOrWhiteSpace(phone))
                throw new ArgumentException("The parameter cannot be null or empty.", nameof(phone));

            if (string.IsNullOrEmpty(billingAddress))
                throw new ArgumentException("The parameter cannot be null or empty.", nameof(billingAddress));

            if (points < 0)
                throw new ArgumentException("The parameter cannot be negative or empty.", nameof(points));

            if (string.IsNullOrWhiteSpace(status))
                throw new ArgumentException("The parameter cannot be null or empty.", nameof(status));

            var d = new CreateMemberDataDelegate(email, firstName, lastName, phone, billingAddress, points, joinedOn, birthDate, status);
            return executor.ExecuteNonQuery(d);
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
        public IReadOnlyList<Member> RetrieveMemberPoints()
        {
            return executor.ExecuteReader(new RetrieveMemberPointsDataDelegate());
        }
    }
}

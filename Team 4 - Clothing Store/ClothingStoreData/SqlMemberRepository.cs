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

        public void UpdateMember(int memberid, string email, string firstname, string lastname, string phone, string billingaddress, int points, DateTimeOffset joinedon, DateTimeOffset birthdate, string status)
        {
            if (email == null)
                throw new ArgumentNullException(nameof(email));

            if (firstname == null)
                throw new ArgumentNullException(nameof(firstname));

            if (lastname == null)
                throw new ArgumentNullException(nameof(lastname));

            if (phone == null)
                throw new ArgumentNullException(nameof(phone));

            if (billingaddress == null)
                throw new ArgumentNullException(nameof(billingaddress));

            if (status == null)
                throw new ArgumentNullException(nameof(status));

            var d = new UpdateMemberDataDelegate(memberid, email, firstname, lastname, phone, billingaddress, points, joinedon, birthdate, status);
            executor.ExecuteNonQuery(d);
        }

        public MemberStatus FetchMemberStatus(int memberid)
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

using System.Collections.Generic;
using ClothingStoreData.Models;

namespace PersonData
{
    public interface IPersonRepository
    {
        IReadOnlyList<Member> RetrieveMember();

        Member FetchMember(int MemberID);

        Member GetMember(string Email);

        Member GetMemberPhone(string Phone);

        Member CreateMember(string Email, string Phone, string firstName, string lastName, string BillingAddress, int Points, string Status);
    }
}

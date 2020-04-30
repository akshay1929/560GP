using System.Collections.Generic;
using ClothingStoreData.Models;

namespace ClothingStoreData
{
    public interface IMemberRepository
    {
        IReadOnlyList<Member> RetrieveMember();

        Member FetchMemberStatus(int MemberID);

        Member GetMemberId(string Email);

        // Member CreateMember(string Email, string Phone, string firstName, string lastName, string BillingAddress, int Points, string Status);
    }
}

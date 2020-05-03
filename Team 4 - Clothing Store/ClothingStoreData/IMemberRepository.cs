using System.Collections.Generic;
using ClothingStoreData.Models;
using System;

namespace ClothingStoreData
{
    public interface IMemberRepository
    {
        IReadOnlyList<Member> RetrieveMember();
        IReadOnlyList<Member> RetrieveMemberPoints();
        MemberStatus FetchMemberStatus(int MemberID);

        Member GetMemberId(string Email);

        Member CreateMember(string email, string firstName, string lastName, string phone, string billingAddress, int points, DateTimeOffset joinedOn, DateTimeOffset birthDate, string status);
    }
}

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

        void UpdateMember(int memberid, string email, string firstname, string lastname, string phone, string billingaddress, int points, DateTimeOffset joinedon, DateTimeOffset birthdate, string status);

        Member GetMemberId(string Email);

        Member CreateMember(string email, string firstName, string lastName, string phone, string billingAddress, int points, DateTimeOffset joinedOn, DateTimeOffset birthDate, string status);
    }
}

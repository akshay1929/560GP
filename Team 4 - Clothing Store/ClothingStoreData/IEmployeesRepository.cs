using System.Collections.Generic;
using ClothingStoreData.Models;

namespace PersonData
{
    public interface IEmployeesRepository
    {
        IReadOnlyList<Member> RetrieveMember();

        Employees FetchEmployeeSalary(int employeeid);

        Member GetMember(string Email);

        Member GetMemberPhone(string Phone);

        Member CreateMember(string Email, string Phone, string firstName, string lastName, string BillingAddress, int Points, string Status);
    }
}

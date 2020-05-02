using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClothingStoreData;
using ClothingStoreData.Delegate;
using ClothingStoreData.Models;
using DataAccess;

using System.Data.SqlClient;

namespace Team_4___Clothing_Store
{
    public partial class MembersData : Form
    {
        const string connectionString = "Data Source=mssql.cs.ksu.edu;Initial Catalog = arahman; User ID = arahman; Password=Potc2003";
        public MembersData()
        {
            InitializeComponent();
        }

        private void GetMemberIdButton_Click(object sender, EventArgs e)
        {

        }

        private void retrieveMembers_Click(object sender, EventArgs e)
        {
            SqlMemberRepository members = new SqlMemberRepository(connectionString);
            IReadOnlyList<Member> memberList = members.RetrieveMember();
            dataGridView1.DataSource = memberList;
        }

        private void memberPoints_Click(object sender, EventArgs e)
        {
            SqlMemberRepository members = new SqlMemberRepository(connectionString);
            IReadOnlyList<Member> memberList = members.RetrieveMemberPoints();
            dataGridView1.DataSource = memberList;
        }

        private void CreateMemberButton_Click(object sender, EventArgs e)
        {
            CreateMemberForm createMember = new CreateMemberForm();
            createMember.ShowDialog();
        }
    }
}

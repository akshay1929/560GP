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
            SqlMemberRepository members = new SqlMemberRepository(connectionString);

            Member member = members.GetMemberId(EmailTextbox.Text);
            List<Member> memberList = new List<Member>();
            memberList.Add(member);
            dataGridView1.DataSource = memberList;
        }

        private void retrieveMembers_Click(object sender, EventArgs e)
        {
            SqlMemberRepository members = new SqlMemberRepository(connectionString);
            IReadOnlyList<Member> memberList = members.RetrieveMember();
            dataGridView1.DataSource = memberList;

            for (int i = 0; i < dataGridView1.Columns.Count; i++)
            {
                DataGridViewColumn columnOne = dataGridView1.Columns[0];
                columnOne.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

                DataGridViewColumn columnTwo = dataGridView1.Columns[2];
                columnTwo.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

                DataGridViewColumn columnThree = dataGridView1.Columns[3];
                columnThree.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

                DataGridViewColumn columnFour = dataGridView1.Columns[6];
                columnFour.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

                DataGridViewColumn columnFive = dataGridView1.Columns[9];
                columnFive.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }
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

            if(createMember.DialogResult == DialogResult.OK || createMember.DialogResult == DialogResult.Cancel)
            {
                createMember.Close();
            }
        }

        private void FetchMemberStatusButton_Click(object sender, EventArgs e)
        {
            SqlMemberRepository members = new SqlMemberRepository(connectionString);

            List<MemberStatus> member = new List<MemberStatus>();
            MemberStatus memberList = members.FetchMemberStatus(Convert.ToInt32(MemberIdTextbox.Text));
            member.Add(memberList);
            dataGridView1.DataSource = member;
        }
    }
}

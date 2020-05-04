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

        private void UpdateMemberButton_Click(object sender, EventArgs e)
        {
            UpdateMember updateForm = new UpdateMember();

            updateForm.MemberIdTextbox.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            updateForm.MemberIdTextbox.ReadOnly = true;
            updateForm.EmailTextBox.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            updateForm.FirstNameTextBox.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            updateForm.LastNameTextBox.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            updateForm.PhoneTextBox.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            updateForm.BillingAddressTextBox.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            updateForm.PointsTextBox.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
            updateForm.JoinedOnTextBox.Text = dataGridView1.CurrentRow.Cells[7].Value.ToString();
            updateForm.BirthDateTextBox.Text = dataGridView1.CurrentRow.Cells[8].Value.ToString();
            updateForm.StatusTextBox.Text = dataGridView1.CurrentRow.Cells[9].Value.ToString();

            updateForm.ShowDialog();

            if (updateForm.DialogResult == DialogResult.OK || updateForm.DialogResult == DialogResult.Cancel)
            {
                updateForm.Close();
            }
        }
    }
}

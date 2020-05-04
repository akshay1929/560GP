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

namespace Team_4___Clothing_Store
{
    public partial class CreateMemberForm : Form
    {
        const string connectionString = "Data Source=mssql.cs.ksu.edu;Initial Catalog = arahman; User ID = arahman; Password=Cicko1999";
        List<Member> list = new List<Member>();

        public CreateMemberForm()
        {
            InitializeComponent();
        }

        private void MemberIDLabel_Click(object sender, EventArgs e)
        {

        }

        private void CreateMemberButton_Click(object sender, EventArgs e)
        {
            try
            {
                SqlMemberRepository members = new SqlMemberRepository(connectionString);

                Member createMember = members.CreateMember(EmailTextBox.Text, FirstNameTextBox.Text, LastNameTextBox.Text, PhoneTextBox.Text, BillingAddressTextBox.Text, Convert.ToInt32(PointsTextBox.Text), Convert.ToDateTime(JoinedOnTextBox.Text), Convert.ToDateTime(BirthDateTextBox.Text), StatusTextBox.Text);
                list.Add(createMember);

                MembersData md = new MembersData();
                md.dataGridView1.DataSource = list;
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void Label2_Click(object sender, EventArgs e)
        {

        }

        private void Label3_Click(object sender, EventArgs e)
        {

        }

        private void Label4_Click(object sender, EventArgs e)
        {

        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void Label5_Click(object sender, EventArgs e)
        {

        }

        private void Label9_Click(object sender, EventArgs e)
        {

        }

        private void Label8_Click(object sender, EventArgs e)
        {

        }

        private void Label7_Click(object sender, EventArgs e)
        {

        }

        private void Label6_Click(object sender, EventArgs e)
        {

        }

        private void BirthDateTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void StatusTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void JoinedOnTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void PointsTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void EmailTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void BillingAddressTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void PhoneTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void LastNameTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void FirstNameTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void CreateMemberForm_Load(object sender, EventArgs e)
        {

        }
    }
}

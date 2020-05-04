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
    public partial class UpdateMember : Form
    {
        const string connectionString = "Data Source=mssql.cs.ksu.edu;Initial Catalog = arahman; User ID = arahman; Password=Potc2003";

        public UpdateMember()
        {
            InitializeComponent();
        }

        private void UpdateMemberButton_Click(object sender, EventArgs e)
        {
            try
            {
                MembersData ed = new MembersData();

                SqlMemberRepository members = new SqlMemberRepository(connectionString);
                members.UpdateMember(Convert.ToInt32(MemberIdTextbox.Text), EmailTextBox.Text, FirstNameTextBox.Text, LastNameTextBox.Text, PhoneTextBox.Text, BillingAddressTextBox.Text, Convert.ToInt32(PointsTextBox.Text), Convert.ToDateTime(JoinedOnTextBox.Text), Convert.ToDateTime(BirthDateTextBox.Text), StatusTextBox.Text);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}

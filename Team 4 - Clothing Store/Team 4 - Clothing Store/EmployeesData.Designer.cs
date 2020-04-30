namespace Team_4___Clothing_Store
{
    partial class EmployeesData
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.EmployeesList = new System.Windows.Forms.ListBox();
            this.RetrieveEmployeesButton = new System.Windows.Forms.Button();
            this.CreateEmployeeButton = new System.Windows.Forms.Button();
            this.FetchEmployeeSalaryButton = new System.Windows.Forms.Button();
            this.EmailTextbox = new System.Windows.Forms.TextBox();
            this.NameTextbox = new System.Windows.Forms.TextBox();
            this.RoleTextbox = new System.Windows.Forms.TextBox();
            this.SalaryTextbox = new System.Windows.Forms.TextBox();
            this.EmailLabel = new System.Windows.Forms.Label();
            this.NameLabel = new System.Windows.Forms.Label();
            this.RoleLabel = new System.Windows.Forms.Label();
            this.SalaryLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.EmployeeIdTextBox = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // EmployeesList
            // 
            this.EmployeesList.FormattingEnabled = true;
            this.EmployeesList.Location = new System.Drawing.Point(12, 15);
            this.EmployeesList.Name = "EmployeesList";
            this.EmployeesList.Size = new System.Drawing.Size(84, 420);
            this.EmployeesList.TabIndex = 0;
            this.EmployeesList.SelectedIndexChanged += new System.EventHandler(this.EmployeesList_SelectedIndexChanged);
            // 
            // RetrieveEmployeesButton
            // 
            this.RetrieveEmployeesButton.Location = new System.Drawing.Point(449, 15);
            this.RetrieveEmployeesButton.Name = "RetrieveEmployeesButton";
            this.RetrieveEmployeesButton.Size = new System.Drawing.Size(212, 42);
            this.RetrieveEmployeesButton.TabIndex = 1;
            this.RetrieveEmployeesButton.Text = "Retrieve Employees";
            this.RetrieveEmployeesButton.UseVisualStyleBackColor = true;
            this.RetrieveEmployeesButton.Click += new System.EventHandler(this.RetrieveEmployeesButton_Click);
            // 
            // CreateEmployeeButton
            // 
            this.CreateEmployeeButton.Location = new System.Drawing.Point(449, 339);
            this.CreateEmployeeButton.Name = "CreateEmployeeButton";
            this.CreateEmployeeButton.Size = new System.Drawing.Size(212, 42);
            this.CreateEmployeeButton.TabIndex = 2;
            this.CreateEmployeeButton.Text = "Create Employee";
            this.CreateEmployeeButton.UseVisualStyleBackColor = true;
            // 
            // FetchEmployeeSalaryButton
            // 
            this.FetchEmployeeSalaryButton.Location = new System.Drawing.Point(449, 133);
            this.FetchEmployeeSalaryButton.Name = "FetchEmployeeSalaryButton";
            this.FetchEmployeeSalaryButton.Size = new System.Drawing.Size(212, 42);
            this.FetchEmployeeSalaryButton.TabIndex = 3;
            this.FetchEmployeeSalaryButton.Text = "Fetch Employee Salary";
            this.FetchEmployeeSalaryButton.UseVisualStyleBackColor = true;
            // 
            // EmailTextbox
            // 
            this.EmailTextbox.Location = new System.Drawing.Point(512, 219);
            this.EmailTextbox.Name = "EmailTextbox";
            this.EmailTextbox.Size = new System.Drawing.Size(149, 20);
            this.EmailTextbox.TabIndex = 4;
            // 
            // NameTextbox
            // 
            this.NameTextbox.Location = new System.Drawing.Point(512, 248);
            this.NameTextbox.Name = "NameTextbox";
            this.NameTextbox.Size = new System.Drawing.Size(149, 20);
            this.NameTextbox.TabIndex = 5;
            // 
            // RoleTextbox
            // 
            this.RoleTextbox.Location = new System.Drawing.Point(512, 277);
            this.RoleTextbox.Name = "RoleTextbox";
            this.RoleTextbox.Size = new System.Drawing.Size(149, 20);
            this.RoleTextbox.TabIndex = 6;
            // 
            // SalaryTextbox
            // 
            this.SalaryTextbox.Location = new System.Drawing.Point(512, 306);
            this.SalaryTextbox.Name = "SalaryTextbox";
            this.SalaryTextbox.Size = new System.Drawing.Size(149, 20);
            this.SalaryTextbox.TabIndex = 7;
            // 
            // EmailLabel
            // 
            this.EmailLabel.AutoSize = true;
            this.EmailLabel.Location = new System.Drawing.Point(446, 222);
            this.EmailLabel.Name = "EmailLabel";
            this.EmailLabel.Size = new System.Drawing.Size(35, 13);
            this.EmailLabel.TabIndex = 8;
            this.EmailLabel.Text = "Email:";
            // 
            // NameLabel
            // 
            this.NameLabel.AutoSize = true;
            this.NameLabel.Location = new System.Drawing.Point(446, 251);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(38, 13);
            this.NameLabel.TabIndex = 9;
            this.NameLabel.Text = "Name:";
            // 
            // RoleLabel
            // 
            this.RoleLabel.AutoSize = true;
            this.RoleLabel.Location = new System.Drawing.Point(446, 280);
            this.RoleLabel.Name = "RoleLabel";
            this.RoleLabel.Size = new System.Drawing.Size(32, 13);
            this.RoleLabel.TabIndex = 10;
            this.RoleLabel.Text = "Role:";
            // 
            // SalaryLabel
            // 
            this.SalaryLabel.AutoSize = true;
            this.SalaryLabel.Location = new System.Drawing.Point(446, 309);
            this.SalaryLabel.Name = "SalaryLabel";
            this.SalaryLabel.Size = new System.Drawing.Size(39, 13);
            this.SalaryLabel.TabIndex = 11;
            this.SalaryLabel.Text = "Salary:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(446, 103);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "Employee Id:";
            // 
            // EmployeeIdTextBox
            // 
            this.EmployeeIdTextBox.Location = new System.Drawing.Point(543, 100);
            this.EmployeeIdTextBox.Name = "EmployeeIdTextBox";
            this.EmployeeIdTextBox.Size = new System.Drawing.Size(118, 20);
            this.EmployeeIdTextBox.TabIndex = 12;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(117, 15);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(310, 420);
            this.dataGridView1.TabIndex = 14;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // EmployeesData
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(703, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.EmployeeIdTextBox);
            this.Controls.Add(this.SalaryLabel);
            this.Controls.Add(this.RoleLabel);
            this.Controls.Add(this.NameLabel);
            this.Controls.Add(this.EmailLabel);
            this.Controls.Add(this.SalaryTextbox);
            this.Controls.Add(this.RoleTextbox);
            this.Controls.Add(this.NameTextbox);
            this.Controls.Add(this.EmailTextbox);
            this.Controls.Add(this.FetchEmployeeSalaryButton);
            this.Controls.Add(this.CreateEmployeeButton);
            this.Controls.Add(this.RetrieveEmployeesButton);
            this.Controls.Add(this.EmployeesList);
            this.Name = "EmployeesData";
            this.Text = "EmployeesData";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox EmployeesList;
        private System.Windows.Forms.Button RetrieveEmployeesButton;
        private System.Windows.Forms.Button CreateEmployeeButton;
        private System.Windows.Forms.Button FetchEmployeeSalaryButton;
        private System.Windows.Forms.TextBox EmailTextbox;
        private System.Windows.Forms.TextBox NameTextbox;
        private System.Windows.Forms.TextBox RoleTextbox;
        private System.Windows.Forms.TextBox SalaryTextbox;
        private System.Windows.Forms.Label EmailLabel;
        private System.Windows.Forms.Label NameLabel;
        private System.Windows.Forms.Label RoleLabel;
        private System.Windows.Forms.Label SalaryLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox EmployeeIdTextBox;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}
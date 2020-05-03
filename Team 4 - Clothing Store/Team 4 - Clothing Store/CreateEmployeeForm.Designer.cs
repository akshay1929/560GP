namespace Team_4___Clothing_Store
{
    partial class CreateEmployeeForm
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
            this.SalaryLabel = new System.Windows.Forms.Label();
            this.RoleLabel = new System.Windows.Forms.Label();
            this.NameLabel = new System.Windows.Forms.Label();
            this.EmailLabel = new System.Windows.Forms.Label();
            this.SalaryTextbox = new System.Windows.Forms.TextBox();
            this.RoleTextbox = new System.Windows.Forms.TextBox();
            this.NameTextbox = new System.Windows.Forms.TextBox();
            this.EmailTextbox = new System.Windows.Forms.TextBox();
            this.CreateEmployeeButton = new System.Windows.Forms.Button();
            this.EmployeeLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // SalaryLabel
            // 
            this.SalaryLabel.AutoSize = true;
            this.SalaryLabel.Location = new System.Drawing.Point(45, 117);
            this.SalaryLabel.Name = "SalaryLabel";
            this.SalaryLabel.Size = new System.Drawing.Size(39, 13);
            this.SalaryLabel.TabIndex = 19;
            this.SalaryLabel.Text = "Salary:";
            // 
            // RoleLabel
            // 
            this.RoleLabel.AutoSize = true;
            this.RoleLabel.Location = new System.Drawing.Point(45, 88);
            this.RoleLabel.Name = "RoleLabel";
            this.RoleLabel.Size = new System.Drawing.Size(32, 13);
            this.RoleLabel.TabIndex = 18;
            this.RoleLabel.Text = "Role:";
            // 
            // NameLabel
            // 
            this.NameLabel.AutoSize = true;
            this.NameLabel.Location = new System.Drawing.Point(45, 59);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(38, 13);
            this.NameLabel.TabIndex = 17;
            this.NameLabel.Text = "Name:";
            // 
            // EmailLabel
            // 
            this.EmailLabel.AutoSize = true;
            this.EmailLabel.Location = new System.Drawing.Point(45, 30);
            this.EmailLabel.Name = "EmailLabel";
            this.EmailLabel.Size = new System.Drawing.Size(35, 13);
            this.EmailLabel.TabIndex = 16;
            this.EmailLabel.Text = "Email:";
            // 
            // SalaryTextbox
            // 
            this.SalaryTextbox.Location = new System.Drawing.Point(111, 114);
            this.SalaryTextbox.Name = "SalaryTextbox";
            this.SalaryTextbox.Size = new System.Drawing.Size(149, 20);
            this.SalaryTextbox.TabIndex = 15;
            // 
            // RoleTextbox
            // 
            this.RoleTextbox.Location = new System.Drawing.Point(111, 85);
            this.RoleTextbox.Name = "RoleTextbox";
            this.RoleTextbox.Size = new System.Drawing.Size(149, 20);
            this.RoleTextbox.TabIndex = 14;
            // 
            // NameTextbox
            // 
            this.NameTextbox.Location = new System.Drawing.Point(111, 56);
            this.NameTextbox.Name = "NameTextbox";
            this.NameTextbox.Size = new System.Drawing.Size(149, 20);
            this.NameTextbox.TabIndex = 13;
            // 
            // EmailTextbox
            // 
            this.EmailTextbox.Location = new System.Drawing.Point(111, 27);
            this.EmailTextbox.Name = "EmailTextbox";
            this.EmailTextbox.Size = new System.Drawing.Size(149, 20);
            this.EmailTextbox.TabIndex = 12;
            // 
            // CreateEmployeeButton
            // 
            this.CreateEmployeeButton.Location = new System.Drawing.Point(48, 158);
            this.CreateEmployeeButton.Name = "CreateEmployeeButton";
            this.CreateEmployeeButton.Size = new System.Drawing.Size(212, 46);
            this.CreateEmployeeButton.TabIndex = 20;
            this.CreateEmployeeButton.Text = "Create Employee";
            this.CreateEmployeeButton.UseVisualStyleBackColor = true;
            this.CreateEmployeeButton.Click += new System.EventHandler(this.CreateEmployeeButton_Click);
            // 
            // EmployeeLabel
            // 
            this.EmployeeLabel.AutoSize = true;
            this.EmployeeLabel.Location = new System.Drawing.Point(45, 226);
            this.EmployeeLabel.Name = "EmployeeLabel";
            this.EmployeeLabel.Size = new System.Drawing.Size(0, 13);
            this.EmployeeLabel.TabIndex = 21;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(48, 225);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 22;
            // 
            // CreateEmployeeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(307, 262);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.EmployeeLabel);
            this.Controls.Add(this.CreateEmployeeButton);
            this.Controls.Add(this.SalaryLabel);
            this.Controls.Add(this.RoleLabel);
            this.Controls.Add(this.NameLabel);
            this.Controls.Add(this.EmailLabel);
            this.Controls.Add(this.SalaryTextbox);
            this.Controls.Add(this.RoleTextbox);
            this.Controls.Add(this.NameTextbox);
            this.Controls.Add(this.EmailTextbox);
            this.Name = "CreateEmployeeForm";
            this.Text = "Create A Employee";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label SalaryLabel;
        private System.Windows.Forms.Label RoleLabel;
        private System.Windows.Forms.Label NameLabel;
        private System.Windows.Forms.Label EmailLabel;
        private System.Windows.Forms.TextBox SalaryTextbox;
        private System.Windows.Forms.TextBox RoleTextbox;
        private System.Windows.Forms.TextBox NameTextbox;
        private System.Windows.Forms.TextBox EmailTextbox;
        private System.Windows.Forms.Button CreateEmployeeButton;
        private System.Windows.Forms.Label EmployeeLabel;
        private System.Windows.Forms.Label label1;
    }
}
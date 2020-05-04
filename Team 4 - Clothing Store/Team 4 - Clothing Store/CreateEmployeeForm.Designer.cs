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
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // SalaryLabel
            // 
            this.SalaryLabel.AutoSize = true;
            this.SalaryLabel.Location = new System.Drawing.Point(12, 117);
            this.SalaryLabel.Name = "SalaryLabel";
            this.SalaryLabel.Size = new System.Drawing.Size(39, 13);
            this.SalaryLabel.TabIndex = 19;
            this.SalaryLabel.Text = "Salary:";
            // 
            // RoleLabel
            // 
            this.RoleLabel.AutoSize = true;
            this.RoleLabel.Location = new System.Drawing.Point(12, 88);
            this.RoleLabel.Name = "RoleLabel";
            this.RoleLabel.Size = new System.Drawing.Size(32, 13);
            this.RoleLabel.TabIndex = 18;
            this.RoleLabel.Text = "Role:";
            // 
            // NameLabel
            // 
            this.NameLabel.AutoSize = true;
            this.NameLabel.Location = new System.Drawing.Point(12, 59);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(38, 13);
            this.NameLabel.TabIndex = 17;
            this.NameLabel.Text = "Name:";
            // 
            // EmailLabel
            // 
            this.EmailLabel.AutoSize = true;
            this.EmailLabel.Location = new System.Drawing.Point(12, 30);
            this.EmailLabel.Name = "EmailLabel";
            this.EmailLabel.Size = new System.Drawing.Size(35, 13);
            this.EmailLabel.TabIndex = 16;
            this.EmailLabel.Text = "Email:";
            // 
            // SalaryTextbox
            // 
            this.SalaryTextbox.Location = new System.Drawing.Point(69, 114);
            this.SalaryTextbox.Name = "SalaryTextbox";
            this.SalaryTextbox.Size = new System.Drawing.Size(226, 20);
            this.SalaryTextbox.TabIndex = 15;
            // 
            // RoleTextbox
            // 
            this.RoleTextbox.Location = new System.Drawing.Point(69, 85);
            this.RoleTextbox.Name = "RoleTextbox";
            this.RoleTextbox.Size = new System.Drawing.Size(226, 20);
            this.RoleTextbox.TabIndex = 14;
            // 
            // NameTextbox
            // 
            this.NameTextbox.Location = new System.Drawing.Point(69, 56);
            this.NameTextbox.Name = "NameTextbox";
            this.NameTextbox.Size = new System.Drawing.Size(226, 20);
            this.NameTextbox.TabIndex = 13;
            // 
            // EmailTextbox
            // 
            this.EmailTextbox.Location = new System.Drawing.Point(69, 27);
            this.EmailTextbox.Name = "EmailTextbox";
            this.EmailTextbox.Size = new System.Drawing.Size(226, 20);
            this.EmailTextbox.TabIndex = 12;
            // 
            // CreateEmployeeButton
            // 
            this.CreateEmployeeButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.CreateEmployeeButton.Location = new System.Drawing.Point(15, 158);
            this.CreateEmployeeButton.Name = "CreateEmployeeButton";
            this.CreateEmployeeButton.Size = new System.Drawing.Size(103, 46);
            this.CreateEmployeeButton.TabIndex = 20;
            this.CreateEmployeeButton.Text = "OK";
            this.CreateEmployeeButton.UseVisualStyleBackColor = true;
            this.CreateEmployeeButton.Click += new System.EventHandler(this.CreateEmployeeButton_Click);
            // 
            // button1
            // 
            this.button1.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button1.Location = new System.Drawing.Point(192, 158);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(103, 46);
            this.button1.TabIndex = 21;
            this.button1.Text = "Cancel";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // CreateEmployeeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(307, 237);
            this.Controls.Add(this.button1);
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
            this.Text = "Add A Employee";
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
        private System.Windows.Forms.Button button1;
    }
}
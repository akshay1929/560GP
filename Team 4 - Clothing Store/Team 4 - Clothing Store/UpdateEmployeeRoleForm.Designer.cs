namespace Team_4___Clothing_Store
{
    partial class UpdateEmployeeRoleForm
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
            this.EmployeeRoleLabel = new System.Windows.Forms.Label();
            this.EmployeeIDLabel = new System.Windows.Forms.Label();
            this.EmployeeRoleText = new System.Windows.Forms.TextBox();
            this.EmployeeIdText = new System.Windows.Forms.TextBox();
            this.UpdateEmployeeRoleButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.EmailTextbox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.NameTextbox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SalaryTextbox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // EmployeeRoleLabel
            // 
            this.EmployeeRoleLabel.AutoSize = true;
            this.EmployeeRoleLabel.Location = new System.Drawing.Point(20, 112);
            this.EmployeeRoleLabel.Name = "EmployeeRoleLabel";
            this.EmployeeRoleLabel.Size = new System.Drawing.Size(81, 13);
            this.EmployeeRoleLabel.TabIndex = 23;
            this.EmployeeRoleLabel.Text = "Employee Role:";
            // 
            // EmployeeIDLabel
            // 
            this.EmployeeIDLabel.AutoSize = true;
            this.EmployeeIDLabel.Location = new System.Drawing.Point(20, 25);
            this.EmployeeIDLabel.Name = "EmployeeIDLabel";
            this.EmployeeIDLabel.Size = new System.Drawing.Size(70, 13);
            this.EmployeeIDLabel.TabIndex = 22;
            this.EmployeeIDLabel.Text = "Employee ID:";
            // 
            // EmployeeRoleText
            // 
            this.EmployeeRoleText.Location = new System.Drawing.Point(118, 109);
            this.EmployeeRoleText.Name = "EmployeeRoleText";
            this.EmployeeRoleText.Size = new System.Drawing.Size(192, 20);
            this.EmployeeRoleText.TabIndex = 21;
            // 
            // EmployeeIdText
            // 
            this.EmployeeIdText.Location = new System.Drawing.Point(118, 22);
            this.EmployeeIdText.Name = "EmployeeIdText";
            this.EmployeeIdText.Size = new System.Drawing.Size(192, 20);
            this.EmployeeIdText.TabIndex = 20;
            // 
            // UpdateEmployeeRoleButton
            // 
            this.UpdateEmployeeRoleButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.UpdateEmployeeRoleButton.Location = new System.Drawing.Point(23, 180);
            this.UpdateEmployeeRoleButton.Name = "UpdateEmployeeRoleButton";
            this.UpdateEmployeeRoleButton.Size = new System.Drawing.Size(120, 45);
            this.UpdateEmployeeRoleButton.TabIndex = 24;
            this.UpdateEmployeeRoleButton.Text = "OK";
            this.UpdateEmployeeRoleButton.UseVisualStyleBackColor = true;
            this.UpdateEmployeeRoleButton.Click += new System.EventHandler(this.UpdateEmployeeRoleButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 27;
            this.label1.Text = "Email:";
            // 
            // EmailTextbox
            // 
            this.EmailTextbox.Location = new System.Drawing.Point(118, 51);
            this.EmailTextbox.Name = "EmailTextbox";
            this.EmailTextbox.Size = new System.Drawing.Size(192, 20);
            this.EmailTextbox.TabIndex = 26;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 29;
            this.label2.Text = "Name:";
            // 
            // NameTextbox
            // 
            this.NameTextbox.Location = new System.Drawing.Point(118, 80);
            this.NameTextbox.Name = "NameTextbox";
            this.NameTextbox.Size = new System.Drawing.Size(192, 20);
            this.NameTextbox.TabIndex = 28;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 142);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 13);
            this.label3.TabIndex = 31;
            this.label3.Text = "Salary:";
            // 
            // SalaryTextbox
            // 
            this.SalaryTextbox.Location = new System.Drawing.Point(118, 139);
            this.SalaryTextbox.Name = "SalaryTextbox";
            this.SalaryTextbox.Size = new System.Drawing.Size(192, 20);
            this.SalaryTextbox.TabIndex = 30;
            // 
            // button1
            // 
            this.button1.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button1.Location = new System.Drawing.Point(190, 180);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(120, 45);
            this.button1.TabIndex = 32;
            this.button1.Text = "Cancel";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // UpdateEmployeeRoleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(322, 248);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.SalaryTextbox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.NameTextbox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.EmailTextbox);
            this.Controls.Add(this.UpdateEmployeeRoleButton);
            this.Controls.Add(this.EmployeeRoleLabel);
            this.Controls.Add(this.EmployeeIDLabel);
            this.Controls.Add(this.EmployeeRoleText);
            this.Controls.Add(this.EmployeeIdText);
            this.Name = "UpdateEmployeeRoleForm";
            this.Text = "Update Employee";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label EmployeeRoleLabel;
        private System.Windows.Forms.Label EmployeeIDLabel;
        private System.Windows.Forms.Button UpdateEmployeeRoleButton;
        public System.Windows.Forms.TextBox EmployeeRoleText;
        public System.Windows.Forms.TextBox EmployeeIdText;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox EmailTextbox;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.TextBox NameTextbox;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.TextBox SalaryTextbox;
        private System.Windows.Forms.Button button1;
    }
}
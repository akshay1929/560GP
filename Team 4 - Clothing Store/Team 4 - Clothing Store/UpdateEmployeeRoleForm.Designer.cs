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
            this.UpdateEmployeeLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // EmployeeRoleLabel
            // 
            this.EmployeeRoleLabel.AutoSize = true;
            this.EmployeeRoleLabel.Location = new System.Drawing.Point(20, 46);
            this.EmployeeRoleLabel.Name = "EmployeeRoleLabel";
            this.EmployeeRoleLabel.Size = new System.Drawing.Size(81, 13);
            this.EmployeeRoleLabel.TabIndex = 23;
            this.EmployeeRoleLabel.Text = "Employee Role:";
            // 
            // EmployeeIDLabel
            // 
            this.EmployeeIDLabel.AutoSize = true;
            this.EmployeeIDLabel.Location = new System.Drawing.Point(20, 15);
            this.EmployeeIDLabel.Name = "EmployeeIDLabel";
            this.EmployeeIDLabel.Size = new System.Drawing.Size(70, 13);
            this.EmployeeIDLabel.TabIndex = 22;
            this.EmployeeIDLabel.Text = "Employee ID:";
            // 
            // EmployeeRoleText
            // 
            this.EmployeeRoleText.Location = new System.Drawing.Point(108, 43);
            this.EmployeeRoleText.Name = "EmployeeRoleText";
            this.EmployeeRoleText.Size = new System.Drawing.Size(166, 20);
            this.EmployeeRoleText.TabIndex = 21;
            // 
            // EmployeeIdText
            // 
            this.EmployeeIdText.Location = new System.Drawing.Point(108, 12);
            this.EmployeeIdText.Name = "EmployeeIdText";
            this.EmployeeIdText.Size = new System.Drawing.Size(166, 20);
            this.EmployeeIdText.TabIndex = 20;
            // 
            // UpdateEmployeeRoleButton
            // 
            this.UpdateEmployeeRoleButton.Location = new System.Drawing.Point(23, 79);
            this.UpdateEmployeeRoleButton.Name = "UpdateEmployeeRoleButton";
            this.UpdateEmployeeRoleButton.Size = new System.Drawing.Size(251, 45);
            this.UpdateEmployeeRoleButton.TabIndex = 24;
            this.UpdateEmployeeRoleButton.Text = "Update Employee Role";
            this.UpdateEmployeeRoleButton.UseVisualStyleBackColor = true;
            this.UpdateEmployeeRoleButton.Click += new System.EventHandler(this.UpdateEmployeeRoleButton_Click);
            // 
            // UpdateEmployeeLabel
            // 
            this.UpdateEmployeeLabel.AutoSize = true;
            this.UpdateEmployeeLabel.Location = new System.Drawing.Point(23, 143);
            this.UpdateEmployeeLabel.Name = "UpdateEmployeeLabel";
            this.UpdateEmployeeLabel.Size = new System.Drawing.Size(0, 13);
            this.UpdateEmployeeLabel.TabIndex = 25;
            // 
            // UpdateEmployeeRoleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(297, 176);
            this.Controls.Add(this.UpdateEmployeeLabel);
            this.Controls.Add(this.UpdateEmployeeRoleButton);
            this.Controls.Add(this.EmployeeRoleLabel);
            this.Controls.Add(this.EmployeeIDLabel);
            this.Controls.Add(this.EmployeeRoleText);
            this.Controls.Add(this.EmployeeIdText);
            this.Name = "UpdateEmployeeRoleForm";
            this.Text = "Update Employee Role";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label EmployeeRoleLabel;
        private System.Windows.Forms.Label EmployeeIDLabel;
        private System.Windows.Forms.Button UpdateEmployeeRoleButton;
        private System.Windows.Forms.Label UpdateEmployeeLabel;
        public System.Windows.Forms.TextBox EmployeeRoleText;
        public System.Windows.Forms.TextBox EmployeeIdText;
    }
}
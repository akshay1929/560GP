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
            this.RetrieveEmployeesButton = new System.Windows.Forms.Button();
            this.CreateEmployeeButton = new System.Windows.Forms.Button();
            this.FetchEmployeeSalaryButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.EmployeeIdTextBox = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // RetrieveEmployeesButton
            // 
            this.RetrieveEmployeesButton.Location = new System.Drawing.Point(604, 12);
            this.RetrieveEmployeesButton.Name = "RetrieveEmployeesButton";
            this.RetrieveEmployeesButton.Size = new System.Drawing.Size(212, 42);
            this.RetrieveEmployeesButton.TabIndex = 1;
            this.RetrieveEmployeesButton.Text = "Retrieve Employees";
            this.RetrieveEmployeesButton.UseVisualStyleBackColor = true;
            this.RetrieveEmployeesButton.Click += new System.EventHandler(this.RetrieveEmployeesButton_Click);
            // 
            // CreateEmployeeButton
            // 
            this.CreateEmployeeButton.Location = new System.Drawing.Point(604, 70);
            this.CreateEmployeeButton.Name = "CreateEmployeeButton";
            this.CreateEmployeeButton.Size = new System.Drawing.Size(212, 42);
            this.CreateEmployeeButton.TabIndex = 2;
            this.CreateEmployeeButton.Text = "Add New Employee";
            this.CreateEmployeeButton.UseVisualStyleBackColor = true;
            this.CreateEmployeeButton.Click += new System.EventHandler(this.CreateEmployeeButton_Click);
            // 
            // FetchEmployeeSalaryButton
            // 
            this.FetchEmployeeSalaryButton.Location = new System.Drawing.Point(604, 166);
            this.FetchEmployeeSalaryButton.Name = "FetchEmployeeSalaryButton";
            this.FetchEmployeeSalaryButton.Size = new System.Drawing.Size(212, 42);
            this.FetchEmployeeSalaryButton.TabIndex = 3;
            this.FetchEmployeeSalaryButton.Text = "Fetch Employee Salary";
            this.FetchEmployeeSalaryButton.UseVisualStyleBackColor = true;
            this.FetchEmployeeSalaryButton.Click += new System.EventHandler(this.FetchEmployeeSalaryButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(601, 136);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "Employee Id:";
            // 
            // EmployeeIdTextBox
            // 
            this.EmployeeIdTextBox.Location = new System.Drawing.Point(698, 133);
            this.EmployeeIdTextBox.Name = "EmployeeIdTextBox";
            this.EmployeeIdTextBox.Size = new System.Drawing.Size(118, 20);
            this.EmployeeIdTextBox.TabIndex = 12;
            this.EmployeeIdTextBox.TextChanged += new System.EventHandler(this.EmployeeIdTextBox_TextChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(543, 423);
            this.dataGridView1.TabIndex = 14;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // EmployeesData
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(830, 449);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.EmployeeIdTextBox);
            this.Controls.Add(this.FetchEmployeeSalaryButton);
            this.Controls.Add(this.CreateEmployeeButton);
            this.Controls.Add(this.RetrieveEmployeesButton);
            this.Name = "EmployeesData";
            this.Text = "EmployeesData";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button RetrieveEmployeesButton;
        private System.Windows.Forms.Button CreateEmployeeButton;
        private System.Windows.Forms.Button FetchEmployeeSalaryButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox EmployeeIdTextBox;
        public System.Windows.Forms.DataGridView dataGridView1;
    }
}
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.RetrieveEmployeesButton = new System.Windows.Forms.Button();
            this.CreateEmployeeButton = new System.Windows.Forms.Button();
            this.FetchEmployeeSalaryButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.EmployeeIdTextBox = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.UpdateEmployeeRole = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // RetrieveEmployeesButton
            // 
            this.RetrieveEmployeesButton.Location = new System.Drawing.Point(43, 10);
            this.RetrieveEmployeesButton.Name = "RetrieveEmployeesButton";
            this.RetrieveEmployeesButton.Size = new System.Drawing.Size(154, 36);
            this.RetrieveEmployeesButton.TabIndex = 1;
            this.RetrieveEmployeesButton.Text = "Retrieve Employees";
            this.RetrieveEmployeesButton.UseVisualStyleBackColor = true;
            this.RetrieveEmployeesButton.Click += new System.EventHandler(this.RetrieveEmployeesButton_Click);
            // 
            // CreateEmployeeButton
            // 
            this.CreateEmployeeButton.Location = new System.Drawing.Point(203, 10);
            this.CreateEmployeeButton.Name = "CreateEmployeeButton";
            this.CreateEmployeeButton.Size = new System.Drawing.Size(154, 36);
            this.CreateEmployeeButton.TabIndex = 2;
            this.CreateEmployeeButton.Text = "Add A Employee";
            this.CreateEmployeeButton.UseVisualStyleBackColor = true;
            this.CreateEmployeeButton.Click += new System.EventHandler(this.CreateEmployeeButton_Click);
            // 
            // FetchEmployeeSalaryButton
            // 
            this.FetchEmployeeSalaryButton.Location = new System.Drawing.Point(474, 45);
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
            this.label1.Location = new System.Drawing.Point(471, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "Employee Id:";
            // 
            // EmployeeIdTextBox
            // 
            this.EmployeeIdTextBox.Location = new System.Drawing.Point(568, 12);
            this.EmployeeIdTextBox.Name = "EmployeeIdTextBox";
            this.EmployeeIdTextBox.Size = new System.Drawing.Size(118, 20);
            this.EmployeeIdTextBox.TabIndex = 12;
            this.EmployeeIdTextBox.TextChanged += new System.EventHandler(this.EmployeeIdTextBox_TextChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridView1.Location = new System.Drawing.Point(43, 55);
            this.dataGridView1.Name = "dataGridView1";
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dataGridView1.Size = new System.Drawing.Size(698, 321);
            this.dataGridView1.TabIndex = 14;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // UpdateEmployeeRole
            // 
            this.UpdateEmployeeRole.Location = new System.Drawing.Point(363, 10);
            this.UpdateEmployeeRole.Name = "UpdateEmployeeRole";
            this.UpdateEmployeeRole.Size = new System.Drawing.Size(154, 36);
            this.UpdateEmployeeRole.TabIndex = 15;
            this.UpdateEmployeeRole.Text = "Update Employee";
            this.UpdateEmployeeRole.UseVisualStyleBackColor = true;
            this.UpdateEmployeeRole.Click += new System.EventHandler(this.UpdateEmployeeRole_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Controls.Add(this.UpdateEmployeeRole);
            this.panel1.Controls.Add(this.RetrieveEmployeesButton);
            this.panel1.Controls.Add(this.CreateEmployeeButton);
            this.panel1.Location = new System.Drawing.Point(-2, 117);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(788, 394);
            this.panel1.TabIndex = 16;
            // 
            // EmployeesData
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(783, 509);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.EmployeeIdTextBox);
            this.Controls.Add(this.FetchEmployeeSalaryButton);
            this.Name = "EmployeesData";
            this.Text = "Employees Data Information";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
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
        private System.Windows.Forms.Button UpdateEmployeeRole;
        private System.Windows.Forms.Panel panel1;
    }
}
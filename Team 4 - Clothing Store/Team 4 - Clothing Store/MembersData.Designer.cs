namespace Team_4___Clothing_Store
{
    partial class MembersData
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
            this.FetchMemberStatusButton = new System.Windows.Forms.Button();
            this.GetMemberIdButton = new System.Windows.Forms.Button();
            this.MemberIdLabel = new System.Windows.Forms.Label();
            this.MemberIdTextbox = new System.Windows.Forms.TextBox();
            this.EmailTextbox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.retrieveMembers = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.memberPoints = new System.Windows.Forms.Button();
            this.CreateMemberButton = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.UpdateMemberButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // FetchMemberStatusButton
            // 
            this.FetchMemberStatusButton.Location = new System.Drawing.Point(34, 85);
            this.FetchMemberStatusButton.Name = "FetchMemberStatusButton";
            this.FetchMemberStatusButton.Size = new System.Drawing.Size(212, 42);
            this.FetchMemberStatusButton.TabIndex = 1;
            this.FetchMemberStatusButton.Text = "Fetch Member Status";
            this.FetchMemberStatusButton.UseVisualStyleBackColor = true;
            this.FetchMemberStatusButton.Click += new System.EventHandler(this.FetchMemberStatusButton_Click);
            // 
            // GetMemberIdButton
            // 
            this.GetMemberIdButton.Location = new System.Drawing.Point(296, 85);
            this.GetMemberIdButton.Name = "GetMemberIdButton";
            this.GetMemberIdButton.Size = new System.Drawing.Size(212, 42);
            this.GetMemberIdButton.TabIndex = 2;
            this.GetMemberIdButton.Text = "Get Member Information";
            this.GetMemberIdButton.UseVisualStyleBackColor = true;
            this.GetMemberIdButton.Click += new System.EventHandler(this.GetMemberIdButton_Click);
            // 
            // MemberIdLabel
            // 
            this.MemberIdLabel.AutoSize = true;
            this.MemberIdLabel.Location = new System.Drawing.Point(31, 55);
            this.MemberIdLabel.Name = "MemberIdLabel";
            this.MemberIdLabel.Size = new System.Drawing.Size(113, 13);
            this.MemberIdLabel.TabIndex = 3;
            this.MemberIdLabel.Text = "Member ID Parameter:";
            // 
            // MemberIdTextbox
            // 
            this.MemberIdTextbox.Location = new System.Drawing.Point(161, 52);
            this.MemberIdTextbox.Name = "MemberIdTextbox";
            this.MemberIdTextbox.Size = new System.Drawing.Size(85, 20);
            this.MemberIdTextbox.TabIndex = 4;
            // 
            // EmailTextbox
            // 
            this.EmailTextbox.Location = new System.Drawing.Point(398, 52);
            this.EmailTextbox.Name = "EmailTextbox";
            this.EmailTextbox.Size = new System.Drawing.Size(110, 20);
            this.EmailTextbox.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(293, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Email Parameter:";
            // 
            // retrieveMembers
            // 
            this.retrieveMembers.Location = new System.Drawing.Point(18, 193);
            this.retrieveMembers.Name = "retrieveMembers";
            this.retrieveMembers.Size = new System.Drawing.Size(154, 36);
            this.retrieveMembers.TabIndex = 7;
            this.retrieveMembers.Text = "Retrieve Members";
            this.retrieveMembers.UseVisualStyleBackColor = true;
            this.retrieveMembers.Click += new System.EventHandler(this.retrieveMembers_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(18, 244);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1050, 320);
            this.dataGridView1.TabIndex = 8;
            // 
            // memberPoints
            // 
            this.memberPoints.Location = new System.Drawing.Point(617, 85);
            this.memberPoints.Name = "memberPoints";
            this.memberPoints.Size = new System.Drawing.Size(212, 42);
            this.memberPoints.TabIndex = 9;
            this.memberPoints.Text = "Retrieve Member Points";
            this.memberPoints.UseVisualStyleBackColor = true;
            this.memberPoints.Click += new System.EventHandler(this.memberPoints_Click);
            // 
            // CreateMemberButton
            // 
            this.CreateMemberButton.Location = new System.Drawing.Point(178, 193);
            this.CreateMemberButton.Name = "CreateMemberButton";
            this.CreateMemberButton.Size = new System.Drawing.Size(154, 36);
            this.CreateMemberButton.TabIndex = 10;
            this.CreateMemberButton.Text = "Add A Member";
            this.CreateMemberButton.UseVisualStyleBackColor = true;
            this.CreateMemberButton.Click += new System.EventHandler(this.CreateMemberButton_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.memberPoints);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.UpdateMemberButton);
            this.panel1.Controls.Add(this.EmailTextbox);
            this.panel1.Controls.Add(this.CreateMemberButton);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.retrieveMembers);
            this.panel1.Controls.Add(this.GetMemberIdButton);
            this.panel1.Controls.Add(this.MemberIdTextbox);
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Controls.Add(this.MemberIdLabel);
            this.panel1.Controls.Add(this.FetchMemberStatusButton);
            this.panel1.Location = new System.Drawing.Point(-2, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1091, 614);
            this.panel1.TabIndex = 11;
            // 
            // UpdateMemberButton
            // 
            this.UpdateMemberButton.Location = new System.Drawing.Point(338, 193);
            this.UpdateMemberButton.Name = "UpdateMemberButton";
            this.UpdateMemberButton.Size = new System.Drawing.Size(154, 36);
            this.UpdateMemberButton.TabIndex = 11;
            this.UpdateMemberButton.Text = "Update Member";
            this.UpdateMemberButton.UseVisualStyleBackColor = true;
            this.UpdateMemberButton.Click += new System.EventHandler(this.UpdateMemberButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(14, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(126, 19);
            this.label2.TabIndex = 12;
            this.label2.Text = "Search Database:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(593, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(119, 19);
            this.label3.TabIndex = 13;
            this.label3.Text = "Report Form(s):";
            // 
            // MembersData
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1088, 615);
            this.Controls.Add(this.panel1);
            this.Name = "MembersData";
            this.Text = "Members Data Information";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button FetchMemberStatusButton;
        private System.Windows.Forms.Button GetMemberIdButton;
        private System.Windows.Forms.Label MemberIdLabel;
        private System.Windows.Forms.TextBox MemberIdTextbox;
        private System.Windows.Forms.TextBox EmailTextbox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button retrieveMembers;
        private System.Windows.Forms.Button memberPoints;
        private System.Windows.Forms.Button CreateMemberButton;
        public System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button UpdateMemberButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}
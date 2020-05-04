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
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // FetchMemberStatusButton
            // 
            this.FetchMemberStatusButton.Location = new System.Drawing.Point(752, 255);
            this.FetchMemberStatusButton.Name = "FetchMemberStatusButton";
            this.FetchMemberStatusButton.Size = new System.Drawing.Size(212, 42);
            this.FetchMemberStatusButton.TabIndex = 1;
            this.FetchMemberStatusButton.Text = "Fetch Member Status";
            this.FetchMemberStatusButton.UseVisualStyleBackColor = true;
            this.FetchMemberStatusButton.Click += new System.EventHandler(this.FetchMemberStatusButton_Click);
            // 
            // GetMemberIdButton
            // 
            this.GetMemberIdButton.Location = new System.Drawing.Point(752, 380);
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
            this.MemberIdLabel.Location = new System.Drawing.Point(749, 225);
            this.MemberIdLabel.Name = "MemberIdLabel";
            this.MemberIdLabel.Size = new System.Drawing.Size(60, 13);
            this.MemberIdLabel.TabIndex = 3;
            this.MemberIdLabel.Text = "Member Id:";
            // 
            // MemberIdTextbox
            // 
            this.MemberIdTextbox.Location = new System.Drawing.Point(864, 222);
            this.MemberIdTextbox.Name = "MemberIdTextbox";
            this.MemberIdTextbox.Size = new System.Drawing.Size(100, 20);
            this.MemberIdTextbox.TabIndex = 4;
            // 
            // EmailTextbox
            // 
            this.EmailTextbox.Location = new System.Drawing.Point(807, 347);
            this.EmailTextbox.Name = "EmailTextbox";
            this.EmailTextbox.Size = new System.Drawing.Size(157, 20);
            this.EmailTextbox.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(749, 350);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Email:";
            // 
            // retrieveMembers
            // 
            this.retrieveMembers.Location = new System.Drawing.Point(752, 18);
            this.retrieveMembers.Name = "retrieveMembers";
            this.retrieveMembers.Size = new System.Drawing.Size(212, 47);
            this.retrieveMembers.TabIndex = 7;
            this.retrieveMembers.Text = "Retrieve Members";
            this.retrieveMembers.UseVisualStyleBackColor = true;
            this.retrieveMembers.Click += new System.EventHandler(this.retrieveMembers_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 15);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(679, 420);
            this.dataGridView1.TabIndex = 8;
            // 
            // memberPoints
            // 
            this.memberPoints.Location = new System.Drawing.Point(752, 144);
            this.memberPoints.Name = "memberPoints";
            this.memberPoints.Size = new System.Drawing.Size(212, 47);
            this.memberPoints.TabIndex = 9;
            this.memberPoints.Text = "Retrieve Member Points";
            this.memberPoints.UseVisualStyleBackColor = true;
            this.memberPoints.Click += new System.EventHandler(this.memberPoints_Click);
            // 
            // CreateMemberButton
            // 
            this.CreateMemberButton.Location = new System.Drawing.Point(752, 81);
            this.CreateMemberButton.Name = "CreateMemberButton";
            this.CreateMemberButton.Size = new System.Drawing.Size(212, 47);
            this.CreateMemberButton.TabIndex = 10;
            this.CreateMemberButton.Text = "Add A Member";
            this.CreateMemberButton.UseVisualStyleBackColor = true;
            this.CreateMemberButton.Click += new System.EventHandler(this.CreateMemberButton_Click);
            // 
            // MembersData
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(976, 450);
            this.Controls.Add(this.CreateMemberButton);
            this.Controls.Add(this.memberPoints);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.retrieveMembers);
            this.Controls.Add(this.EmailTextbox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.MemberIdTextbox);
            this.Controls.Add(this.MemberIdLabel);
            this.Controls.Add(this.GetMemberIdButton);
            this.Controls.Add(this.FetchMemberStatusButton);
            this.Name = "MembersData";
            this.Text = "Members Data";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

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
    }
}
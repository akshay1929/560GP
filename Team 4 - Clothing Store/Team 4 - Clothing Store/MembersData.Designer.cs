﻿namespace Team_4___Clothing_Store
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
            this.MembersList = new System.Windows.Forms.ListBox();
            this.FetchMemberStatusButton = new System.Windows.Forms.Button();
            this.GetMemberIdButton = new System.Windows.Forms.Button();
            this.MemberIdLabel = new System.Windows.Forms.Label();
            this.MemberIdTextbox = new System.Windows.Forms.TextBox();
            this.EmailTextbox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.retrieveMembers = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // MembersList
            // 
            this.MembersList.FormattingEnabled = true;
            this.MembersList.Location = new System.Drawing.Point(12, 15);
            this.MembersList.Name = "MembersList";
            this.MembersList.Size = new System.Drawing.Size(71, 420);
            this.MembersList.TabIndex = 0;
            // 
            // FetchMemberStatusButton
            // 
            this.FetchMemberStatusButton.Location = new System.Drawing.Point(449, 48);
            this.FetchMemberStatusButton.Name = "FetchMemberStatusButton";
            this.FetchMemberStatusButton.Size = new System.Drawing.Size(212, 42);
            this.FetchMemberStatusButton.TabIndex = 1;
            this.FetchMemberStatusButton.Text = "Fetch Member Status";
            this.FetchMemberStatusButton.UseVisualStyleBackColor = true;
            // 
            // GetMemberIdButton
            // 
            this.GetMemberIdButton.Location = new System.Drawing.Point(449, 173);
            this.GetMemberIdButton.Name = "GetMemberIdButton";
            this.GetMemberIdButton.Size = new System.Drawing.Size(212, 42);
            this.GetMemberIdButton.TabIndex = 2;
            this.GetMemberIdButton.Text = "Get Member Id";
            this.GetMemberIdButton.UseVisualStyleBackColor = true;
            this.GetMemberIdButton.Click += new System.EventHandler(this.GetMemberIdButton_Click);
            // 
            // MemberIdLabel
            // 
            this.MemberIdLabel.AutoSize = true;
            this.MemberIdLabel.Location = new System.Drawing.Point(446, 18);
            this.MemberIdLabel.Name = "MemberIdLabel";
            this.MemberIdLabel.Size = new System.Drawing.Size(60, 13);
            this.MemberIdLabel.TabIndex = 3;
            this.MemberIdLabel.Text = "Member Id:";
            // 
            // MemberIdTextbox
            // 
            this.MemberIdTextbox.Location = new System.Drawing.Point(561, 15);
            this.MemberIdTextbox.Name = "MemberIdTextbox";
            this.MemberIdTextbox.Size = new System.Drawing.Size(100, 20);
            this.MemberIdTextbox.TabIndex = 4;
            // 
            // EmailTextbox
            // 
            this.EmailTextbox.Location = new System.Drawing.Point(504, 140);
            this.EmailTextbox.Name = "EmailTextbox";
            this.EmailTextbox.Size = new System.Drawing.Size(157, 20);
            this.EmailTextbox.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(446, 143);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Email:";
            // 
            // retrieveMembers
            // 
            this.retrieveMembers.Location = new System.Drawing.Point(449, 254);
            this.retrieveMembers.Name = "retrieveMembers";
            this.retrieveMembers.Size = new System.Drawing.Size(212, 47);
            this.retrieveMembers.TabIndex = 7;
            this.retrieveMembers.Text = "Retrieve Members";
            this.retrieveMembers.UseVisualStyleBackColor = true;
            this.retrieveMembers.Click += new System.EventHandler(this.retrieveMembers_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(90, 18);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(337, 417);
            this.dataGridView1.TabIndex = 8;
            // 
            // MembersData
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(703, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.retrieveMembers);
            this.Controls.Add(this.EmailTextbox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.MemberIdTextbox);
            this.Controls.Add(this.MemberIdLabel);
            this.Controls.Add(this.GetMemberIdButton);
            this.Controls.Add(this.FetchMemberStatusButton);
            this.Controls.Add(this.MembersList);
            this.Name = "MembersData";
            this.Text = "MembersData";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox MembersList;
        private System.Windows.Forms.Button FetchMemberStatusButton;
        private System.Windows.Forms.Button GetMemberIdButton;
        private System.Windows.Forms.Label MemberIdLabel;
        private System.Windows.Forms.TextBox MemberIdTextbox;
        private System.Windows.Forms.TextBox EmailTextbox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button retrieveMembers;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}
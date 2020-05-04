namespace Team_4___Clothing_Store
{
    partial class OrdersData
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
            this.retrieveOrders = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.startDatePicker = new System.Windows.Forms.DateTimePicker();
            this.endDatePicker = new System.Windows.Forms.DateTimePicker();
            this.orderCount = new System.Windows.Forms.Button();
            this.StartDateLabel = new System.Windows.Forms.Label();
            this.EndDateLabel = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.UpdateOrderButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // retrieveOrders
            // 
            this.retrieveOrders.Location = new System.Drawing.Point(46, 231);
            this.retrieveOrders.Name = "retrieveOrders";
            this.retrieveOrders.Size = new System.Drawing.Size(154, 36);
            this.retrieveOrders.TabIndex = 5;
            this.retrieveOrders.Text = "Retrieve Orders";
            this.retrieveOrders.UseVisualStyleBackColor = true;
            this.retrieveOrders.Click += new System.EventHandler(this.retrieveOrders_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(46, 279);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(697, 322);
            this.dataGridView1.TabIndex = 6;
            // 
            // startDatePicker
            // 
            this.startDatePicker.Location = new System.Drawing.Point(133, 58);
            this.startDatePicker.Name = "startDatePicker";
            this.startDatePicker.Size = new System.Drawing.Size(185, 20);
            this.startDatePicker.TabIndex = 7;
            this.startDatePicker.ValueChanged += new System.EventHandler(this.StartDatePicker_ValueChanged);
            // 
            // endDatePicker
            // 
            this.endDatePicker.Location = new System.Drawing.Point(133, 95);
            this.endDatePicker.Name = "endDatePicker";
            this.endDatePicker.Size = new System.Drawing.Size(185, 20);
            this.endDatePicker.TabIndex = 8;
            this.endDatePicker.ValueChanged += new System.EventHandler(this.EndDatePicker_ValueChanged);
            // 
            // orderCount
            // 
            this.orderCount.Location = new System.Drawing.Point(66, 135);
            this.orderCount.Name = "orderCount";
            this.orderCount.Size = new System.Drawing.Size(252, 42);
            this.orderCount.TabIndex = 9;
            this.orderCount.Text = "Retrieve Order Count";
            this.orderCount.UseVisualStyleBackColor = true;
            this.orderCount.Click += new System.EventHandler(this.orderCount_Click);
            // 
            // StartDateLabel
            // 
            this.StartDateLabel.AutoSize = true;
            this.StartDateLabel.Location = new System.Drawing.Point(63, 61);
            this.StartDateLabel.Name = "StartDateLabel";
            this.StartDateLabel.Size = new System.Drawing.Size(58, 13);
            this.StartDateLabel.TabIndex = 10;
            this.StartDateLabel.Text = "Start Date:";
            this.StartDateLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // EndDateLabel
            // 
            this.EndDateLabel.AutoSize = true;
            this.EndDateLabel.Location = new System.Drawing.Point(63, 98);
            this.EndDateLabel.Name = "EndDateLabel";
            this.EndDateLabel.Size = new System.Drawing.Size(55, 13);
            this.EndDateLabel.TabIndex = 11;
            this.EndDateLabel.Text = "End Date:";
            this.EndDateLabel.Click += new System.EventHandler(this.EndDateLabel_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.EndDateLabel);
            this.panel1.Controls.Add(this.UpdateOrderButton);
            this.panel1.Controls.Add(this.StartDateLabel);
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Controls.Add(this.orderCount);
            this.panel1.Controls.Add(this.endDatePicker);
            this.panel1.Controls.Add(this.retrieveOrders);
            this.panel1.Controls.Add(this.startDatePicker);
            this.panel1.Location = new System.Drawing.Point(-2, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(794, 656);
            this.panel1.TabIndex = 12;
            // 
            // UpdateOrderButton
            // 
            this.UpdateOrderButton.Location = new System.Drawing.Point(206, 231);
            this.UpdateOrderButton.Name = "UpdateOrderButton";
            this.UpdateOrderButton.Size = new System.Drawing.Size(154, 36);
            this.UpdateOrderButton.TabIndex = 7;
            this.UpdateOrderButton.Text = "Update Order";
            this.UpdateOrderButton.UseVisualStyleBackColor = true;
            this.UpdateOrderButton.Click += new System.EventHandler(this.UpdateOrderButton_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(42, 10);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(119, 19);
            this.label3.TabIndex = 14;
            this.label3.Text = "Report Form(s):";
            // 
            // OrdersData
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(791, 651);
            this.Controls.Add(this.panel1);
            this.Name = "OrdersData";
            this.Text = "Orders Data Information";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button retrieveOrders;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DateTimePicker startDatePicker;
        private System.Windows.Forms.DateTimePicker endDatePicker;
        private System.Windows.Forms.Button orderCount;
        private System.Windows.Forms.Label StartDateLabel;
        private System.Windows.Forms.Label EndDateLabel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button UpdateOrderButton;
        private System.Windows.Forms.Label label3;
    }
}
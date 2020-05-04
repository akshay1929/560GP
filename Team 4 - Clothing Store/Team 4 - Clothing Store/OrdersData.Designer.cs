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
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // retrieveOrders
            // 
            this.retrieveOrders.Location = new System.Drawing.Point(704, 15);
            this.retrieveOrders.Name = "retrieveOrders";
            this.retrieveOrders.Size = new System.Drawing.Size(242, 48);
            this.retrieveOrders.TabIndex = 5;
            this.retrieveOrders.Text = "Retrieve Orders";
            this.retrieveOrders.UseVisualStyleBackColor = true;
            this.retrieveOrders.Click += new System.EventHandler(this.retrieveOrders_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 15);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(621, 420);
            this.dataGridView1.TabIndex = 6;
            // 
            // startDatePicker
            // 
            this.startDatePicker.Location = new System.Drawing.Point(761, 102);
            this.startDatePicker.Name = "startDatePicker";
            this.startDatePicker.Size = new System.Drawing.Size(185, 20);
            this.startDatePicker.TabIndex = 7;
            this.startDatePicker.ValueChanged += new System.EventHandler(this.StartDatePicker_ValueChanged);
            // 
            // endDatePicker
            // 
            this.endDatePicker.Location = new System.Drawing.Point(761, 139);
            this.endDatePicker.Name = "endDatePicker";
            this.endDatePicker.Size = new System.Drawing.Size(185, 20);
            this.endDatePicker.TabIndex = 8;
            this.endDatePicker.ValueChanged += new System.EventHandler(this.EndDatePicker_ValueChanged);
            // 
            // orderCount
            // 
            this.orderCount.Location = new System.Drawing.Point(704, 179);
            this.orderCount.Name = "orderCount";
            this.orderCount.Size = new System.Drawing.Size(242, 42);
            this.orderCount.TabIndex = 9;
            this.orderCount.Text = "Retrieve Order Count";
            this.orderCount.UseVisualStyleBackColor = true;
            this.orderCount.Click += new System.EventHandler(this.orderCount_Click);
            // 
            // StartDateLabel
            // 
            this.StartDateLabel.AutoSize = true;
            this.StartDateLabel.Location = new System.Drawing.Point(701, 105);
            this.StartDateLabel.Name = "StartDateLabel";
            this.StartDateLabel.Size = new System.Drawing.Size(58, 13);
            this.StartDateLabel.TabIndex = 10;
            this.StartDateLabel.Text = "Start Date:";
            this.StartDateLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // EndDateLabel
            // 
            this.EndDateLabel.AutoSize = true;
            this.EndDateLabel.Location = new System.Drawing.Point(701, 142);
            this.EndDateLabel.Name = "EndDateLabel";
            this.EndDateLabel.Size = new System.Drawing.Size(55, 13);
            this.EndDateLabel.TabIndex = 11;
            this.EndDateLabel.Text = "End Date:";
            this.EndDateLabel.Click += new System.EventHandler(this.EndDateLabel_Click);
            // 
            // OrdersData
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(958, 450);
            this.Controls.Add(this.EndDateLabel);
            this.Controls.Add(this.StartDateLabel);
            this.Controls.Add(this.orderCount);
            this.Controls.Add(this.endDatePicker);
            this.Controls.Add(this.startDatePicker);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.retrieveOrders);
            this.Name = "OrdersData";
            this.Text = "Orders Data";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button retrieveOrders;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DateTimePicker startDatePicker;
        private System.Windows.Forms.DateTimePicker endDatePicker;
        private System.Windows.Forms.Button orderCount;
        private System.Windows.Forms.Label StartDateLabel;
        private System.Windows.Forms.Label EndDateLabel;
    }
}
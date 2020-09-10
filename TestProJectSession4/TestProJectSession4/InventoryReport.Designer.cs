namespace TestProJectSession4
{
    partial class InventoryReport
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
            this.label1 = new System.Windows.Forms.Label();
            this.cbxWarehouse = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radOutOfStock = new System.Windows.Forms.RadioButton();
            this.radReceivedStock = new System.Windows.Forms.RadioButton();
            this.radCurentStock = new System.Windows.Forms.RadioButton();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.partname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.current = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.received = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.action = new System.Windows.Forms.DataGridViewLinkColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Warehouse:";
            // 
            // cbxWarehouse
            // 
            this.cbxWarehouse.FormattingEnabled = true;
            this.cbxWarehouse.Location = new System.Drawing.Point(102, 60);
            this.cbxWarehouse.Name = "cbxWarehouse";
            this.cbxWarehouse.Size = new System.Drawing.Size(249, 21);
            this.cbxWarehouse.TabIndex = 1;
            this.cbxWarehouse.Text = "-----";
            this.cbxWarehouse.SelectedIndexChanged += new System.EventHandler(this.cbxWarehouse_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(31, 133);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Result:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radOutOfStock);
            this.groupBox1.Controls.Add(this.radReceivedStock);
            this.groupBox1.Controls.Add(this.radCurentStock);
            this.groupBox1.Location = new System.Drawing.Point(376, 25);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(396, 56);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Inventory Type:";
            // 
            // radOutOfStock
            // 
            this.radOutOfStock.AutoSize = true;
            this.radOutOfStock.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radOutOfStock.Location = new System.Drawing.Point(278, 33);
            this.radOutOfStock.Name = "radOutOfStock";
            this.radOutOfStock.Size = new System.Drawing.Size(90, 19);
            this.radOutOfStock.TabIndex = 2;
            this.radOutOfStock.TabStop = true;
            this.radOutOfStock.Text = "Out of Stock";
            this.radOutOfStock.UseVisualStyleBackColor = true;
            this.radOutOfStock.CheckedChanged += new System.EventHandler(this.radOutOfStock_CheckedChanged);
            // 
            // radReceivedStock
            // 
            this.radReceivedStock.AutoSize = true;
            this.radReceivedStock.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radReceivedStock.Location = new System.Drawing.Point(139, 33);
            this.radReceivedStock.Name = "radReceivedStock";
            this.radReceivedStock.Size = new System.Drawing.Size(109, 19);
            this.radReceivedStock.TabIndex = 3;
            this.radReceivedStock.TabStop = true;
            this.radReceivedStock.Text = "Received Stock";
            this.radReceivedStock.UseVisualStyleBackColor = true;
            this.radReceivedStock.CheckedChanged += new System.EventHandler(this.radReceivedStock_CheckedChanged);
            // 
            // radCurentStock
            // 
            this.radCurentStock.AutoSize = true;
            this.radCurentStock.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radCurentStock.Location = new System.Drawing.Point(17, 31);
            this.radCurentStock.Name = "radCurentStock";
            this.radCurentStock.Size = new System.Drawing.Size(98, 19);
            this.radCurentStock.TabIndex = 4;
            this.radCurentStock.TabStop = true;
            this.radCurentStock.Text = "Current Stock";
            this.radCurentStock.UseVisualStyleBackColor = true;
            this.radCurentStock.CheckedChanged += new System.EventHandler(this.radCurentStock_CheckedChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.partname,
            this.current,
            this.received,
            this.action});
            this.dataGridView1.Location = new System.Drawing.Point(34, 169);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(738, 229);
            this.dataGridView1.TabIndex = 5;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // partname
            // 
            this.partname.HeaderText = "Part Name";
            this.partname.Name = "partname";
            this.partname.Width = 225;
            // 
            // current
            // 
            this.current.HeaderText = "Current Stock";
            this.current.Name = "current";
            this.current.Width = 150;
            // 
            // received
            // 
            this.received.HeaderText = "Received Stock";
            this.received.Name = "received";
            this.received.Width = 150;
            // 
            // action
            // 
            this.action.HeaderText = "Action";
            this.action.Name = "action";
            this.action.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.action.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.action.Text = "View Batch Numbers";
            this.action.UseColumnTextForLinkValue = true;
            this.action.Width = 170;
            // 
            // InventoryReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 424);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cbxWarehouse);
            this.Controls.Add(this.label1);
            this.Name = "InventoryReport";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Inventory Report";
            this.Load += new System.EventHandler(this.InventoryReport_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbxWarehouse;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radOutOfStock;
        private System.Windows.Forms.RadioButton radReceivedStock;
        private System.Windows.Forms.RadioButton radCurentStock;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn partname;
        private System.Windows.Forms.DataGridViewTextBoxColumn current;
        private System.Windows.Forms.DataGridViewTextBoxColumn received;
        private System.Windows.Forms.DataGridViewLinkColumn action;
    }
}
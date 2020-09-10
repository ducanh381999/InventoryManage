namespace TestProJectSession4
{
    partial class WarehouseManagement
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
            this.label2 = new System.Windows.Forms.Label();
            this.cbxSourceWarehouse = new System.Windows.Forms.ComboBox();
            this.cbxDestinationWarehouse = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dtpDateWM = new System.Windows.Forms.DateTimePicker();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbxBatchNumber = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnAddToList = new System.Windows.Forms.Button();
            this.txtAmount = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cbxPartName = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.partid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.partname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.batchnumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.amount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.action = new System.Windows.Forms.DataGridViewLinkColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(32, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Source Warehouse:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(409, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(143, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Destination Warehouse:";
            // 
            // cbxSourceWarehouse
            // 
            this.cbxSourceWarehouse.FormattingEnabled = true;
            this.cbxSourceWarehouse.Location = new System.Drawing.Point(35, 45);
            this.cbxSourceWarehouse.Name = "cbxSourceWarehouse";
            this.cbxSourceWarehouse.Size = new System.Drawing.Size(259, 21);
            this.cbxSourceWarehouse.TabIndex = 2;
            this.cbxSourceWarehouse.Text = "-----";
            // 
            // cbxDestinationWarehouse
            // 
            this.cbxDestinationWarehouse.FormattingEnabled = true;
            this.cbxDestinationWarehouse.Location = new System.Drawing.Point(412, 45);
            this.cbxDestinationWarehouse.Name = "cbxDestinationWarehouse";
            this.cbxDestinationWarehouse.Size = new System.Drawing.Size(302, 21);
            this.cbxDestinationWarehouse.TabIndex = 3;
            this.cbxDestinationWarehouse.Text = "-----";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(32, 85);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Date:";
            // 
            // dtpDateWM
            // 
            this.dtpDateWM.CustomFormat = "dd/MM/yyyy";
            this.dtpDateWM.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDateWM.Location = new System.Drawing.Point(76, 85);
            this.dtpDateWM.Name = "dtpDateWM";
            this.dtpDateWM.Size = new System.Drawing.Size(120, 20);
            this.dtpDateWM.TabIndex = 6;
            this.dtpDateWM.Value = new System.DateTime(2020, 5, 11, 0, 0, 0, 0);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(405, 404);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(120, 23);
            this.btnCancel.TabIndex = 8;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(254, 404);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(120, 23);
            this.btnSubmit.TabIndex = 9;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbxBatchNumber);
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Controls.Add(this.btnAddToList);
            this.groupBox1.Controls.Add(this.txtAmount);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.cbxPartName);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Location = new System.Drawing.Point(35, 129);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(731, 249);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Parts List";
            // 
            // cbxBatchNumber
            // 
            this.cbxBatchNumber.FormattingEnabled = true;
            this.cbxBatchNumber.Location = new System.Drawing.Point(295, 31);
            this.cbxBatchNumber.Name = "cbxBatchNumber";
            this.cbxBatchNumber.Size = new System.Drawing.Size(143, 21);
            this.cbxBatchNumber.TabIndex = 15;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.partid,
            this.partname,
            this.batchnumber,
            this.amount,
            this.action});
            this.dataGridView1.Location = new System.Drawing.Point(14, 76);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(704, 155);
            this.dataGridView1.TabIndex = 14;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // btnAddToList
            // 
            this.btnAddToList.Location = new System.Drawing.Point(640, 31);
            this.btnAddToList.Name = "btnAddToList";
            this.btnAddToList.Size = new System.Drawing.Size(78, 23);
            this.btnAddToList.TabIndex = 13;
            this.btnAddToList.Text = "+ Add to list";
            this.btnAddToList.UseVisualStyleBackColor = true;
            this.btnAddToList.Click += new System.EventHandler(this.btnAddToList_Click);
            // 
            // txtAmount
            // 
            this.txtAmount.Location = new System.Drawing.Point(496, 33);
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.Size = new System.Drawing.Size(100, 20);
            this.txtAmount.TabIndex = 12;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(444, 35);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(46, 13);
            this.label7.TabIndex = 11;
            this.label7.Text = "Amount:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(211, 34);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(78, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "Batch Number:";
            // 
            // cbxPartName
            // 
            this.cbxPartName.FormattingEnabled = true;
            this.cbxPartName.Location = new System.Drawing.Point(77, 31);
            this.cbxPartName.Name = "cbxPartName";
            this.cbxPartName.Size = new System.Drawing.Size(128, 21);
            this.cbxPartName.TabIndex = 8;
            this.cbxPartName.Text = "-----";
            this.cbxPartName.SelectedIndexChanged += new System.EventHandler(this.cbxPartName_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(11, 35);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Part Name:";
            // 
            // partid
            // 
            this.partid.HeaderText = "PartID";
            this.partid.Name = "partid";
            this.partid.Visible = false;
            // 
            // partname
            // 
            this.partname.HeaderText = "Part Name";
            this.partname.Name = "partname";
            this.partname.Width = 250;
            // 
            // batchnumber
            // 
            this.batchnumber.HeaderText = "Batch Number";
            this.batchnumber.Name = "batchnumber";
            this.batchnumber.Width = 190;
            // 
            // amount
            // 
            this.amount.HeaderText = "Amount";
            this.amount.Name = "amount";
            this.amount.Width = 110;
            // 
            // action
            // 
            this.action.HeaderText = "Action";
            this.action.Name = "action";
            this.action.Text = "Remove";
            this.action.UseColumnTextForLinkValue = true;
            this.action.Width = 110;
            // 
            // WarehouseManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.dtpDateWM);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cbxDestinationWarehouse);
            this.Controls.Add(this.cbxSourceWarehouse);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "WarehouseManagement";
            this.Text = "Warehouse Management";
            this.Load += new System.EventHandler(this.WarehouseManagement_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbxSourceWarehouse;
        private System.Windows.Forms.ComboBox cbxDestinationWarehouse;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtpDateWM;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnAddToList;
        private System.Windows.Forms.TextBox txtAmount;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbxPartName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbxBatchNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn partid;
        private System.Windows.Forms.DataGridViewTextBoxColumn partname;
        private System.Windows.Forms.DataGridViewTextBoxColumn batchnumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn amount;
        private System.Windows.Forms.DataGridViewLinkColumn action;
    }
}
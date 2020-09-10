using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestProJectSession4
{
    public partial class WarehouseManagement : Form
    {
        sql sql = new sql();
        Warehouse_Management wh = new Warehouse_Management();
        List<Warehouse_Management> list = new List<Warehouse_Management>();

        public bool flag { get; private set; }

        public WarehouseManagement()
        {
            InitializeComponent();
        }

        private void WarehouseManagement_Load(object sender, EventArgs e)
        {
            DataTable dt = sql.getWareHouses();
            cbxSourceWarehouse.DataSource = dt;
            cbxSourceWarehouse.DisplayMember = "Name";
            cbxSourceWarehouse.ValueMember = "ID";

            DataTable dt1 = sql.getWareHouses();
            cbxDestinationWarehouse.DataSource = dt1;
            cbxDestinationWarehouse.ValueMember = "ID";
            cbxDestinationWarehouse.DisplayMember = "Name";

            DataTable dt2 = sql.getPartName();
            cbxPartName.DataSource = dt2;
            cbxPartName.DisplayMember = "Name";
            cbxPartName.ValueMember = "ID";
            cbxBatchNumber.Enabled = true;
        }


        private void btnCancel_Click(object sender, EventArgs e)
        {
            flag = false;
            this.Close();
        }

        private void btnAddToList_Click(object sender, EventArgs e)
        {
            
            wh.partid = (int)cbxPartName.SelectedValue;
            wh.partname = sql.getPartnamByID(wh).Trim();
            wh.amount = Convert.ToDecimal(txtAmount.Text);
            wh.batchnumber = cbxBatchNumber.SelectedValue.ToString().Trim();
            if(wh.amount < 0)
            {
                MessageBox.Show("Amount cần nhập số dương.");
            }
            else
            {
                list.Add(wh);
                dataGridView1.Rows.Add(wh.partid, wh.partname, wh.batchnumber, wh.amount, action);
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.ColumnIndex == 4)
            {
                DialogResult result = MessageBox.Show("Bạn có muốn xóa dòng này?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if(result.ToString() == "Yes")
                {
                    list.RemoveAt(e.RowIndex);
                    dataGridView1.Rows.RemoveAt(e.RowIndex);
                }
                MessageBox.Show("Đã xóa thành công!");
            }
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {

            
            wh.sourceid = (int)cbxSourceWarehouse.SelectedValue;
            wh.destinationid = (int)cbxDestinationWarehouse.SelectedValue;
            if(wh.sourceid == wh.destinationid)
            {
                MessageBox.Show("Kho nguồn và đích không được cùng giá trị");
            }
            else {
                flag = true;
                wh.date = dtpDateWM.Value;
                sql.insertOrder2(wh);
                for (int i=0; i < dataGridView1.Rows.Count - 1; i++)
                {
                    int partid = (int)dataGridView1.Rows[i].Cells["partid"].Value;
                    String batchnumber = dataGridView1.Rows[i].Cells["batchnumber"].Value.ToString().Trim();
                    decimal amount = (decimal)dataGridView1.Rows[i].Cells["amount"].Value;
                    sql.insertOrderitems(partid, batchnumber, amount);
                }
                this.Close();
            }

            
        }

        private void cbxPartName_SelectedIndexChanged(object sender, EventArgs e)
        {
            int pID;
            if(int.TryParse(cbxPartName.SelectedValue.ToString(), out pID))
            {
                bool flag = sql.batchNumberHasRequired(pID);
                DataTable dt = sql.getBatchNumberByPartID(pID);
                cbxBatchNumber.DataSource = dt;
                cbxBatchNumber.DisplayMember = "BatchNumber";
                cbxBatchNumber.ValueMember = "BatchNumber";
                if (flag == true)
                {
                    cbxBatchNumber.Enabled = true;

                }
                else
                {
                    cbxBatchNumber.Enabled = false;
                }
                
            }
        }
    }
}

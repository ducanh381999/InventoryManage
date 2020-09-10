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
    public partial class PurchaseOrder : Form
    {
        sql sql = new sql();
        Purchase_Order po = new Purchase_Order();
        List<Purchase_Order> list = new List<Purchase_Order>();

        public bool flag { get; private set; }

        public PurchaseOrder()
        {
            InitializeComponent();
        }
        
        private void PurchaseOrder_Load(object sender, EventArgs e)
        {
            DataTable dt = sql.getSuppliers();
            cbxSupplier.DataSource = dt;
            cbxSupplier.DisplayMember = "Name";
            cbxSupplier.ValueMember = "ID";

            DataTable dt1 = sql.getWareHouses();
            cbxWarhouse.DataSource = dt1;
            cbxWarhouse.DisplayMember = "Name";
            cbxWarhouse.ValueMember = "ID";

            DataTable dt2 = sql.getPartName();
            cbxPartName.DataSource = dt2;
            cbxPartName.DisplayMember = "Name";
            cbxPartName.ValueMember = "ID";
            txtBatchNumber.Enabled = true;
        }
        
        private void btnCancel_Click(object sender, EventArgs e)
        {
            flag = false;
            this.Close();
        }

        private void btnAddToList_Click(object sender, EventArgs e)
        {
            po.partid = (int)cbxPartName.SelectedValue;
            po.partname = sql.getPartnamByID(po).ToString().Trim();
            po.batchrequired = txtBatchNumber.Text;
            po.amount = Convert.ToDecimal(txtAmount.Text);
            
            if (po.amount < 0)
            {
                MessageBox.Show("Amount cần nhập số dương.");
            }
            //else {
                //if (dataGridView1.Rows.Count > 1)
                //{
                    //for (int i = 0; i < dataGridView1.Rows.Count - 2; i++)
                    //{
                    //    String partname = dataGridView1.Rows[i].Cells[1].Value.ToString();
                    //    String batchrequired = dataGridView1.Rows[i].Cells[2].Value.ToString();
                    //    if(partname == po.partname && batchrequired == po.batchrequired)
                    //    {
                    //        MessageBox.Show("Nếu có 2 part name giống nhau thì batch number phải khác nhau");
                    //    }
                    //    else
                    //    {
                    //        list.Add(po);
                    //        dataGridView1.Rows.Add(po.partid, po.partname, po.batchrequired, po.amount, action);
                    //    }
                    //    //break;
                    //}
                //}
                else
                {
                    list.Add(po);
                    dataGridView1.Rows.Add(po.partid, po.partname, po.batchrequired, po.amount, action);
                }
        }

        private void cbxPartName_SelectedIndexChanged(object sender, EventArgs e)
        {
            int pID;
            
            if (int.TryParse(cbxPartName.SelectedValue.ToString(), out pID))
            {
                bool flag = sql.batchNumberHasRequired(pID);
                if (flag == true)
                {
                    txtBatchNumber.Enabled = true;

                }
                else
                {
                    txtBatchNumber.Enabled = false;

                }
            }
        }
        

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.ColumnIndex == 4)
            {
                DialogResult result = MessageBox.Show("Bạn có muốn xóa dòng này?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if(result.ToString() == "Yes")
                {
                    dataGridView1.Rows.RemoveAt(e.RowIndex);
                    list.RemoveAt(e.RowIndex);
                }
                MessageBox.Show("Đã xóa thành công!");  
            }
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            flag = true;
            //string batch = txtBatchNumber.Text;
            //if (batch == "")
            //{
            //    MessageBox.Show("Can nhap batch number");
            //}
            //else
            //{
                po.warehouseid = (int)cbxWarhouse.SelectedValue;
                po.supplierid = (int)cbxSupplier.SelectedValue;
                po.date = dtpDatePO.Value;
                sql.insertOrder(po);
                for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
                {
                    int partid = (int)dataGridView1.Rows[i].Cells["PartID"].Value;
                    String batchnumber = dataGridView1.Rows[i].Cells["batchnumber"].Value.ToString();
                    decimal amount = (decimal)dataGridView1.Rows[i].Cells["amount"].Value;
                    sql.insertOrderitems(partid, batchnumber, amount);
                }
                this.Close();
            //}
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestProJectSession4
{
    public partial class InventoryManagement : Form
    {
        sql sql = new sql();
        List<Inventory_Management> list = new List<Inventory_Management>();
        
       
        public InventoryManagement()
        {
            InitializeComponent();
        }

        private void InventoryManagement_Load(object sender, EventArgs e)
        {

            //list = sql.getInventory_Managements();
            list = sql.getInventory_Managements1();
            hienthi1();
            //HienThi();


        }


        private void purchaseOrderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            var PO = new PurchaseOrder();
            PO.ShowDialog();
            //list = sql.getInventory_Managements();
            if (PO.flag == true) {
                list = sql.getInventory_Managements1();
                //HienThi();
                hienthi1();
            }
            

        }

        private void warehouseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var warehouse = new WarehouseManagement();
            warehouse.ShowDialog();
            //list = sql.getInventory_Managements();
            if(warehouse.flag == true) {
                list = sql.getInventory_Managements1();
                //HienThi();
                hienthi1();
            }
        }

        private void inventoryReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            
            InventoryReport ir = new InventoryReport();
            ir.ShowDialog();
           
        }



        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
                //DataGridViewLinkCell link = (DataGridViewLinkCell)dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex];

                if (e.ColumnIndex == 9)
                {
                    DialogResult result = MessageBox.Show("Bạn muốn xóa dòng này?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (result.ToString() == "Yes")
                    {
                        sql.delete(list[e.RowIndex]);
                        MessageBox.Show("Đã xóa thành công!");
                        //list = sql.getInventory_Managements();
                        //HienThi();
                        list = sql.getInventory_Managements1();
                        hienthi1();
                    }
                }

                 if (e.ColumnIndex == 8)
                 {
                    frmEdit edit = new frmEdit();
                    edit.orderid = dataGridView1.Rows[e.RowIndex].Cells["OrderID"].Value;
                    edit.orderitemsid = dataGridView1.Rows[e.RowIndex].Cells["orderitemsID"].Value;
                    edit.ShowDialog();
                    if (edit.flag == true)
                    {
                        //list = sql.getInventory_Managements();
                        //HienThi();
                        list = sql.getInventory_Managements1();
                        hienthi1();
                    }
                 }
        }

        public void hienthi1()
        {
            dataGridView1.Rows.Clear();
            //list.Sort();
            for (int i = 0; i < list.Count; i++)
            {
                dataGridView1.Rows.Add();
                dataGridView1.Rows[i].Cells["OrderID"].Value = list[i].orderid;
                dataGridView1.Rows[i].Cells["orderitemsID"].Value = list[i].orderitemsid;
                dataGridView1.Rows[i].Cells["partname"].Value = list[i].partname;
                dataGridView1.Rows[i].Cells["transactiontype"].Value = list[i].transactiontype;
                if (dataGridView1.Rows[i].Cells["transactiontype"].Value.ToString().Trim() == "Purchase Order")
                {
                    dataGridView1.Rows[i].Cells["date"].Value = list[i].date;
                    dataGridView1.Rows[i].Cells["amount"].Value = list[i].amount;
                    dataGridView1.Rows[i].Cells["source"].Value = list[i].supplier;
                    dataGridView1.Rows[i].Cells["destination"].Value = list[i].destination;
                    dataGridView1.Rows[i].Cells["action1"].Value = "Edit";
                    dataGridView1.Rows[i].Cells["action2"].Value = "Remove";
                }
                else if (dataGridView1.Rows[i].Cells["transactiontype"].Value.ToString().Trim() == "Warehouse Management")
                {
                    dataGridView1.Rows[i].Cells["date"].Value = list[i].date;
                    dataGridView1.Rows[i].Cells["amount"].Value = list[i].amount;
                    dataGridView1.Rows[i].Cells["source"].Value = list[i].source;
                    dataGridView1.Rows[i].Cells["destination"].Value = list[i].destination;
                    dataGridView1.Rows[i].Cells["action1"].Value = "Edit";
                    dataGridView1.Rows[i].Cells["action2"].Value = "Remove";
                }
                if (dataGridView1.Rows[i].Cells["transactiontype"].Value.ToString().Trim() == "Purchase Order")
                {
                    dataGridView1.Rows[i].Cells["amount"].Style.BackColor = Color.Green;
                }
            }
        }
        
    }
}


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
    public partial class InventoryReport : Form
    {
        sql sql = new sql();
        Inventory_Report ir = new Inventory_Report();
        List<Inventory_Report> list = new List<Inventory_Report>();
        List<Inventory_Report> list1 = new List<Inventory_Report>();
        public InventoryReport()
        {
            InitializeComponent();
        }

        private void InventoryReport_Load(object sender, EventArgs e)
        {
            DataTable dt = sql.getWareHouses();
            cbxWarehouse.DataSource = dt;
            cbxWarehouse.ValueMember = "ID";
            cbxWarehouse.DisplayMember = "Name";
        }
        public void hienthi()
        {
            dataGridView1.Rows.Clear();
            for (int i = 0; i < list.Count; i++)
            {
                dataGridView1.Rows.Add();
                dataGridView1.Rows[i].Cells["partname"].Value = list[i].partname;
                dataGridView1.Rows[i].Cells["received"].Value = list[i].received;
            }
            for (int i = 0; i < dataGridView1.Rows.Count-1; i++)
            {
                for(int j = 0;j < list1.Count; j++) {
                    string partname = Convert.ToString(dataGridView1.Rows[i].Cells["partname"].Value);
                    if (partname == list1[j].partname)
                    {
                        dataGridView1.Rows[i].Cells["current"].Value = list[i].received - list1[j].buy;
                    }
                }
            }
            for (int i = 0; i < list.Count; i++)
            {
                if (dataGridView1.Rows[i].Cells["current"].Value == null)
                {
                    dataGridView1.Rows[i].Cells["current"].Value = list[i].received;
                }
            }

        }
        public void hienthi1()
        {
            dataGridView1.Rows.Clear();
            for (int i=0; i < list.Count; i++)
            {
                for(int j=0;j < list1.Count; j++)
                {
                    string partname = list1[j].partname;
                    if(list[i].received - list1[j].buy == 0 && partname == list[i].partname)
                    {
                        dataGridView1.Rows.Add();
                        dataGridView1.Rows[i].Cells["partname"].Value = list[i].partname;
                        dataGridView1.Rows[i].Cells["received"].Value = list[i].received;
                        dataGridView1.Rows[i].Cells["current"].Value = list[i].received - list1[j].buy;
                    }
                }
            }
        }
        public void hienthi2()
        {
            dataGridView1.Rows.Clear();
            for (int i = 0; i < list.Count; i++)
            {
                for (int j = 0; j < list1.Count; j++)
                {
                    string partname = list1[j].partname;
                    if (list[i].received - list1[j].buy > 0 && partname == list[i].partname)
                    {
                        dataGridView1.Rows.Add();
                        dataGridView1.Rows[i].Cells["partname"].Value = list[i].partname;
                        dataGridView1.Rows[i].Cells["received"].Value = list[i].received;
                        dataGridView1.Rows[i].Cells["current"].Value = list[i].received - list1[j].buy;
                    }
                    else if (partname != list[i].partname )
                    {
                        dataGridView1.Rows.Add();
                        dataGridView1.Rows[i].Cells["partname"].Value = list[i].partname;
                        dataGridView1.Rows[i].Cells["received"].Value = list[i].received;
                        dataGridView1.Rows[i].Cells["current"].Value = list[i].received;
                        dataGridView1.Rows[i].Cells["action"].Value = "View Batch Numbers";
                    }
                    
                }
                
            }
            for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
            {
                if (dataGridView1.Rows[i].IsNewRow) continue;
                string tmp = dataGridView1.Rows[i].Cells["partname"].Value.ToString();
                for (int j = dataGridView1.Rows.Count - 1; j > i; j--)
                {
                    if (dataGridView1.Rows[j].IsNewRow) continue;
                    if (null == dataGridView1.Rows[j].Cells["partname"].Value)
                    {
                        dataGridView1.Rows.RemoveAt(j);
                    }
                }
            }
        }

        private void radCurentStock_CheckedChanged(object sender, EventArgs e)
        {
            ir.warehousesid = (int)cbxWarehouse.SelectedValue;
            list = sql.getReceived(ir.warehousesid);
            list1 = sql.getBuy(ir.warehousesid);
            hienthi2();
        }

        private void radReceivedStock_CheckedChanged(object sender, EventArgs e)
        {
            ir.warehousesid = (int)cbxWarehouse.SelectedValue;
            list = sql.getReceived(ir.warehousesid);
            list1 = sql.getBuy(ir.warehousesid);
            hienthi();
        }

        private void radOutOfStock_CheckedChanged(object sender, EventArgs e)
        {
            ir.warehousesid = (int)cbxWarehouse.SelectedValue;
            list = sql.getReceived(ir.warehousesid);
            list1 = sql.getBuy(ir.warehousesid);
            hienthi1();

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 3)
            {
                frmView view = new frmView();
                view.partname = (string)dataGridView1.Rows[e.RowIndex].Cells["partname"].Value;
                view.ShowDialog();
            }
            else if (e.ColumnIndex == -1)
            {
                
            }
        }

        private void cbxWarehouse_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(radCurentStock.Checked == true)
            {
                ir.warehousesid = (int)cbxWarehouse.SelectedValue;
                list = sql.getReceived(ir.warehousesid);
                list1 = sql.getBuy(ir.warehousesid);
                hienthi2();
            }
            else if(radOutOfStock.Checked == true)
            {
                ir.warehousesid = (int)cbxWarehouse.SelectedValue;
                list = sql.getReceived(ir.warehousesid);
                list1 = sql.getBuy(ir.warehousesid);
                hienthi1();
            }
            else if(radReceivedStock.Checked == true)
            {
                ir.warehousesid = (int)cbxWarehouse.SelectedValue;
                list = sql.getReceived(ir.warehousesid);
                list1 = sql.getBuy(ir.warehousesid);
                hienthi();
            }
            else { }
        }
    }
}

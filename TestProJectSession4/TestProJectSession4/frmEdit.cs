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
    public partial class frmEdit : Form
    {
        sql sql = new sql();
        SqlConnection cnn;
        string connection = @"Data Source=DESKTOP-TT36UIL;Initial Catalog=Session4;Integrated Security=True";

        public object orderitemsid { get; set; }
        public object orderid { get; set; }
        public bool flag { get; set; }

        public frmEdit()
        {
            InitializeComponent();
        }
        
        public void loadPartName()
        {
            DataTable dt = sql.getPartName();
            cbxPartName.DataSource = dt;
            cbxPartName.ValueMember = "ID";
            cbxPartName.DisplayMember = "Name";
        }
        
        public void loadTransaction()
        {
            DataTable dt = sql.getTransaction();
            cbxTransactionType.DataSource = dt;
            cbxTransactionType.ValueMember = "ID";
            cbxTransactionType.DisplayMember = "Name";
        }

        public void loadWarehouses()
        {
            DataTable dt = sql.getWareHouses();
            cbxSource.DataSource = dt;
            cbxSource.ValueMember = "ID";
            cbxSource.DisplayMember = "Name";

            
        }
        public void loadDestination()
        {
            DataTable dt = sql.getWareHouses();
            cbxDestination.DataSource = dt;
            cbxDestination.ValueMember = "ID";
            cbxDestination.DisplayMember = "Name";
        }

        public void loadSupplier()
        {
            DataTable dt = sql.getSuppliers();
            cbxSupplier.DataSource = dt;
            cbxSupplier.DisplayMember = "Name";
            cbxSupplier.ValueMember = "ID";
        }
        public void update()
        {
            cnn = new SqlConnection(connection);
            cnn.Open();
            string sql = "update OrderItems set PartID = @partid, Amount = @amount where ID = @orderitemsid";
            SqlCommand cmd = new SqlCommand(sql, cnn);
            cmd.Parameters.AddWithValue("partid", cbxPartName.SelectedValue.ToString());
            cmd.Parameters.AddWithValue("amount", txtAmount.Text);
            cmd.Parameters.AddWithValue("orderitemsid", orderitemsid);
            cmd.ExecuteNonQuery();

            string sql1 = "update Orders set Date = @date, SupplierID = @supid,TransactionTypeID=@transaction, SourceWarehouseID = @source, DestinationWarehouseID = @destination where ID = @orderid";
            SqlCommand cmd1 = new SqlCommand(sql1, cnn);
            cmd1.Parameters.AddWithValue("date", dateTimePicker1.Text);
            cmd1.Parameters.AddWithValue("supid", cbxSupplier.SelectedValue.ToString());
            cmd1.Parameters.AddWithValue("transaction", cbxTransactionType.SelectedValue.ToString());
            cmd1.Parameters.AddWithValue("source", cbxSource.SelectedValue.ToString());
            cmd1.Parameters.AddWithValue("destination", cbxDestination.SelectedValue.ToString());
            cmd1.Parameters.AddWithValue("orderid", orderid);
            cmd1.ExecuteNonQuery();
            cnn.Close();
        }

        private void Edit_Load(object sender, EventArgs e)
        {
            loadPartName();
            loadTransaction();
            loadWarehouses();
            loadDestination();
            loadSupplier();
        }
        

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (cbxDestination.SelectedValue.ToString() == cbxSource.SelectedValue.ToString())
            {
                MessageBox.Show("Source và Destination phải là 2 giá trị khác nhau");
            }
            else
            {
                update();
                flag = true;
                MessageBox.Show("Đã cập nhật thành công!");
                this.Close();
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace TestProJectSession4
{
    class sql
    {
        string connection = @"Data Source=DESKTOP-TT36UIL;Initial Catalog=Session4;Integrated Security=True";
        SqlConnection cnn;
        //List<Inventory_Management> iventory_management;
        
        

        public void getConnection()
        {
            cnn = new SqlConnection(connection);
            cnn.Open();
        }

        

        public List<Inventory_Management> getInventory_Managements()
        {
            var inventory_management = new List<Inventory_Management>();
            getConnection();
            string sql = "select * from InventoryManagement";
            SqlCommand cmd = new SqlCommand(sql, cnn);
            SqlDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                Inventory_Management Inventory_Management = new Inventory_Management();
                Inventory_Management.orderid = (int)dr["orderid"];
                Inventory_Management.orderitemsid = (int)dr["id"];
                Inventory_Management.partname = (string)dr["part name"];
                Inventory_Management.transactiontype = (string)dr["transaction type"];
                Inventory_Management.date = (DateTime)dr["date"];
                Inventory_Management.amount = (decimal)dr["amount"];
                Inventory_Management.source = (string)dr["source"];
                Inventory_Management.destination = (string)dr["destination"];
                inventory_management.Add(Inventory_Management);
            }
            cnn.Close();
            return inventory_management;
           
        }

        public void delete(Inventory_Management Inventory_Management)
        {
            getConnection();
            string sql = "delete from OrderItems where orderID = @OrderID";
            SqlCommand cmd = new SqlCommand(sql, cnn);
            cmd.Parameters.AddWithValue("@OrderID", Inventory_Management.orderid);
            cmd.ExecuteNonQuery();
            cnn.Close();
        }

        internal string getPartnamByID(Warehouse_Management wh)
        {
            getConnection();
            string sql = "select name from parts where id = @partid";
            SqlCommand cmd = new SqlCommand(sql, cnn);
            cmd.Parameters.AddWithValue("partid", wh.partid);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                wh.partname = (string)dr["Name"];
            }
            cnn.Close();
            return wh.partname;
        }

        public DataTable getPartName()
        {
            getConnection();
            string sql = "select * from Parts";
            SqlCommand cmd = new SqlCommand(sql, cnn);
            SqlDataReader dr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);
            cnn.Close();
            return dt;            
        }

        public DataTable getTransaction()
        {
            getConnection();
            string sql = "select * from TransactionTypes";
            SqlCommand cmd = new SqlCommand(sql, cnn);
            SqlDataReader dr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);
            cnn.Close();
            return dt;
        }
        public DataTable getWareHouses()
        {
            getConnection();
            string sql = "select * from Warehouses";
            SqlCommand cmd = new SqlCommand(sql, cnn);
            SqlDataReader dr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);
            cnn.Close();
            return dt;
        }
        public DataTable getSuppliers()
        {
            getConnection();
            string sql = "select * from Suppliers";
            SqlCommand cmd = new SqlCommand(sql, cnn);
            SqlDataReader dr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);
            cnn.Close();
            return dt;
        }
        public string   getDestinationNameByID(Warehouse_Management wh)
        {
            getConnection();
            string sql = "select name from Warehouses where id=@id";
            SqlCommand cmd = new SqlCommand(sql, cnn);
            cmd.Parameters.AddWithValue("id", wh.destinationid);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                wh.destinationname = (string)dr["Name"];
            }
            cnn.Close();
            return wh.destinationname;
        }

        public bool batchNumberHasRequired(int id)
        {
            getConnection();
            string sql = "select BatchNumberHasRequired from Parts where id = @partid";
            SqlCommand cmd = new SqlCommand(sql, cnn);
            cmd.Parameters.AddWithValue("partid", id);
            SqlDataReader dr = cmd.ExecuteReader();
            string batchrequired="";
            while (dr.Read())
            {
                batchrequired = (String)dr["BatchNumberHasRequired"];

            }
            cnn.Close();
            if (batchrequired.Trim() == "True")
            {
                return true;
            }
            else return false;

        }

        public String getPartnamByID(Purchase_Order po)
        {
            getConnection();
            string sql = "select name from parts where id = @partid";
            SqlCommand cmd = new SqlCommand(sql, cnn);
            cmd.Parameters.AddWithValue("partid", po.partid);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                po.partname = (string)dr["Name"];
            }
            cnn.Close();
            return po.partname;
        }

        public string getSuppliernameByID(Purchase_Order po)
        {
            getConnection();
            string sql = "select name from Suppliers where id = @supplierid";
            SqlCommand cmd = new SqlCommand(sql, cnn);
            cmd.Parameters.AddWithValue("supplierid", po.supplierid);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                po.suppliername = (string)dr["Name"];
            }
            cnn.Close();
            return po.suppliername;
        }

        public string getWarehouseNameByID(Purchase_Order po)
        {
            getConnection();
            string sql = "select name from Warehouses where id=@id";
            SqlCommand cmd = new SqlCommand(sql, cnn);
            cmd.Parameters.AddWithValue("id", po.warehouseid);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                po.warehousename = (string)dr["Name"];
            }
            cnn.Close();
            return po.warehousename;
        }

        
        public string getSourceNameByID(Warehouse_Management wh)
        {
            getConnection();
            string sql = "select name from Warehouses where id=@id";
            SqlCommand cmd = new SqlCommand(sql, cnn);
            cmd.Parameters.AddWithValue("id", wh.sourceid);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                wh.source = (string)dr["Name"];
            }
            cnn.Close();
            return wh.source;
        }
        public void insertOrder(Purchase_Order po)
        {
            getConnection();
            string sql = "insert into Orders(TransactionTypeID, SupplierID, DestinationWarehouseID,Date) values(1, @supplierid, @desid, @date)";
            SqlCommand cmd = new SqlCommand(sql, cnn);
            cmd.Parameters.AddWithValue("supplierid", po.supplierid);
            cmd.Parameters.AddWithValue("desid", po.warehouseid);
            cmd.Parameters.AddWithValue("date", po.date);
            cmd.ExecuteNonQuery();
            cnn.Close();
        }
        public DataTable getBatchNumberByPartID(int pID)
        {
            getConnection();
            string sql = "select BatchNumber from Orderitems where partid = @partid";
            SqlCommand cmd = new SqlCommand(sql, cnn);
            cmd.Parameters.AddWithValue("partid", pID);
            SqlDataReader dr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);
            cnn.Close();
            return dt;
        }
        public void insertOrder2(Warehouse_Management wh)
        {
            getConnection();
            string sql = "insert into Orders(TransactionTypeID, SourceWarehouseID, DestinationWarehouseID,Date) values(2, @sourceid, @desid, @date)";
            SqlCommand cmd = new SqlCommand(sql, cnn);
            cmd.Parameters.AddWithValue("sourceid", wh.sourceid);
            cmd.Parameters.AddWithValue("desid", wh.destinationid);
            cmd.Parameters.AddWithValue("date", wh.date);
            cmd.ExecuteNonQuery();
            cnn.Close();
        }
        public int getOrderidmax()
        {
            string sql = "select max(id) from Orders";
            SqlCommand cmd = new SqlCommand(sql, cnn);
            SqlDataReader dr = cmd.ExecuteReader();
            int id = 0;
            while (dr.Read())
            {
                id = (int)dr[0];
            }
            cnn.Close();
            return id;
        }
        public void insertOrderitems(int partid, String batchnumber, decimal amount)
        {
            getConnection();
            int id = getOrderidmax();
            getConnection();
            string sql = "insert into OrderItems(OrderID, PartID, BatchNumber, Amount) values (@id, @partid, @batchnumber, @amount)";
            SqlCommand cmd = new SqlCommand(sql, cnn);
            cmd.Parameters.AddWithValue("id", id);
            cmd.Parameters.AddWithValue("partid", partid);
            cmd.Parameters.AddWithValue("batchnumber", batchnumber);
            cmd.Parameters.AddWithValue("amount", amount);
            cmd.ExecuteNonQuery();
            cnn.Close();
        }

        public List<Inventory_Management> getInventory_Managements1()
        {
            var inventory_management = new List<Inventory_Management>();
            getConnection();
            string sql = "select * from purchase";
            SqlCommand cmd = new SqlCommand(sql, cnn);
            SqlDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                Inventory_Management Inventory_Management = new Inventory_Management();
                Inventory_Management.orderid = (int)dr["orderid"];
                Inventory_Management.orderitemsid = (int)dr["id"];
                Inventory_Management.partname = (string)dr["part name"];
                Inventory_Management.transactiontype = (string)dr["transaction type"];
                Inventory_Management.date = (DateTime)dr["date"];
                Inventory_Management.amount = (decimal)dr["amount"];
                //Inventory_Management.source = (string)dr["source"];
                Inventory_Management.supplier = (string)dr["suppliers"];
                Inventory_Management.destination = (string)dr["destination"];
                inventory_management.Add(Inventory_Management);
            }
            cnn.Close();

            //getConnection();
            string sql1 = "select * from warehouse";
            getConnection();
            SqlCommand cmd1 = new SqlCommand(sql1, cnn);
            dr = cmd1.ExecuteReader();

            while (dr.Read())
            {
                Inventory_Management Inventory_Management = new Inventory_Management();
                Inventory_Management.orderid = (int)dr["orderid"];
                Inventory_Management.orderitemsid = (int)dr["id"];
                Inventory_Management.partname = (string)dr["part name"];
                Inventory_Management.transactiontype = (string)dr["transaction type"];
                Inventory_Management.date = (DateTime)dr["date"];
                Inventory_Management.amount = (decimal)dr["amount"];
                Inventory_Management.source = (string)dr["source"];
                //Inventory_Management.supplier = (string)dr["suppliers"];
                Inventory_Management.destination = (string)dr["destination"];
                inventory_management.Add(Inventory_Management);
            }
            cnn.Close();
            return inventory_management;

        }

        public List<Inventory_Report> getBuy(int warehousesid)
        {
            getConnection();
            var inventory_report = new List<Inventory_Report>();
            string sql = "" + "select Parts.name, SUM(amount) as 'buy' " +
                          "from OrderItems inner join Parts on OrderItems.PartID = Parts.ID " +
                           "inner join Orders on OrderItems.OrderID = Orders.ID " +
                           "where SourceWarehouseID = @source and amount > 0 " +
                           "group by Parts.name,PartID";
            SqlCommand cmd = new SqlCommand(sql, cnn);
            cmd.Parameters.AddWithValue("source", warehousesid);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                Inventory_Report ir = new Inventory_Report();
                ir.partname = (string)dr["name"];
                ir.buy = (decimal)dr["buy"];
                inventory_report.Add(ir);
            }
            cnn.Close();
            return inventory_report;
        }
        public List<Inventory_Report> getReceived(int warehousesid)
        {
            getConnection();
            var inventory_report1 = new List<Inventory_Report>();
            string sql = "" + "select Parts.name, SUM(amount) as 'received' " +
                            "from OrderItems inner join Parts on OrderItems.PartID = Parts.ID " +
                            "inner join Orders on OrderItems.OrderID = Orders.ID " +
                            "where DestinationWarehouseID = @des " +
                            "group by Parts.name";
            SqlCommand cmd = new SqlCommand(sql, cnn);
            cmd.Parameters.AddWithValue("des", warehousesid);
            cmd.Parameters.AddWithValue("source", warehousesid);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                Inventory_Report ir = new Inventory_Report();
                ir.partname = (string)dr["name"];
                ir.received = (decimal)dr["received"];
                inventory_report1.Add(ir);
            }
            cnn.Close();
            return inventory_report1;
        }
        

        public DataTable getBatchNumberByPartName(string partname)
        {
            getConnection();
            string sql = "select batchnumber from OrderItems inner join Parts on OrderItems.PartID = Parts.ID where Parts.name = @name";
            SqlCommand cmd = new SqlCommand(sql, cnn);
            cmd.Parameters.AddWithValue("name", partname);
            SqlDataReader dr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);
            cnn.Close();
            return dt;
        }
        public List<View> getBatchNumber(string partname)
        {
            getConnection();
            var view = new List<View>();
            string sql = "select batchnumber from OrderItems inner join Parts on OrderItems.PartID = Parts.ID where Parts.name = @name";
            SqlCommand cmd = new SqlCommand(sql, cnn);
            cmd.Parameters.AddWithValue("name", partname);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                View View = new View();
                View.batchnumber = (string)dr["batchnumber"];
                view.Add(View);
            }
            cnn.Close();
            return view;
        }
        
    }
}

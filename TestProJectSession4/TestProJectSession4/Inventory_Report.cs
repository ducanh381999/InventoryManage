using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProJectSession4
{
    class Inventory_Report
    {
        private int WarehousesID;

        public int warehousesid
        {
            get { return WarehousesID; }
            set { WarehousesID = value; }
        }
        private String Warehouse;

        public String warehouse
        {
            get { return Warehouse; }
            set { Warehouse = value; }
        }
        private String PartName;

        public String partname
        {
            get { return PartName; }
            set { PartName = value; }
        }
        private Decimal Current;

        public Decimal current
        {
            get { return Current; }
            set { Current = value; }
        }
        private Decimal Received;

        public Decimal received
        {
            get { return Received; }
            set { Received = value; }
        }
        private Decimal Buy;

        public Decimal buy
        {
            get { return Buy; }
            set { Buy = value; }
        }

    }
}

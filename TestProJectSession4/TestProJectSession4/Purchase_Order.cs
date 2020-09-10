using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProJectSession4
{
    class Purchase_Order
    {
        private int PartID;

        public int partid
        {
            get { return PartID; }
            set { PartID = value; }
        }
        private String batchNumberHasRequired;

        public String batchrequired
        {
            get { return batchNumberHasRequired; }
            set { batchNumberHasRequired = value; }
        }
        private decimal Amount;

        public decimal amount
        {
            get { return Amount; }
            set { Amount = value; }
        }
        private int SupplierID;

        public int supplierid
        {
            get { return SupplierID; }
            set { SupplierID = value; }
        }

        private String SupplierName;

        public String suppliername
        {
            get { return SupplierName; }
            set { SupplierName = value; }
        }
        private int WarehouseID;

        public int warehouseid
        {
            get { return WarehouseID; }
            set { WarehouseID = value; }
        }
        private String WarehouseName;

        public String warehousename
        {
            get { return WarehouseName; }
            set { WarehouseName = value; }
        }
        private String PartName;

        public String partname
        {
            get { return PartName; }
            set { PartName = value; }
        }
        private DateTime Date;

        public DateTime date
        {
            get { return Date; }
            set { Date = value; }
        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProJectSession4
{
    public class Inventory_Management : IComparable<Inventory_Management>
    {
        private int OrderID;

        public int orderid
        {
            get { return OrderID; }
            set { OrderID = value; }
        }
        private string PartName;
        private int OrderItemsID;

        public int orderitemsid
        {
            get { return OrderItemsID; }
            set { OrderItemsID = value; }
        }

        public string partname
        {
            get { return PartName; }
            set { PartName = value; }
        }
        private string TransactionType;

        public string transactiontype
        {
            get { return TransactionType; }
            set { TransactionType = value; }
        }
        private DateTime Date;

        public DateTime date
        {
            get { return Date; }
            set { Date = value; }
        }
        private decimal Amount;

        public decimal amount
        {
            get { return Amount; }
            set { Amount = value; }
        }
        private string Source;

        public string source
        {
            get { return Source; }
            set { Source = value; }
        }
        private string Destination;

        public string destination
        {
            get { return Destination; }
            set { Destination = value; }
        }
        private string Supplier;

        public string supplier
        {
            get { return Supplier; }
            set { Supplier = value; }
        }

        public Inventory_Management() { }

        public int CompareTo(Inventory_Management other)
        {
            if (this.date > other.date) return 1;
            else if (this.date < other.date) return -1;
            else if (this.transactiontype.ToString().Trim() == "Purchase Order") return -1;
            else return 0;
        }
    }
}

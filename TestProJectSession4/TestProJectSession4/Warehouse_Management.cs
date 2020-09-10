using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProJectSession4
{
    class Warehouse_Management
    {
        private int SourceID;

        public int sourceid
        {
            get { return SourceID; }
            set { SourceID = value; }
        }
        private String Source;

        public String source
        {
            get { return Source; }
            set { Source = value; }
        }
        private int DestinationID;

        public int destinationid
        {
            get { return DestinationID; }
            set { DestinationID = value; }
        }
        private String DestinationName;

        public String destinationname
        {
            get { return DestinationName; }
            set { DestinationName = value; }
        }
        private DateTime Date;

        public DateTime date
        {
            get { return Date; }
            set { Date = value; }
        }
        private int PartID;

        public int partid
        {
            get { return PartID; }
            set { PartID = value; }
        }
        private String PartName;

        public String partname
        {
            get { return PartName; }
            set { PartName = value; }
        }
        private String BatchNumber;

        public String batchnumber
        {
            get { return BatchNumber; }
            set { BatchNumber = value; }
        }
        private Decimal Amount;

        public Decimal amount
        {
            get { return Amount; }
            set { Amount = value; }
        }

    }
}

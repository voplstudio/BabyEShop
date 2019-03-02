using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eshop
{
    public class Order
    {
        public int OrderID;

        public string Number { get { return OrderID.ToString(); } }

        public string CustomerID;
        public int EmployeeID;
        public DateTime OrderDate;
        public DateTime RequiredDate;
        public DateTime ShippedDate;
        public int ShipVia;
        public double Freight;
        public string ShipName;
        public string ShipAddress;
        public string ShipCity;
        public string ShipRegion;
        public string ShipPostalCode;
        public string ShipCountry;
        public List<OrderLine> Items = new List<OrderLine>();

    }
}

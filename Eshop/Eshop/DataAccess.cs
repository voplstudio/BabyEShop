using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eshop
{
    class DataAccess
    {

        private static string myNorthwindDBConnectionString = null;
        // @"Persist Security Info=False;Integrated Security = true; Initial Catalog = Northwind; server=DESKTOP-5NL2LJB\SQLEXPRESS"

        public static string NorthwindDBConnectionString
        {
            get
            {
                return myNorthwindDBConnectionString;
            }
            set
            {
                if (myNorthwindDBConnectionString == null)
                    myNorthwindDBConnectionString = value;
            }
        }

        internal static DataSet GetOrderDetailsDataSet(int orderID)
        {
            return GetDataSet(NorthwindDBConnectionString,
                "SELECT d.*, p.ProductName " +
                "from [Order Details] d " +
                "join Products p on p.ProductID=d.ProductID " +
                "where @0 = OrderID",
                CommandType.Text, new SqlParameter("@0", orderID));
        }

        delegate void ReaderProcedure(SqlDataReader reader, object recipient);

        internal static Customer GetCustomerByID(string customerID)
        {
            DataSet dataSet = GetDataSet(NorthwindDBConnectionString,
                "SELECT * from Customers where CustomerID = @0",
                CommandType.Text, new SqlParameter("@0", customerID));
            if (dataSet.Tables[0].Rows.Count == 0)
            {
                throw new Exception("Non valid CustomerID " + customerID);
            }
            else
            {
                return new Customer()
                {
                    CustomerID = customerID,
                    CompanyName = dataSet.Tables[0].Rows[0].ItemArray[1].ToString(),
                    ContactName = dataSet.Tables[0].Rows[0].ItemArray[2].ToString(),
                    ContactTitle = dataSet.Tables[0].Rows[0].ItemArray[3].ToString(),
                    Address = dataSet.Tables[0].Rows[0].ItemArray[4].ToString(),
                    City = dataSet.Tables[0].Rows[0].ItemArray[5].ToString(),
                    Region = dataSet.Tables[0].Rows[0].ItemArray[6].ToString(),
                    PostalCode = dataSet.Tables[0].Rows[0].ItemArray[7].ToString(),
                    Country = dataSet.Tables[0].Rows[0].ItemArray[8].ToString(),
                    Phone = dataSet.Tables[0].Rows[0].ItemArray[9].ToString(),
                    Fax = dataSet.Tables[0].Rows[0].ItemArray[10].ToString(),
                };
            }
        }


        static void OrderListReaderProc(SqlDataReader reader, object recipient)
        {
            List<Tuple<int, string>> result = recipient as List<Tuple<int, string>>;
            result.Add(new Tuple<int, string>(
                Int32.Parse(reader[0].ToString()),
                reader[0].ToString()));
        }

        public static List<Tuple<int, string>> ReadOrders()
        {
            List<Tuple<int, string>> result = new List<Tuple<int, string>>();
            string queryString =
                "SELECT OrderID FROM dbo.Orders order by OrderID;";
            return ReadData(queryString, OrderListReaderProc, result) as List<Tuple<int, string>>;
        }

        // see https://docs.microsoft.com/en-us/dotnet/api/system.data.sqlclient.sqlcommand?f1url=https%3A%2F%2Fmsdn.microsoft.com%2Fquery%2Fdev15.query%3FappId%3DDev15IDEF1%26l%3DEN-US%26k%3Dk(System.Data.SqlClient.SqlCommand)%3Bk(TargetFrameworkMoniker-.NETFramework%2CVersion%3Dv4.6.1)%3Bk(DevLang-csharp)%26rd%3Dtrue&view=netframework-4.7.2#examples
        public static Int32 ExecuteNonQuery(SqlConnection conn, SqlTransaction tran, String commandText,
            CommandType commandType, params SqlParameter[] parameters)
        {
            using (SqlCommand cmd = new SqlCommand(commandText, conn))
            {
                // There're three command types: StoredProcedure, Text, TableDirect. The TableDirect   
                // type is only for OLE DB.    
                cmd.CommandType = commandType;
                cmd.Parameters.AddRange(parameters);
                cmd.Transaction = tran;
                return cmd.ExecuteNonQuery();
            }
        }

        public static Object ExecuteScalar(String connectionString, String commandText,
          CommandType commandType, params SqlParameter[] parameters)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = new SqlCommand(commandText, conn))
                {
                    cmd.CommandType = commandType;
                    cmd.Parameters.AddRange(parameters);

                    conn.Open();
                    return cmd.ExecuteScalar();
                }
            }
        }

        public static DataSet GetDataSet(String connectionString, String commandText,
            CommandType commandType, params SqlParameter[] parameters)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = new SqlCommand(commandText, conn))
                {
                    // There're three command types: StoredProcedure, Text, TableDirect. The TableDirect   
                    // type is only for OLE DB.    
                    cmd.CommandType = commandType;
                    cmd.Parameters.AddRange(parameters);

                    conn.Open();
                    DataSet dataSet = new DataSet();
                    using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                    {
                        adapter.Fill(dataSet);
                        return dataSet;
                    }
                }
            }
        }
        private static object ReadData(string queryString, ReaderProcedure proc, object result, params SqlParameter[] parameters)
        {
            using (SqlConnection connection = new SqlConnection(
                       NorthwindDBConnectionString))
            {
                SqlCommand command = new SqlCommand(
                    queryString, connection);
                command.Parameters.AddRange(parameters);
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                try
                {
                    while (reader.Read())
                    {
                        proc(reader, result);
                    }
                }
                finally
                {
                    // Always call Close when done reading.
                    reader.Close();
                }
            }

            return result;
        }

        internal static Order ReadOrder(int orderId)
        {
            Order result = new Order();
            string queryString =  // "sdfsd';delete table orders;"
                "SELECT * FROM dbo.Orders WHERE OrderID=@0;";
            SqlParameter id = new SqlParameter("@0", System.Data.SqlDbType.Int)
            {
                Value = Convert.ToInt32(orderId)
            };
            return ReadData(queryString, OrderReaderProc, result, id) as Order;
        }

        private static void OrderReaderProc(SqlDataReader reader, object recipient)
        {
            Order result = recipient as Order;
            result.CustomerID = reader[1].ToString();
            result.ShipName = reader[8].ToString();
            result.Freight = Convert.ToInt32(reader[7]);
            result.ShipAddress = reader[9].ToString();
            result.ShipCity = reader[10].ToString();
            result.ShipRegion = reader[11].ToString();
            result.ShipPostalCode = reader[12].ToString();
            result.ShipCountry = reader[13].ToString();
            result.OrderDate = Convert.ToDateTime(reader[3]);
            result.RequiredDate = Convert.ToDateTime(reader[4]);
            result.ShippedDate = Convert.ToDateTime(reader[5]);
            result.OrderID = Convert.ToInt32(reader[0]);
        }

        internal static void SaveExistingOrder(Order order)
        {
            using (SqlConnection conn = new SqlConnection(NorthwindDBConnectionString))
            {
                SqlTransaction transaction;
                conn.Open();
                transaction = conn.BeginTransaction();
                try
                {
                    string queryString =
                        "UPDATE dbo.Orders " +
                        "SET OrderDate=@1, RequiredDate=@2, ShippedDate=@3, " +
                        "Freight=@4, ShipName=@5, ShipAddress=@6, ShipCity=@7, " +
                        "ShipRegion=@8, ShipPostalCode=@9, ShipCountry=@10, CustomerID=@11 " +
                        "WHERE OrderID=@0";

                    SqlParameter[] parms = new SqlParameter[]
                    {
                        new SqlParameter("@0", SqlDbType.Int) { Value = order.OrderID },
                        new SqlParameter("@1", SqlDbType.DateTime) { Value = order.OrderDate },
                        new SqlParameter("@2", SqlDbType.DateTime) { Value = order.RequiredDate },
                        new SqlParameter("@3", SqlDbType.DateTime) { Value = order.ShippedDate },
                        new SqlParameter("@4", SqlDbType.Decimal) { Value = order.Freight },
                        new SqlParameter("@5", SqlDbType.NVarChar) { Value = order.ShipName },
                        new SqlParameter("@6", SqlDbType.NVarChar) { Value = order.ShipAddress },
                        new SqlParameter("@7", SqlDbType.NVarChar) { Value = order.ShipCity },
                        new SqlParameter("@8", SqlDbType.NVarChar) { Value = order.ShipRegion },
                        new SqlParameter("@9", SqlDbType.NVarChar) { Value = order.ShipPostalCode },
                        new SqlParameter("@10", SqlDbType.NVarChar) { Value = order.ShipCountry },
                        new SqlParameter("@11", SqlDbType.NVarChar) { Value = order.CustomerID }};

                    ExecuteNonQuery(conn, transaction, queryString, CommandType.Text, parms);

                    queryString =
                        "DELETE FROM dbo.[Order Details] " +
                        "WHERE OrderID=@0";

                    parms = new SqlParameter[]
                        { new SqlParameter("@0", SqlDbType.Int) { Value = order.OrderID } };

                    ExecuteNonQuery(conn, transaction, queryString, CommandType.Text, parms);

                    queryString =
                        "INSERT INTO dbo.[Order Details] " +
                        "VALUES(@0, @1, @2, @3, @4);";
                    foreach (var item in order.Items)
                    {


                        parms = new SqlParameter[]                    {
                            new SqlParameter("@0", SqlDbType.Int) { Value = order.OrderID },
                            new SqlParameter("@1", SqlDbType.Int) { Value = item.ProductID },
                            new SqlParameter("@2", SqlDbType.Money) { Value = item.UnitPrice },
                            new SqlParameter("@3", SqlDbType.SmallInt) { Value = item.Quantity },
                            new SqlParameter("@4", SqlDbType.Real) { Value = item.Discount }};

                        ExecuteNonQuery(conn, transaction, queryString, CommandType.Text, parms);
                    }
                    transaction.Commit();
                }
                catch (Exception)
                {
                    transaction.Rollback();
                    throw;
                }
            }
        }
        internal static void SaveNewOrder(Order order)
        {
            string queryString = "SELECT  MAX([OrderID]) FROM dbo.[Orders]";
            order.OrderID = 1 + (int)ExecuteScalar(NorthwindDBConnectionString, queryString, CommandType.Text);
            using (SqlConnection conn = new SqlConnection(NorthwindDBConnectionString))
            {
                SqlTransaction transaction;
                conn.Open();
                transaction = conn.BeginTransaction();
                try
                {
                    queryString =

       "INSERT INTO dbo.Orders(CustomerID, EmployeeID, OrderDate, RequiredDate, ShippedDate, ShipVia, Freight, ShipName, ShipAddress, ShipCity, ShipRegion, ShipPostalCode, ShipCountry) " +
                 "VALUES (@11, @12, @1, @2, @3, @13, @4, @5, @6, @7, @8, @9, @10)";

                    SqlParameter[] parms = new SqlParameter[]
                        {
                            new SqlParameter("@0", SqlDbType.Int) { Value = order.OrderID },
                            new SqlParameter("@1", SqlDbType.DateTime) { Value = order.OrderDate },
                            new SqlParameter("@2", SqlDbType.DateTime) { Value = order.RequiredDate },
                            new SqlParameter("@3", SqlDbType.DateTime) { Value = order.ShippedDate },
                            new SqlParameter("@4", SqlDbType.Decimal) { Value = order.Freight },
                            new SqlParameter("@5", SqlDbType.NVarChar) { Value = order.ShipName },
                            new SqlParameter("@6", SqlDbType.NVarChar) { Value = order.ShipAddress },
                            new SqlParameter("@7", SqlDbType.NVarChar) { Value = order.ShipCity },
                            new SqlParameter("@8", SqlDbType.NVarChar) { Value = order.ShipRegion },
                            new SqlParameter("@9", SqlDbType.NVarChar) { Value = order.ShipPostalCode },
                            new SqlParameter("@10", SqlDbType.NVarChar) { Value = order.ShipCountry },
                            new SqlParameter("@11", SqlDbType.NVarChar) { Value = order.CustomerID },
                            new SqlParameter("@12", SqlDbType.Int) { Value = 1 },
                            new SqlParameter("@13", SqlDbType.Int) { Value = 1 } };

                    ExecuteNonQuery(conn, transaction, queryString, CommandType.Text, parms);

                    queryString =
                         "INSERT INTO dbo.[Order Details] " +
                         "VALUES(@0, @1, @2, @3, @4);";
                    foreach (var item in order.Items)
                    {


                        parms = new SqlParameter[]                    {
                    new SqlParameter("@0", SqlDbType.Int) { Value = order.OrderID },
                    new SqlParameter("@1", SqlDbType.Int) { Value = item.ProductID },
                    new SqlParameter("@2", SqlDbType.Money) { Value = item.UnitPrice },
                    new SqlParameter("@3", SqlDbType.SmallInt) { Value = item.Quantity },
                    new SqlParameter("@4", SqlDbType.Real) { Value = item.Discount }};

                        ExecuteNonQuery(conn, transaction, queryString, CommandType.Text, parms);
                    }
                    transaction.Commit();
                }
                catch (Exception)
                {
                    transaction.Rollback();
                    throw;
                }
            }
        }

        internal static DataSet GetCompanyNameDataSet()
        {
            return GetDataSet(NorthwindDBConnectionString,
                "SELECT * " +
                "from Customers",
                CommandType.Text);
        }
        internal static DataSet GetProducts()
        {
            return GetDataSet(NorthwindDBConnectionString,
                "SELECT * FROM Products", CommandType.Text);
        }
    }
}

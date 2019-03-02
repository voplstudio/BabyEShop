using System;
using System.Data;
using System.Windows.Forms;

namespace Eshop
{
    public partial class OrderForm : Form
    {
        private Order order;
        public bool IsSaved { get; private set; } = false;
        public OrderForm()
        {
            InitializeComponent();
        }

        public OrderForm(Order order)
        {
            InitializeComponent();
            DataSet dataSet;
            if (order is null)
            {
                this.order = new Order();
                dataSet = CreateEmptyOrderLinesDataSet();

            }
            else
            {
                this.order = order;
                 dataSet = DataAccess.GetOrderDetailsDataSet(order.OrderID);
            }
            dataGridView1.DataSource = dataSet.Tables[0];
            dataGridView1.Columns["ProductID"].Visible = false;
            dataGridView1.Columns["OrderID"].Visible = false;
            dataGridView1.Columns["ProductName"].HeaderText = "Product";
            dataGridView1.Columns["ProductName"].DisplayIndex = 0;
            dataGridView1.Columns["ProductName"].ReadOnly = true;

        }

        private DataSet CreateEmptyOrderLinesDataSet()
        {
            DataSet dataSet = new DataSet();
            dataSet.Tables.Add(new DataTable());
            dataSet.Tables[0].Columns.Add(new DataColumn("OrderID", typeof(int)));
            dataSet.Tables[0].Columns.Add(new DataColumn("ProductID", typeof(int)));
            dataSet.Tables[0].Columns.Add(new DataColumn("UnitPrice", typeof(double)));
            dataSet.Tables[0].Columns.Add(new DataColumn("Quantity", typeof(int)));
            dataSet.Tables[0].Columns.Add(new DataColumn("Discount", typeof(float)));
            dataSet.Tables[0].Columns.Add(new DataColumn("ProductName", typeof(string)));
            return dataSet;
        }

        private void OrderForm_Load(object sender, EventArgs e)
        {
            ShipNameTextBox.Text = order.ShipName;
            ShipNameTextBox.Text = order.ShipName;
            FreightTextBox.Text = order.Freight.ToString();
            ShipAddressTextBox.Text = order.ShipAddress;
            ShipCityTextBox.Text = order.ShipCity;
            ShipRegionTextBox.Text = order.ShipRegion;
            ShipPostalCodeTextBox.Text = order.ShipPostalCode;
            ShipCountryTextBox.Text = order.ShipCountry;
            ApplyData(order.OrderDate, OrderDateDateTimePicker);
            ApplyData(order.RequiredDate, RequiredDateDateTimePicker);
            ApplyData(order.ShippedDate, ShippingDateDateTimePicker);
            Text = "Order #" + order.Number;
            OrderNumberTextBox.Text = order.Number;
            if (string.IsNullOrEmpty(order.CustomerID))
            {
                CompanyNameTextBox.Text = "(Double click to select)";
            }
            else
            {
                Customer customer = DataAccess.GetCustomerByID(order.CustomerID);
                CompanyNameTextBox.Text = customer.CompanyName;
            }
        }

        private void ApplyData(DateTime date, DateTimePicker dateTimePicker)
        {
            if (date != new DateTime(0001, 01, 01, 0, 00, 00))
            {
                dateTimePicker.Value = date;
            }
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {//TODO проверять заполнение имени компании
            Order order = new Order();
            order.OrderID = this.order.OrderID;
            order.ShipName = ShipNameTextBox.Text;
            order.Freight = Int32.Parse(FreightTextBox.Text);
            order.ShipAddress = ShipAddressTextBox.Text;
            order.ShipCity = ShipCityTextBox.Text;
            order.ShipRegion = ShipRegionTextBox.Text;
            order.ShipPostalCode = ShipPostalCodeTextBox.Text;
            order.ShipCountry = ShipCountryTextBox.Text;
            order.OrderDate = OrderDateDateTimePicker.Value;
            order.RequiredDate = RequiredDateDateTimePicker.Value;
            order.ShippedDate = ShippingDateDateTimePicker.Value;
            order.CustomerID = this.order.CustomerID;
            order.Items.Clear();
            for (int i = 0; i < dataGridView1.RowCount; i++)
            {
                int productID = Convert.ToInt32(dataGridView1.Rows[i].Cells[1].Value);
                decimal unitPrice = Convert.ToDecimal(dataGridView1.Rows[i].Cells[2].Value);
                int quantity = Convert.ToInt32(dataGridView1.Rows[i].Cells[3].Value);
                double discount = Convert.ToDouble(dataGridView1.Rows[i].Cells[4].Value);
                if (productID > 0 && unitPrice >= 0 && quantity > 0 && discount >= 0 && discount <= 1) {
                    order.Items.Add(new OrderLine()
                    {
                        ProductID = productID,
                        UnitPrice = unitPrice,
                        Quantity = quantity,
                        Discount = discount,
                    });
                }
            }
            if (order.OrderID > 0)
            {
                DataAccess.SaveExistingOrder(order);
            }
            else
            {
                DataAccess.SaveNewOrder(order);
                OrderNumberTextBox.Text = order.Number; 
            }
            IsSaved = true;
        }

        private void CancelBtn_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void ChangeCompanyNameButton_Click(object sender, EventArgs e)
        {
            CompanyNameForm ccnForm;
            ccnForm = new CompanyNameForm();
            DataSet dataSet = DataAccess.GetCompanyNameDataSet();
            ccnForm.dataGridView1.DataSource = dataSet.Tables[0];

            //dataGridView1.Columns["ProductID"].Visible = false;
            //dataGridView1.Columns["OrderID"].Visible = false;
            //dataGridView1.Columns["ProductName"].HeaderText = "Product";
            //dataGridView1.Columns["ProductName"].DisplayIndex = 0;
            if (ccnForm.ShowDialog() == DialogResult.OK)
            {
                order.CustomerID = ccnForm.Id;
                CompanyNameTextBox.Text = ccnForm.CompanyName;
            }
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 5)
            {
                ChangeProductForm cpForm;
                cpForm = new ChangeProductForm();
                DataSet dataSet = DataAccess.GetProducts();
                cpForm.dataGridView1.DataSource = dataSet.Tables[0];

                if (cpForm.ShowDialog() == DialogResult.OK)
                {
                    dataGridView1.Rows[e.RowIndex].Cells[1].Value = cpForm.ProductID;
                    dataGridView1.Rows[e.RowIndex].Cells[5].Value = cpForm.ProductName;
                }
            }
        }
    }
}

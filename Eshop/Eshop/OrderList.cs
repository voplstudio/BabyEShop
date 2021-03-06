﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Eshop
{
    public partial class OrderList : Form
    {
        public OrderList()
        {
            InitializeComponent();
            DataAccess.NorthwindDBConnectionString = @"Persist Security Info=False;Integrated Security = true; Initial Catalog = Northwind; server=DESKTOP-5NL2LJB\SQLEXPRESS";
            FillOrderList();
        }
        public void FillOrderList()
        {
            List<Tuple<int, string>> orderList = DataAccess.ReadOrders();
            listBox1.DataSource = orderList;
            listBox1.DisplayMember = "Item2";
            listBox1.ValueMember = "Item1";
            listBox1.Cursor = Cursors.Arrow;
        }
        public void ShowOrder(Order order)
        {
            OrderForm form = new OrderForm(order);
            form.ShowDialog();
            if (form.IsSaved)
            {
                FillOrderList();
            }
        }

        private void EditButton_Click(object sender, EventArgs e)
        {
            // read order
            Order order = DataAccess.ReadOrder((listBox1.SelectedItem as Tuple<int, string>).Item1);
            ShowOrder(order);
        }

        private void OrderList_Load(object sender, EventArgs e)
        {

        }

        private void ListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox1.DataSource != null)
                System.Diagnostics.Debug.WriteLine("listBox1_SelectedIndexChanged");
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void NewButton_Click(object sender, EventArgs e)
        {          
            ShowOrder(null);
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure?", "Confirmation deleting", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                DataAccess.DeleteOrder((listBox1.SelectedItem as Tuple<int, string>).Item1);
                FillOrderList();
            }

        }
    }
}

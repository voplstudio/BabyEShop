using System;
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
    public partial class ChangeProductForm : Form
    {
        public string ProductID = null;
        public string ProductName = null;
        public ChangeProductForm()
        {
            InitializeComponent();
        }

        private void ChangeButton_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                ProductID = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
                ProductName = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
                DialogResult = DialogResult.OK;

            }
            else DialogResult = DialogResult.Cancel;
        }

        private void ChangeProduct_Load(object sender, EventArgs e)
        {

        }
    }
}

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
    public partial class CompanyNameForm : Form
    {
        public string Id = null;
        public string Company = null;
        public CompanyNameForm()
        {
            InitializeComponent();
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {

        }

        private void ChangeButton_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                Id = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
                Company = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
                DialogResult = DialogResult.OK;

            }
            else DialogResult = DialogResult.Cancel;
        }
    }
}

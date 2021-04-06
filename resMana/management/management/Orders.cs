using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace management
{
    public partial class Orders : Form
    {
        public Orders()
        {
            InitializeComponent();
        }

        private void rowSelected(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                dataGridView1.CurrentRow.Selected = true;
            }
        }

        private void btnBack(object sender, EventArgs e)
        {
            this.Hide();
            Menu mn = new Menu();
            mn.ShowDialog();
            this.Close();
        }

        private void btnCall(object sender, EventArgs e)
        {
            this.Hide();
            Foodcall fc = new Foodcall();
            fc.ShowDialog();
            this.Close();
        }
    }
}

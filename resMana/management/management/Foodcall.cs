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
    public partial class Foodcall : Form
    {
        public Foodcall()
        {
            InitializeComponent();
        }

        private void btnBack(object sender, EventArgs e)
        {
            this.Hide();
            Orders ord = new Orders();
            ord.ShowDialog();
            this.Close();
        }
    }
}

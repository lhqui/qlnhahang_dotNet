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
    public partial class ChangePass : Form
    {
        public ChangePass()
        {
            InitializeComponent();
        }

        private void btnClick_Change(object sender, EventArgs e)
        {
            //this.Hide();
            //Staffs st = new Staffs();
            //st.ShowDialog();
            this.Close();
        }
    }
}

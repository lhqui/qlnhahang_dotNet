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
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void btnFoods(object sender, EventArgs e)
        {
            this.Hide();
            Foods fd = new Foods();
            fd.ShowDialog();
            this.Close();
        }

        private void btnExit(object sender, EventArgs e)
        {
            DBConnect db = new DBConnect();
            String valueId = CacheStore.GetItemsFromCache();
            if (valueId == "1") {
                CacheStore.RemoveItemsFromCache();
            } 
            this.Hide();
            Login lg = new Login();
            lg.ShowDialog();
            this.Close();
        }

        private void btnOrders(object sender, EventArgs e)
        {
            this.Hide();
            Orders ord = new Orders();
            ord.ShowDialog();
            this.Close();
        }

        private void btnHistory(object sender, EventArgs e)
        {
            this.Hide();
            History hs = new History();
            hs.ShowDialog();
            this.Close();
        }

        private void btnStaffs(object sender, EventArgs e)
        {
            this.Hide();
            Staffs st = new Staffs();
            st.ShowDialog();
            this.Close();
        }
    }
}

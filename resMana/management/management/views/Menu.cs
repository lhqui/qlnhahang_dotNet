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
        private Users user;
        public Menu(Users user)
        {
            InitializeComponent();
            this.user = user;
        }

        private void btnFoods(object sender, EventArgs e)
        {
            if (user.CheckPermission() == true)
            {
                this.Hide();
                Foods fd = new Foods(this.user);
                fd.Parent = Parent;
                fd.StartPosition = FormStartPosition.CenterParent;
                fd.ShowDialog();
                this.Close();
            } else
            {
                MessageBox.Show("Bạn Không đủ quyền!");
            }
           
        }

        private void btnExit(object sender, EventArgs e)
        {
            DBConnect db = new DBConnect();
            this.Hide();
            Login lg = new Login();
            lg.ShowDialog();
            this.Close();
        }

        private void btnOrders(object sender, EventArgs e)
        {
            user.GetStartHoursFromDb(user.users["uid"]);
            if (user.CheckIsWorkingHour() == true)
            {
                //MessageBox.Show("co");
                this.Hide();
                Orders ord = new Orders(this.user);
                ord.Parent = Parent;
                ord.StartPosition = FormStartPosition.CenterParent;
                ord.ShowDialog();
                this.Close();
            }
            else
            {
                MessageBox.Show("Bạn không có ca làm!");
            }

        }

        private void btnHistory(object sender, EventArgs e)
        {
            //this.Hide();
            Total tt = new Total();
            tt.StartPosition = FormStartPosition.CenterParent;
            tt.ShowDialog();
            //hs.ShowDialog();
        }

        private void btnStaffs(object sender, EventArgs e)
        {
            this.Hide();
            Staffs st = new Staffs(this.user);
            st.Parent = Parent;
            st.StartPosition = FormStartPosition.CenterParent;
            st.ShowDialog();
            this.Close();
        }
    }
}

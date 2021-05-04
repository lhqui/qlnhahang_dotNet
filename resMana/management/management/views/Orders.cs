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
        private Users user;
        private String orderId;
        DBConnect db = new DBConnect();
        public Orders(Users user)
        {
            InitializeComponent();
            ShowOrderInOperate();
            this.user = user;
            CheckAreAnyOrder();
        }

        private void btnBack(object sender, EventArgs e)
        {
            this.Hide();
            Menu mn = new Menu(this.user);
           // mn.Parent = Parent;
            mn.StartPosition = FormStartPosition.CenterParent;
            mn.ShowDialog();
            this.Close();
        }



        private void ChooseTable(object sender, EventArgs e)
        {
            SelectTable tb = new SelectTable();
            tb.Parent = Parent;
            tb.StartPosition = FormStartPosition.CenterParent;
            tb.ShowDialog();
            ShowOrderInOperate();
        }

        private void ChangeTable(object sender, EventArgs e)
        {
            GetOrderIdInCell();
            SelectTable tb = new SelectTable(this.orderId);
            tb.Parent = Parent;
            tb.StartPosition = FormStartPosition.CenterParent;
            tb.ShowDialog();
            ShowOrderInOperate();
        }

        private void GetOrderIdInCell()
        {
             int n = dataOrderGridView1.CurrentCell.RowIndex;
             DataGridViewRow row = this.dataOrderGridView1.Rows[n];
             this.orderId = row.Cells["ordersid"].Value.ToString();
        }
        private void CheckAreAnyOrder()
        {
            String query = "select ordersid, tablename, opentime, customername, statusid " +
                    "from orders inner join tablest on orders.tableid = tablest.tableid where statusid=2";
            db.Query(query);
            if (db.count == 0)
            {
                btnChangeTable.Enabled = false;
                btnViewOrder.Enabled = false;
                btnGetBill.Enabled = false;
            } 

        }
        public void ShowOrderInOperate()
        {
            String query = "select ordersid, tablename, opentime, customername, statusid " +
                "from orders inner join tablest on orders.tableid = tablest.tableid where statusid=2";
            db.ShowDt(query);
            dataOrderGridView1.DataSource = db.dt;
            dataOrderGridView1.Columns[0].HeaderCell.Value = "STT";
            dataOrderGridView1.Columns[1].HeaderCell.Value = "Bàn";
            dataOrderGridView1.Columns[2].HeaderCell.Value = "Thời gian vào";
            dataOrderGridView1.Columns[3].HeaderCell.Value = "Tên khách";
            dataOrderGridView1.Columns[4].Visible = false;

        }

        private void GetOrderId(object sender, DataGridViewCellEventArgs e)
        {
            GetOrderIdInCell();
        }

        private void ViewOrder(object sender, EventArgs e)
        {
            GetOrderIdInCell();
            FoodOrder fod = new FoodOrder(this.orderId, this.user.users["uid"]);
            fod.Parent = Parent;
            fod.StartPosition = FormStartPosition.CenterParent;
            fod.ShowDialog();
            GetOrderIdInCell();
        }

        private void PayOrder(object sender, EventArgs e)
        {
            GetOrderIdInCell();
            GetBill get = new GetBill(this.user, this.orderId);
            get.StartPosition = FormStartPosition.CenterParent;
            get.ShowDialog();
            ShowOrderInOperate();
        }
    }
}

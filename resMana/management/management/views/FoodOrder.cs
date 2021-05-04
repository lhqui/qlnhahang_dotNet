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
    public partial class FoodOrder : Form
    {
        //Order ord;
        DBConnect db = new DBConnect();
        private String uId;
        private String orderId;
        private String tableId;
        public FoodOrder(String orderId, String uid)
        {
            InitializeComponent();
            this.uId = uid;
            this.orderId = orderId;
            ShowOrderFoodList();
            ShowOrderDetail();
        }
        private void ShowOrderFoodList()
        {
            String query = "select orderlist.ordersid, foods.foodname, staffs.staffname, ordertime, quantity"
                + " from orderlist"
                + " Inner join orders on orderlist.ordersid = orders.ordersid"
                + " INNER JOIN foods ON Orderlist.foodid = foods.foodid"
                + " INNER JOIN staffs ON Orderlist.staffid = staffs.staffid where orderlist.ordersid="+ this.orderId;
            db.ShowDt(query);
            orderListGridView1.DataSource = db.dt;
            //orderListGridView1.Columns[0].HeaderCell.Value = "STT";
            orderListGridView1.Columns[0].Visible =  false;
            orderListGridView1.Columns[1].HeaderCell.Value = "Tên món";
            orderListGridView1.Columns[2].HeaderCell.Value = "Nhân viên gọi";
            orderListGridView1.Columns[3].HeaderCell.Value = "Thời gian gọi";
            orderListGridView1.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            orderListGridView1.Columns[4].HeaderCell.Value = "Số lượng";
        }
        private void ShowOrderDetail()
        {
            Order ord = new Order(this.orderId);
            Tables tb = new Tables(ord.orderDic["tableid"]);
            String tableName = tb.tableDic["tablename"];
            txtName.Text = ord.orderDic["customername"];
            txtTable.Text = tableName;
            txtNote.Text = ord.orderDic["ordernote"];
        }
        private void ExitToOrder(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AddMoreFood(object sender, EventArgs e)
        {
            AddFood add = new AddFood(this.orderId, this.uId);
            add.StartPosition = FormStartPosition.CenterParent;
            add.ShowDialog();
            ShowOrderFoodList();
        }
    }
}

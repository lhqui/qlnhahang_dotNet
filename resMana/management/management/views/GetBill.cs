using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace management
{
    public partial class GetBill : Form
    {
        Users User;
        private String orderId;
        DBConnect db = new DBConnect();
        private int totalpirce = 0;
        public GetBill(Users user, String orderId)
        {
            InitializeComponent();
            this.User = user;
            this.orderId = orderId;
            ShowOrderList();
            ToTalPriceOfBill();
            ShowDetailOfBill();
        }

        private void Payment(object sender, EventArgs e)
        {
            String[] arr = {this.orderId, User.users["uid"], DateTime.Now.ToString("yyyy-MM-dd HH:00"), this.totalpirce.ToString() }; 
            String query = "insert into bills values " + db.StringValue(arr);
            Console.WriteLine(query);
            db.ExecuteNonQuery(query);
            if(db.count != 0)
            {
                Order order = new Order(this.orderId);
                String updateTableStatus = "update tablest set statusid=1 where tableid=" + order.orderDic["tableid"];
                db.ExecuteNonQuery(updateTableStatus);
                Console.WriteLine(query);
                MessageBox.Show("Thanh toán thành công");
                this.Close();
            } else
            {
                MessageBox.Show("Thanh toán thất bại");
            }
        }
        private void ShowOrderList()
        {
            String query = "SELECT foodname, quantity, foodprice, foodprice*quantity  AS total_price " +
                "from orderlist inner join foods on orderlist.foodid = foods.foodid where ordersid=" + this.orderId;
            db.ShowDt(query);
            listOrderGridView1.DataSource = db.dt;
            listOrderGridView1.Columns[0].HeaderCell.Value = "Tên món";
            listOrderGridView1.Columns[1].HeaderCell.Value = "Số lượng";
            listOrderGridView1.Columns[2].HeaderCell.Value = "Giá món";
            listOrderGridView1.Columns[3].HeaderCell.Value = "Tổng";
        }
        private void ToTalPriceOfBill()
        {
            String query = "SELECT foodprice*quantity  AS total_price " +
                "from orderlist inner join foods on orderlist.foodid = foods.foodid where ordersid=" + this.orderId;
            SqlDataReader reader = db.ExecuteReader(query);
            while (reader.Read())
            {
                totalpirce = totalpirce + Int32.Parse(reader["total_price"].ToString()); 
            }
        }
        private void ShowDetailOfBill()
        {
             
            Order order = new Order(this.orderId);
            txtName.Text = order.orderDic["customername"];
            txtStaff.Text= User.users["uname"];
            txtTime.Text = DateTime.Now.ToString("yyyy-MM-dd HH:00");
            txtTotal.Text = this.totalpirce.ToString();
        }
    }
}

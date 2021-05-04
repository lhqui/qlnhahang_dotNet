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
    public partial class AddFood : Form
    {
       // Order ord;
        private String foodId = "";
        private String orderId = "";
        private String uId = "";
        DBConnect db = new DBConnect();
        public AddFood(String orderId, String uid)
        {
            InitializeComponent();
            this.orderId = orderId;
            this.uId = uid;
            ShowAllFood();
        }


        private void ShowAllFood()
        {
            
            String query = "select foodid, foodname , foodprice ,kindname from  foods inner join foodkind  on foods.foodkind_id = foodkind.foodkind_id";
            db.ShowDt(query);
            foodDataGridView1.DataSource = db.dt;
            foodDataGridView1.Columns[0].HeaderCell.Value = "STT";
            foodDataGridView1.Columns[1].HeaderCell.Value = "Tên món";
            foodDataGridView1.Columns[2].HeaderCell.Value = "Giá";
            foodDataGridView1.Columns[3].HeaderCell.Value = "Loại";

        }
        private void GetFoddIdInCell()
        {
            int n = foodDataGridView1.CurrentCell.RowIndex;
            DataGridViewRow row = this.foodDataGridView1.Rows[n];
            this.foodId = row.Cells["foodid"].Value.ToString();
        }
        private void OnSearchchange(object sender, EventArgs e)
        {
            if (txtSearch.TextLength > 0)
            {
                lbSearch.Text = "Đang tìm Kiếm...";
                Search(txtSearch.Text);
                return;
            }
            else
            {
                lbSearch.Text = "Tìm Kiếm";
                ShowAllFood();
            }
        }
        private void Search(String searchString)
        {
            //select foodid as ID, foodname , foodprice ,kindname from  foods inner join foodkind  on foods.foodkind_id = foodkind.foodkind_id
            String columns = "foodid, foodname, foodprice, kindname";
            String afterFrom = "foods inner join foodkind on foods.foodkind_id = foodkind.foodkind_id";
            String query = db.SelectWhereLike(db.SelectColumn(columns, afterFrom), "foodname", searchString);
            db.ShowDt(query);
            foodDataGridView1.DataSource = db.dt;
            foodDataGridView1.Columns[0].HeaderCell.Value = "STT";
            foodDataGridView1.Columns[1].HeaderCell.Value = "Tên món";
            foodDataGridView1.Columns[2].HeaderCell.Value = "Giá";
            foodDataGridView1.Columns[3].HeaderCell.Value = "Loại";
        }

        private void OnClickAdd(object sender, EventArgs e)
        {
            GetFoddIdInCell();
            String[] arr = {this.orderId, this.foodId, this.uId, DateTime.Now.ToString("yyyy-MM-dd HH:MM"), txtQuantity.Text };
            String query = "insert into orderlist values "+ db.StringValue(arr);
            // Console.WriteLine(query);
            //MessageBox.Show(query);
            db.ExecuteNonQuery(query);
            if (db.count != 0)
            {
                MessageBox.Show("Đã Thêm món");
                this.Close();
            }
            else
            {
                MessageBox.Show("Đã Thêm món");
            }

        }

        private void CheckIsNumber(object sender, EventArgs e)
        {
            if(!int.TryParse(txtQuantity.Text, out _))
            {
                MessageBox.Show("Số lượng phải là số");
                txtQuantity.Text = "";
            }
        }
    }
}

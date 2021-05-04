using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.SqlClient;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace management
{
    public partial class Foods : Form
    {
        private string foodid = "";
        DBConnect db = new DBConnect();
        private Users user;
        public Foods(Users user)
        {
            InitializeComponent();
            this.user = user;
            ShowAllFood();
            GetFoodKind();
        }

        private int GetIndexlistBox()
        {
            int lstIndex = 0;
            if (cbKind.SelectedIndex == -1)
            {
                MessageBox.Show("Hãy chọn loại");
            }
            else
            {
                lstIndex = cbKind.SelectedIndex + 1;
            }
            return lstIndex;
        }

 
        public void Message(int count)
        {
            if (count != 0)
            {
                MessageBox.Show("Thành Công");
            } else
            {
                MessageBox.Show("Thất Bại");
            }
        }
        private Boolean IsExistInDb(String foodName)
        {
            DBConnect db = new DBConnect();
            String query = "Select * from foods where foodname='" + foodName + "'";
            db.Query(query);
            if(db.count > 0)
            {
                return true;
            }
            return false;
        }

        private void CheckIsNumber(object sender, EventArgs e)
        {
            if (!int.TryParse(txtPrice.Text, out _))
            {
                MessageBox.Show("Giá phải là số");
                txtPrice.Text = "";
            }
        }

        private void CheckIsString(object sender, EventArgs e)
        {
            if (int.TryParse(txtName.Text, out _))
            {
                MessageBox.Show("Tên không bao gồm số");
                txtName.Text = "";
            }
        }

        private void GetFoodIdInRow()
        {
            int n = foodDataGridView1.CurrentCell.RowIndex;
            DataGridViewRow row = this.foodDataGridView1.Rows[n];
            this.foodid = row.Cells["foodid"].Value.ToString();
        }
 
        public void ShowAllFood()
        {
            DBConnect db = new DBConnect();
            String query = "select foodid, foodname , foodprice ,kindname from  foods inner join foodkind  on foods.foodkind_id = foodkind.foodkind_id";
            db.ShowDt(query);
            foodDataGridView1.DataSource = db.dt;
            foodDataGridView1.Columns[0].HeaderCell.Value = "STT";
            foodDataGridView1.Columns[1].HeaderCell.Value = "Tên món";
            foodDataGridView1.Columns[2].HeaderCell.Value = "Giá";
            foodDataGridView1.Columns[3].HeaderCell.Value = "Loại";
        }

        private void Clear()
        {
            txtName.Text = "";
            txtPrice.Text = "0";
            cbKind.SelectedItem = null;
        }

   

        private void Refrs(object sender, EventArgs e)
        {
            ShowAllFood();
        }

        private void Search(String searchString)
        {
            DBConnect db = new DBConnect();
            //select foodid as ID, foodname , foodprice ,kindname from  foods inner join foodkind  on foods.foodkind_id = foodkind.foodkind_id
            String columns = "foodid, foodname, foodprice, kindname";
            String afterFrom = "foods inner join foodkind on foods.foodkind_id = foodkind.foodkind_id";
            String query = db.SelectWhereLike(db.SelectColumn(columns,afterFrom), "foodname", searchString);
            db.ShowDt(query);
            foodDataGridView1.DataSource = db.dt;
        }
        private void GetFoodKind()
        {
            DBConnect db = new DBConnect();
            String query = db.SelectColumn("","foodkind");
            SqlDataAdapter adap = db.FillAdapter(query);
            DataSet dt = new DataSet();
            adap.Fill(dt);
            if(dt.Tables[0].Rows.Count>0)
            {
                cbKind.DataSource = dt.Tables[0];
                cbKind.DisplayMember = "kindname";
                cbKind.ValueMember = "foodkind_id";
            } else
            {
                cbKind.Text = "not found";
            }
            
        }
        private void AddFoodToDb(object sender, EventArgs e)
        {
            //create string for attr and values
            int indexKind = GetIndexlistBox();
            string[] tableValues = { txtName.Text, txtPrice.Text, indexKind.ToString() };
            String query = "Insert into foods values" + db.StringValue(tableValues);
            // check conditions
            if (txtName.Text != "" && cbKind.Text != "")
            {
                if (IsExistInDb(txtName.Text) == true)
                {
                    MessageBox.Show("Món ăn đã tồn tại ");
                }
                else
                {
                    db.ExecuteNonQuery(query);
                    Message(db.count);
                    ShowAllFood();
                }
                //clear data input
                Clear();
                
            }
            else
            {
                txtPrice.Text = "";
            }

        }

        private void EditFood(object sender, EventArgs e)
        {
            FoodObject x = new FoodObject(this.foodid);


            if (x.GetValueFromDic("foodname") != txtName.Text || x.GetValueFromDic("foodkind") != txtPrice.Text || x.GetValueFromDic("foodkind") != cbKind.Text)
            {

                int indexKind = GetIndexlistBox();
                String afterSet = "foodname=N'" + txtName.Text + "', foodprice='" + txtPrice.Text + "',"
                    + " foodkind_id='" + indexKind.ToString() + "'";
                String afterWhere = "foodid = " + this.foodid;
                String query = "update foods set " + afterSet + " where " + afterWhere;
                db.ExecuteNonQuery(query);
                Message(db.count);
                ShowAllFood();
                //MessageBox.Show("difference");

            }
            else
            {
                MessageBox.Show("Thông tin chưa thay đổi");
            }
        }

        private void DeleteFood(object sender, EventArgs e)
        {
            GetFoodIdInRow();
            DialogResult diag = MessageBox.Show("Bạn  có muốn xóa", "Xóa", MessageBoxButtons.YesNo);
            String query = "delete from foods where foodid=" + this.foodid;
            if (diag == DialogResult.Yes && foodid != "")
            {
                db.ExecuteNonQuery(query);
                Message(db.count);
                Clear();
                ShowAllFood();
            }
            else
            {
                Clear();
            }

        }

        private void OnSearchchange(object sender, EventArgs e)
        {
            if (txtSearch.TextLength > 0)
            {
                lbSearch.Text = "Đang tìm Kiếm ...";
                Search(txtSearch.Text);
                return;
            }
            else
            {
                lbSearch.Text = "Tìm Kiếm";
                ShowAllFood();
            }
        }

        private void GetFoodInCell(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.foodDataGridView1.Rows[e.RowIndex];
                this.foodid = row.Cells["foodid"].Value.ToString();
                txtName.Text = row.Cells["FoodName"].Value.ToString();
                cbKind.Text = row.Cells["kindname"].Value.ToString();
                txtPrice.Text = row.Cells["FoodPrice"].Value.ToString();
            }
        }

        private void GetFoodInfor(object sender, EventArgs e)
        {
            FoodObject x = new FoodObject(this.foodid);

            MessageBox.Show(" Stt: " + x.GetValueFromDic("foodid")
                + "\n Tên thực phẩm: " + x.GetValueFromDic("foodname")
                + "\n Loại: " + x.GetValueFromDic("foodkind")
                + "\n Giá: " + x.GetValueFromDic("foodprice") + " vnđ");
        }

        private void ClearAllText(object sender, EventArgs e)
        {
            Clear();
        }

        private void ExistToMenu(object sender, EventArgs e)
        {
            this.Hide();
            Menu mn = new Menu(this.user);

            mn.StartPosition = FormStartPosition.CenterParent;
            mn.ShowDialog();
            this.Close();
        }
    }
}

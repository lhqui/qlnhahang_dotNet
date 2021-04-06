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
        FoodObject fo = new FoodObject();
        public Foods()
        {
            InitializeComponent();
            showdata();
            getFoodkind();
        }

        private void btnBack(object sender, EventArgs e)
        {
            this.Hide();
            Menu mn = new Menu();
            mn.ShowDialog();
            this.Close();
        }
        public int checkindexFoodKind(int index)
        {
            int indexReturn = 5;
            if (index == 1)
            {
                return indexReturn=6;
            } 
            return indexReturn;
        }
        private void btnAdd(object sender, EventArgs e)
        {
            //create string for attr and values
            int findindex = checkindexFoodKind(cbKind.SelectedIndex); 
            string[] tableValues = { txtName.Text, txtPrice.Text, findindex.ToString() };
            // check conditions
            if(txtName.Text != "" && cbKind.Text != "" && checkNum(txtPrice.Text)==true )
            {
                DBConnect dbc = new DBConnect();
               dbc.Insert("foods", dbc.convertStringValue(tableValues) );
                //MessageBox.Show(dbc.convertStringValue(tableValues));
                if (dbc.msg != "")
                {
                    MessageBox.Show(dbc.msg);
                }

                // use crtl k + c to comment all or ctrl k +u

                //clear data input
                Clear();
                showdata();
            } else
            {
                txtPrice.Text = "";
            }


        }



        private void rowSelected(object sender, DataGridViewCellEventArgs e)
        {
            //if (foodDataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            //{
            //    foodDataGridView1.CurrentRow.Selected = true;
            //}
            if (e.RowIndex >=0 )
            {
                DataGridViewRow row = this.foodDataGridView1.Rows[e.RowIndex];
                getIdfood(row.Cells["foodid"].Value.ToString());
                txtName.Text = row.Cells["FoodName"].Value.ToString();
                txtPrice.Text = row.Cells["FoodPrice"].Value.ToString();

                
            }
        }
        private string getIdfood(String selectedId)
        {
            return foodid=selectedId;
        }
        public void showdata()
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

        private void btnClear(object sender, EventArgs e)
        {
            Clear();
        }
        private void Clear()
        {
            txtName.Text = "";
            txtPrice.Text = "";
            cbKind.SelectedItem = null;
        }

        //private void FoodsLoad(object sender, EventArgs e)
        //{
        //    // TODO: This line of code loads data into the 'nhahangDataSet.foodkind' table. You can move, or remove it, as needed.
        //    //this.foodkindTableAdapter.Fill(this.nhahangDataSet.foodkind);
        //    showdata();
        //}

        private void Refrs(object sender, EventArgs e)
        {
            showdata();
        }
        //"DELETE FROM `foods` WHERE `foods`.`FOODID` = 6"
        private void btnDelete(object sender, EventArgs e)
        {
            DBConnect db = new DBConnect();
            DialogResult diag = MessageBox.Show("Bạn  có muốn xóa","Xóa", MessageBoxButtons.YesNo);
            if (diag == DialogResult.Yes && foodid!= "")
            {
                db.Delete("foods", "FOODID", this.foodid);
                //MessageBox.Show(db.testCmd);

                Clear();
                showdata();
            } else
            {
                Clear();
            }

        }
        private void btnOnchange(object sender, EventArgs e)
        {
            if (txtSearch.TextLength > 0)
            {
                lbSearch.Text = "Đang tìm Kiếm ...";
                Search(txtSearch.Text);
                return;
            } else 
            {
                lbSearch.Text = "Tìm Kiếm";
                showdata();
            }
        }
        private void Search(String searchString)
        {
            DBConnect db = new DBConnect();
            //select foodid as ID, foodname , foodprice ,kindname from  foods inner join foodkind  on foods.foodkind_id = foodkind.foodkind_id
            String columns = "foodid, foodname, foodprice, kindname";
            String afterFrom = "foods inner join foodkind on foods.foodkind_id = foodkind.foodkind_id";
            String query = db.selectWhereLike(db.SelectColumn(columns,afterFrom), "foodname", searchString);
            db.ShowDt(query);
            foodDataGridView1.DataSource = db.dt;
        }

        private bool checkNum(String checkValue)
        {
            int parValue;
            if (!int.TryParse(checkValue, out parValue))
            {
                MessageBox.Show(" giá phải là số!");
                return false;
            } else
            {
                return true;
            }
        }

        private void btnDouble_click(object sender, EventArgs e)
        {
            FoodObject x = new FoodObject();
            x = fo.getFoodInfor(this.foodid);
            MessageBox.Show( " Stt: "+ x.foodid +"\n Tên thực phẩm: " +x.foodName+ "\n Loại: " + x.foodKind + "\n Giá: " 
                + x.foodPrice + " vnđ");
        }

        private void getFoodkind()
        {
            DBConnect db = new DBConnect();
            String query = db.SelectAll("foodkind");
            SqlDataAdapter adap = db.fillAdapter(query);
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
    }
}

﻿using System;
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
    public partial class Staffs : Form
    {
        DBConnect db = new DBConnect();
        private bool isUsersShow = true;
        private Users user;
        private string userId = "";
        private string userName = "";
        public Staffs(Users user)
        {
            InitializeComponent();
            this.user = user;
            ShowDataToGridView();
            GetRoll();
        }

        private void btnBack(object sender, EventArgs e)
        {
            this.Hide();
            Menu mn = new Menu(this.user);
            mn.StartPosition = FormStartPosition.CenterParent;
            mn.ShowDialog();
            this.Close();
        }

        private void btnClick_Change(object sender, EventArgs e)
        {
         ChangePass cp = new ChangePass(this.userId);
         cp.Parent = Parent;
         cp.StartPosition = FormStartPosition.CenterParent;
         cp.ShowDialog();
           
        }

        private void btnClick_Regis(object sender, EventArgs e)
        {
            GetIdUserInCell();
            if(user.CheckPermission() == true)
            {
                ShiftRegis sr = new ShiftRegis(this.userId);
                sr.Parent = Parent;
                sr.StartPosition = FormStartPosition.CenterParent;
                sr.ShowDialog();
            } else
            {
                MessageBox.Show("Bạn không đủ quyền");
            }

        }

        private void ShowWorkShifts(object sender, EventArgs e)
        {
            if(isUsersShow == true)
            {
                isUsersShow = false;
                btnXemMK.Enabled = false;
                btnDoiMK.Enabled = false;
                btnDelete.Enabled = false;
                btnShift.Enabled = false;
                ShowDataToGridView();
            } else
            {
                ShowDataToGridView();
            }
           
        }
 

        private void ShowUsersList(object sender, EventArgs e)
        {
            if (isUsersShow == false)
            {
                isUsersShow = true;
                btnXemMK.Enabled = true;
                btnDoiMK.Enabled = true;
                btnDelete.Enabled = true;
                btnShift.Enabled = true;
                ShowDataToGridView();
            }
            else
            {
                ShowDataToGridView();
            }


        }

        private void SearchInStaff(object sender, EventArgs e)
        {
            Search();
        }
        private int GetIdexlistBox()
        {
            int lstIndex = 0;
            if( cbRollName.SelectedIndex == -1)
            {
                MessageBox.Show("Hãy chọn chức vụ");
            } else
            {
                lstIndex = cbRollName.SelectedIndex + 1;
            }
            return lstIndex;
        }
        private bool UserIsExist(String username)
        {
            String query = "Select * from staffs where username= '" + username + "'";
            db.Query(query);
            if(db.count > 0)
            {
                return true;
            }
            return false;
        }
        private void Message(int count)
        {
            if (count != 0)
            {
                MessageBox.Show("Thành công");
            } else
            {
                MessageBox.Show("Thất bại");
            }
        }
        private void AddUser(object sender, EventArgs e)
        {
            String rollIndex = cbRollName.SelectedValue.ToString();
            String[] arr = { txtAcc.Text, txtPass.Text, txtName.Text, rollIndex };
            String queryValue = db.StringValue(arr);
            String query = "insert into staffs values " + queryValue;
            if (txtAcc.Text != "" && txtName.Text != "" && txtPass.Text != "")
            {
                if(UserIsExist(txtAcc.Text) == false)
                {
                    db.ExecuteNonQuery(query);
                   Message(db.count);
                    // MessageBox.Show(query);
                    clear();
                    ShowDataToGridView();

                } else
                {
                    MessageBox.Show("Tài khoản đã tồn tại");
                }
            } else
            {
                MessageBox.Show("Xin hãy điền hết");
            }

        }

        private void GetRoll()
        {
            DBConnect db = new DBConnect();
            String query = db.SelectColumn("", "staffroll");
            SqlDataAdapter adap = db.FillAdapter(query);
            DataSet dt = new DataSet();
            adap.Fill(dt);
            if (dt.Tables[0].Rows.Count > 0)
            {
                cbRollName.DataSource = dt.Tables[0];
                cbRollName.DisplayMember = "rollname";
                cbRollName.ValueMember = "rollid";
            }
            else
            {
                cbRollName.Text = "not found";
            }
        }

        private void CellClick(object sender, DataGridViewCellEventArgs e)
        {
            GetIdUserInCell();
        }
        private void GetIdUserInCell()
        {
            if(isUsersShow == true)
            {
                int n = dataUserGridView1.CurrentCell.RowIndex;
                DataGridViewRow row = this.dataUserGridView1.Rows[n];
                userId = row.Cells["staffid"].Value.ToString(); ;
            } 

        }
        private bool CountUserFromDb()
        {
            String query = "select count(*) from staffs";
            int n= db.CountAllRow(query);
            if(n>1)
            {
                return true;
            }
            return false;
        }

        private void DeleteUser(object sender, EventArgs e)
        {
            GetIdUserInCell();
            String query = "delete from staffs where staffid=" + this.userId;
<<<<<<< HEAD
            String queryDeleteFk = "delete from SHIFT where STAFFID = " + this.userId;
            String queryDeleteFk1 = "delete from ORDERLIST where STAFFID = " + this.userId;
            String queryDeleteFk2 = "delete from BILLS where STAFFID = " + this.userId;
            if (CountUserFromDb() == true  && user.OriginlUser(this.userId) == false)
            {
                // MessageBox.Show(query);
                Console.WriteLine(query);
                db.ExecuteNonQuery(queryDeleteFk);
                db.ExecuteNonQuery(queryDeleteFk1);
                db.ExecuteNonQuery(queryDeleteFk2);
=======
            String queryDeleteFkShift = "delete from SHIFT where STAFFID = " + this.userId;
            String queryDeleteFkOrderList = "delete from orderlist where STAFFID = " + this.userId;
            String queryDeleteFkBill = "delete from bills where STAFFID = " + this.userId;
            if (CountUserFromDb() == true  && user.OriginlUser(this.userId) == false)
            {
                // MessageBox.Show(query);
                db.ExecuteNonQuery(queryDeleteFkShift);
                db.ExecuteNonQuery(queryDeleteFkOrderList);
                db.ExecuteNonQuery(queryDeleteFkBill);
>>>>>>> 03fcc5b302c2f31a9463115628320b8fe530e487
                db.ExecuteNonQuery(query);
                Message(db.count);
                clear();
                ShowDataToGridView();


            } else
            {
                MessageBox.Show("Không thể xóa tài khoản này");
            }
            //MessageBox.Show(this.userId);
        }

        private void ViewPassword(object sender, EventArgs e)
        {
           GetIdUserInCell();
            Users us = new Users(this.userId);
            MessageBox.Show("Mật khẩu là: " + us.users["password"]);
        }
        private void ShowDataToGridView()
        {
            //dataUserGridView1.DataSource = null;
            if(isUsersShow == true)
            {
                String query = "select staffid, staffname, rollname from staffs inner join staffroll " +
                 "on staffs.rollid = staffroll.rollid"; 
                db.ShowDt(query);
                //db.ShowDt(query);
                dataUserGridView1.DataSource = db.dt;
               // dataUserGridView1.AutoGenerateColumns = false;
                dataUserGridView1.Columns[0].HeaderCell.Value = "STT";
                dataUserGridView1.Columns[0].Visible = false;
                dataUserGridView1.Columns[1].HeaderCell.Value = "Họ tên";
                dataUserGridView1.Columns[2].HeaderCell.Value = "Chức vụ";

            } else
            {
                String today = DateTime.Now.ToString("MM/dd/yyyy");
                String daysInMonth = DateTime.DaysInMonth(DateTime.Now.Year, DateTime.Now.Month).ToString();
                String lastDayInMonth = DateTime.Now.ToString("MM") + "/" + daysInMonth + "/"
                    + DateTime.Now.ToString("yyyy");
                //MessageBox.Show(today + "; " +lastDayInMonth);
                String query = "select staffname, startime, endtime from shift inner join staffs on shift.staffid = staffs.staffid" +
                    "  where startime between '"
                    + today + "' and '"
                    + lastDayInMonth + "'";       
                db.ShowDt(query);
                dataUserGridView1.DataSource = db.dt;
                dataUserGridView1.Columns[0].HeaderCell.Value = "Tên Nhân viên";
                dataUserGridView1.Columns[1].HeaderCell.Value = "Ca bắt đầu";
                dataUserGridView1.Columns[2].HeaderCell.Value = "Ca kết thúc";
            }
        }
        private void Search()
        {
             if (isUsersShow == true)
                {
                    String queryStaff = "select staffid, staffname, rollname from staffs inner join staffroll "
                        + "on staffs.rollid = staffroll.rollid where staffid like N'%"
                        + txtSearch.Text + "%'"
                        + " or staffname like N'%" + txtSearch.Text + "%' or rollname like N'%"
                        + txtSearch.Text + "%'";
                    db.ShowDt(queryStaff);
                    dataUserGridView1.DataSource = db.dt;
                    dataUserGridView1.Columns[0].HeaderCell.Value = "STT";
                    dataUserGridView1.Columns[0].Visible = false;
                    dataUserGridView1.Columns[1].HeaderCell.Value = "Họ tên";
                    dataUserGridView1.Columns[2].HeaderCell.Value = "Chức vụ";
                } else
                {

                    String queryShift = "select staffname, startime, endtime from shift inner join staffs "
                               + "on shift.staffid = staffs.staffid where staffname like N'%"
                               + txtSearch.Text + "%'"
                               + " or startime like N'%" + txtSearch.Text + "%' or endtime like N'%"
                               + txtSearch.Text + "%'";
                    db.ShowDt(queryShift);
                    dataUserGridView1.DataSource = db.dt;
                    dataUserGridView1.Columns[0].HeaderCell.Value = "Tên Nhân viên";
                    dataUserGridView1.Columns[1].HeaderCell.Value = "Ca bắt đầu";
                    dataUserGridView1.Columns[2].HeaderCell.Value = "Ca kết thúc";
                }
       

        }
        private void clear()
        {
            txtAcc.Text = "";
            txtName.Text = "";
            txtPass.Text = "";
        }
    }
}

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
    public partial class ShiftRegis : Form
    {
        private String userId;
        public ShiftRegis(String userId)
        {
            InitializeComponent();
            this.userId = userId;
        }

        private void OnClick_Regis(object sender, EventArgs e)
        {
            if(cbStartTime.Text !="" && cbEndTime.Text != "")
            {
                DBConnect db = new DBConnect();
                String startTime = workDatepicker.Value.ToString("yyyy-MM-dd") + " " + cbStartTime.Text + ":00";
                String endTime = workDatepicker.Value.ToString("yyyy-MM-dd") + " " + cbEndTime.Text + ":00";
                //Kiem tra ca lam co trung
                String queryCheck = "select * from shift where staffid=" + this.userId + " and startime='"
                    + startTime + "' and endtime='" + endTime + "'";
                db.Query(queryCheck);
                if (db.count > 0)
                {
                    MessageBox.Show("Ca làm đã được đăng ký");
                }
                else
                {
                    // dang ky ca lam vao db
                    String[] arr = { this.userId, startTime, endTime };
                    String insertValue = db.StringValue(arr);
                    String queryInsert = "insert into shift values " + insertValue;
                    db.ExecuteNonQuery(queryInsert);
                    if (db.count != 0)
                    {
                        cbStartTime.Items.Clear();
                        cbEndTime.Items.Clear();
                        MessageBox.Show("Đăng ký thành công");
                    }
                    else
                    {
                        MessageBox.Show("Đăng ký thất bại");
                    }
                }
                
            } else
            {
                MessageBox.Show("Xin Chọn ca làm!");
            }
 
            //MessageBox.Show(query);
            //Console.WriteLine(queryCheck);
            
        }



        private void OnClick_Starttime(object sender, EventArgs e)
        {
            cbStartTime.Items.Clear();
            cbEndTime.Items.Clear();
               
            int currentHour = Int32.Parse(DateTime.Now.ToString("HH"));
            // 15 tieng co the lam trong 21 tieng 
            if (workDatepicker.Value.Date >= DateTime.Now.Date)
            {
               if(workDatepicker.Value.Date == DateTime.Now.Date && currentHour > 21)
                {
                    MessageBox.Show("Đã hết ca làm !");
                } else if (workDatepicker.Value.Date == DateTime.Now.Date)
                {
                    for (int i = currentHour+1; i <= 21; i++)
                    {
                        cbStartTime.Items.Add(i);
                    }
                } else
                {
                    for (int i = 8; i <= 21; i++)
                    {
                        cbStartTime.Items.Add(i);
                    }
                }
            } else
            {
                MessageBox.Show("Ngày Không thể đăng ký thêm!");
            }
        }

        private void OnClick_EndShift(object sender, EventArgs e)
        {
            String selectStartTime = cbStartTime.Text;
            cbEndTime.Items.Clear();
            //workHours.Clear();

            if (selectStartTime != "") 
            {
                // lay value cua starttime
                for (int i = Int32.Parse(selectStartTime) + 1; i <= 22; i++)
                {
                    cbEndTime.Items.Add(i);
                };
            } else
            {
                MessageBox.Show("Hay chon ca bat dau");
            }


        }

        private void OnClick_Cancel(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnClear_listbox(object sender, EventArgs e)
        {

            cbStartTime.Items.Clear();
            cbEndTime.Items.Clear();
        }
    }
}

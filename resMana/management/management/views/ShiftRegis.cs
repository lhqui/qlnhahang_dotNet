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
        LinkedList<int> workHours = new LinkedList<int>();
        LinkedList<int> listEndtime = new LinkedList<int>();
        private String userId;
        public ShiftRegis(String userId)
        {
            InitializeComponent();
            this.userId = userId;
        }

        private void OnClick_Regis(object sender, EventArgs e)
        {
            DBConnect db = new DBConnect();
            String startTime = workDatepicker.Value.ToString("yyyy-MM-dd") + " " + cbStartTime.Text + ":00";
            String endTime = workDatepicker.Value.ToString("yyyy-MM-dd") + " " + cbEndTime.Text + ":00";
            //Kiem tra ca lam co trung
            String queryCheck = "select * from shift where staffid=" + this.userId + " and startime='"
                + startTime + "' and endtime='" + endTime + "'";
            db.Query(queryCheck);
            if(db.count > 0)
            {
                MessageBox.Show("Ca da duoc dang ky");
            } else
            {
                // dang ky ca lam vao db
                String[] arr = { this.userId, startTime, endTime };
                String insertValue = db.StringValue(arr);
                String queryInsert = "insert into shift values " + insertValue;
                db.ExecuteNonQuery(queryInsert);
                if (db.count != 0)
                {
                    MessageBox.Show("dang ki thanh cong");
                }
                else
                {
                    MessageBox.Show("khong dang ky duoc");
                }
            }
            //MessageBox.Show(query);
            Console.WriteLine(queryCheck);
            
        }


        private void OnClick_Starttime(object sender, EventArgs e)
        {
            int currentHour = Int32.Parse(DateTime.Now.ToString("HH"));
            // 15 tieng co the lam trong 21 tieng
            cbEndTime.Items.Clear();
            cbStartTime.Items.Clear();
            workHours.Clear();
            
            if (workDatepicker.Value.Date == DateTime.Now.Date && currentHour > 10)
            {
                MessageBox.Show("Hom nay da het ca dang ki");
            } else
            {
                if (workDatepicker.Value.Date == DateTime.Now.Date)
                {
                    for (int i = 8; i <= 21; i++)
                    {
                        if (currentHour < i)
                        {
                            //Console.WriteLine(Starthour);
                            workHours.AddLast(i);
                        }
                        //  Starthour++;
                    }
                }
                else
                {
                    //listStart.Items.Clear();
                    for (int i = 8; i <= 21; i++)
                    {
                        workHours.AddLast(i);
                    }
                }
                foreach (int num in workHours)
                {
                    cbStartTime.Items.Add(num);
                    //Console.WriteLine(num);
                }
            }




        }

        private void OnClick_EndShift(object sender, EventArgs e)
        {
            String selectStartTime = cbStartTime.Text;
            listEndtime.Clear();

            // lay value cua starttime
            for (int i= Int32.Parse(selectStartTime) + 1; i <= 22 ; i ++)
                {
                    listEndtime.AddLast(i);
                }
                foreach (int num in listEndtime) {
                    cbEndTime.Items.Add(num);
                }
               // MessageBox.Show(selectStartTime);

        }

        private void OnClick_Cancel(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnClear_listbox(object sender, EventArgs e)
        {
            workHours.Clear();
            listEndtime.Clear();
            cbStartTime.Items.Clear();
            cbEndTime.Items.Clear();
        }
    }
}

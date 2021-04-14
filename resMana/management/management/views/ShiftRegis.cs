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
        public ShiftRegis()
        {
            InitializeComponent();
        }

        private void btnClick_Regis(object sender, EventArgs e)
        {
            // DBConnect db = new DBConnect();
            //String tableValue = "";
            //CacheStore cache = new CacheStore();
            String valueId = CacheStore.GetItemsFromCache();
            //MessageBox.Show(db.staffId);
            string query = workDatepicker.Value.Date + ";" + listStart.GetItemText(listStart.SelectedItem) + ";" 
                + listEnd.GetItemText(listEnd.SelectedItem);
            if (valueId == "1")
            {
                MessageBox.Show(query);
                //MessageBox.Show("u are admin");
            }
            else {
                MessageBox.Show("Bạn Không đủ quyền");
                
            }
           // String query = db.Insert("shift", "");
            
        }

        private void btnClick_Starttime(object sender, EventArgs e)
        {
            int currentHour = Int32.Parse(DateTime.Now.ToString("HH"));
           // int Starthour = 8;
            // 15 tieng co the lam trong 21 tieng
            
            if (workDatepicker.Value.Date == DateTime.Now.Date) {
               // workHours.Clear();
                //listStart.Items.Clear();
                for (int i = 8; i <= 21; i++)
                {
                    if (currentHour < i)
                    {
                        //Console.WriteLine(Starthour);
                        workHours.AddLast(i);
                    }

                  //  Starthour++;

                }
            } else
            {
                //listStart.Items.Clear();
                for (int i=8; i <=21; i++)
                {
                    workHours.AddLast(i);
                }
            }
            foreach(int num in workHours) {
                listStart.Items.Add(num);
                //Console.WriteLine(num);
            }

        }

        private void btnClick_EndShift(object sender, EventArgs e)
        {
            String selectStartTime = "";
            
            if ( listStart.Items.Count > 0)
            {
                // lay value cua starttime
                for (int i=0; i< listStart.Items.Count; i++) {
                    if(selectStartTime == "")
                    {
                        selectStartTime = listStart.Items[i].ToString();
                    }
                }
                // lay so h toi thieu co the lam dc
                for (int i= Int32.Parse(selectStartTime) + 1; i <= 22 ; i ++)
                {
                    listEndtime.AddLast(i);
                }
                foreach (int num in listEndtime) {
                    listEnd.Items.Add(num);
                }
               // MessageBox.Show(selectStartTime);
                
            } else
            {
                MessageBox.Show("Hãy chọn giờ bắt đầu");
            }
        }

        private void btnClick_Cancel(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnClear_listbox(object sender, EventArgs e)
        {
            workHours.Clear();
            listEndtime.Clear();
            listStart.Items.Clear();
            listEnd.Items.Clear();
        }
    }
}

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
    public partial class Total : Form
    {
        private bool isBillShow = true;
        DBConnect db = new DBConnect();
        public Total()
        {
            InitializeComponent();
            ShowAllData();
        }

        private void GetTotalBills(object sender, EventArgs e)
        {
            if(isBillShow == false)
            {
                isBillShow = true;
                ShowAllData();
            } else
            {
                ShowAllData();
            }
        }
        private void ShowAllData()
        {
            totalDataGridView1.DataSource = null;
            if(isBillShow == true)
            {
                String query = "select billsid, ordersid, staffname, closetime, totalprice " +
                    " from bills inner join staffs on bills.staffid = staffs.staffid";
                db.ShowDt(query);
                totalDataGridView1.DataSource = db.dt;
                totalDataGridView1.Columns[0].HeaderCell.Value = "STT";
                totalDataGridView1.Columns[1].HeaderCell.Value = "Mã order";
                totalDataGridView1.Columns[2].HeaderCell.Value = "Tên nhân viên";
                totalDataGridView1.Columns[3].HeaderCell.Value = "Thời gian";
                totalDataGridView1.Columns[4].HeaderCell.Value = "Tổng Giá";

            } else
            {
                String query = "select staffname, startime, endtime from shift " +
                    "inner join staffs on shift.staffid = staffs.staffid";
                db.ShowDt(query);
                totalDataGridView1.DataSource = db.dt;
                totalDataGridView1.Columns[0].HeaderCell.Value = "Tên nhân viên";
                totalDataGridView1.Columns[1].HeaderCell.Value = "Ca bắt đầu";
                totalDataGridView1.Columns[2].HeaderCell.Value = "Ca kết thúc";
            }
        }

        private void GetAllShifts(object sender, EventArgs e)
        {
            if (isBillShow == true)
            {
                isBillShow = false;
                ShowAllData();
            }
            else
            {
                ShowAllData();
            }
        }

        private void Exit(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

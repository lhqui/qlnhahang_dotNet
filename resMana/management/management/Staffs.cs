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
    public partial class Staffs : Form
    {
        DBConnect db = new DBConnect();
        private string staffid = "";
        public Staffs()
        {
            InitializeComponent();
            //showData();
        }
        public void showData()
        {
            String[] arr = { "staffid", " staffname", "staffroll" };
            String columnName = db.StringColumnName(arr);
            String query = db.SelectColumn(columnName,"staffs");
            db.ShowDt(query);
            dataUserGridView1.DataSource = db.dt;
            dataUserGridView1.Columns[0].HeaderCell.Value = "Stt";
            dataUserGridView1.Columns[1].HeaderCell.Value = "Họ Tên";
            dataUserGridView1.Columns[2].HeaderCell.Value = "Chức vụ";
        }
        
        private void btnBack(object sender, EventArgs e)
        {
            this.Hide();
            Menu mn = new Menu();
            mn.ShowDialog();
            this.Close();
        }

        private void onClickCell(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dataUserGridView1.Rows[e.RowIndex];
                getStaffid(row.Cells["staffid"].Value.ToString());
                txtName.Text = row.Cells["staffname"].Value.ToString();
                txtRoll.Text = row.Cells["staffroll"].Value.ToString();
            }
        }
        private String getStaffid(String staffid) {
            return this.staffid = staffid;
        }
        private void insertUser()
        {
            String[] arr = {txtName.Text, txtAcc.Text, txtPass.Text, txtRoll.Text};
        }

        private void btnClick_Change(object sender, EventArgs e)
        {
            ChangePass cp = new ChangePass();
            cp.Parent = Parent;
            cp.StartPosition = FormStartPosition.CenterParent;
            cp.ShowDialog();
        }

        private void btnClick_Regis(object sender, EventArgs e)
        {
            ShiftRegis sr = new ShiftRegis();
            sr.Parent = Parent;
            sr.StartPosition = FormStartPosition.CenterParent;
            sr.ShowDialog();
        }
    }
}

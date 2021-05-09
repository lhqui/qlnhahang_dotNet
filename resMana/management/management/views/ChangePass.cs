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
    public partial class ChangePass : Form
    {
        private String userId;
       
        public ChangePass(String userId)
        {
            InitializeComponent();
            this.userId = userId;
            //this.user = user;
        }

        private void btnClick_Change(object sender, EventArgs e)
        {
            DBConnect db = new DBConnect();
            if(txtPass1.Text == txtPass2.Text && txtPass1.Text != "" && txtPass2.Text !="")
            {
                String query = "update staffs set password=N'" + txtPass2.Text + "' where staffid=" + this.userId;
                db.ExecuteNonQuery(query);
                if(db.count != 0)
                {
                    MessageBox.Show("Thành công");
                } else
                {
                    MessageBox.Show("Thất bại");
                }
            } else
            {
                MessageBox.Show("Mật khẩu không trùng khớp");
            }
            //this.Hide();
            //Staffs st = new Staffs();
            //st.ShowDialog();
            this.Close();
        }
    }
}

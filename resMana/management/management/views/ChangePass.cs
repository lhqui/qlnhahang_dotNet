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
        private String userId = "";
       
        public ChangePass(String userId)
        {
            InitializeComponent();
            this.userId = "";
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
                    MessageBox.Show("Thanh Cong");
                } else
                {
                    MessageBox.Show("That bai");
                }
            } else
            {
                MessageBox.Show("mat khau khong giong nhau");
            }
            //this.Hide();
            //Staffs st = new Staffs();
            //st.ShowDialog();
            this.Close();
        }
    }
}

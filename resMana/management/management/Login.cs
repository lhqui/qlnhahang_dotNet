using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using MySql.Data.MySqlClient;

namespace management
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btnLogin(object sender, EventArgs e)
        {
            if (txtPass.Text != "" && txtUser.Text != "")
            {
                Users us = new Users();
                if (us.Login(txtUser.Text.ToString(), txtPass.Text.ToString()) == true)
                {
                    this.Hide();
                    Menu mn = new Menu();
                    mn.ShowDialog();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("User or Password not true!");
                }
            } else
            {
                MessageBox.Show("User or Password are blank!");
            }
        }

        private void hideText(object sender, EventArgs e)
        {
            txtPass.Text = "";
            txtPass.ForeColor = Color.Black;
            txtPass.PasswordChar = '*';
        }

        private void btnHide(object sender, EventArgs e)
        {
                txtPass.Text = "";
                txtPass.ForeColor = Color.Black;
                txtPass.PasswordChar = '*';
        }
        private void txtPassLeave(object sender, EventArgs e)
        {

        }
    }
}

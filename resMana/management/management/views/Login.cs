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
                object user = Users.Login(txtUser.Text.ToString(), txtPass.Text.ToString());
               // Users us = new Users();
                if ( user is Users)
                {
                    this.Hide();
                    Menu mn = new Menu((Users) user);
                    mn.Parent = Parent;
                    mn.StartPosition = FormStartPosition.CenterParent;
                    mn.ShowDialog();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Tên người dùng hoặc mật khẩu không chính xác!");
                }
            } else
            {
                MessageBox.Show("Vui lòng điền đầy đủ vào form!");
            }
        }



        private void btnHide(object sender, EventArgs e)
        {

                txtPass.ForeColor = Color.Black;
                txtPass.PasswordChar = '*';
        }
        public void HidePass()
        {
            txtPass.PasswordChar = '*';
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}

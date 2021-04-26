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
    public partial class GetCustomeInfo : Form
    {
        String tableId = "";
        DBConnect db = new DBConnect();
        public GetCustomeInfo(String tableId)
        {
            InitializeComponent();
            this.tableId = tableId;
        }

        private void CreateNewOrder(object sender, EventArgs e)
        {
            String[] queryValues = {this.tableId, txtNote.Text, DateTime.Now.ToString("yyyy-MM-dd HH:mm"), txtCusName.Text};
            String query = "insert into orders values " + db.StringValue(queryValues);
            // Console.WriteLine(query);
            db.ExecuteNonQuery(query);
            if (db.count != 0)
            {
                String tableStatusChange = "update tablest set statusid=2 where tableid=" + this.tableId;
                db.ExecuteNonQuery(tableStatusChange);
                MessageBox.Show("Đã thêm bàn");
                this.Close();
            }
            else
            {
                MessageBox.Show("không thể thêm");
            }
        }
    }
}

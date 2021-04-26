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
    public partial class SelectTable : Form
    {
        String tableId = "";
        String orderId = "";
        DBConnect db = new DBConnect();

        public SelectTable(String orderId = null)
        {
            InitializeComponent();
            CheckAction(orderId);
            ShowTable();
        }
        private void CheckAction(String orderId = null)
        {
            if(orderId != null )
            {
                this.orderId = orderId;
                btnChoose.Enabled = false;
                btnChange.Enabled = true;
            } else
            {
                btnChoose.Enabled = true;
                btnChange.Enabled = false;
            }
        }
        private void ShowTable()
        {
            String query = "select tableid, tablename, tableschair, status from " +
                "tablest inner join tablestatus on tablest.statusid = tablestatus.statusid where status=N'Trống'";
            db.ShowDt(query);
            dataTableGridView1.DataSource = db.dt;
            dataTableGridView1.Columns[0].HeaderCell.Value = "STT";
            dataTableGridView1.Columns[1].HeaderCell.Value = "Tên bàn";
            dataTableGridView1.Columns[2].HeaderCell.Value = "Số ghế";
            dataTableGridView1.Columns[3].HeaderCell.Value = "Trạng thái";
        }

        private void ExitToOrder(object sender, EventArgs e)
        {
            this.Close();
        }
        private void GetIdTableInCell()
        {
            int n = dataTableGridView1.CurrentCell.RowIndex;
            DataGridViewRow row = this.dataTableGridView1.Rows[n];
            tableId = row.Cells["tableid"].Value.ToString(); ;
        }

        private void GetTable(object sender, DataGridViewCellEventArgs e)
        {
            GetIdTableInCell();
        }



        private void GetCustomInfor(object sender, EventArgs e)
        {
            GetIdTableInCell();
            GetCustomeInfo gt = new GetCustomeInfo(this.tableId);
            gt.Parent = Parent;
            gt.StartPosition = FormStartPosition.CenterParent;
            gt.ShowDialog();
            this.Close();
        }

        private void ChangeTable(object sender, EventArgs e)
        {
            GetIdTableInCell();
            Order od = new Order(this.orderId);
            String updateTable = od.orderDic["tableid"];
            String queryUpdateOrderTable = "update orders set tableid="+ this.tableId 
                +" where ordersid=" + this.orderId;
            db.ExecuteNonQuery(queryUpdateOrderTable);
            if(db.count != 0)
            {
                String queryUpdateTableStatus = "update tablest set statusid=1 where tableid=" + updateTable;
                String queryUpdateOldTableStatus = "update tablest set statusid=2 where tableid=" + this.tableId;
                db.ExecuteNonQuery(queryUpdateTableStatus);
                db.ExecuteNonQuery(queryUpdateOldTableStatus);

                MessageBox.Show("Đã đổi bàn");
                this.Close();
            } else
            {
                MessageBox.Show("Không thể đổi");
            }

        }
    }
}

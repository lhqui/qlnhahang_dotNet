using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace management
{
    class Order
    {
        DBConnect db = new DBConnect();
        public Dictionary<string, string> orderDic = new Dictionary<string, string>();

        public Order(String orderId)
        {
            String query = "select * from orders where ordersid=" + orderId;
            SqlDataReader reader = db.ExecuteReader(query);
            while (reader.Read())
            {
                orderDic.Add("ordersid", reader["ordersid"].ToString());
                orderDic.Add("tableid", reader["tableid"].ToString());
                orderDic.Add("ordernote", reader["ordernote"].ToString());
                orderDic.Add("opentime", reader["opentime"].ToString());
                orderDic.Add("customername", reader["customername"].ToString());
            }
        }
    }
}

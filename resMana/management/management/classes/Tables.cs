using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace management
{
    class Tables
    {
        DBConnect db = new DBConnect();
        public Dictionary<string, string> tableDic = new Dictionary<string, string>();

        public Tables(String orderId)
        {
            String query = "select * from tablest where tableid=" + orderId;
            SqlDataReader reader = db.ExecuteReader(query);
            while (reader.Read())
            {
                tableDic.Add("tableid", reader["tableid"].ToString());
                tableDic.Add("tablename", reader["tablename"].ToString());
                tableDic.Add("tableschair", reader["tableschair"].ToString());
                tableDic.Add("statusid", reader["statusid"].ToString());
            }
        }
    }
}

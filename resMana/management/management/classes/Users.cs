using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Runtime.Caching;

namespace management
{
    class Users
    {
        private string Uid { get; set; }
        public string uname { get; set; }
        public string password { get; set; }
        public string staffname { get; set; }
        public string staffroll { get; set; }
        public string positon { get; set; }
        DBConnect db = new DBConnect();

        public Users getUserInfor(string staffid)
        {
            Users us = new Users();
            String columns = "staffid, staffname, staffroll";
            String afterFrom = "staffs staffid=" + staffid;
            String query = db.SelectColumn(columns,afterFrom);

            SqlDataReader dtRead = db.ExecuteReader(query);
            while (dtRead.Read())
            {
                us.Uid = dtRead["staffid"].ToString();
                us.staffname = dtRead["staffname"].ToString();
                us.staffroll = dtRead["staffroll"].ToString();
                
            }
            dtRead.Close();

            return us;
        }
        public bool Login(String uname, String password)
        {
            Boolean allow = false;
            string query = "SELECT * FROM STAFFS WHERE USERNAME='" + uname + "' AND PASSWORD='" + password + "'";
            Users user = new Users();
            int a = db.ExecuteNon(query);
            if ( a != 0)
            {
                SqlDataReader data = db.ExecuteReader(query);
                while (data.Read())
                {
                   // db.staffId = data["staffid"].ToString();
                    if( data["rollid"].ToString() == "1" )
                    {
                        CacheStore cache = new CacheStore();
                        cache.storeItemInCache(data["rollid"].ToString());
                    } 
                }
                return allow = true;
            }
            return allow;
        }

    }
}

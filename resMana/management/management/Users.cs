using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace management
{
    class Users
    {
        private string Uid { get; set; }
        public string uname { get; set; }
        public string password { get; set; }

        public string positon { get; set; }
        DBConnect db = new DBConnect();

        public bool Login(String uname, String password)
        {
            Boolean allow = false;
            string query = "SELECT * FROM STAFFS WHERE USERNAME='" + uname + "' AND PASSWORD='" + password + "'";
            Users user = new Users();
            int a = db.ExecuteNon(query);
            if ( a != 0)
            {
                return allow = true;
            }
            return allow;
        }

    }
}

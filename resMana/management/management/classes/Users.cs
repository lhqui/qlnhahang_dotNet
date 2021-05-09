using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Runtime.Caching;

namespace management
{
     public class Users
    {
        private static String uId = "";
        public Dictionary<String, String> users = new Dictionary<string, string>();
        private LinkedList<int> startShift = new LinkedList<int>();
        private LinkedList<int> endShift = new LinkedList<int>();
        public Dictionary<int, int> workHoursOfUser = new Dictionary<int, int>();
        DBConnect db = new DBConnect();

        public Users(string staffid)
        {

            String query = "select * from staffs where staffid='" + staffid + "'";
            SqlDataReader reader = db.ExecuteReader(query);
            while (reader.Read())
            {
                users.Add("uid", reader["staffid"].ToString());
                users.Add("uname", reader["staffname"].ToString());
                users.Add("rollid", reader["rollid"].ToString());
                users.Add("password", reader["password"].ToString());
            }

        }
        public static object Login(String uname, String password)
        {
            DBConnect db = new DBConnect();
            
            string query = "SELECT * FROM STAFFS WHERE USERNAME='" + uname + "' AND PASSWORD='" + password + "' ";
            //Console.WriteLine(query);
           
            db.Query(query);
            if (db.count > 0)
            {
                SqlDataReader reader = db.ExecuteReader(query);
                while (reader.Read())
                {
                    uId = reader["staffid"].ToString();
                    // Console.WriteLine(uId);
                }
                return new Users(uId);
            }
               // Console.WriteLine(query)
            return false;
        }
        
        public bool OriginlUser(String userId)
        {
            Users us = new Users(userId);
            if(us.users["uid"] == "1")
            {
                return true;
            }
            return false;
        }
        public bool CheckPermission()
        {
            if(  users["rollid"] == "1" )
            {
                return true;
            }
            return false;
        }
        public bool CheckIsWorkingHour(String uId)
        {

            GetStartHoursFromDb(uId);

            // kiem tra ca thu 1
            int size = startShift.Count;
            Console.WriteLine(size.ToString());
            for (int i=0; i<size; i++)
            {
                int starTime = startShift.ElementAt(i);
                int endTime = endShift.ElementAt(i);
                int currentime = int.Parse(DateTime.Now.ToString("HH"));
                if (currentime >= 22)
                {
                    return false;
                } else if(starTime <= currentime && currentime <= endTime)
                {
                    //Console.WriteLine(starTime);
                    //Console.WriteLine(endTime);
                    return true;
                } 
              
            }
            return false;
        }
   
        public void GetStartHoursFromDb(String uId)
        {
            workHoursOfUser.Clear();
            String todayTime = DateTime.Now.ToString("yyyy-MM-dd HH:MM");
            String query = "select CONVERT(VARCHAR(5),startime,108) AS [TimeStart], CONVERT(VARCHAR(5),endtime,108) AS [TimeEnd] " +
                "from shift where staffid="+uId+" and startime>='"+ todayTime+"'";
           // Console.WriteLine(todayTime);
            //Console.WriteLine(query);
           db.Query(query);
            if(db.count > 0)
            {
                SqlDataReader reader = db.ExecuteReader(query);
                while(reader.Read())
                {
                    startShift.AddLast(int.Parse(reader["TimeStart"].ToString().Substring(0, 2)));
                    endShift.AddLast(int.Parse(reader["TimeEnd"].ToString().Substring(0, 2)));
                }

            }
        }


    }
}

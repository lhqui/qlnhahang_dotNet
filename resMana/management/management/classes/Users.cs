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
        public LinkedList<String> startHours = new LinkedList<string>();
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
        public bool CheckIsWorkingHour()
        {
            int m = 0;
            //int j = 0;
            foreach(String n in startHours)
            {
                workHoursOfUser.Add(m, Int32.Parse(n));
                m += 1; 
            }
            // kiem tra ca thu 1
            for(int i=0; i<workHoursOfUser.Count; i++)
            {
                String starTime = DateTime.Now.ToString("yyyy-MM-dd") + " " + workHoursOfUser[0].ToString() + ":00";
                int nextHour = workHoursOfUser[0] + i;
                String endTime = DateTime.Now.ToString("yyyy-MM-dd") + " " + nextHour.ToString() + ":00";
                if (CheckExistStartAndEnd(starTime, endTime) == true)
                {
                    return true;
                }
            }
            return false;
        }
        public void GetStartHoursFromDb(String uId)
        {
            startHours.Clear();
            String todayTime = DateTime.Now.ToString("yyyy-MM-dd HH:MM");
            String query = "select CONVERT(VARCHAR(5),startime,108) AS [Time] from shift " +
                "where staffid=" + uId + "and startime>='" + todayTime + "'";
            //Console.WriteLine(query);
            db.Query(query);
            if(db.count > 0)
            {
                SqlDataReader reader = db.ExecuteReader(query);
                while(reader.Read())
                {
                    startHours.AddLast(reader["Time"].ToString().Substring(0,2));
                }

            }
        }
        public bool CheckExistStartAndEnd(String startime, String endtime )
        {
            String startShift = DateTime.Now.ToString("yyyy-MM-dd")+ " " + startime +":00";
            String endShift = DateTime.Now.ToString("yyyy-MM-dd") + " " + endtime + ":00";
            String query = "select CONVERT(VARCHAR(5),startime,108) AS [Time] from shift " +
                "where staffid=" + users["uid"] + "and startime>='" + startShift + "'" +
                " and endtime<='" + endShift;
            if(db.count>0)
            {
                return true;
            }
            return false;
        }

    }
}

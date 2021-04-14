using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using MySql.Data.MySqlClient;
using System.Data.SqlClient;
using System.Data;
namespace management
{
    class DBConnect
    {
        private SqlConnection cnn;
        private String connectionString = "";
        public string msg = "";
        public String testCmd = "";
        SqlDataAdapter apt;
        public DataTable dt;
        public String staffId = "";
        public Boolean isAdmin = false;
        
        
        public DBConnect()
        {
            Initialize();
        }
        private void Initialize()
        {
            //connectionString = "server=DESKTOP-2JU4MVK\\SQLEXPRESS;database=nhahang; integrated security = true";
            connectionString = "server=" +Config.get("server") + ";database="+Config.get("db")+";integrated security="+Config.get("is");
            cnn = new SqlConnection(connectionString);
        }
        private bool OpenConnection()
        {
            try
            {
                cnn.Open();
                return true;
            } catch (SqlException ex)
            {
                switch (ex.Number)
                {
                    case 0:
                        Console.WriteLine("Cannot Connect to server");
                        break;
                    case 1045:
                        Console.WriteLine("Invalid user/pasword");
                        break;
                }
                return false;
            }
        }
        private  bool CloseConnection()
        {
            try
            {
                cnn.Close();
                return true;
            } catch (SqlException ex)
            {
                Console.WriteLine(ex.Message);
                return false;
            }
        }
        public int ExecuteNon(String query)
        {
            int count = 0;
            SqlCommand cmd = new SqlCommand(query, cnn);
            //int count=1;
            if (this.OpenConnection() == true)
            {
                count = cmd.ExecuteNonQuery();
                //SqlDataReader dtread = cmd.ExecuteReader();
                //if (dtread.HasRows)
                //{
                //    while (dtread.Read())
                //    {
                //        count++;
                //    }
                //}
                this.CloseConnection();
            }
            else
            {
                Console.WriteLine("conect error");
            }
            return count;
        }
        public SqlDataReader ExecuteReader(String query)
        {
            cnn.Open();
            SqlCommand cmd = new SqlCommand(query, cnn);
            SqlDataReader reader = cmd.ExecuteReader(CommandBehavior.CloseConnection);
            return reader;
        }
        public SqlDataAdapter fillAdapter( String query)
        {
            cnn.Open();
            //SqlCommand cmd = new SqlCommand(query, cnn);
            SqlDataAdapter adap = new SqlDataAdapter(query, cnn);
            //DataSet dt = new DataSet();
            return adap;
        }
        
        public void MessageErr(int a)
        {
            if(a == 0)
            {
                this.msg = "Fail";
            } else
            {  
                this.msg = "Success";
            }
        }
 

        public void Insert(String tableName, String tableValue )
        {
            String query = "INSERT INTO " + tableName + " VALUES " + tableValue + ";";  
            //Console.WriteLine(testCmd);
           MessageErr(ExecuteNon(query)) ;
        }
        public void Update(String tableName, String afterSet, String whereId)
        {
            String query = "UPDATE " + tableName + " SET " + afterSet + " WHERE " + whereId;
            MessageErr(ExecuteNon(query));
            //Console.WriteLine(query);
        }
        //"DELETE FROM `foods` WHERE `foods`.`FOODID` = 6"
        public void Delete(String tableName, String columnName, String deleteId)
        {
            string query = "DELETE FROM " + tableName + " WHERE "+columnName+" = '" + deleteId +"'";
            //testCmd = "DELETE FROM `" + tableName + "` WHERE "+ tableAttr + " = " + deleteId;
            Console.WriteLine(testCmd);
            MessageErr(ExecuteNon(query));
        }
        //public String SelectAll(String tableName)
        //{
        //    string query = "SELECT * FROM " + tableName;
        //    return query;
        //}
        public String SelectColumn(String columnName, String afterFrom)
        {
            String query = "";
            if (columnName != "") {
                query = "SELECT " + columnName + " From " + afterFrom;
            } else
            {
                query = "SELECT * FROM " + afterFrom;
            }
            
            return query;
        }
        public String selectWhereLike(String beforeWhere, String columnName, String whereValue)
        {
            String query = beforeWhere + " WHERE " + columnName + " LIKE N'%" + whereValue + "%'"; 
            return query;
        }

        public String StringColumnName(String[] arr)
        {
            string onConvert = "";
            string converted = "";
            // foodname, foodprice , food kind
            for (int i = 0; i < arr.Length; i++)
            {
                if (i + 1 == arr.Length)
                {
                    onConvert = onConvert + " " + arr[i] + " ";
                }
                else
                {
                    onConvert = onConvert + " " + arr[i] + ", ";
                }
                // onConvertd = onConvertd + "`" + arr[i] + "`,";
            }
            converted = " " + onConvert + " ";
            return converted;
        }
        public String StringValue(String[] arr)
        {
            string onConvert = "";
            string converted = "";
            for (int i=0; i < arr.Length; i++)
            {
                if(i + 1 == arr.Length)
                {
                    onConvert = onConvert + "N'" + arr[i] + "'";
                } else
                {
                    onConvert = onConvert + "N'" + arr[i] + "'" + ",";
                }
            }
            converted = "(" + onConvert + ")";
            return converted;
        }
        public void ShowDt(String selectString)
        {
            apt = new SqlDataAdapter(selectString, cnn);
            dt = new DataTable();
            //fill to datatable
            apt.Fill(dt);
        }
       
      


     }
}

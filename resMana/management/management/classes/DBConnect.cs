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

        SqlDataReader reader;
        SqlDataAdapter apt;
        public DataTable dt;

        public List<Dictionary<string, string>> result = new List<Dictionary<string, string>>();
  
        public int count;


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

        public SqlDataAdapter FillAdapter( String query)
        {
            cnn.Open();
            //SqlCommand cmd = new SqlCommand(query, cnn);
            SqlDataAdapter adap = new SqlDataAdapter(query, cnn);
            //DataSet dt = new DataSet();
            return adap;
        }

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
        public String SelectWhereLike(String beforeWhere, String columnName, String whereValue)
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
        public void Query(String query) {
            this.CloseConnection();
            if (this.OpenConnection() == true ) {
                this.count = 0;
                this.result = new List<Dictionary<string, string>>();
                SqlCommand cmd = new SqlCommand(query, cnn);
                SqlDataReader reader = cmd.ExecuteReader();
                if(reader.HasRows)
                {
                    int i = 0;
                    while(reader.Read())
                    {
                        Dictionary<String, String> dic = new Dictionary<string, string>();
                        for(int j=0; j<reader.FieldCount; j++) 
                        {
                            dic.Add(reader.GetName(j), Convert.ToString(reader.GetValue(j)));
                        }
                        i++;
                        this.result.Add(dic);
                    }
                    reader.Close();
                    this.CloseConnection();
                    this.count = i;
                }
            }
        }
        public void ExecuteNonQuery(String query)
        {
            this.CloseConnection();
            this.count = 0;
            if (this.OpenConnection() == true)
            {
                SqlCommand cmd = new SqlCommand(query, cnn);
                int i = cmd.ExecuteNonQuery();
                this.CloseConnection();
                this.count = i;
            }
        }
        public SqlDataReader ExecuteReader(String query)
        {
            this.CloseConnection();
            
            if(this.OpenConnection() == true)
            {
                SqlCommand cmd = new SqlCommand(query, cnn);
                reader = cmd.ExecuteReader(CommandBehavior.CloseConnection);
                                
            }
            return reader;
        }
        public int CountAllRow(String query)
        {
            Int32 n = 0;
            if (this.OpenConnection() == true)
            {
                SqlCommand cmd = new SqlCommand(query, cnn);
                n = (Int32)cmd.ExecuteScalar();
            }
            this.CloseConnection();
         
            return n;
        }

    }
}

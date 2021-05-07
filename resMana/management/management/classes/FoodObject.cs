using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace management
{
    public class FoodObject
    {
        DBConnect db = new DBConnect();

        public Dictionary<string, string> foodDic = new Dictionary<string, string>();

 
        public FoodObject(string foodid)
        {

            String columns = "foodid, foodname, foodprice, kindname";
            String afterFrom = "foods inner join foodkind on foods.foodkind_id = foodkind.foodkind_id";
            String query = db.SelectWhereLike(db.SelectColumn(columns, afterFrom), "foodid", foodid);
            //db.ExecuteReader(query);
            SqlDataReader dtRead = db.ExecuteReader(query);
            while (dtRead.Read())
            {
                foodDic.Add("foodname", dtRead["FOODNAME"].ToString());
                foodDic.Add("kindname", dtRead["kindname"].ToString());
                foodDic.Add("foodprice", dtRead["FOODPRICE"].ToString());
                foodDic.Add("foodid", dtRead["foodid"].ToString());
            }
        }



    }
}

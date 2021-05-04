using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace management
{
    class FoodObject
    {
        DBConnect db = new DBConnect();
        //     public String foodid { get { return foodid; } set { foodid = value; } }
        //public String foodid { get; set; }
        //public String foodName { get; set; }
        //public String foodPrice { get; set; }
        //public String foodKind { get; set; }
        Dictionary<string, string> food = new Dictionary<string, string>();

 
        public FoodObject(string foodid)
        {

            String columns = "foodid, foodname, foodprice, kindname";
            String afterFrom = "foods inner join foodkind on foods.foodkind_id = foodkind.foodkind_id";
            String query = db.SelectWhereLike(db.SelectColumn(columns, afterFrom), "foodid", foodid);
            //db.ExecuteReader(query);
            SqlDataReader dtRead = db.ExecuteReader(query);
            while (dtRead.Read())
            {
                food.Add("foodname", dtRead["FOODNAME"].ToString());
                food.Add("kindname", dtRead["kindname"].ToString());
                food.Add("foodprice", dtRead["FOODPRICE"].ToString());
                food.Add("foodid", dtRead["foodid"].ToString());
            }
        }
        public String GetValueFromDic(String keyname)
        {
            return food[keyname] as String;
        }


    }
}

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
        public String foodid { get; set; }
        public String foodName { get; set; }
        public String foodPrice { get; set; }
        public String foodKind { get; set; }

 
        public FoodObject getFoodInfor(string foodid)
        {
            FoodObject fdo = new FoodObject();
            String columns = "foodid, foodname, foodprice, kindname";
            String afterFrom = "foods inner join foodkind on foods.foodkind_id = foodkind.foodkind_id";
            String query = db.selectWhereLike(db.SelectColumn(columns, afterFrom), "foodid", foodid);
            
            SqlDataReader dtRead = db.ExecuteReader(query);
                while (dtRead.Read())
                {
                    fdo.foodid = dtRead["FOODID"].ToString();
                    fdo.foodName = dtRead["FOODNAME"].ToString();
                    fdo.foodKind = dtRead["kindname"].ToString();
                    fdo.foodPrice = dtRead["FOODPRICE"].ToString();
                }
            dtRead.Close();
              
            return fdo;
        }


    }
}

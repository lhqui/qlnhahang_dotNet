using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace management
{
    class Config
    {
        private static Dictionary<String, String> configs = new Dictionary<string, string>()
        {
            {"server","OS-VVN\\SQLEXPRESS" },
            { "db","nhahang"},
            {"is","true" }
        };
        public static String get(String key)
        {
            return configs[key];
        }
    }
}

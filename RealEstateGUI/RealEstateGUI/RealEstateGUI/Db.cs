using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealEstateGUI
{
    public static class Db
    {
        private const string ConnStr =
            "Server=localhost;Port=3307;Database=ingatlan;Uid=root;Pwd=;";

        public static MySqlConnection GetConnection()
        {
            return new MySqlConnection(ConnStr);
        }
    }
}

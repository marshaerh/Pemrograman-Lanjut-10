using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using MySql.Data.MySqlClient;


namespace AplikasiPSB.KoneksiDB
{
    class Koneksi
    {
        public static MySqlConnection getKoneksi()
        {
            string strCon = "SERVER = localhost; PORT = 3306; " +
                        "UID = root; PWD = ; " +
                        "DATABASE = db_psbx;";
            return new MySqlConnection(strCon);
        }
        
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using MySql.Data.MySqlClient;
using AplikasiPSB.Interface;
using AplikasiPSB.Entity;

namespace AplikasiPSB.Implement
{
    class ImpStaff : Interface.IntStaff
    {
        private string query;
        private bool status;
        private MySqlConnection koneksi;
        private MySqlCommand command;

        bool IntStaff.deleteStaff(string kode)
        {
            throw new NotImplementedException();
        }

        DataTable IntStaff.getPekerjaan()
        {
            throw new NotImplementedException();
        }

        bool IntStaff.insertStaff(EntStaff e)
        {
            status = false;
            try
            {
                query = "INSERT INTO tb_staff VALUES ('"
                    + e.getKode() + "','"
                    + e.getNama() + "','"
                    + e.getAlamat() + "','"
                    + e.getTelp() + "','"
                    + e.getPassword() + "','";
                koneksi.Open();
                command = new MySqlCommand();
                command.Connection = koneksi;
                command.CommandText = query;
                command.ExecuteNonQuery();
                status = true;
                koneksi.Close();
            }
            catch (MySqlException)
            {
                Console.WriteLine("ERROR");
            }
            return status;
        }

        string IntStaff.kodeBaru()
        {
            throw new NotImplementedException();
        }

        DataSet IntStaff.selectData()
        {
            throw new NotImplementedException();
        }

        bool IntStaff.updateStaff(EntStaff e)
        {
            status = false;
            try
            {
                query = "UPDATE tb_staff SET nama_staff='" +
                    e.getNama() + "', alamat= '" +
                    e.getAlamat() + "', telp= '" +
                    e.getTelp() + "', password= '" +
                    e.getPassword() + "' WHERE id_staff='" +
                    e.getKode() + "'";
                Console.WriteLine(query);
                koneksi.Open();
                command = new MySqlCommand();
                command.Connection = koneksi;
                command.CommandText = query;
                command.ExecuteNonQuery();
                status = true;
                koneksi.Close();
            }
            catch (MySqlException)
            {
                Console.WriteLine("ERROR");
            }
            return status;
        }
    }
}

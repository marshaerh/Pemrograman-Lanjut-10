using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AplikasiPSB.Entity
{
    class EntStaff
    {
        private string kode;
        private string nama;
        private string alamat;
        private string telp;
        private string password;
        public void setKode(string kode)
        {
            this.kode = kode;
        }
        public string getKode()
        {
            return kode;
        }
        public void setNama(string nama)
        {
            this.nama = nama;
        }
        public string getNama()
        {
            return nama;
        }
        public void setAlamat(string alamat)
        {
            this.alamat = alamat;
        }
        public string getAlamat()
        {
            return alamat;
        }
    
        public void setTelp(string telp)
        {
            this.telp = telp;
        }
        public string getTelp()
        {
            return telp;
        }
        public void setPassword(string password)
        {
            this.password = password;
        }
        public string getPassword()
        {
            return password;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AplikasiPSB.Interface
{
    interface IntStaff
    {
        Boolean insertStaff(Entity.EntStaff e);
        Boolean updateStaff(Entity.EntStaff e);
        Boolean deleteStaff(string kode);
        string kodeBaru();
        DataSet selectData();
        DataTable getPekerjaan();
    }
}

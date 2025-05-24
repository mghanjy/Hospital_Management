using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Hospital_Management
{
     class Class1
    {
        Class2 bgl1 = new Class2();
        public SqlConnection baglanti()
        {
            SqlConnection baglan = new SqlConnection(bgl1.Adres);
            baglan.Open();
            return baglan;
        }
    }
}

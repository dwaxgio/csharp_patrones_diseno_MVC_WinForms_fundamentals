using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatronDiseñoMVC_WindowsForms.Models.Dao
{
    public class DbContext
    {
        // 2.
        protected SqlConnection Conexion = new SqlConnection("Server=(LocalDB)\\MSSQLLocalDB;Database=Practica_Patrones;User=sa;Pwd=Unemamad249");
    }
}

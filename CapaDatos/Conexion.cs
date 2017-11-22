using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class Conexion
    {
        public static string leerConexion()
        {
            //return "DATA SOURCE = .; INITIAL CATALOG = DAP_ProyectoSistFinan; INTEGRATED SECURITY = True";
            return "Data Source = NEYRA\\SQLEXPRESS; Initial Catalog = DAP_ProyectoSistFinan; Integrated Security = True";
        }
    }
}

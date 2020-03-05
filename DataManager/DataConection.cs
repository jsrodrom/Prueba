using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace DataManager
{
    public class DataConection
    {
        public string ObtenerConexionEmpresa1()
        {
            return ConfigurationManager.ConnectionStrings["ConstringEmpresa1"].ConnectionString;
        }
        public string ObtenerConexionEmpresa2()
        {
            return ConfigurationManager.ConnectionStrings["ConstringEmpresa2"].ConnectionString;
        }
    }
}

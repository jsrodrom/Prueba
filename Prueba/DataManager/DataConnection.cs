using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;

namespace Prueba.DataManager
{
    public class DataConnection
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
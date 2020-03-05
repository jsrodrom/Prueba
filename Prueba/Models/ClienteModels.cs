using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Prueba.Models
{
    public class ClienteModels
    {
        public string Identidad { get; set; }
        public string Nombres { get; set; }
        public string Apellidos { get; set; }
        public string Edad { get; set; }
        public DateTime fechaNacimiento { get; set; }
        public bool Estado { get; set; }
        public string Codigo_cliente { get; set; }
        public string Ultima_Compra { get; set; }
        public string Compras_Realizadas { get; set; }
        public string Correo { get; set; }
        public int Id_Ciudad { get; set; }
        public int Id_Pais { get; set; }
        public string Empresa { get; set; }
        public int indiceDB { get; set; }

    }
}
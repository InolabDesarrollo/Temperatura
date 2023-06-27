using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace TemperaturaInolab.DataSQL
{
    internal class Usuario
    {
        public static int tipoBD { get; set; }
        public static int IdUsuario { get; set; }
        public static int IdArea { get; set; }
        public static int IdRol { get; set; }
        public static string Nombre { get; set;}
        public static string usuario { get; set;}
        public static string Password { get; set;}

        //public static string hostName { get; set;}

        public static int TotalSensores { get; set; }
        public static int AdicionalSensores { get; set; }
    }
}

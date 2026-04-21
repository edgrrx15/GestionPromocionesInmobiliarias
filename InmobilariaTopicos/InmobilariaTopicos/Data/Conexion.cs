using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace topicos_autosbd.Data
{
    internal class conexion
    {
        string cadenaConexion = "server=edgar;Initial Catalog=inmobiliaria;Integrated Security=True; Timeout=3";

        // Se inicia un metodo con el tipo de dato SqlConnection, el cual se encarga de abrir la conexion
        // a la base de datos y devolverla para ser utilizada en otras partes del programa
        public SqlConnection conectar()
        {
            // Se crea una instancia de SqlConnection utilizando la cadena de conexion definida anteriormente
            SqlConnection conexion = new SqlConnection(cadenaConexion);
            conexion.Open(); // Se abre la conexion a la base de datos
            return conexion; // Se devuelve la conexion abierta para su uso en otras partes del programa
        }
    }
}
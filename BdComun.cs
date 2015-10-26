using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace ConexionCSharpMySQL
{
    public class BdComun
    {
        //ObtenerConexion: Nombre del método que nos conectará a la base de datos
        public static MySqlConnection ObtenerConexion()
        {
            //Server es el servidor de MySQL
            //Database es el nombre de la base de datos en este caso Tutorial
            //Uid es el nombre del usuario de MySQL, por defecto es "root"
            //pwd es la contraseña del usuario de MySQL
            MySqlConnection conectar = new MySqlConnection("server=127.0.0.1; database=Tutorial; Uid=root; pwd=;");

            conectar.Open();
            return conectar;
        }
    }
}

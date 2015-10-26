using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConexionCSharpMySQL
{
    public class Cliente
    {
        //Estas son las 5 propiedades equivalentes a los 5 campos que se tienen en la base de datos en la tabla Clientes
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Fecha_Nac { get; set; }
        public string Direccion { get; set; }

        //Constructor vacio para crear objetos
        public Cliente() { }

        //Constructor el cual tiene cinco parámetros, son los parametros que serviran para enviar los datos hacia las propiedades para los insert, consultas, etc
        public Cliente(int pId, string pNombre, string pApellido, string pFecha_Nac, string pDireccion)
        {
            this.Id = pId;
            this.Nombre = pNombre;
            this.Apellido = pApellido;
            this.Fecha_Nac = pFecha_Nac;
            this.Direccion = pDireccion;
        }
    }
}

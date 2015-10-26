using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace ConexionCSharpMySQL
{
    //Esta clase contiene los metodos que utilizaremos para insertar registros, actualizar, consultar o eliminar
    class ClientesDAL
    {
        //Metodo para agregar un nuevo registro a la base de datos
        public static int Agregar(Cliente pCliente)
        {

            int retorno = 0;

            //Comando para insertar un nuevo cliente en la base de datos en la tabla Clientes, se evita el ID debido a que ese es autoincrementable
            MySqlCommand comando = new MySqlCommand(string.Format("Insert into clientes (Nombre, Apellido, Fecha_Nacimiento, Direccion) values ('{0}','{1}','{2}', '{3}')", pCliente.Nombre, pCliente.Apellido, pCliente.Fecha_Nac, pCliente.Direccion), BdComun.ObtenerConexion());
            //Se ejecuta el Query
            retorno = comando.ExecuteNonQuery();
            return retorno;
        }

        //Metodo para buscar un cliente ya registrado en la base de datos, el cual es tipo Lista y recibe los parametrs de Nombre y Apellido
        public static List<Cliente> Buscar(string pNombre, string pApellido)
        {
            List<Cliente> _lista = new List<Cliente>();

            //Comando para buscar un cliente y regrese todos sus datos si este coincide con el nombre o el apellido 
            MySqlCommand _comando = new MySqlCommand(String.Format("SELECT IdCliente, Nombre, Apellido, Fecha_Nacimiento, Direccion FROM clientes  where Nombre ='{0}' or Apellido='{1}'", pNombre, pApellido), BdComun.ObtenerConexion());
            //Se crea un comando de lectura y se ejecuta con ExecuteReader
            MySqlDataReader _reader = _comando.ExecuteReader();
            //Mientras haya lectura se ejecuta este ciclo
            while (_reader.Read())
            {
                Cliente pCliente = new Cliente();
                pCliente.Id = _reader.GetInt32(0);
                pCliente.Nombre = _reader.GetString(1);
                pCliente.Apellido = _reader.GetString(2);
                pCliente.Fecha_Nac = _reader.GetString(3);
                pCliente.Direccion = _reader.GetString(4);

                //Como es una lista, esta puede almacenar varios clientes registrados y solo se van agregando uno a uno depende los que encuentre
                _lista.Add(pCliente);
            }
            //Aqui simplemente retorna la lista
            return _lista;
        }

        //Metodo para obtener el cliente mediante su ID
        public static Cliente ObtenerCliente(int pId)
        {
            Cliente pCliente = new Cliente();
            //Se crea la conexion con la base de datos
            MySqlConnection conexion = BdComun.ObtenerConexion();

            //Comando para seleccionar los datos del cliente que coincidan con el ID del cliente que se manda de parametro
            MySqlCommand _comando = new MySqlCommand(String.Format("SELECT IdCliente, Nombre, Apellido, Fecha_Nacimiento, Direccion FROM clientes where IdCliente={0}", pId), conexion);
            //Se crea un comando de lectura y se ejecuta con ExecuteReader
            MySqlDataReader _reader = _comando.ExecuteReader();
            //Se busca el cliente y se obtienen sus datos
            while (_reader.Read())
            {
                pCliente.Id = _reader.GetInt32(0);
                pCliente.Nombre = _reader.GetString(1);
                pCliente.Apellido = _reader.GetString(2);
                pCliente.Fecha_Nac = _reader.GetString(3);
                pCliente.Direccion = _reader.GetString(4);

            }

            //Se cierra la conexion con la base de datos
            conexion.Close();
            return pCliente;

        }

        //Metodo para Actualizar los datos del cliente seleccionado en el DataGridView
        public static int Actualizar(Cliente pCliente)
        {
            int retorno = 0;
            //Se crea la conexion con la base de datos
            MySqlConnection conexion = BdComun.ObtenerConexion();

            //Comando Update para actualizar los datos del cliente segun los parametros que se asignan en cada una de las posiciones 0,1,2,3 mientras el ID sea igual al del parametro 4, o sea el ID obtenido anteriormente
            MySqlCommand comando = new MySqlCommand(string.Format("Update clientes set Nombre='{0}', Apellido='{1}', Fecha_Nacimiento='{2}', Direccion='{3}' where IdCliente={4}", pCliente.Nombre, pCliente.Apellido, pCliente.Fecha_Nac, pCliente.Direccion, pCliente.Id), conexion);

            //Se ejecuta el comando Update de MySql
            retorno = comando.ExecuteNonQuery();
            //Se cierra la conexion
            conexion.Close();

            return retorno;


        }

        //Metodo para eliminar un cliente mientras el IDCliente se igual al que especifiquemos al ejecutar el método, y en la variable retorno se guardaría un 0 si no se afecto ninguna fila o un 1 si pudo eliminar el cliente
        public static int Eliminar(int pId)
        {
            int retorno = 0;
            MySqlConnection conexion = BdComun.ObtenerConexion();

            MySqlCommand comando = new MySqlCommand(string.Format("Delete From clientes where IdCliente={0}", pId), conexion);

            retorno = comando.ExecuteNonQuery();
            //Se cierra la conexion
            conexion.Close();

            //Retorna 0 si no se elimino y un 1 si se elimino
            return retorno;

        }
    }
}

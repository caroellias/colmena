using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConexionCSharpMySQL
{
    public partial class FormularioPrincipal : Form
    {
        public FormularioPrincipal()
        {
            InitializeComponent();
        }

        public Cliente ClienteActual { get; set; }

        //Se ejecuta el metodo ObtenerConexion y muestra un mensaje si todo sale bien
        private void button1_Click(object sender, EventArgs e)
        {
            BdComun.ObtenerConexion();
            MessageBox.Show("¡Conexión Exitosa!");
        }

        //Codigo para grabar un nuevo cliente en la base de datos
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            //Se crea un nuevo objeto de Cliente el cual recibe los valores que contiene cada una de las cajas de texto del formulario
            Cliente pCliente = new Cliente();
            pCliente.Nombre = txtNombre.Text.Trim();
            pCliente.Apellido = txtApellido.Text.Trim();
            pCliente.Fecha_Nac = dtpFechaNacimiento.Value.Year + "/" + dtpFechaNacimiento.Value.Month + "/" + dtpFechaNacimiento.Value.Day;
            pCliente.Direccion = txtDireccion.Text.Trim();

            //Si todo sale bien, "resultado" obtiene un 1 y se presenta un mensaje de exito, si no es asi, se presenta un mensaje de fallo
            int resultado = ClientesDAL.Agregar(pCliente);
            if (resultado > 0)
            {
                MessageBox.Show("Cliente Guardado Con Exito!", "Guardado", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("No se pudo guardar el cliente", "Fallo!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            //Al presionar este boton se abre el formulario BuscarClientes
            BuscarClientes buscar = new BuscarClientes();
            buscar.ShowDialog();

            //Se muestran los datos del cliente seleccinado en el DataGridView, en cada una de las cajas de texto del formulario
            if (buscar.ClienteSeleccionado != null)
            {
                //Al asignarle a ClienteActual lo que tiene buscar.ClienteSeleccionado, la propiedad ClienteActual tendrá todos los datos del cliente seleccionado por el usuario en el DataGridView, incluyendo el ID que necesitamos para actualizar
                ClienteActual = buscar.ClienteSeleccionado;
                txtNombre.Text = buscar.ClienteSeleccionado.Nombre;
                txtApellido.Text = buscar.ClienteSeleccionado.Apellido;
                txtDireccion.Text = buscar.ClienteSeleccionado.Direccion;
                dtpFechaNacimiento.Text = buscar.ClienteSeleccionado.Fecha_Nac;
            }
        }

        //Al presionar este boton se actualizan los datos del cliente seleccinado
        private void btnModificar_Click(object sender, EventArgs e)
        {
            //Se crea un objeto de Cliente
            Cliente pCliente = new Cliente();

            //Lo que este escrito en las cajas de texto es lo que tomara el metodo Actualizar y con esos datos actualizara en la base de datos
            pCliente.Nombre = txtNombre.Text.Trim();
            pCliente.Apellido = txtApellido.Text.Trim();
            pCliente.Fecha_Nac = dtpFechaNacimiento.Value.Year + "/" + dtpFechaNacimiento.Value.Month + "/" + dtpFechaNacimiento.Value.Day;
            pCliente.Direccion = txtDireccion.Text.Trim();
            pCliente.Id = ClienteActual.Id;

            //Se ejecuta el metodo Actualizar si esto devuelve un valor mayor a 0
            if (ClientesDAL.Actualizar(pCliente) > 0)
            {
                MessageBox.Show("Los datos del cliente se actualizaron", "Datos Actualizados", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("No se pudo actualizar", "Error al Actualizar", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            //Se muestra una ventana que pregunta si queremos eliminar el cliente actual
            if (MessageBox.Show("Esta Seguro que desea eliminar el Cliente Actual", "Estas Seguro?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                //Se ejecuta el metodo Eliminar si el usuario presiona que Si, en caso de que si se haya eliminado se muestra un mensaje de que se elimino
                if (ClientesDAL.Eliminar(ClienteActual.Id) > 0)
                {
                    MessageBox.Show("Cliente Eliminado Correctamente!", "Cliente Eliminado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                //Si no se elimino, se muestra este mensaje
                else
                {
                    MessageBox.Show("No se pudo eliminar el Cliente", "Cliente No Eliminado", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            //Este mensaje se muestra si el usuario presiona que No
            else
                MessageBox.Show("Se cancelo la eliminacion", "Eliminacion Cancelada", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }
    }
}

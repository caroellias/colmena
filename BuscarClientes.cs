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
    public partial class BuscarClientes : Form
    {
        public BuscarClientes()
        {
            InitializeComponent();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            //Se cargan en el DataGridView los datos de los clientes obtenidos en la lista del metodo Buscar de ClientesDAL
            dgvBuscar.DataSource = ClientesDAL.Buscar(txtNombre.Text, txtApellido.Text);
        }

        public Cliente ClienteSeleccionado { get; set; }

        //Capturamos el ID del cliente seleccionado e invocamos el método ObtenerCliente enviando como parámetro el ID que selecciono el usuario en el DataGridView
        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (dgvBuscar.SelectedRows.Count == 1)
            {
                int id = Convert.ToInt32(dgvBuscar.CurrentRow.Cells[0].Value);
                ClienteSeleccionado = ClientesDAL.ObtenerCliente(id);

                this.Close();
            }
            else
                MessageBox.Show("Debe de seleccionar una fila");
        }
    }
}

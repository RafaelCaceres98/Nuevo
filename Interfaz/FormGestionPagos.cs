using BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Interfaz
{
    public partial class FormGestionPagos : Form
    {
        ClienteService clienteService = new ClienteService(ConfigConnection.connectionString);
        public FormGestionPagos()
        {
            InitializeComponent();
            PintarTabla();
        }

        private void DtgClientes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void cedulaTxt_TextChanged(object sender, EventArgs e)
        {
            DtgClientes.Rows.Clear();
            foreach (var item in clienteService.ClientesFiltroCedula(cedulaTxt.Text)) {
                DtgClientes.Rows.Add(item.Cedula, item.PrimerNombre, item.SegundoNombre, item.PrimerApellido, item.SegundoApellido, item.Genero, item.Celular, item.Direccion, item.Email);


            
            } 
        }

        public void PintarTabla() {

            DtgClientes.Rows.Clear();
            foreach (var item in clienteService.ConsultarClientes())
            {
                DtgClientes.Rows.Add(item.Cedula, item.PrimerNombre, item.SegundoNombre, item.PrimerApellido, item.SegundoApellido, item.Genero, item.Celular, item.Direccion, item.Email);



            }

        }


        public void AbrirFormPagar() 
        {
            FrmPagar frmPagar = new FrmPagar(clienteService.BuscarCliente(cedulaTxt.Text));
            frmPagar.Show();
        }

        private void buscarBtn_Click(object sender, EventArgs e)
        {
            if (clienteService.BuscarCliente(cedulaTxt.Text) == null)
            {
                MessageBox.Show("No existe la cedula.");
            }
            else
            {
                AbrirFormPagar();
            }
            
        }
    }
}

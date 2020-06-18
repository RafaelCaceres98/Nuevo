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
    public partial class FormListaClientes : Form
    {
        private ClienteService clienteservice = new ClienteService(ConfigConnection.connectionString);
        public FormListaClientes()
        {
            InitializeComponent();
          
        }

        private void cambiarEstadoBtn_Click(object sender, EventArgs e)
        {

        }

        private void DtgClientes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void filtroCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (filtroCombo.SelectedIndex == 0)
            {
                DtgClientes.Rows.Clear();
                foreach (var item in clienteservice.ConsultarClientes())
                {
                    DtgClientes.Rows.Add(item.Cedula, item.PrimerNombre, item.SegundoNombre, item.PrimerApellido, item.SegundoApellido, item.Genero, item.Celular, item.Direccion, item.Email);
                }
            }  

                if (filtroCombo.SelectedIndex == 1)
                {
                    DtgClientes.Rows.Clear();
                    foreach (var item in clienteservice.ClientesGenero('F'))
                    {
                        DtgClientes.Rows.Add(item.Cedula, item.PrimerNombre, item.SegundoNombre, item.PrimerApellido, item.SegundoApellido, item.Genero, item.Celular, item.Direccion, item.Email);
                    }
                }
                if (filtroCombo.SelectedIndex == 2)
                {
                    DtgClientes.Rows.Clear();
                    foreach (var item in clienteservice.ClientesGenero('M'))
                    {
                        DtgClientes.Rows.Add(item.Cedula, item.PrimerNombre, item.SegundoNombre, item.PrimerApellido, item.SegundoApellido, item.Genero, item.Celular, item.Direccion, item.Email);
                    }
                }
            
        }

        private void filtroLetrasTxt_TextChanged(object sender, EventArgs e)
        {
            DtgClientes.Rows.Clear();
            foreach (var item in clienteservice.ClientesFiltroCedula(filtroLetrasTxt.Text))
            {
                DtgClientes.Rows.Add(item.Cedula, item.PrimerNombre, item.SegundoNombre, item.PrimerApellido, item.SegundoApellido, item.Genero, item.Celular, item.Direccion, item.Email);



            }
        }
    }
}

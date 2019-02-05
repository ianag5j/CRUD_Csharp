using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using MySql.Data.MySqlClient;

namespace ABMEirc
{
	public partial class Buscar : Form
	{
        private void setDiseñoDG()
        {
            DGBuscar.Columns[0].HeaderText = "Nombre";
            DGBuscar.Columns[0].Width = 187;
            DGBuscar.Columns[1].HeaderText = "Id";
            DGBuscar.Columns[1].ReadOnly = true;
        }

		public Buscar()
		{
			InitializeComponent();
		}

		private void btnBuscar_Click(object sender, EventArgs e)
		{
			DGBuscar.DataSource = Funciones.buscarNombre(txtBuscadorNombre.Text);
            setDiseñoDG();
        }

		private void btnBuscarId_Click(object sender, EventArgs e)
		{
			DGBuscar.DataSource = Funciones.buscarId(txtBuscardorId.Text);
            setDiseñoDG();
        }

		private void btnVerTodos_Click(object sender, EventArgs e)
		{
			DGBuscar.DataSource = Funciones.mostrarTodos();
            setDiseñoDG();
        }

		private void btnAtras_Click(object sender, EventArgs e)
		{
			this.Close();
			Program.MenuPrincipal.Show();
		}

		private void btnBorrarSeleccionado_Click(object sender, EventArgs e)
		{
			int cantFilasSeleccionadas = DGBuscar.SelectedRows.Count;
			if ( cantFilasSeleccionadas > 0)
			{
				int filasAfectadas = 0;
                MySqlConnection conexion = BDConect.getConexion();
                foreach (DataGridViewRow r in DGBuscar.SelectedRows)
				{
					int idSelect = Convert.ToInt32(r.Cells[1].Value);
                    
                    filasAfectadas = filasAfectadas + Funciones.borrarAlumnoId(idSelect, conexion);
				}
				if (filasAfectadas == cantFilasSeleccionadas)
				{
					MessageBox.Show("Columnas Seleccionadas Borradas");
				}
				else
				{
					if (filasAfectadas > 1 && filasAfectadas < cantFilasSeleccionadas)
					{
						MessageBox.Show("Se borraron " + filasAfectadas + " filas");
					}
					else
					{
						if (filasAfectadas == 1)
						{
							MessageBox.Show("se borro la fila seleccionada");
						}
						else
						{
							MessageBox.Show("Error Ninguna columna Borrada");
						}
					}

				}
			}
			else
			{
				MessageBox.Show("Debe seleccionar al menos una fila");
			}

		}

		private void btnAgregarModificaciones_Click(object sender, EventArgs e)
		{
		}

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            string NombreActualizar = txtActualizar.Text;
            int filasAfectadas = Funciones.updateNombre(idSeleccionado, NombreActualizar);
            if (filasAfectadas == 1)
            {
                MessageBox.Show("El nombre de la persona con el Id: " + idSeleccionado + " se cambio a " + NombreActualizar);
            }
            else
            {
                MessageBox.Show("Error al atualizar");
            }
        }

        private void DGBuscar_SelectionChanged(object sender, EventArgs e)
        {
            MessageBox.Show("addsasadsadsasaddsa");
            int cantFilasSeleccionadas = DGBuscar.SelectedRows.Count;
            if (cantFilasSeleccionadas == 1)
            {
                
                foreach (DataGridViewRow r in DGBuscar.SelectedRows)
                {
                    int idSelect = Convert.ToInt32(r.Cells[1].Value);
                    string NombreSelect = Convert.ToString(r.Cells[1].Value);
                    txtActualizar.Text = NombreSelect;
                }
            }
        }

        private void DGBuscar_CellContentClick(object sender, EventArgs e)
        {

        }
        //id del ultima fila seleccionada
        int idSeleccionado;
        //funcion para el evento cuando se hace click en un cell del datagrid
        private void DGBuscar_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //obtiene el valor del nombre de la fila seleccionada
            string valorNombreFila = Convert.ToString(DGBuscar.Rows[e.RowIndex].Cells[0].Value);
            //ingresa el valor nombre de la fila seleccionada al input para actualizar
            txtActualizar.Text = valorNombreFila;

            int valorIdFila = Convert.ToInt32(DGBuscar.Rows[e.RowIndex].Cells[1].Value);
            //ingresa el valor id de la fila selecionada a una vaariable global
            idSeleccionado = valorIdFila;
        }

        bool UserClosing = false;
        //evento si el boton de la x de arriba es seleccionado
        void buttonExit_Click(object sender, EventArgs e)
        {
            UserClosing = true;
            this.Close();
        }

        private void Buscar_FormClosed(object sender, FormClosedEventArgs e)
        {}
        //evento antes de cerrar el formulario
        private void Buscar_FormClosing(object sender, FormClosingEventArgs e)
        {
            //para ver la rason del cierre del formulario
            switch (e.CloseReason)
            {
                case CloseReason.ApplicationExitCall:
                    break;
                case CloseReason.FormOwnerClosing:
                    break;
                case CloseReason.MdiFormClosing:
                    break;
                case CloseReason.None:
                    break;
                case CloseReason.TaskManagerClosing:
                    break;
                case CloseReason.UserClosing:   //si el usuario cierra el formulario
                    if (UserClosing)
                    {
                        Program.MenuPrincipal.Close();
                    }
                    else
                    {
                       
                    }
                    break;
                case CloseReason.WindowsShutDown:
                    break;
                default:
                    break;
            }
        }
    }
}

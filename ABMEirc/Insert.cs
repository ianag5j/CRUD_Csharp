using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ABMEirc
{
	public partial class Insert : Form
	{
		public Insert()
		{
			InitializeComponent();
		}

		private void atrasInsert_Click(object sender, EventArgs e)
		{
			//Menu formMenu = new Menu();
			this.Close();
			Program.MenuPrincipal.Show();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			Persona PersonaIngresar = new Persona(txtNombreIngresar.Text);

			int retorno = Funciones.agregar(PersonaIngresar);
			
			if(retorno > 0)
			{
				MessageBox.Show("ingresado correctamente: " + PersonaIngresar.atributoNombre);
			}
			else
			{
				MessageBox.Show("Error al ingresar a: " + PersonaIngresar.atributoNombre);
			}
		}

        bool UserClosing = false;
        //evento si el boton de la x de arriba es seleccionado
        void buttonExit_Click(object sender, EventArgs e)
        {
            UserClosing = true;
            this.Close();
        }
        //evento antes de cerrar el formulario
        private void Insert_FormClosing(object sender, FormClosingEventArgs e)
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
                case CloseReason.UserClosing:
                    if (UserClosing) //si el usuario cierra el formulario
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

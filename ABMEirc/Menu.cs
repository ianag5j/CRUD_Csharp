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
	public partial class Menu : Form
	{
		public Menu()
		{
			InitializeComponent();
		}

		private void Form1_Load(object sender, EventArgs e)
		{

		}

		private void insert_Click(object sender, EventArgs e)
		{
			//creo el formulario insert
			Insert formInsert = new Insert();
			//oculto el formulario actual (no lo cierro por que es el formulario principal)
			this.Hide();
			//muestro el formulario insert
			formInsert.Show();
		}

		private void select_Click(object sender, EventArgs e)
		{
			Buscar b = new Buscar();
			this.Hide();
			b.Show();
		}
	}
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace ABMEirc
{
	public class BDConect
	{
		public static MySqlConnection getConexion()
		{
			//conecta con la BD seleccionada 
			MySqlConnection conexion = new MySqlConnection("server='localhost'; database='abmeric'; Uid='root'; pwd=''; SslMode = none");
			try
			{
				//abre la conexion
				conexion.Open();
				return conexion;
			}
			catch
			{
				MessageBox.Show("Error conectar a la BD", "Error BD", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
				return conexion;
			}
			
			

		}
	}
}

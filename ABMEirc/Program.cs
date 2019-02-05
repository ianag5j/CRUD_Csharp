using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ABMEirc
{
	static class Program
	{
		/// <summary>
		/// Punto de entrada principal para la aplicación.
		/// </summary>
		public static Menu MenuPrincipal;
		[STAThread]
		static void Main()
		{
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			Application.Run(MenuPrincipal = new Menu());
		}
	}
}

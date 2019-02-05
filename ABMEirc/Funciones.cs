using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace ABMEirc
{
	class Funciones
	{
		public static int agregar(Persona add)
		{
			int retorno = 0;
			MySqlCommand insert = new MySqlCommand(string.Format("Insert into personas (nombre) values ('{0}')", add.atributoNombre), BDConect.getConexion());
			retorno = insert.ExecuteNonQuery();
			Console.WriteLine(retorno);
			return retorno;
		}

		public static List<Persona> mostrarTodos()
		{
			//crear llista de objetos de persona
			List<Persona> personas = new List<Persona>();
			//comando mysql
			MySqlCommand selectTodo = new MySqlCommand(string.Format("select * from personas"), BDConect.getConexion());
			MySqlDataReader datos = selectTodo.ExecuteReader();

			while(datos.Read())
			{
				Persona p = new Persona();
				p.atributoId = datos.GetInt32(0);
				p.atributoNombre = datos.GetString(1);
				personas.Add(p);
			}
			return personas;
		}

		public static List<Persona> buscarNombre(string busqueda)
		{
			//crear llista de objetos de persona
			List<Persona> personas = new List<Persona>();
			//comando mysql
			MySqlCommand select = new MySqlCommand(string.Format("SELECT * FROM `personas` WHERE `nombre` LIKE '%{0}%'", busqueda), BDConect.getConexion());
			MySqlDataReader datos = select.ExecuteReader();
			while (datos.Read())
			{
				Persona p = new Persona();
				p.atributoId = datos.GetInt32(0);
				p.atributoNombre = datos.GetString(1);
				personas.Add(p);
			}
			return personas;
		}

		public static List<Persona> buscarId(string busqueda)
		{
			//crear llista de objetos de persona
			List<Persona> personas = new List<Persona>();
			//comando mysql
			MySqlCommand select = new MySqlCommand(string.Format("SELECT * FROM `personas` WHERE `id` LIKE '%{0}%'", busqueda), BDConect.getConexion());
			MySqlDataReader datos = select.ExecuteReader();
			while (datos.Read())
			{
				Persona p = new Persona();
				p.atributoId = datos.GetInt32(0);
				p.atributoNombre = datos.GetString(1);
				personas.Add(p);
			}
			return personas;
		}

		public static int borrarAlumnoId(int id, MySqlConnection conexion)
		{
            MySqlCommand borrar = new MySqlCommand(string.Format("delete from personas where id like ('{0}')", id), conexion);
			int retorno = borrar.ExecuteNonQuery();
			return retorno;
		}

        public static int updateNombre(int id, string nombreNuevo)
        {
            //"SELECT * FROM `personas` WHERE `id` LIKE '%{0}%'"
            MySqlCommand actualizar = new MySqlCommand(string.Format("UPDATE `personas` SET `nombre` = ('{0}') WHERE `id` LIKE '{1}'", nombreNuevo, id), BDConect.getConexion());
            int retorno = actualizar.ExecuteNonQuery();
            return retorno;
        }
	}
}

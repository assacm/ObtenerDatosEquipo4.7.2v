using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ObtenerDatosEquipo4._7._2v.Modelos
{
	public class comboBoxArea
	{
		SqlConnection Conn = new SqlConnection(ConfigurationManager.ConnectionStrings["ConStr"].ConnectionString);

		public void Llenar(ComboBox cbArea)
		{
			cbArea.Items.Clear();
			Conn.Open();
			string query = "Select * from Area";
			SqlCommand cmd = new SqlCommand(query, Conn);
			SqlDataReader reader = cmd.ExecuteReader();

			while (reader.Read())
			{
				cbArea.Items.Add(reader["Area"].ToString());
			}

			Conn.Close();

			cbArea.Items.Insert(0, "Seleccione su área");
			cbArea.SelectedIndex = 0;
		}

		public int ObtenerIdArea(string nombre)
		{
			Conn.Open();
			string query = string.Format("Select AreaKey from Area where Area = '{0}' ", nombre);
			SqlCommand cmd = new SqlCommand(query, Conn);
			SqlDataReader reader = cmd.ExecuteReader();
			int id = 0;
			while (reader.Read())
			{
				id = Convert.ToInt32(reader[0]);
			}

			Conn.Close();
			return id;
		}
	}
}

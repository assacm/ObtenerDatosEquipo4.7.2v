using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObtenerDatosEquipo4._7._2v.Modelos
{
	public class DatosPC
	{
		public int ID { get; set; }
		public DateTime Fecha { get; set; }

		public string NombrePC { get; set; }
		public string NoSerie { get; set; }
		public string Marca { get; set; }

		public string Modelo { get; set; }
		public string SO { get; set; }

		public string Arquitectura { get; set; }
		public string Usuario { get; set; }
		public string Procesador { get; set; }
		public string DiscoGB { get; set; }
		public string RAMGB { get; set; }
		public string TipoEquipo { get; set; }
	}
}

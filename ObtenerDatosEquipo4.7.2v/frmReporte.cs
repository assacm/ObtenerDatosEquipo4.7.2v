using Microsoft.Reporting.WinForms;
using ObtenerDatosEquipo4._7._2v.Modelos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ObtenerDatosEquipo4._7._2v
{
	public partial class frmReporte : Form
	{
		public frmReporte()
		{
			InitializeComponent();
		}
		
		public DatosPC PC { get; set; }
		public Usuario Usuario { get; set; }
		public Areas Area { get; set; }
		private void frmReporte_Load(object sender, EventArgs e)
		{
			// date.Value.ToShortDateString();
			ReportParameter[] parametros = new ReportParameter[11];

			parametros[0] = new ReportParameter("Fecha",DateTime.Today.ToShortDateString());
			parametros[1] = new ReportParameter("TipoEquipo",this.PC.TipoEquipo);
			parametros[2] = new ReportParameter("Marca",this.PC.Marca);
			parametros[3] = new ReportParameter("Modelo",this.PC.Modelo);
			parametros[4] = new ReportParameter("NoSerie",this.PC.NoSerie);
			parametros[5] = new ReportParameter("SO",this.PC.SO);
			parametros[6] = new ReportParameter("Usuario",this.Usuario.Nombre);
			parametros[7] = new ReportParameter("EstadoPC",this.PC.Estado);
			parametros[8] = new ReportParameter("Procesador",this.PC.Procesador);
			parametros[9] = new ReportParameter("Almacenamiento",this.PC.DiscoGB);
			parametros[10] = new ReportParameter("RAM",this.PC.RAMGB);

			this.reportViewer1.LocalReport.SetParameters(parametros);

			this.reportViewer1.RefreshReport();
		}
	}
}

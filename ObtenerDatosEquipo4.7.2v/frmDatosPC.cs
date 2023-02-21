using ObtenerDatosEquipo4._7._2v.Modelos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Management;
using System.Text.RegularExpressions;

namespace ObtenerDatosEquipo4._7._2v
{
	public partial class frmDatosPC : Form
	{
		public DatosPC pc = new DatosPC();
		public comboBoxArea combo = new comboBoxArea();
		public Areas area = new Areas();
		public Usuario usuario = new Usuario();

		public frmDatosPC()
		{
			InitializeComponent();
            combo.Llenar(cbArea);
        }



		private void frmDatosPC_Load(object sender, EventArgs e)
		{

		}

        private string getDiscoTot()
        {
            string str = "";
            double tot = 0;

            foreach (DriveInfo obj in DriveInfo.GetDrives())
            {
                if (obj.IsReady)
                    tot += obj.TotalSize;
            }

            tot = tot / 1024; //kbs
            tot = tot / 1024; //mbs
            tot = tot / 1024; //gbs

            str = Math.Round(tot, 0) + "";

            return str;
        }

        private string getSO()
        {
            ManagementObjectSearcher myOperativeSystemObject = new ManagementObjectSearcher("select * from Win32_OperatingSystem");
            string str = "";

            foreach (ManagementObject obj in myOperativeSystemObject.Get())
            {
                str = obj["Caption"] + "";

                /* Console.WriteLine("WindowsDirectory  -  " + obj["WindowsDirectory"]);
                 Console.WriteLine("ProductType  -  " + obj["ProductType"]);
                 Console.WriteLine("SerialNumber  -  " + obj["SerialNumber"]);
                 Console.WriteLine("SystemDirectory  -  " + obj["SystemDirectory"]);
                 Console.WriteLine("CountryCode  -  " + obj["CountryCode"]);
                 Console.WriteLine("CurrentTimeZone  -  " + obj["CurrentTimeZone"]);
                 Console.WriteLine("EncryptionLevel  -  " + obj["EncryptionLevel"]);
                 Console.WriteLine("OSType  -  " + obj["OSType"]);
                 Console.WriteLine("Version  -  " + obj["Version"]);*/
            }

            return str;
        }
        private string getProcesador()
        {
            ManagementObjectSearcher myOperativeSystemObject = new ManagementObjectSearcher("select * from Win32_Processor");
            string str = "";

            foreach (ManagementObject obj in myOperativeSystemObject.Get())
            {
                str = obj["Name"] + "";

            }

            return str;
        }
        private string getSerie()
        {
            ManagementObjectSearcher myOperativeSystemObject = new ManagementObjectSearcher("select * from Win32_BIOS");
            string str = "";

            foreach (ManagementObject obj in myOperativeSystemObject.Get())
            {
                str = obj["SerialNumber"] + "";// + " " + obj["Model"];
            }

            return str;
        }
        private string getModelo(string campo)
        {
            ManagementObjectSearcher myOperativeSystemObject = new ManagementObjectSearcher("select * from Win32_ComputerSystem");
            string str = "";

            foreach (ManagementObject obj in myOperativeSystemObject.Get())
            {
                str = obj[campo] + "";
            }

            return str;
        }
        public void InsertarPC()
        {
            SqlConnection Conn = new SqlConnection();

            try
            {
                Conn = new SqlConnection(ConfigurationManager.ConnectionStrings["ConStr"].ConnectionString);

                string Sql = string.Format("INSERT INTO [dbo].[DatosPC] ([Fecha],[NombrePC],[NoSerie],[Marca],[Modelo],[SO],[Arquitectura],[Usuario],[Procesador],[DiscoGb],[RAMGb],[TipoEquipo]) " +
                             "VALUES ('{0:yyyy-MM-dd}', '{1}', '{2}', '{3}', '{4}','{5}', '{6}', '{7}', '{8}', {9}, {10}, '{11}')",
                             this.pc.Fecha.ToString(),
                             this.pc.NombrePC, this.pc.NoSerie, this.pc.Marca, this.pc.Modelo,
                             this.pc.SO, this.pc.Arquitectura, this.pc.Usuario, this.pc.Procesador,
                             this.pc.DiscoGB, this.pc.RAMGB, this.pc.TipoEquipo);

                SqlCommand cmd = new SqlCommand(Sql, Conn);

                Conn.Open();
                cmd.ExecuteNonQuery();

                MessageBox.Show("Proceso finalizado correctamente", "Obtención de datos", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error al guardar: " + ex.Message, "Obtención de datos", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        public void ObtenerIdPC(string noSerie)
        {
            SqlConnection Conn = new SqlConnection();
            Conn = new SqlConnection(ConfigurationManager.ConnectionStrings["ConStr"].ConnectionString);

            try
            {
                var query = string.Format(@"
                Select ID
                From DatosPC
                Where NoSerie = '{0}' 
                ", noSerie);


                SqlCommand cmd = new SqlCommand(query, Conn);
                Conn.Open();
                SqlDataReader data = cmd.ExecuteReader();



                var resp = "";


                if (data.Read())
                {
                    resp = string.Format("{0}", data[0]);
                }

                if (resp != "")
                {
                    this.pc.ID = Convert.ToInt32(resp);

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error: " + ex.Message, "Obtención de datos", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }
        public bool ObtenerUsuarioID(string nombre)
        {
            SqlConnection Conn = new SqlConnection();
            Conn = new SqlConnection(ConfigurationManager.ConnectionStrings["ConStr"].ConnectionString);

            try
            {
                var query = string.Format(@"
                Select id
                From Usuarios
                Where nombre = '{0}' 
                ", nombre);


                SqlCommand cmd = new SqlCommand(query, Conn);
                Conn.Open();
                SqlDataReader data = cmd.ExecuteReader();

                var resp = "";

                if (data.Read())
                {
                    resp = string.Format("{0}", data[0]);
                }

                if (resp != "")
                {
                    this.usuario.ID = Convert.ToInt32(resp);
                    return true;
                }
                else
                {
                    MessageBox.Show("El usuario ingresado no se encuentra registrado. ", "Usuario no encontrado", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }

            }
            catch (Exception ex)
            {

                Console.WriteLine(ex);
                return false;
            }



        }

        public void NuevoHistorial(int id_pc, int id_usuario, int id_area)
        {
            SqlConnection Conn = new SqlConnection();
            try
            {
                Conn = new SqlConnection(ConfigurationManager.ConnectionStrings["ConStr"].ConnectionString);

                string Sql = string.Format("INSERT INTO [dbo].[HistorialPC] ([Fecha],[ID_PC],[ID_USUARIO],[ID_AREA]) " +
                         "VALUES ('{0:yyyy-MM-dd}', '{1}', '{2}', '{3}')",
                         DateTime.Today.ToString(),
                         id_pc, id_usuario, id_area);

                SqlCommand cmd = new SqlCommand(Sql, Conn);
                Conn.Open();

                cmd.ExecuteNonQuery();

                Conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error al guardar: " + ex.Message, "Obtención de datos", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

        }

        public bool Existencia(string noSerie)
        {
            SqlConnection Conn = new SqlConnection();
            Conn = new SqlConnection(ConfigurationManager.ConnectionStrings["ConStr"].ConnectionString);

            try
            {
                var query = string.Format(@"
                    Select ID
                    From DatosPC
                    Where NoSerie = '{0}' 
                    ", noSerie);


                SqlCommand cmd = new SqlCommand(query, Conn);
                Conn.Open();
                SqlDataReader data = cmd.ExecuteReader();



                var resp = "";


                if (data.Read())
                {
                    resp = string.Format("{0}", data[0]);
                }

                if (resp != "")
                {
                    this.pc.ID = Convert.ToInt32(resp);
                    return true;
                }


                return false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error: " + ex.Message, "Obtención de datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

        }

        private void cbArea_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (cbArea.SelectedIndex > 0)
			{
				this.area.ID = combo.ObtenerIdArea(cbArea.Text);
				this.area.NombreArea = cbArea.Text;
			}
		}

		private void btnGuardar_Click(object sender, EventArgs e)
		{
            SqlConnection Conn = new SqlConnection();
            this.usuario.Nombre = txtAsignadoA.Text;
            try
            {
                if (string.IsNullOrWhiteSpace(txtAsignadoA.Text) || cbArea.SelectedIndex == 0)
                {
                    MessageBox.Show("Llene los campos Asignados A y Area por favor ", "Obtención de datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtAsignadoA.Focus();
                    return;
                }

                Conn = new SqlConnection(ConfigurationManager.ConnectionStrings["ConStr"].ConnectionString);

                if (Existencia(this.pc.NoSerie))
                {
                    if (MessageBox.Show("El equipo ya ha sido registrado ¿Desea modificar el trabajador asignado a este equipo?", "Equipo ya existe", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        if (ObtenerUsuarioID(this.usuario.Nombre) != false)
                        {
                            NuevoHistorial(this.pc.ID, this.usuario.ID, this.area.ID);
                        }
                        else { return; }
                    }
                }
                else
                {

                    if (ObtenerUsuarioID(this.usuario.Nombre) != false)
                    {
                        InsertarPC();
                        ObtenerIdPC(this.pc.NoSerie);
                        NuevoHistorial(this.pc.ID, this.usuario.ID, this.area.ID);
                    }
                    else { return; }
                }

                MessageBox.Show("Proceso finalizado correctamente", "Obtención de datos", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //CREACION DDE CARTA COMPROMISO
                //btnGuardar.Enabled = btnGuardaArch.Enabled = false;
                Conn.Close();

                btnGuardar.Enabled = false;
                if (btnReporte.Enabled == false && btnGuardaArch.Enabled == false && btnOpt.Enabled == false)
                { btnOpt.Enabled = true; }

            }
            catch (Exception ex)
            {
                if (Conn.State == ConnectionState.Open)
                    Conn.Close();

                MessageBox.Show("Ocurrió un error al guardar: " + ex.Message, "Obtención de datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                btnGuardar.Enabled = btnGuardaArch.Enabled = true;
            }

        }

		private void btnGuardaArch_Click(object sender, EventArgs e)
		{
            try
            {
                this.usuario.Nombre = txtAsignadoA.Text;
                if (string.IsNullOrWhiteSpace(txtAsignadoA.Text) || cbArea.SelectedIndex == 0)
                {
                    MessageBox.Show("Llene los campos Asignados A y Area por favor ", "Obtención de datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtAsignadoA.Focus();
                    return;
                }

                saveFileDialog1.FileName = txtNoserie.Text + "-" + txtUsuario.Text + ".txt";

                if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    string f = saveFileDialog1.FileName;

                    string datos = string.Format("\t{0:yyyy-MM-dd}\t{1}\t{2}\t{3}\t{4}\t{5}\t{6}\t{7}\t{8}\t{9}\t{10}\t{11}\t{12}\t{13}",
                    DateTime.Today, this.pc.NombrePC, this.pc.NoSerie, this.pc.Marca, this.pc.Modelo, this.pc.SO,
                    this.pc.Arquitectura, this.pc.Usuario, this.pc.Procesador, this.pc.DiscoGB, this.pc.RAMGB, this.pc.TipoEquipo,
                    this.usuario.Nombre, this.area.NombreArea);

                    File.WriteAllText(f, datos);

                    MessageBox.Show("Proceso finalizado correctamente", "Obtención de datos", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    //btnGuardar.Enabled = btnGuardaArch.Enabled = false;
                    btnGuardaArch.Enabled = false;
                    if (btnReporte.Enabled == false && btnGuardar.Enabled == false && btnOpt.Enabled == false)
                    { btnOpt.Enabled = true; }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error al guardar: " + ex.Message, "Obtención de datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                btnGuardar.Enabled = btnGuardaArch.Enabled = true;
            }
        }

		private void btnOpt_Click(object sender, EventArgs e)
		{
            try
            {
                this.pc.NombrePC = txtNomEq.Text = getModelo("Name"); //Environment.MachineName;
                this.pc.Arquitectura = txt64o32b.Text = Environment.Is64BitOperatingSystem ? "x64" : "x86";
                this.pc.Usuario = txtUsuario.Text = Environment.UserName;
                this.pc.DiscoGB = txtDisco.Text = getDiscoTot(); //DriveInfo.GetDrives()[0].TotalSize + "";
                this.pc.Procesador = txtProcesa.Text = getProcesador();
                this.pc.SO = txtSO.Text = getSO();
                this.pc.NoSerie = txtNoserie.Text = getSerie();
                this.pc.Marca = txtMarca.Text = getModelo("Manufacturer");
                this.pc.Modelo = txtModelo.Text = getModelo("Model");
                this.pc.Fecha = DateTime.Today;
                double ram = double.Parse(getModelo("TotalPhysicalMemory"));
                ram = ram / 1024; //kbs
                ram = ram / 1024; //mbs
                ram = ram / 1024; //gbs

                this.pc.RAMGB = txtRam.Text = Math.Round(ram, 0) + "";

                try
                {
                    this.pc.TipoEquipo = txtTipoEq.Text = getModelo("ChassisSKUNumber");
                }
                catch
                {

                }

                MessageBox.Show("Proceso finalizado correctamente", "Obtención de datos", MessageBoxButtons.OK, MessageBoxIcon.Information);
                btnGuardar.Enabled = btnGuardaArch.Enabled = btnReporte.Enabled = true;
                btnOpt.Enabled = false;
                txtAsignadoA.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Obtención de datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                btnGuardar.Enabled = btnGuardaArch.Enabled = btnReporte.Enabled = false;
            }
        }

		private void btnReporte_Click(object sender, EventArgs e)
		{
            this.usuario.Nombre = txtAsignadoA.Text;
            frmReporte verReporte = new frmReporte();
            verReporte.PC = this.pc;
            verReporte.Usuario = this.usuario;
            verReporte.Area = this.area;

            verReporte.ShowDialog();
            btnReporte.Enabled = false;
			if (btnGuardaArch.Enabled ==false && btnGuardar.Enabled == false && btnOpt.Enabled ==false) 
            { btnOpt.Enabled = true; }
		}

		private void cmbEstado_SelectedIndexChanged(object sender, EventArgs e)
		{

            pc.Estado = cmbEstado.Text;
		}
	}
}

//validar campos en blanco

namespace ObtenerDatosEquipo4._7._2v
{
	partial class frmDatosPC
	{
		/// <summary>
		/// Variable del diseñador necesaria.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Limpiar los recursos que se estén usando.
		/// </summary>
		/// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Código generado por el Diseñador de Windows Forms

		/// <summary>
		/// Método necesario para admitir el Diseñador. No se puede modificar
		/// el contenido de este método con el editor de código.
		/// </summary>
		private void InitializeComponent()
		{
			this.btnGuardaArch = new System.Windows.Forms.Button();
			this.btnGuardar = new System.Windows.Forms.Button();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.cmbEstado = new System.Windows.Forms.ComboBox();
			this.label13 = new System.Windows.Forms.Label();
			this.cbArea = new System.Windows.Forms.ComboBox();
			this.label12 = new System.Windows.Forms.Label();
			this.txtTipoEq = new System.Windows.Forms.TextBox();
			this.label11 = new System.Windows.Forms.Label();
			this.label10 = new System.Windows.Forms.Label();
			this.txtAsignadoA = new System.Windows.Forms.TextBox();
			this.txtModelo = new System.Windows.Forms.TextBox();
			this.label9 = new System.Windows.Forms.Label();
			this.txtMarca = new System.Windows.Forms.TextBox();
			this.label8 = new System.Windows.Forms.Label();
			this.txtNoserie = new System.Windows.Forms.TextBox();
			this.label7 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.Almacenamiento = new System.Windows.Forms.Label();
			this.txtRam = new System.Windows.Forms.TextBox();
			this.txtDisco = new System.Windows.Forms.TextBox();
			this.txtProcesa = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.txtUsuario = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.txt64o32b = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.txtSO = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.txtNomEq = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.btnOpt = new System.Windows.Forms.Button();
			this.btnReporte = new System.Windows.Forms.Button();
			this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
			this.groupBox1.SuspendLayout();
			this.SuspendLayout();
			// 
			// btnGuardaArch
			// 
			this.btnGuardaArch.Enabled = false;
			this.btnGuardaArch.Location = new System.Drawing.Point(239, 695);
			this.btnGuardaArch.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.btnGuardaArch.Name = "btnGuardaArch";
			this.btnGuardaArch.Size = new System.Drawing.Size(138, 55);
			this.btnGuardaArch.TabIndex = 9;
			this.btnGuardaArch.Text = "Guardar en txt";
			this.btnGuardaArch.UseVisualStyleBackColor = true;
			this.btnGuardaArch.Click += new System.EventHandler(this.btnGuardaArch_Click);
			// 
			// btnGuardar
			// 
			this.btnGuardar.Enabled = false;
			this.btnGuardar.Location = new System.Drawing.Point(95, 695);
			this.btnGuardar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.btnGuardar.Name = "btnGuardar";
			this.btnGuardar.Size = new System.Drawing.Size(135, 55);
			this.btnGuardar.TabIndex = 8;
			this.btnGuardar.Text = "Guardar en BD";
			this.btnGuardar.UseVisualStyleBackColor = true;
			this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.cmbEstado);
			this.groupBox1.Controls.Add(this.label13);
			this.groupBox1.Controls.Add(this.cbArea);
			this.groupBox1.Controls.Add(this.label12);
			this.groupBox1.Controls.Add(this.txtTipoEq);
			this.groupBox1.Controls.Add(this.label11);
			this.groupBox1.Controls.Add(this.label10);
			this.groupBox1.Controls.Add(this.txtAsignadoA);
			this.groupBox1.Controls.Add(this.txtModelo);
			this.groupBox1.Controls.Add(this.label9);
			this.groupBox1.Controls.Add(this.txtMarca);
			this.groupBox1.Controls.Add(this.label8);
			this.groupBox1.Controls.Add(this.txtNoserie);
			this.groupBox1.Controls.Add(this.label7);
			this.groupBox1.Controls.Add(this.label6);
			this.groupBox1.Controls.Add(this.Almacenamiento);
			this.groupBox1.Controls.Add(this.txtRam);
			this.groupBox1.Controls.Add(this.txtDisco);
			this.groupBox1.Controls.Add(this.txtProcesa);
			this.groupBox1.Controls.Add(this.label5);
			this.groupBox1.Controls.Add(this.txtUsuario);
			this.groupBox1.Controls.Add(this.label4);
			this.groupBox1.Controls.Add(this.txt64o32b);
			this.groupBox1.Controls.Add(this.label3);
			this.groupBox1.Controls.Add(this.txtSO);
			this.groupBox1.Controls.Add(this.label2);
			this.groupBox1.Controls.Add(this.txtNomEq);
			this.groupBox1.Controls.Add(this.label1);
			this.groupBox1.Location = new System.Drawing.Point(45, 14);
			this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.groupBox1.Size = new System.Drawing.Size(723, 671);
			this.groupBox1.TabIndex = 7;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "[ Datos equipo ]";
			// 
			// cmbEstado
			// 
			this.cmbEstado.FormattingEnabled = true;
			this.cmbEstado.Items.AddRange(new object[] {
            "Nuevo",
            "Usado"});
			this.cmbEstado.Location = new System.Drawing.Point(177, 519);
			this.cmbEstado.Name = "cmbEstado";
			this.cmbEstado.Size = new System.Drawing.Size(479, 28);
			this.cmbEstado.TabIndex = 29;
			this.cmbEstado.Text = "Seleccione el estado del equipo";
			this.cmbEstado.SelectedIndexChanged += new System.EventHandler(this.cmbEstado_SelectedIndexChanged);
			// 
			// label13
			// 
			this.label13.AutoSize = true;
			this.label13.Location = new System.Drawing.Point(99, 519);
			this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label13.Name = "label13";
			this.label13.Size = new System.Drawing.Size(64, 20);
			this.label13.TabIndex = 28;
			this.label13.Text = "Estado:";
			// 
			// cbArea
			// 
			this.cbArea.FormattingEnabled = true;
			this.cbArea.Location = new System.Drawing.Point(175, 609);
			this.cbArea.Name = "cbArea";
			this.cbArea.Size = new System.Drawing.Size(479, 28);
			this.cbArea.TabIndex = 27;
			this.cbArea.Text = "Seleccione su área";
			this.cbArea.SelectedIndexChanged += new System.EventHandler(this.cbArea_SelectedIndexChanged);
			// 
			// label12
			// 
			this.label12.AutoSize = true;
			this.label12.Location = new System.Drawing.Point(68, 482);
			this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label12.Name = "label12";
			this.label12.Size = new System.Drawing.Size(93, 20);
			this.label12.TabIndex = 26;
			this.label12.Text = "Tipo Equipo";
			// 
			// txtTipoEq
			// 
			this.txtTipoEq.Location = new System.Drawing.Point(176, 474);
			this.txtTipoEq.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.txtTipoEq.Name = "txtTipoEq";
			this.txtTipoEq.ReadOnly = true;
			this.txtTipoEq.Size = new System.Drawing.Size(478, 26);
			this.txtTipoEq.TabIndex = 25;
			// 
			// label11
			// 
			this.label11.AutoSize = true;
			this.label11.Location = new System.Drawing.Point(102, 609);
			this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(51, 20);
			this.label11.TabIndex = 24;
			this.label11.Text = "Area: ";
			// 
			// label10
			// 
			this.label10.AutoSize = true;
			this.label10.Location = new System.Drawing.Point(68, 563);
			this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(95, 20);
			this.label10.TabIndex = 22;
			this.label10.Text = "Asignado A:";
			// 
			// txtAsignadoA
			// 
			this.txtAsignadoA.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
			this.txtAsignadoA.Location = new System.Drawing.Point(176, 558);
			this.txtAsignadoA.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.txtAsignadoA.MaxLength = 50;
			this.txtAsignadoA.Name = "txtAsignadoA";
			this.txtAsignadoA.Size = new System.Drawing.Size(478, 26);
			this.txtAsignadoA.TabIndex = 21;
			// 
			// txtModelo
			// 
			this.txtModelo.Location = new System.Drawing.Point(176, 183);
			this.txtModelo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.txtModelo.Name = "txtModelo";
			this.txtModelo.ReadOnly = true;
			this.txtModelo.Size = new System.Drawing.Size(478, 26);
			this.txtModelo.TabIndex = 19;
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.Location = new System.Drawing.Point(92, 193);
			this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(61, 20);
			this.label9.TabIndex = 20;
			this.label9.Text = "Modelo";
			// 
			// txtMarca
			// 
			this.txtMarca.Location = new System.Drawing.Point(176, 143);
			this.txtMarca.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.txtMarca.Name = "txtMarca";
			this.txtMarca.ReadOnly = true;
			this.txtMarca.Size = new System.Drawing.Size(478, 26);
			this.txtMarca.TabIndex = 17;
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Location = new System.Drawing.Point(97, 154);
			this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(53, 20);
			this.label8.TabIndex = 18;
			this.label8.Text = "Marca";
			// 
			// txtNoserie
			// 
			this.txtNoserie.Location = new System.Drawing.Point(176, 103);
			this.txtNoserie.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.txtNoserie.Name = "txtNoserie";
			this.txtNoserie.ReadOnly = true;
			this.txtNoserie.Size = new System.Drawing.Size(478, 26);
			this.txtNoserie.TabIndex = 15;
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(82, 114);
			this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(74, 20);
			this.label7.TabIndex = 16;
			this.label7.Text = "No. Serie";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(68, 442);
			this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(83, 20);
			this.label6.TabIndex = 14;
			this.label6.Text = "RAM (GB)";
			// 
			// Almacenamiento
			// 
			this.Almacenamiento.AutoSize = true;
			this.Almacenamiento.Location = new System.Drawing.Point(68, 397);
			this.Almacenamiento.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.Almacenamiento.Name = "Almacenamiento";
			this.Almacenamiento.Size = new System.Drawing.Size(87, 20);
			this.Almacenamiento.TabIndex = 13;
			this.Almacenamiento.Text = "Disco (GB)";
			// 
			// txtRam
			// 
			this.txtRam.Location = new System.Drawing.Point(176, 432);
			this.txtRam.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.txtRam.Name = "txtRam";
			this.txtRam.ReadOnly = true;
			this.txtRam.Size = new System.Drawing.Size(478, 26);
			this.txtRam.TabIndex = 12;
			// 
			// txtDisco
			// 
			this.txtDisco.Location = new System.Drawing.Point(176, 392);
			this.txtDisco.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.txtDisco.Name = "txtDisco";
			this.txtDisco.ReadOnly = true;
			this.txtDisco.Size = new System.Drawing.Size(478, 26);
			this.txtDisco.TabIndex = 11;
			// 
			// txtProcesa
			// 
			this.txtProcesa.Location = new System.Drawing.Point(176, 352);
			this.txtProcesa.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.txtProcesa.Name = "txtProcesa";
			this.txtProcesa.ReadOnly = true;
			this.txtProcesa.Size = new System.Drawing.Size(478, 26);
			this.txtProcesa.TabIndex = 9;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(68, 357);
			this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(90, 20);
			this.label5.TabIndex = 10;
			this.label5.Text = "Procesador";
			// 
			// txtUsuario
			// 
			this.txtUsuario.Location = new System.Drawing.Point(176, 312);
			this.txtUsuario.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.txtUsuario.Name = "txtUsuario";
			this.txtUsuario.ReadOnly = true;
			this.txtUsuario.Size = new System.Drawing.Size(478, 26);
			this.txtUsuario.TabIndex = 7;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(90, 323);
			this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(64, 20);
			this.label4.TabIndex = 8;
			this.label4.Text = "Usuario";
			// 
			// txt64o32b
			// 
			this.txt64o32b.Location = new System.Drawing.Point(176, 272);
			this.txt64o32b.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.txt64o32b.Name = "txt64o32b";
			this.txt64o32b.ReadOnly = true;
			this.txt64o32b.Size = new System.Drawing.Size(478, 26);
			this.txt64o32b.TabIndex = 5;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(68, 277);
			this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(96, 20);
			this.label3.TabIndex = 6;
			this.label3.Text = "Arquitectura";
			// 
			// txtSO
			// 
			this.txtSO.Location = new System.Drawing.Point(176, 232);
			this.txtSO.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.txtSO.Name = "txtSO";
			this.txtSO.ReadOnly = true;
			this.txtSO.Size = new System.Drawing.Size(478, 26);
			this.txtSO.TabIndex = 3;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(122, 243);
			this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(32, 20);
			this.label2.TabIndex = 4;
			this.label2.Text = "SO";
			// 
			// txtNomEq
			// 
			this.txtNomEq.Location = new System.Drawing.Point(176, 63);
			this.txtNomEq.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.txtNomEq.Name = "txtNomEq";
			this.txtNomEq.ReadOnly = true;
			this.txtNomEq.Size = new System.Drawing.Size(478, 26);
			this.txtNomEq.TabIndex = 0;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(63, 68);
			this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(90, 20);
			this.label1.TabIndex = 2;
			this.label1.Text = "Nombre PC";
			// 
			// btnOpt
			// 
			this.btnOpt.Location = new System.Drawing.Point(656, 695);
			this.btnOpt.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.btnOpt.Name = "btnOpt";
			this.btnOpt.Size = new System.Drawing.Size(112, 55);
			this.btnOpt.TabIndex = 6;
			this.btnOpt.Text = "Obtener";
			this.btnOpt.UseVisualStyleBackColor = true;
			this.btnOpt.Click += new System.EventHandler(this.btnOpt_Click);
			// 
			// btnReporte
			// 
			this.btnReporte.Enabled = false;
			this.btnReporte.Location = new System.Drawing.Point(405, 695);
			this.btnReporte.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.btnReporte.Name = "btnReporte";
			this.btnReporte.Size = new System.Drawing.Size(138, 55);
			this.btnReporte.TabIndex = 10;
			this.btnReporte.Text = "Generar Reporte";
			this.btnReporte.UseVisualStyleBackColor = true;
			this.btnReporte.Click += new System.EventHandler(this.btnReporte_Click);
			// 
			// frmDatosPC
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.AutoSize = true;
			this.ClientSize = new System.Drawing.Size(808, 773);
			this.Controls.Add(this.btnReporte);
			this.Controls.Add(this.btnGuardaArch);
			this.Controls.Add(this.btnGuardar);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.btnOpt);
			this.Name = "frmDatosPC";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Datos del Equipo";
			this.Load += new System.EventHandler(this.frmDatosPC_Load);
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Button btnGuardaArch;
		private System.Windows.Forms.Button btnGuardar;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.ComboBox cbArea;
		private System.Windows.Forms.Label label12;
		private System.Windows.Forms.TextBox txtTipoEq;
		private System.Windows.Forms.Label label11;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.TextBox txtAsignadoA;
		private System.Windows.Forms.TextBox txtModelo;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.TextBox txtMarca;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.TextBox txtNoserie;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label Almacenamiento;
		private System.Windows.Forms.TextBox txtRam;
		private System.Windows.Forms.TextBox txtDisco;
		private System.Windows.Forms.TextBox txtProcesa;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.TextBox txtUsuario;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox txt64o32b;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox txtSO;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox txtNomEq;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button btnOpt;
		private System.Windows.Forms.Button btnReporte;
		private System.Windows.Forms.SaveFileDialog saveFileDialog1;
		private System.Windows.Forms.ComboBox cmbEstado;
		private System.Windows.Forms.Label label13;
	}
}


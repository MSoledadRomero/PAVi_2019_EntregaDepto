namespace TP_Aplicaciones_Visuales.GUILayer
{
    partial class ABMPrestamos
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.cboEstado = new MetroFramework.Controls.MetroComboBox();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.btnCancelar = new MetroFramework.Controls.MetroButton();
            this.btnAceptar = new MetroFramework.Controls.MetroButton();
            this.cboCantLibros = new MetroFramework.Controls.MetroComboBox();
            this.metroLabel7 = new MetroFramework.Controls.MetroLabel();
            this.tabControlDetalles = new MetroFramework.Controls.MetroTabControl();
            this.metroTabPage1 = new MetroFramework.Controls.MetroTabPage();
            this.mPanel1 = new MetroFramework.Controls.MetroPanel();
            this.cboNumeroDeEjemplar1 = new MetroFramework.Controls.MetroComboBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.txtCodigoLibro1 = new MetroFramework.Controls.MetroTextBox();
            this.btnConsultarLibros = new MetroFramework.Controls.MetroButton();
            this.cboEstadoDetallePrestamo1 = new MetroFramework.Controls.MetroComboBox();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.metroTabPage2 = new MetroFramework.Controls.MetroTabPage();
            this.mPanel2 = new MetroFramework.Controls.MetroPanel();
            this.cboNumeroDeEjemplar2 = new MetroFramework.Controls.MetroComboBox();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel8 = new MetroFramework.Controls.MetroLabel();
            this.txtCodigoLibro2 = new MetroFramework.Controls.MetroTextBox();
            this.btnConsultarLibros2 = new MetroFramework.Controls.MetroButton();
            this.cboEstadoDetallePrestamo2 = new MetroFramework.Controls.MetroComboBox();
            this.metroLabel9 = new MetroFramework.Controls.MetroLabel();
            this.metroTabPage3 = new MetroFramework.Controls.MetroTabPage();
            this.mPanel3 = new MetroFramework.Controls.MetroPanel();
            this.cboNumeroDeEjemplar3 = new MetroFramework.Controls.MetroComboBox();
            this.metroLabel10 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel11 = new MetroFramework.Controls.MetroLabel();
            this.txtCodigoLibro3 = new MetroFramework.Controls.MetroTextBox();
            this.btnConsultarLibros3 = new MetroFramework.Controls.MetroButton();
            this.cboEstadoDetallePrestamo3 = new MetroFramework.Controls.MetroComboBox();
            this.metroLabel12 = new MetroFramework.Controls.MetroLabel();
            this.dtFechaLimite = new MetroFramework.Controls.MetroDateTime();
            this.tabControlDetalles.SuspendLayout();
            this.metroTabPage1.SuspendLayout();
            this.mPanel1.SuspendLayout();
            this.metroTabPage2.SuspendLayout();
            this.mPanel2.SuspendLayout();
            this.metroTabPage3.SuspendLayout();
            this.mPanel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // cboEstado
            // 
            this.cboEstado.FormattingEnabled = true;
            this.cboEstado.ItemHeight = 23;
            this.cboEstado.Location = new System.Drawing.Point(154, 103);
            this.cboEstado.Name = "cboEstado";
            this.cboEstado.Size = new System.Drawing.Size(108, 29);
            this.cboEstado.TabIndex = 47;
            this.cboEstado.UseSelectable = true;
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(445, 105);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(82, 19);
            this.metroLabel3.TabIndex = 46;
            this.metroLabel3.Text = "Fecha limite:";
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.Location = new System.Drawing.Point(37, 105);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(51, 19);
            this.metroLabel6.TabIndex = 44;
            this.metroLabel6.Text = "Estado:";
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(611, 440);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(88, 32);
            this.btnCancelar.TabIndex = 59;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseSelectable = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(23, 458);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(88, 32);
            this.btnAceptar.TabIndex = 58;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseSelectable = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // cboCantLibros
            // 
            this.cboCantLibros.FormattingEnabled = true;
            this.cboCantLibros.ItemHeight = 23;
            this.cboCantLibros.Items.AddRange(new object[] {
            "1",
            "2",
            "3"});
            this.cboCantLibros.Location = new System.Drawing.Point(588, 147);
            this.cboCantLibros.Name = "cboCantLibros";
            this.cboCantLibros.Size = new System.Drawing.Size(114, 29);
            this.cboCantLibros.TabIndex = 61;
            this.cboCantLibros.UseSelectable = true;
            this.cboCantLibros.SelectedIndexChanged += new System.EventHandler(this.cboCantLibros_SelectedIndexChanged);
            // 
            // metroLabel7
            // 
            this.metroLabel7.AutoSize = true;
            this.metroLabel7.Location = new System.Drawing.Point(445, 157);
            this.metroLabel7.Name = "metroLabel7";
            this.metroLabel7.Size = new System.Drawing.Size(120, 19);
            this.metroLabel7.TabIndex = 60;
            this.metroLabel7.Text = "Cantidad de libros:";
            // 
            // tabControlDetalles
            // 
            this.tabControlDetalles.Controls.Add(this.metroTabPage1);
            this.tabControlDetalles.Controls.Add(this.metroTabPage2);
            this.tabControlDetalles.Controls.Add(this.metroTabPage3);
            this.tabControlDetalles.Location = new System.Drawing.Point(23, 198);
            this.tabControlDetalles.Name = "tabControlDetalles";
            this.tabControlDetalles.SelectedIndex = 2;
            this.tabControlDetalles.Size = new System.Drawing.Size(676, 236);
            this.tabControlDetalles.TabIndex = 63;
            this.tabControlDetalles.UseSelectable = true;
            // 
            // metroTabPage1
            // 
            this.metroTabPage1.Controls.Add(this.mPanel1);
            this.metroTabPage1.HorizontalScrollbarBarColor = true;
            this.metroTabPage1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroTabPage1.HorizontalScrollbarSize = 10;
            this.metroTabPage1.Location = new System.Drawing.Point(4, 38);
            this.metroTabPage1.Name = "metroTabPage1";
            this.metroTabPage1.Size = new System.Drawing.Size(668, 194);
            this.metroTabPage1.TabIndex = 0;
            this.metroTabPage1.Text = "Libro 1 ";
            this.metroTabPage1.VerticalScrollbarBarColor = true;
            this.metroTabPage1.VerticalScrollbarHighlightOnWheel = false;
            this.metroTabPage1.VerticalScrollbarSize = 10;
            // 
            // mPanel1
            // 
            this.mPanel1.Controls.Add(this.cboNumeroDeEjemplar1);
            this.mPanel1.Controls.Add(this.metroLabel1);
            this.mPanel1.Controls.Add(this.metroLabel4);
            this.mPanel1.Controls.Add(this.txtCodigoLibro1);
            this.mPanel1.Controls.Add(this.btnConsultarLibros);
            this.mPanel1.Controls.Add(this.cboEstadoDetallePrestamo1);
            this.mPanel1.Controls.Add(this.metroLabel5);
            this.mPanel1.HorizontalScrollbarBarColor = true;
            this.mPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.mPanel1.HorizontalScrollbarSize = 10;
            this.mPanel1.Location = new System.Drawing.Point(0, 3);
            this.mPanel1.Name = "mPanel1";
            this.mPanel1.Size = new System.Drawing.Size(668, 188);
            this.mPanel1.TabIndex = 3;
            this.mPanel1.VerticalScrollbarBarColor = true;
            this.mPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.mPanel1.VerticalScrollbarSize = 10;
            // 
            // cboNumeroDeEjemplar1
            // 
            this.cboNumeroDeEjemplar1.FormattingEnabled = true;
            this.cboNumeroDeEjemplar1.ItemHeight = 23;
            this.cboNumeroDeEjemplar1.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.cboNumeroDeEjemplar1.Location = new System.Drawing.Point(161, 74);
            this.cboNumeroDeEjemplar1.Name = "cboNumeroDeEjemplar1";
            this.cboNumeroDeEjemplar1.Size = new System.Drawing.Size(108, 29);
            this.cboNumeroDeEjemplar1.TabIndex = 70;
            this.cboNumeroDeEjemplar1.UseSelectable = true;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(10, 38);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(106, 19);
            this.metroLabel1.TabIndex = 69;
            this.metroLabel1.Text = "Codigo de libro:";
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(10, 84);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(133, 19);
            this.metroLabel4.TabIndex = 64;
            this.metroLabel4.Text = "Numero de ejemplar";
            // 
            // txtCodigoLibro1
            // 
            // 
            // 
            // 
            this.txtCodigoLibro1.CustomButton.Image = null;
            this.txtCodigoLibro1.CustomButton.Location = new System.Drawing.Point(78, 2);
            this.txtCodigoLibro1.CustomButton.Name = "";
            this.txtCodigoLibro1.CustomButton.Size = new System.Drawing.Size(27, 27);
            this.txtCodigoLibro1.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtCodigoLibro1.CustomButton.TabIndex = 1;
            this.txtCodigoLibro1.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtCodigoLibro1.CustomButton.UseSelectable = true;
            this.txtCodigoLibro1.CustomButton.Visible = false;
            this.txtCodigoLibro1.Lines = new string[0];
            this.txtCodigoLibro1.Location = new System.Drawing.Point(161, 25);
            this.txtCodigoLibro1.MaxLength = 32767;
            this.txtCodigoLibro1.Name = "txtCodigoLibro1";
            this.txtCodigoLibro1.PasswordChar = '\0';
            this.txtCodigoLibro1.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtCodigoLibro1.SelectedText = "";
            this.txtCodigoLibro1.SelectionLength = 0;
            this.txtCodigoLibro1.SelectionStart = 0;
            this.txtCodigoLibro1.ShortcutsEnabled = true;
            this.txtCodigoLibro1.Size = new System.Drawing.Size(108, 32);
            this.txtCodigoLibro1.TabIndex = 65;
            this.txtCodigoLibro1.UseSelectable = true;
            this.txtCodigoLibro1.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtCodigoLibro1.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // btnConsultarLibros
            // 
            this.btnConsultarLibros.Location = new System.Drawing.Point(309, 25);
            this.btnConsultarLibros.Name = "btnConsultarLibros";
            this.btnConsultarLibros.Size = new System.Drawing.Size(136, 32);
            this.btnConsultarLibros.TabIndex = 66;
            this.btnConsultarLibros.Text = "Consultar Libros";
            this.btnConsultarLibros.UseSelectable = true;
            this.btnConsultarLibros.Click += new System.EventHandler(this.btnConsultarLibros_Click);
            // 
            // cboEstadoDetallePrestamo1
            // 
            this.cboEstadoDetallePrestamo1.FormattingEnabled = true;
            this.cboEstadoDetallePrestamo1.ItemHeight = 23;
            this.cboEstadoDetallePrestamo1.Location = new System.Drawing.Point(161, 120);
            this.cboEstadoDetallePrestamo1.Name = "cboEstadoDetallePrestamo1";
            this.cboEstadoDetallePrestamo1.Size = new System.Drawing.Size(108, 29);
            this.cboEstadoDetallePrestamo1.TabIndex = 68;
            this.cboEstadoDetallePrestamo1.UseSelectable = true;
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.Location = new System.Drawing.Point(10, 130);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(51, 19);
            this.metroLabel5.TabIndex = 67;
            this.metroLabel5.Text = "Estado:";
            // 
            // metroTabPage2
            // 
            this.metroTabPage2.Controls.Add(this.mPanel2);
            this.metroTabPage2.HorizontalScrollbarBarColor = true;
            this.metroTabPage2.HorizontalScrollbarHighlightOnWheel = false;
            this.metroTabPage2.HorizontalScrollbarSize = 10;
            this.metroTabPage2.Location = new System.Drawing.Point(4, 38);
            this.metroTabPage2.Name = "metroTabPage2";
            this.metroTabPage2.Size = new System.Drawing.Size(668, 194);
            this.metroTabPage2.TabIndex = 1;
            this.metroTabPage2.Text = "Libro 2";
            this.metroTabPage2.VerticalScrollbarBarColor = true;
            this.metroTabPage2.VerticalScrollbarHighlightOnWheel = false;
            this.metroTabPage2.VerticalScrollbarSize = 10;
            // 
            // mPanel2
            // 
            this.mPanel2.Controls.Add(this.cboNumeroDeEjemplar2);
            this.mPanel2.Controls.Add(this.metroLabel2);
            this.mPanel2.Controls.Add(this.metroLabel8);
            this.mPanel2.Controls.Add(this.txtCodigoLibro2);
            this.mPanel2.Controls.Add(this.btnConsultarLibros2);
            this.mPanel2.Controls.Add(this.cboEstadoDetallePrestamo2);
            this.mPanel2.Controls.Add(this.metroLabel9);
            this.mPanel2.HorizontalScrollbarBarColor = true;
            this.mPanel2.HorizontalScrollbarHighlightOnWheel = false;
            this.mPanel2.HorizontalScrollbarSize = 10;
            this.mPanel2.Location = new System.Drawing.Point(0, 3);
            this.mPanel2.Name = "mPanel2";
            this.mPanel2.Size = new System.Drawing.Size(668, 188);
            this.mPanel2.TabIndex = 3;
            this.mPanel2.VerticalScrollbarBarColor = true;
            this.mPanel2.VerticalScrollbarHighlightOnWheel = false;
            this.mPanel2.VerticalScrollbarSize = 10;
            // 
            // cboNumeroDeEjemplar2
            // 
            this.cboNumeroDeEjemplar2.FormattingEnabled = true;
            this.cboNumeroDeEjemplar2.ItemHeight = 23;
            this.cboNumeroDeEjemplar2.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.cboNumeroDeEjemplar2.Location = new System.Drawing.Point(161, 74);
            this.cboNumeroDeEjemplar2.Name = "cboNumeroDeEjemplar2";
            this.cboNumeroDeEjemplar2.Size = new System.Drawing.Size(108, 29);
            this.cboNumeroDeEjemplar2.TabIndex = 70;
            this.cboNumeroDeEjemplar2.UseSelectable = true;
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(10, 38);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(106, 19);
            this.metroLabel2.TabIndex = 69;
            this.metroLabel2.Text = "Codigo de libro:";
            // 
            // metroLabel8
            // 
            this.metroLabel8.AutoSize = true;
            this.metroLabel8.Location = new System.Drawing.Point(10, 84);
            this.metroLabel8.Name = "metroLabel8";
            this.metroLabel8.Size = new System.Drawing.Size(133, 19);
            this.metroLabel8.TabIndex = 64;
            this.metroLabel8.Text = "Numero de ejemplar";
            // 
            // txtCodigoLibro2
            // 
            // 
            // 
            // 
            this.txtCodigoLibro2.CustomButton.Image = null;
            this.txtCodigoLibro2.CustomButton.Location = new System.Drawing.Point(78, 2);
            this.txtCodigoLibro2.CustomButton.Name = "";
            this.txtCodigoLibro2.CustomButton.Size = new System.Drawing.Size(27, 27);
            this.txtCodigoLibro2.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtCodigoLibro2.CustomButton.TabIndex = 1;
            this.txtCodigoLibro2.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtCodigoLibro2.CustomButton.UseSelectable = true;
            this.txtCodigoLibro2.CustomButton.Visible = false;
            this.txtCodigoLibro2.Lines = new string[0];
            this.txtCodigoLibro2.Location = new System.Drawing.Point(161, 25);
            this.txtCodigoLibro2.MaxLength = 32767;
            this.txtCodigoLibro2.Name = "txtCodigoLibro2";
            this.txtCodigoLibro2.PasswordChar = '\0';
            this.txtCodigoLibro2.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtCodigoLibro2.SelectedText = "";
            this.txtCodigoLibro2.SelectionLength = 0;
            this.txtCodigoLibro2.SelectionStart = 0;
            this.txtCodigoLibro2.ShortcutsEnabled = true;
            this.txtCodigoLibro2.Size = new System.Drawing.Size(108, 32);
            this.txtCodigoLibro2.TabIndex = 65;
            this.txtCodigoLibro2.UseSelectable = true;
            this.txtCodigoLibro2.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtCodigoLibro2.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // btnConsultarLibros2
            // 
            this.btnConsultarLibros2.Location = new System.Drawing.Point(309, 25);
            this.btnConsultarLibros2.Name = "btnConsultarLibros2";
            this.btnConsultarLibros2.Size = new System.Drawing.Size(136, 32);
            this.btnConsultarLibros2.TabIndex = 66;
            this.btnConsultarLibros2.Text = "Consultar Libros";
            this.btnConsultarLibros2.UseSelectable = true;
            this.btnConsultarLibros2.Click += new System.EventHandler(this.btnConsultarLibros_Click);
            // 
            // cboEstadoDetallePrestamo2
            // 
            this.cboEstadoDetallePrestamo2.FormattingEnabled = true;
            this.cboEstadoDetallePrestamo2.ItemHeight = 23;
            this.cboEstadoDetallePrestamo2.Location = new System.Drawing.Point(161, 120);
            this.cboEstadoDetallePrestamo2.Name = "cboEstadoDetallePrestamo2";
            this.cboEstadoDetallePrestamo2.Size = new System.Drawing.Size(108, 29);
            this.cboEstadoDetallePrestamo2.TabIndex = 68;
            this.cboEstadoDetallePrestamo2.UseSelectable = true;
            // 
            // metroLabel9
            // 
            this.metroLabel9.AutoSize = true;
            this.metroLabel9.Location = new System.Drawing.Point(10, 130);
            this.metroLabel9.Name = "metroLabel9";
            this.metroLabel9.Size = new System.Drawing.Size(51, 19);
            this.metroLabel9.TabIndex = 67;
            this.metroLabel9.Text = "Estado:";
            // 
            // metroTabPage3
            // 
            this.metroTabPage3.Controls.Add(this.mPanel3);
            this.metroTabPage3.HorizontalScrollbarBarColor = true;
            this.metroTabPage3.HorizontalScrollbarHighlightOnWheel = false;
            this.metroTabPage3.HorizontalScrollbarSize = 10;
            this.metroTabPage3.Location = new System.Drawing.Point(4, 38);
            this.metroTabPage3.Name = "metroTabPage3";
            this.metroTabPage3.Size = new System.Drawing.Size(668, 194);
            this.metroTabPage3.TabIndex = 2;
            this.metroTabPage3.Text = "Libro 3";
            this.metroTabPage3.VerticalScrollbarBarColor = true;
            this.metroTabPage3.VerticalScrollbarHighlightOnWheel = false;
            this.metroTabPage3.VerticalScrollbarSize = 10;
            // 
            // mPanel3
            // 
            this.mPanel3.Controls.Add(this.cboNumeroDeEjemplar3);
            this.mPanel3.Controls.Add(this.metroLabel10);
            this.mPanel3.Controls.Add(this.metroLabel11);
            this.mPanel3.Controls.Add(this.txtCodigoLibro3);
            this.mPanel3.Controls.Add(this.btnConsultarLibros3);
            this.mPanel3.Controls.Add(this.cboEstadoDetallePrestamo3);
            this.mPanel3.Controls.Add(this.metroLabel12);
            this.mPanel3.HorizontalScrollbarBarColor = true;
            this.mPanel3.HorizontalScrollbarHighlightOnWheel = false;
            this.mPanel3.HorizontalScrollbarSize = 10;
            this.mPanel3.Location = new System.Drawing.Point(0, 3);
            this.mPanel3.Name = "mPanel3";
            this.mPanel3.Size = new System.Drawing.Size(668, 188);
            this.mPanel3.TabIndex = 3;
            this.mPanel3.VerticalScrollbarBarColor = true;
            this.mPanel3.VerticalScrollbarHighlightOnWheel = false;
            this.mPanel3.VerticalScrollbarSize = 10;
            // 
            // cboNumeroDeEjemplar3
            // 
            this.cboNumeroDeEjemplar3.FormattingEnabled = true;
            this.cboNumeroDeEjemplar3.ItemHeight = 23;
            this.cboNumeroDeEjemplar3.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.cboNumeroDeEjemplar3.Location = new System.Drawing.Point(161, 74);
            this.cboNumeroDeEjemplar3.Name = "cboNumeroDeEjemplar3";
            this.cboNumeroDeEjemplar3.Size = new System.Drawing.Size(108, 29);
            this.cboNumeroDeEjemplar3.TabIndex = 70;
            this.cboNumeroDeEjemplar3.UseSelectable = true;
            // 
            // metroLabel10
            // 
            this.metroLabel10.AutoSize = true;
            this.metroLabel10.Location = new System.Drawing.Point(10, 38);
            this.metroLabel10.Name = "metroLabel10";
            this.metroLabel10.Size = new System.Drawing.Size(106, 19);
            this.metroLabel10.TabIndex = 69;
            this.metroLabel10.Text = "Codigo de libro:";
            // 
            // metroLabel11
            // 
            this.metroLabel11.AutoSize = true;
            this.metroLabel11.Location = new System.Drawing.Point(10, 84);
            this.metroLabel11.Name = "metroLabel11";
            this.metroLabel11.Size = new System.Drawing.Size(133, 19);
            this.metroLabel11.TabIndex = 64;
            this.metroLabel11.Text = "Numero de ejemplar";
            // 
            // txtCodigoLibro3
            // 
            // 
            // 
            // 
            this.txtCodigoLibro3.CustomButton.Image = null;
            this.txtCodigoLibro3.CustomButton.Location = new System.Drawing.Point(78, 2);
            this.txtCodigoLibro3.CustomButton.Name = "";
            this.txtCodigoLibro3.CustomButton.Size = new System.Drawing.Size(27, 27);
            this.txtCodigoLibro3.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtCodigoLibro3.CustomButton.TabIndex = 1;
            this.txtCodigoLibro3.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtCodigoLibro3.CustomButton.UseSelectable = true;
            this.txtCodigoLibro3.CustomButton.Visible = false;
            this.txtCodigoLibro3.Lines = new string[0];
            this.txtCodigoLibro3.Location = new System.Drawing.Point(161, 25);
            this.txtCodigoLibro3.MaxLength = 32767;
            this.txtCodigoLibro3.Name = "txtCodigoLibro3";
            this.txtCodigoLibro3.PasswordChar = '\0';
            this.txtCodigoLibro3.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtCodigoLibro3.SelectedText = "";
            this.txtCodigoLibro3.SelectionLength = 0;
            this.txtCodigoLibro3.SelectionStart = 0;
            this.txtCodigoLibro3.ShortcutsEnabled = true;
            this.txtCodigoLibro3.Size = new System.Drawing.Size(108, 32);
            this.txtCodigoLibro3.TabIndex = 65;
            this.txtCodigoLibro3.UseSelectable = true;
            this.txtCodigoLibro3.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtCodigoLibro3.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // btnConsultarLibros3
            // 
            this.btnConsultarLibros3.Location = new System.Drawing.Point(309, 25);
            this.btnConsultarLibros3.Name = "btnConsultarLibros3";
            this.btnConsultarLibros3.Size = new System.Drawing.Size(136, 32);
            this.btnConsultarLibros3.TabIndex = 66;
            this.btnConsultarLibros3.Text = "Consultar Libros";
            this.btnConsultarLibros3.UseSelectable = true;
            this.btnConsultarLibros3.Click += new System.EventHandler(this.btnConsultarLibros_Click);
            // 
            // cboEstadoDetallePrestamo3
            // 
            this.cboEstadoDetallePrestamo3.FormattingEnabled = true;
            this.cboEstadoDetallePrestamo3.ItemHeight = 23;
            this.cboEstadoDetallePrestamo3.Location = new System.Drawing.Point(161, 120);
            this.cboEstadoDetallePrestamo3.Name = "cboEstadoDetallePrestamo3";
            this.cboEstadoDetallePrestamo3.Size = new System.Drawing.Size(108, 29);
            this.cboEstadoDetallePrestamo3.TabIndex = 68;
            this.cboEstadoDetallePrestamo3.UseSelectable = true;
            // 
            // metroLabel12
            // 
            this.metroLabel12.AutoSize = true;
            this.metroLabel12.Location = new System.Drawing.Point(10, 130);
            this.metroLabel12.Name = "metroLabel12";
            this.metroLabel12.Size = new System.Drawing.Size(51, 19);
            this.metroLabel12.TabIndex = 67;
            this.metroLabel12.Text = "Estado:";
            // 
            // dtFechaLimite
            // 
            this.dtFechaLimite.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtFechaLimite.Location = new System.Drawing.Point(588, 103);
            this.dtFechaLimite.MinimumSize = new System.Drawing.Size(0, 29);
            this.dtFechaLimite.Name = "dtFechaLimite";
            this.dtFechaLimite.Size = new System.Drawing.Size(114, 29);
            this.dtFechaLimite.TabIndex = 64;
            // 
            // ABMPrestamos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(725, 509);
            this.Controls.Add(this.dtFechaLimite);
            this.Controls.Add(this.tabControlDetalles);
            this.Controls.Add(this.cboCantLibros);
            this.Controls.Add(this.metroLabel7);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.cboEstado);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.metroLabel6);
            this.Name = "ABMPrestamos";
            this.Text = "Prestamo";
            this.Load += new System.EventHandler(this.ABMPrestamos_Load);
            this.tabControlDetalles.ResumeLayout(false);
            this.metroTabPage1.ResumeLayout(false);
            this.mPanel1.ResumeLayout(false);
            this.mPanel1.PerformLayout();
            this.metroTabPage2.ResumeLayout(false);
            this.mPanel2.ResumeLayout(false);
            this.mPanel2.PerformLayout();
            this.metroTabPage3.ResumeLayout(false);
            this.mPanel3.ResumeLayout(false);
            this.mPanel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MetroFramework.Controls.MetroComboBox cboEstado;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private MetroFramework.Controls.MetroButton btnCancelar;
        private MetroFramework.Controls.MetroButton btnAceptar;
        private MetroFramework.Controls.MetroComboBox cboCantLibros;
        private MetroFramework.Controls.MetroLabel metroLabel7;
        private MetroFramework.Controls.MetroTabControl tabControlDetalles;
        private MetroFramework.Controls.MetroTabPage metroTabPage1;
        private MetroFramework.Controls.MetroTabPage metroTabPage2;
        private MetroFramework.Controls.MetroTabPage metroTabPage3;
        private MetroFramework.Controls.MetroDateTime dtFechaLimite;
        private MetroFramework.Controls.MetroPanel mPanel1;
        private MetroFramework.Controls.MetroComboBox cboNumeroDeEjemplar1;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroTextBox txtCodigoLibro1;
        private MetroFramework.Controls.MetroButton btnConsultarLibros;
        private MetroFramework.Controls.MetroComboBox cboEstadoDetallePrestamo1;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroPanel mPanel2;
        private MetroFramework.Controls.MetroComboBox cboNumeroDeEjemplar2;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel8;
        private MetroFramework.Controls.MetroTextBox txtCodigoLibro2;
        private MetroFramework.Controls.MetroButton btnConsultarLibros2;
        private MetroFramework.Controls.MetroComboBox cboEstadoDetallePrestamo2;
        private MetroFramework.Controls.MetroLabel metroLabel9;
        private MetroFramework.Controls.MetroPanel mPanel3;
        private MetroFramework.Controls.MetroComboBox cboNumeroDeEjemplar3;
        private MetroFramework.Controls.MetroLabel metroLabel10;
        private MetroFramework.Controls.MetroLabel metroLabel11;
        private MetroFramework.Controls.MetroTextBox txtCodigoLibro3;
        private MetroFramework.Controls.MetroButton btnConsultarLibros3;
        private MetroFramework.Controls.MetroComboBox cboEstadoDetallePrestamo3;
        private MetroFramework.Controls.MetroLabel metroLabel12;
    }
}
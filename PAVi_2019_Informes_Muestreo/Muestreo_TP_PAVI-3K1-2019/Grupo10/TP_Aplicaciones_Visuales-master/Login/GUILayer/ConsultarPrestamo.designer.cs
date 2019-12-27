namespace TP_Aplicaciones_Visuales.GUILayer
{
    partial class frmPrestamo
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnAgregar = new MetroFramework.Controls.MetroButton();
            this.btnModificar = new MetroFramework.Controls.MetroButton();
            this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
            this.dgvPrestamos = new MetroFramework.Controls.MetroGrid();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel7 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel8 = new MetroFramework.Controls.MetroLabel();
            this.cboEstado = new MetroFramework.Controls.MetroComboBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.txtIDPrestamo = new MetroFramework.Controls.MetroTextBox();
            this.txtFechaPrestamo = new System.Windows.Forms.MaskedTextBox();
            this.btnConsultar = new MetroFramework.Controls.MetroButton();
            this.txtFechaLimite = new System.Windows.Forms.MaskedTextBox();
            this.metroButton1 = new MetroFramework.Controls.MetroButton();
            this.txtIDSocio = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroButton2 = new MetroFramework.Controls.MetroButton();
            this.metroPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPrestamos)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(24, 518);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(88, 32);
            this.btnAgregar.TabIndex = 21;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseSelectable = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.Location = new System.Drawing.Point(140, 518);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(88, 32);
            this.btnModificar.TabIndex = 22;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseSelectable = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // metroPanel1
            // 
            this.metroPanel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.metroPanel1.Controls.Add(this.dgvPrestamos);
            this.metroPanel1.HorizontalScrollbarBarColor = true;
            this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel1.HorizontalScrollbarSize = 10;
            this.metroPanel1.Location = new System.Drawing.Point(23, 215);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(646, 295);
            this.metroPanel1.TabIndex = 25;
            this.metroPanel1.VerticalScrollbarBarColor = true;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 10;
            // 
            // dgvPrestamos
            // 
            this.dgvPrestamos.AllowUserToAddRows = false;
            this.dgvPrestamos.AllowUserToResizeRows = false;
            this.dgvPrestamos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPrestamos.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dgvPrestamos.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvPrestamos.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
            this.dgvPrestamos.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPrestamos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dgvPrestamos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvPrestamos.DefaultCellStyle = dataGridViewCellStyle8;
            this.dgvPrestamos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvPrestamos.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.dgvPrestamos.EnableHeadersVisualStyles = false;
            this.dgvPrestamos.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.dgvPrestamos.GridColor = System.Drawing.Color.Black;
            this.dgvPrestamos.Location = new System.Drawing.Point(0, 0);
            this.dgvPrestamos.MultiSelect = false;
            this.dgvPrestamos.Name = "dgvPrestamos";
            this.dgvPrestamos.ReadOnly = true;
            this.dgvPrestamos.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPrestamos.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.dgvPrestamos.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvPrestamos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPrestamos.Size = new System.Drawing.Size(644, 293);
            this.dgvPrestamos.TabIndex = 56;
            this.dgvPrestamos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPrestamos_CellContentClick);
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.Location = new System.Drawing.Point(23, 174);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(51, 19);
            this.metroLabel6.TabIndex = 27;
            this.metroLabel6.Text = "Estado:";
            // 
            // metroLabel7
            // 
            this.metroLabel7.AutoSize = true;
            this.metroLabel7.Location = new System.Drawing.Point(20, 129);
            this.metroLabel7.Name = "metroLabel7";
            this.metroLabel7.Size = new System.Drawing.Size(122, 19);
            this.metroLabel7.TabIndex = 28;
            this.metroLabel7.Text = "Fecha de prestamo";
            // 
            // metroLabel8
            // 
            this.metroLabel8.AutoSize = true;
            this.metroLabel8.Location = new System.Drawing.Point(386, 129);
            this.metroLabel8.Name = "metroLabel8";
            this.metroLabel8.Size = new System.Drawing.Size(165, 19);
            this.metroLabel8.TabIndex = 29;
            this.metroLabel8.Text = "Fecha limite de devolucion";
            // 
            // cboEstado
            // 
            this.cboEstado.FormattingEnabled = true;
            this.cboEstado.ItemHeight = 23;
            this.cboEstado.Location = new System.Drawing.Point(140, 174);
            this.cboEstado.Name = "cboEstado";
            this.cboEstado.Size = new System.Drawing.Size(108, 29);
            this.cboEstado.TabIndex = 33;
            this.cboEstado.UseSelectable = true;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(414, 80);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(135, 19);
            this.metroLabel1.TabIndex = 34;
            this.metroLabel1.Text = "Codigo de Prestamo:";
            // 
            // txtIDPrestamo
            // 
            // 
            // 
            // 
            this.txtIDPrestamo.CustomButton.Image = null;
            this.txtIDPrestamo.CustomButton.Location = new System.Drawing.Point(78, 2);
            this.txtIDPrestamo.CustomButton.Name = "";
            this.txtIDPrestamo.CustomButton.Size = new System.Drawing.Size(27, 27);
            this.txtIDPrestamo.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtIDPrestamo.CustomButton.TabIndex = 1;
            this.txtIDPrestamo.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtIDPrestamo.CustomButton.UseSelectable = true;
            this.txtIDPrestamo.CustomButton.Visible = false;
            this.txtIDPrestamo.Lines = new string[0];
            this.txtIDPrestamo.Location = new System.Drawing.Point(555, 80);
            this.txtIDPrestamo.MaxLength = 32767;
            this.txtIDPrestamo.Name = "txtIDPrestamo";
            this.txtIDPrestamo.PasswordChar = '\0';
            this.txtIDPrestamo.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtIDPrestamo.SelectedText = "";
            this.txtIDPrestamo.SelectionLength = 0;
            this.txtIDPrestamo.SelectionStart = 0;
            this.txtIDPrestamo.ShortcutsEnabled = true;
            this.txtIDPrestamo.Size = new System.Drawing.Size(108, 32);
            this.txtIDPrestamo.TabIndex = 35;
            this.txtIDPrestamo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtIDPrestamo.UseSelectable = true;
            this.txtIDPrestamo.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtIDPrestamo.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtFechaPrestamo
            // 
            this.txtFechaPrestamo.Location = new System.Drawing.Point(140, 128);
            this.txtFechaPrestamo.Mask = "00/00/0000";
            this.txtFechaPrestamo.Name = "txtFechaPrestamo";
            this.txtFechaPrestamo.Size = new System.Drawing.Size(108, 20);
            this.txtFechaPrestamo.TabIndex = 38;
            this.txtFechaPrestamo.ValidatingType = typeof(System.DateTime);
            // 
            // btnConsultar
            // 
            this.btnConsultar.Location = new System.Drawing.Point(559, 171);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(108, 32);
            this.btnConsultar.TabIndex = 10;
            this.btnConsultar.Text = "Consultar";
            this.btnConsultar.UseSelectable = true;
            this.btnConsultar.Click += new System.EventHandler(this.btnConsultar_Click);
            // 
            // txtFechaLimite
            // 
            this.txtFechaLimite.Location = new System.Drawing.Point(555, 128);
            this.txtFechaLimite.Mask = "00/00/0000";
            this.txtFechaLimite.Name = "txtFechaLimite";
            this.txtFechaLimite.Size = new System.Drawing.Size(108, 20);
            this.txtFechaLimite.TabIndex = 39;
            this.txtFechaLimite.ValidatingType = typeof(System.DateTime);
            // 
            // metroButton1
            // 
            this.metroButton1.Location = new System.Drawing.Point(254, 518);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(88, 32);
            this.metroButton1.TabIndex = 40;
            this.metroButton1.Text = "Detalle";
            this.metroButton1.UseSelectable = true;
            // 
            // txtIDSocio
            // 
            // 
            // 
            // 
            this.txtIDSocio.CustomButton.Image = null;
            this.txtIDSocio.CustomButton.Location = new System.Drawing.Point(78, 2);
            this.txtIDSocio.CustomButton.Name = "";
            this.txtIDSocio.CustomButton.Size = new System.Drawing.Size(27, 27);
            this.txtIDSocio.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtIDSocio.CustomButton.TabIndex = 1;
            this.txtIDSocio.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtIDSocio.CustomButton.UseSelectable = true;
            this.txtIDSocio.CustomButton.Visible = false;
            this.txtIDSocio.Lines = new string[0];
            this.txtIDSocio.Location = new System.Drawing.Point(140, 80);
            this.txtIDSocio.MaxLength = 32767;
            this.txtIDSocio.Name = "txtIDSocio";
            this.txtIDSocio.PasswordChar = '\0';
            this.txtIDSocio.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtIDSocio.SelectedText = "";
            this.txtIDSocio.SelectionLength = 0;
            this.txtIDSocio.SelectionStart = 0;
            this.txtIDSocio.ShortcutsEnabled = true;
            this.txtIDSocio.Size = new System.Drawing.Size(108, 32);
            this.txtIDSocio.TabIndex = 42;
            this.txtIDSocio.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtIDSocio.UseSelectable = true;
            this.txtIDSocio.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtIDSocio.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(20, 80);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(106, 19);
            this.metroLabel2.TabIndex = 41;
            this.metroLabel2.Text = "Codigo de socio";
            // 
            // metroButton2
            // 
            this.metroButton2.Location = new System.Drawing.Point(254, 80);
            this.metroButton2.Name = "metroButton2";
            this.metroButton2.Size = new System.Drawing.Size(136, 32);
            this.metroButton2.TabIndex = 43;
            this.metroButton2.Text = "Consultar Socio";
            this.metroButton2.UseSelectable = true;
            this.metroButton2.Click += new System.EventHandler(this.metroButton2_Click);
            // 
            // frmPrestamo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(688, 566);
            this.Controls.Add(this.metroButton2);
            this.Controls.Add(this.txtIDSocio);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroButton1);
            this.Controls.Add(this.txtFechaLimite);
            this.Controls.Add(this.txtFechaPrestamo);
            this.Controls.Add(this.txtIDPrestamo);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.cboEstado);
            this.Controls.Add(this.btnConsultar);
            this.Controls.Add(this.metroLabel8);
            this.Controls.Add(this.metroLabel7);
            this.Controls.Add(this.metroLabel6);
            this.Controls.Add(this.metroPanel1);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.btnAgregar);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(692, 601);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(641, 466);
            this.Name = "frmPrestamo";
            this.Text = "Prestamo";
            this.Load += new System.EventHandler(this.frmPrestamo_Load);
            this.metroPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPrestamos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MetroFramework.Controls.MetroButton btnAgregar;
        private MetroFramework.Controls.MetroButton btnModificar;
        private MetroFramework.Controls.MetroPanel metroPanel1;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private MetroFramework.Controls.MetroLabel metroLabel7;
        private MetroFramework.Controls.MetroLabel metroLabel8;
        private MetroFramework.Controls.MetroComboBox cboEstado;
        private MetroFramework.Controls.MetroGrid dgvPrestamos;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroTextBox txtIDPrestamo;
        private System.Windows.Forms.MaskedTextBox txtFechaPrestamo;
        private MetroFramework.Controls.MetroButton btnConsultar;
        private System.Windows.Forms.MaskedTextBox txtFechaLimite;
        private MetroFramework.Controls.MetroButton metroButton1;
        private MetroFramework.Controls.MetroTextBox txtIDSocio;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroButton metroButton2;
    }
}
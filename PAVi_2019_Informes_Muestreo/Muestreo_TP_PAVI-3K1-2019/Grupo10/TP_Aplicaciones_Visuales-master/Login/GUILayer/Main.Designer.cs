namespace TP_Aplicaciones_Visuales.GUILayer
{
    partial class frmMain
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.metroTileProveedores = new MetroFramework.Controls.MetroTile();
            this.metroTileTiposDeDocumento = new MetroFramework.Controls.MetroTile();
            this.metroTileCompras = new MetroFramework.Controls.MetroTile();
            this.metroTilePrestamos = new MetroFramework.Controls.MetroTile();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.consultarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.agregarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eliminarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.metroTileBarrios = new MetroFramework.Controls.MetroTile();
            this.metroTileGeneros = new MetroFramework.Controls.MetroTile();
            this.metroTileLibros = new MetroFramework.Controls.MetroTile();
            this.metroTileEditoriales = new MetroFramework.Controls.MetroTile();
            this.metroTileAutores = new MetroFramework.Controls.MetroTile();
            this.metroTileInformes = new MetroFramework.Controls.MetroTile();
            this.metroTileSocios = new MetroFramework.Controls.MetroTile();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // metroTileProveedores
            // 
            this.metroTileProveedores.ActiveControl = null;
            this.metroTileProveedores.Location = new System.Drawing.Point(478, 214);
            this.metroTileProveedores.Name = "metroTileProveedores";
            this.metroTileProveedores.Size = new System.Drawing.Size(135, 125);
            this.metroTileProveedores.TabIndex = 10;
            this.metroTileProveedores.Text = "Proveedores";
            this.metroTileProveedores.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.metroTileProveedores.TileImage = global::TP_Aplicaciones_Visuales.Properties.Resources.Proveedor;
            this.metroTileProveedores.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroTileProveedores.UseSelectable = true;
            this.metroTileProveedores.UseTileImage = true;
            this.metroTileProveedores.Click += new System.EventHandler(this.metroTileProveedores_Click_1);
            // 
            // metroTileTiposDeDocumento
            // 
            this.metroTileTiposDeDocumento.ActiveControl = null;
            this.metroTileTiposDeDocumento.Location = new System.Drawing.Point(336, 214);
            this.metroTileTiposDeDocumento.Name = "metroTileTiposDeDocumento";
            this.metroTileTiposDeDocumento.Size = new System.Drawing.Size(135, 125);
            this.metroTileTiposDeDocumento.TabIndex = 9;
            this.metroTileTiposDeDocumento.Text = "Documentos";
            this.metroTileTiposDeDocumento.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.metroTileTiposDeDocumento.TileImage = ((System.Drawing.Image)(resources.GetObject("metroTileTiposDeDocumento.TileImage")));
            this.metroTileTiposDeDocumento.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroTileTiposDeDocumento.UseSelectable = true;
            this.metroTileTiposDeDocumento.UseTileImage = true;
            this.metroTileTiposDeDocumento.Click += new System.EventHandler(this.metroTileTiposDeDocumento_Click);
            // 
            // metroTileCompras
            // 
            this.metroTileCompras.ActiveControl = null;
            this.metroTileCompras.Location = new System.Drawing.Point(23, 214);
            this.metroTileCompras.Name = "metroTileCompras";
            this.metroTileCompras.Size = new System.Drawing.Size(135, 125);
            this.metroTileCompras.TabIndex = 8;
            this.metroTileCompras.Text = "Compras";
            this.metroTileCompras.TileImage = ((System.Drawing.Image)(resources.GetObject("metroTileCompras.TileImage")));
            this.metroTileCompras.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroTileCompras.UseSelectable = true;
            this.metroTileCompras.UseTileImage = true;
            this.metroTileCompras.Click += new System.EventHandler(this.metroTileCompras_Click);
            // 
            // metroTilePrestamos
            // 
            this.metroTilePrestamos.ActiveControl = null;
            this.metroTilePrestamos.ContextMenuStrip = this.contextMenuStrip1;
            this.metroTilePrestamos.Location = new System.Drawing.Point(23, 83);
            this.metroTilePrestamos.Name = "metroTilePrestamos";
            this.metroTilePrestamos.Size = new System.Drawing.Size(135, 125);
            this.metroTilePrestamos.TabIndex = 7;
            this.metroTilePrestamos.Text = "Prestamos";
            this.metroTilePrestamos.TileImage = ((System.Drawing.Image)(resources.GetObject("metroTilePrestamos.TileImage")));
            this.metroTilePrestamos.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroTilePrestamos.UseSelectable = true;
            this.metroTilePrestamos.UseTileImage = true;
            this.metroTilePrestamos.Click += new System.EventHandler(this.metroTilePrestamos_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.consultarToolStripMenuItem,
            this.agregarToolStripMenuItem,
            this.eliminarToolStripMenuItem,
            this.editarToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(126, 92);
            // 
            // consultarToolStripMenuItem
            // 
            this.consultarToolStripMenuItem.Name = "consultarToolStripMenuItem";
            this.consultarToolStripMenuItem.Size = new System.Drawing.Size(125, 22);
            this.consultarToolStripMenuItem.Text = "Consultar";
            // 
            // agregarToolStripMenuItem
            // 
            this.agregarToolStripMenuItem.Name = "agregarToolStripMenuItem";
            this.agregarToolStripMenuItem.Size = new System.Drawing.Size(125, 22);
            this.agregarToolStripMenuItem.Text = "Agregar";
            // 
            // eliminarToolStripMenuItem
            // 
            this.eliminarToolStripMenuItem.Name = "eliminarToolStripMenuItem";
            this.eliminarToolStripMenuItem.Size = new System.Drawing.Size(125, 22);
            this.eliminarToolStripMenuItem.Text = "Eliminar";
            // 
            // editarToolStripMenuItem
            // 
            this.editarToolStripMenuItem.Name = "editarToolStripMenuItem";
            this.editarToolStripMenuItem.Size = new System.Drawing.Size(125, 22);
            this.editarToolStripMenuItem.Text = "Editar";
            // 
            // metroTileBarrios
            // 
            this.metroTileBarrios.ActiveControl = null;
            this.metroTileBarrios.Location = new System.Drawing.Point(477, 83);
            this.metroTileBarrios.Name = "metroTileBarrios";
            this.metroTileBarrios.Size = new System.Drawing.Size(135, 125);
            this.metroTileBarrios.TabIndex = 6;
            this.metroTileBarrios.Text = "Barrios";
            this.metroTileBarrios.TileImage = ((System.Drawing.Image)(resources.GetObject("metroTileBarrios.TileImage")));
            this.metroTileBarrios.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroTileBarrios.UseSelectable = true;
            this.metroTileBarrios.UseTileImage = true;
            this.metroTileBarrios.Click += new System.EventHandler(this.metroTileBarrios_Click);
            // 
            // metroTileGeneros
            // 
            this.metroTileGeneros.ActiveControl = null;
            this.metroTileGeneros.Location = new System.Drawing.Point(164, 371);
            this.metroTileGeneros.Name = "metroTileGeneros";
            this.metroTileGeneros.Size = new System.Drawing.Size(135, 125);
            this.metroTileGeneros.TabIndex = 5;
            this.metroTileGeneros.Text = "Generos";
            this.metroTileGeneros.TileImage = ((System.Drawing.Image)(resources.GetObject("metroTileGeneros.TileImage")));
            this.metroTileGeneros.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroTileGeneros.UseSelectable = true;
            this.metroTileGeneros.UseTileImage = true;
            this.metroTileGeneros.Click += new System.EventHandler(this.metroTileGeneros_Click);
            // 
            // metroTileLibros
            // 
            this.metroTileLibros.ActiveControl = null;
            this.metroTileLibros.Location = new System.Drawing.Point(23, 371);
            this.metroTileLibros.Name = "metroTileLibros";
            this.metroTileLibros.Size = new System.Drawing.Size(135, 125);
            this.metroTileLibros.TabIndex = 4;
            this.metroTileLibros.Text = "Libros";
            this.metroTileLibros.TileImage = ((System.Drawing.Image)(resources.GetObject("metroTileLibros.TileImage")));
            this.metroTileLibros.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroTileLibros.UseSelectable = true;
            this.metroTileLibros.UseTileImage = true;
            this.metroTileLibros.Click += new System.EventHandler(this.metroTileLibros_Click);
            // 
            // metroTileEditoriales
            // 
            this.metroTileEditoriales.ActiveControl = null;
            this.metroTileEditoriales.Location = new System.Drawing.Point(23, 502);
            this.metroTileEditoriales.Name = "metroTileEditoriales";
            this.metroTileEditoriales.Size = new System.Drawing.Size(135, 125);
            this.metroTileEditoriales.TabIndex = 3;
            this.metroTileEditoriales.Text = "Editoriales";
            this.metroTileEditoriales.TileImage = ((System.Drawing.Image)(resources.GetObject("metroTileEditoriales.TileImage")));
            this.metroTileEditoriales.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroTileEditoriales.UseSelectable = true;
            this.metroTileEditoriales.UseTileImage = true;
            this.metroTileEditoriales.Click += new System.EventHandler(this.metroTileEditoriales_Click);
            // 
            // metroTileAutores
            // 
            this.metroTileAutores.ActiveControl = null;
            this.metroTileAutores.Location = new System.Drawing.Point(164, 502);
            this.metroTileAutores.Name = "metroTileAutores";
            this.metroTileAutores.Size = new System.Drawing.Size(135, 125);
            this.metroTileAutores.TabIndex = 2;
            this.metroTileAutores.Text = "Autores";
            this.metroTileAutores.TileImage = ((System.Drawing.Image)(resources.GetObject("metroTileAutores.TileImage")));
            this.metroTileAutores.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroTileAutores.UseSelectable = true;
            this.metroTileAutores.UseTileImage = true;
            this.metroTileAutores.Click += new System.EventHandler(this.metroTileAutores_Click);
            // 
            // metroTileInformes
            // 
            this.metroTileInformes.ActiveControl = null;
            this.metroTileInformes.Location = new System.Drawing.Point(164, 83);
            this.metroTileInformes.Name = "metroTileInformes";
            this.metroTileInformes.Size = new System.Drawing.Size(135, 256);
            this.metroTileInformes.TabIndex = 1;
            this.metroTileInformes.Text = "Informes";
            this.metroTileInformes.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.metroTileInformes.TileImage = ((System.Drawing.Image)(resources.GetObject("metroTileInformes.TileImage")));
            this.metroTileInformes.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroTileInformes.UseSelectable = true;
            this.metroTileInformes.UseTileImage = true;
            this.metroTileInformes.Click += new System.EventHandler(this.metroTileInformes_Click);
            // 
            // metroTileSocios
            // 
            this.metroTileSocios.ActiveControl = null;
            this.metroTileSocios.Location = new System.Drawing.Point(336, 83);
            this.metroTileSocios.Name = "metroTileSocios";
            this.metroTileSocios.Size = new System.Drawing.Size(135, 125);
            this.metroTileSocios.TabIndex = 0;
            this.metroTileSocios.Text = "Socios";
            this.metroTileSocios.TileImage = ((System.Drawing.Image)(resources.GetObject("metroTileSocios.TileImage")));
            this.metroTileSocios.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroTileSocios.UseSelectable = true;
            this.metroTileSocios.UseTileImage = true;
            this.metroTileSocios.Click += new System.EventHandler(this.metroTileSocios_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(636, 657);
            this.Controls.Add(this.metroTileProveedores);
            this.Controls.Add(this.metroTileTiposDeDocumento);
            this.Controls.Add(this.metroTileCompras);
            this.Controls.Add(this.metroTilePrestamos);
            this.Controls.Add(this.metroTileBarrios);
            this.Controls.Add(this.metroTileGeneros);
            this.Controls.Add(this.metroTileLibros);
            this.Controls.Add(this.metroTileEditoriales);
            this.Controls.Add(this.metroTileAutores);
            this.Controls.Add(this.metroTileInformes);
            this.Controls.Add(this.metroTileSocios);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(636, 657);
            this.Name = "frmMain";
            this.Resizable = false;
            this.Text = "Biblioteca";
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroTile metroTileSocios;
        private MetroFramework.Controls.MetroTile metroTileInformes;
        private MetroFramework.Controls.MetroTile metroTileAutores;
        private MetroFramework.Controls.MetroTile metroTileEditoriales;
        private MetroFramework.Controls.MetroTile metroTileGeneros;
        private MetroFramework.Controls.MetroTile metroTileLibros;
        private MetroFramework.Controls.MetroTile metroTileBarrios;
        private MetroFramework.Controls.MetroTile metroTilePrestamos;
        private MetroFramework.Controls.MetroTile metroTileCompras;
        private MetroFramework.Controls.MetroTile metroTileTiposDeDocumento;
        private MetroFramework.Controls.MetroTile metroTileProveedores;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem consultarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem agregarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eliminarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editarToolStripMenuItem;
    }
}
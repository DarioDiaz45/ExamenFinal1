namespace PiramidesFinal.Windows
{
    partial class Piramides
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
            toolStrip1 = new ToolStrip();
            tsbnuevo = new ToolStripButton();
            tsbBorrar = new ToolStripButton();
            tsbEditar = new ToolStripButton();
            toolStripSeparator1 = new ToolStripSeparator();
            tsbFiltrar = new ToolStripButton();
            tsbOrdenar = new ToolStripButton();
            tsbDetalles = new ToolStripButton();
            tsbActualizar = new ToolStripButton();
            toolStripSeparator2 = new ToolStripSeparator();
            tsbSalir = new ToolStripButton();
            pnlCantidad = new Panel();
            txtCantidad = new TextBox();
            lblCantidad = new Label();
            pnlGrilla = new Panel();
            dgvDatos = new DataGridView();
            colLadoBase = new DataGridViewTextBoxColumn();
            colAltura = new DataGridViewTextBoxColumn();
            colMaterial = new DataGridViewTextBoxColumn();
            colColor = new DataGridViewTextBoxColumn();
            colAreaBase = new DataGridViewTextBoxColumn();
            colVolumen = new DataGridViewTextBoxColumn();
            toolStrip1.SuspendLayout();
            pnlCantidad.SuspendLayout();
            pnlGrilla.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDatos).BeginInit();
            SuspendLayout();
            // 
            // toolStrip1
            // 
            toolStrip1.Items.AddRange(new ToolStripItem[] { tsbnuevo, tsbBorrar, tsbEditar, toolStripSeparator1, tsbFiltrar, tsbOrdenar, tsbDetalles, tsbActualizar, toolStripSeparator2, tsbSalir });
            toolStrip1.Location = new Point(0, 0);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(750, 72);
            toolStrip1.TabIndex = 0;
            toolStrip1.Text = "toolStrip1";
            // 
            // tsbnuevo
            // 
            tsbnuevo.Image = Properties.Resources.New_Copy;
            tsbnuevo.ImageScaling = ToolStripItemImageScaling.None;
            tsbnuevo.ImageTransparentColor = Color.Magenta;
            tsbnuevo.Name = "tsbnuevo";
            tsbnuevo.Size = new Size(54, 69);
            tsbnuevo.Text = "Nuevo";
            tsbnuevo.TextImageRelation = TextImageRelation.ImageAboveText;
            tsbnuevo.Click += tsbnuevo_Click;
            // 
            // tsbBorrar
            // 
            tsbBorrar.Image = Properties.Resources.Delete_File;
            tsbBorrar.ImageScaling = ToolStripItemImageScaling.None;
            tsbBorrar.ImageTransparentColor = Color.Magenta;
            tsbBorrar.Name = "tsbBorrar";
            tsbBorrar.Size = new Size(54, 69);
            tsbBorrar.Text = "Borrar";
            tsbBorrar.TextImageRelation = TextImageRelation.ImageAboveText;
            tsbBorrar.Click += tsbBorrar_Click;
            // 
            // tsbEditar
            // 
            tsbEditar.Image = Properties.Resources.Edit_File;
            tsbEditar.ImageScaling = ToolStripItemImageScaling.None;
            tsbEditar.ImageTransparentColor = Color.Magenta;
            tsbEditar.Name = "tsbEditar";
            tsbEditar.Size = new Size(52, 69);
            tsbEditar.Text = "Editar";
            tsbEditar.TextImageRelation = TextImageRelation.ImageAboveText;
            tsbEditar.Click += tsbEditar_Click;
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(6, 72);
            // 
            // tsbFiltrar
            // 
            tsbFiltrar.Image = Properties.Resources.Filter;
            tsbFiltrar.ImageScaling = ToolStripItemImageScaling.None;
            tsbFiltrar.ImageTransparentColor = Color.Magenta;
            tsbFiltrar.Name = "tsbFiltrar";
            tsbFiltrar.Size = new Size(52, 69);
            tsbFiltrar.Text = "Filtrar";
            tsbFiltrar.TextImageRelation = TextImageRelation.ImageAboveText;
            // 
            // tsbOrdenar
            // 
            tsbOrdenar.Image = Properties.Resources.Sorting_Arrows;
            tsbOrdenar.ImageScaling = ToolStripItemImageScaling.None;
            tsbOrdenar.ImageTransparentColor = Color.Magenta;
            tsbOrdenar.Name = "tsbOrdenar";
            tsbOrdenar.Size = new Size(54, 69);
            tsbOrdenar.Text = "Ordenar";
            tsbOrdenar.TextImageRelation = TextImageRelation.ImageAboveText;
            // 
            // tsbDetalles
            // 
            tsbDetalles.Image = Properties.Resources.More_Details;
            tsbDetalles.ImageScaling = ToolStripItemImageScaling.None;
            tsbDetalles.ImageTransparentColor = Color.Magenta;
            tsbDetalles.Name = "tsbDetalles";
            tsbDetalles.Size = new Size(52, 69);
            tsbDetalles.Text = "Detalles";
            tsbDetalles.TextImageRelation = TextImageRelation.ImageAboveText;
            // 
            // tsbActualizar
            // 
            tsbActualizar.Image = Properties.Resources.Refresh;
            tsbActualizar.ImageScaling = ToolStripItemImageScaling.None;
            tsbActualizar.ImageTransparentColor = Color.Magenta;
            tsbActualizar.Name = "tsbActualizar";
            tsbActualizar.Size = new Size(63, 69);
            tsbActualizar.Text = "Actualizar";
            tsbActualizar.TextImageRelation = TextImageRelation.ImageAboveText;
            tsbActualizar.Click += tsbActualizar_Click;
            // 
            // toolStripSeparator2
            // 
            toolStripSeparator2.Name = "toolStripSeparator2";
            toolStripSeparator2.Size = new Size(6, 72);
            // 
            // tsbSalir
            // 
            tsbSalir.Image = Properties.Resources.Export;
            tsbSalir.ImageScaling = ToolStripItemImageScaling.None;
            tsbSalir.ImageTransparentColor = Color.Magenta;
            tsbSalir.Name = "tsbSalir";
            tsbSalir.Size = new Size(52, 69);
            tsbSalir.Text = "Salir";
            tsbSalir.TextImageRelation = TextImageRelation.ImageAboveText;
            tsbSalir.Click += tsbSalir_Click;
            // 
            // pnlCantidad
            // 
            pnlCantidad.Controls.Add(txtCantidad);
            pnlCantidad.Controls.Add(lblCantidad);
            pnlCantidad.Dock = DockStyle.Bottom;
            pnlCantidad.Location = new Point(0, 382);
            pnlCantidad.Name = "pnlCantidad";
            pnlCantidad.Size = new Size(750, 38);
            pnlCantidad.TabIndex = 1;
            // 
            // txtCantidad
            // 
            txtCantidad.Location = new Point(76, 10);
            txtCantidad.Name = "txtCantidad";
            txtCantidad.Size = new Size(116, 23);
            txtCantidad.TabIndex = 1;
            // 
            // lblCantidad
            // 
            lblCantidad.AutoSize = true;
            lblCantidad.Location = new Point(15, 13);
            lblCantidad.Name = "lblCantidad";
            lblCantidad.Size = new Size(55, 15);
            lblCantidad.TabIndex = 0;
            lblCantidad.Text = "Cantidad";
            // 
            // pnlGrilla
            // 
            pnlGrilla.Controls.Add(dgvDatos);
            pnlGrilla.Dock = DockStyle.Fill;
            pnlGrilla.Location = new Point(0, 72);
            pnlGrilla.Name = "pnlGrilla";
            pnlGrilla.Size = new Size(750, 310);
            pnlGrilla.TabIndex = 2;
            // 
            // dgvDatos
            // 
            dgvDatos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDatos.Columns.AddRange(new DataGridViewColumn[] { colLadoBase, colAltura, colMaterial, colColor, colAreaBase, colVolumen });
            dgvDatos.Dock = DockStyle.Fill;
            dgvDatos.Location = new Point(0, 0);
            dgvDatos.Name = "dgvDatos";
            dgvDatos.Size = new Size(750, 310);
            dgvDatos.TabIndex = 0;
            // 
            // colLadoBase
            // 
            colLadoBase.HeaderText = "Lado Base";
            colLadoBase.Name = "colLadoBase";
            // 
            // colAltura
            // 
            colAltura.HeaderText = "Altura";
            colAltura.Name = "colAltura";
            // 
            // colMaterial
            // 
            colMaterial.HeaderText = "Material";
            colMaterial.Name = "colMaterial";
            // 
            // colColor
            // 
            colColor.HeaderText = "Color";
            colColor.Name = "colColor";
            // 
            // colAreaBase
            // 
            colAreaBase.HeaderText = "Area Base";
            colAreaBase.Name = "colAreaBase";
            // 
            // colVolumen
            // 
            colVolumen.HeaderText = "Volumen";
            colVolumen.Name = "colVolumen";
            // 
            // Piramides
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(750, 420);
            Controls.Add(pnlGrilla);
            Controls.Add(pnlCantidad);
            Controls.Add(toolStrip1);
            Name = "Piramides";
            Text = "Piramides";
            Load += Piramides_Load;
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            pnlCantidad.ResumeLayout(false);
            pnlCantidad.PerformLayout();
            pnlGrilla.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvDatos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ToolStrip toolStrip1;
        private ToolStripButton tsbnuevo;
        private ToolStripButton tsbBorrar;
        private ToolStripButton tsbEditar;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripButton tsbFiltrar;
        private ToolStripButton tsbOrdenar;
        private ToolStripButton tsbDetalles;
        private ToolStripButton tsbActualizar;
        private ToolStripSeparator toolStripSeparator2;
        private ToolStripButton tsbSalir;
        private Panel pnlCantidad;
        private Label lblCantidad;
        private TextBox txtCantidad;
        private Panel pnlGrilla;
        private DataGridView dgvDatos;
        private DataGridViewTextBoxColumn colLadoBase;
        private DataGridViewTextBoxColumn colAltura;
        private DataGridViewTextBoxColumn colMaterial;
        private DataGridViewTextBoxColumn colColor;
        private DataGridViewTextBoxColumn colAreaBase;
        private DataGridViewTextBoxColumn colVolumen;
    }
}
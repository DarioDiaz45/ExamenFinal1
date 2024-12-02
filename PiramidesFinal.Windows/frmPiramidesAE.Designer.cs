namespace PiramidesFinal.Windows
{
    partial class frmPiramidesAE
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
            components = new System.ComponentModel.Container();
            grbAtributos = new GroupBox();
            txtCLados = new TextBox();
            txtAltura = new TextBox();
            txtLadoBase = new TextBox();
            label3 = new Label();
            lblAltura = new Label();
            label1 = new Label();
            grbMaterial = new GroupBox();
            rbtMadera = new RadioButton();
            rbtVidrio = new RadioButton();
            rbtPlastico = new RadioButton();
            cboColor = new ComboBox();
            btnOK = new Button();
            btnCancelar = new Button();
            lblColor = new Label();
            errorProvider1 = new ErrorProvider(components);
            grbAtributos.SuspendLayout();
            grbMaterial.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // grbAtributos
            // 
            grbAtributos.Controls.Add(txtCLados);
            grbAtributos.Controls.Add(txtAltura);
            grbAtributos.Controls.Add(txtLadoBase);
            grbAtributos.Controls.Add(label3);
            grbAtributos.Controls.Add(lblAltura);
            grbAtributos.Controls.Add(label1);
            grbAtributos.Location = new Point(12, 23);
            grbAtributos.Name = "grbAtributos";
            grbAtributos.Size = new Size(226, 156);
            grbAtributos.TabIndex = 0;
            grbAtributos.TabStop = false;
            grbAtributos.Text = "Atributos Piramide";
            // 
            // txtCLados
            // 
            txtCLados.Location = new Point(101, 93);
            txtCLados.Name = "txtCLados";
            txtCLados.Size = new Size(100, 23);
            txtCLados.TabIndex = 1;
            // 
            // txtAltura
            // 
            txtAltura.Location = new Point(101, 63);
            txtAltura.Name = "txtAltura";
            txtAltura.Size = new Size(100, 23);
            txtAltura.TabIndex = 1;
            // 
            // txtLadoBase
            // 
            txtLadoBase.Location = new Point(101, 31);
            txtLadoBase.Name = "txtLadoBase";
            txtLadoBase.Size = new Size(100, 23);
            txtLadoBase.TabIndex = 1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(3, 96);
            label3.Name = "label3";
            label3.Size = new Size(92, 15);
            label3.TabIndex = 0;
            label3.Text = "Cantidad Lados:";
            // 
            // lblAltura
            // 
            lblAltura.AutoSize = true;
            lblAltura.Location = new Point(6, 62);
            lblAltura.Name = "lblAltura";
            lblAltura.Size = new Size(42, 15);
            lblAltura.TabIndex = 0;
            lblAltura.Text = "Altura:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 34);
            label1.Name = "label1";
            label1.Size = new Size(63, 15);
            label1.TabIndex = 0;
            label1.Text = "Lado Base:";
            // 
            // grbMaterial
            // 
            grbMaterial.Controls.Add(rbtMadera);
            grbMaterial.Controls.Add(rbtVidrio);
            grbMaterial.Controls.Add(rbtPlastico);
            grbMaterial.Location = new Point(265, 37);
            grbMaterial.Name = "grbMaterial";
            grbMaterial.Size = new Size(162, 142);
            grbMaterial.TabIndex = 1;
            grbMaterial.TabStop = false;
            grbMaterial.Text = "Material";
            // 
            // rbtMadera
            // 
            rbtMadera.AutoSize = true;
            rbtMadera.Location = new Point(6, 83);
            rbtMadera.Name = "rbtMadera";
            rbtMadera.Size = new Size(65, 19);
            rbtMadera.TabIndex = 0;
            rbtMadera.TabStop = true;
            rbtMadera.Text = "Madera";
            rbtMadera.UseVisualStyleBackColor = true;
            // 
            // rbtVidrio
            // 
            rbtVidrio.AutoSize = true;
            rbtVidrio.Location = new Point(6, 58);
            rbtVidrio.Name = "rbtVidrio";
            rbtVidrio.Size = new Size(56, 19);
            rbtVidrio.TabIndex = 0;
            rbtVidrio.TabStop = true;
            rbtVidrio.Text = "Vidrio";
            rbtVidrio.UseVisualStyleBackColor = true;
            // 
            // rbtPlastico
            // 
            rbtPlastico.AutoSize = true;
            rbtPlastico.Location = new Point(6, 33);
            rbtPlastico.Name = "rbtPlastico";
            rbtPlastico.Size = new Size(66, 19);
            rbtPlastico.TabIndex = 0;
            rbtPlastico.TabStop = true;
            rbtPlastico.Text = "Plastico";
            rbtPlastico.UseVisualStyleBackColor = true;
            // 
            // cboColor
            // 
            cboColor.FormattingEnabled = true;
            cboColor.Location = new Point(74, 210);
            cboColor.Name = "cboColor";
            cboColor.Size = new Size(139, 23);
            cboColor.TabIndex = 2;
            // 
            // btnOK
            // 
            btnOK.Location = new Point(54, 326);
            btnOK.Name = "btnOK";
            btnOK.Size = new Size(75, 74);
            btnOK.TabIndex = 3;
            btnOK.Text = "OK";
            btnOK.UseVisualStyleBackColor = true;
            btnOK.Click += btnOK_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(252, 326);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(75, 74);
            btnCancelar.TabIndex = 3;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // lblColor
            // 
            lblColor.AutoSize = true;
            lblColor.Location = new Point(12, 213);
            lblColor.Name = "lblColor";
            lblColor.Size = new Size(36, 15);
            lblColor.TabIndex = 4;
            lblColor.Text = "Color";
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // frmPiramidesAE
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(439, 450);
            Controls.Add(lblColor);
            Controls.Add(btnCancelar);
            Controls.Add(btnOK);
            Controls.Add(cboColor);
            Controls.Add(grbMaterial);
            Controls.Add(grbAtributos);
            Name = "frmPiramidesAE";
            Text = "frmPiramidesAE";
            grbAtributos.ResumeLayout(false);
            grbAtributos.PerformLayout();
            grbMaterial.ResumeLayout(false);
            grbMaterial.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox grbAtributos;
        private TextBox txtCLados;
        private TextBox txtAltura;
        private TextBox txtLadoBase;
        private Label label3;
        private Label lblAltura;
        private Label label1;
        private GroupBox grbMaterial;
        private RadioButton rbtMadera;
        private RadioButton rbtVidrio;
        private RadioButton rbtPlastico;
        private ComboBox cboColor;
        private Button btnOK;
        private Button btnCancelar;
        private Label lblColor;
        private ErrorProvider errorProvider1;
    }
}
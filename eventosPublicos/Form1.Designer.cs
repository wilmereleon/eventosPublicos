namespace eventosPublicos
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.btnPago = new System.Windows.Forms.Button();
            this.txtEdad = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtPago = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.pxNoIngresar = new System.Windows.Forms.PictureBox();
            this.pxIngresar = new System.Windows.Forms.PictureBox();
            this.pxGratis = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pxNoIngresar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pxIngresar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pxGratis)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnSalir);
            this.groupBox1.Controls.Add(this.btnNuevo);
            this.groupBox1.Controls.Add(this.btnPago);
            this.groupBox1.Controls.Add(this.txtEdad);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(29, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(732, 242);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ingrese edad para acceso a eventos públicos";
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(494, 156);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(153, 36);
            this.btnSalir.TabIndex = 4;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnNuevo
            // 
            this.btnNuevo.Location = new System.Drawing.Point(493, 102);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(156, 34);
            this.btnNuevo.TabIndex = 3;
            this.btnNuevo.Text = "Nuevo";
            this.btnNuevo.UseVisualStyleBackColor = true;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // btnPago
            // 
            this.btnPago.Location = new System.Drawing.Point(494, 40);
            this.btnPago.Name = "btnPago";
            this.btnPago.Size = new System.Drawing.Size(155, 37);
            this.btnPago.TabIndex = 2;
            this.btnPago.Text = "Evaluar pago";
            this.btnPago.UseVisualStyleBackColor = true;
            this.btnPago.Click += new System.EventHandler(this.btnPago_Click);
            // 
            // txtEdad
            // 
            this.txtEdad.Location = new System.Drawing.Point(28, 53);
            this.txtEdad.Name = "txtEdad";
            this.txtEdad.Size = new System.Drawing.Size(100, 23);
            this.txtEdad.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ingrese edad";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtPago);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Location = new System.Drawing.Point(397, 271);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(363, 150);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Valor de pago";
            // 
            // txtPago
            // 
            this.txtPago.Location = new System.Drawing.Point(83, 37);
            this.txtPago.Name = "txtPago";
            this.txtPago.Size = new System.Drawing.Size(161, 23);
            this.txtPago.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 15);
            this.label2.TabIndex = 0;
            this.label2.Text = "Su pago es";
            // 
            // pxNoIngresar
            // 
            this.pxNoIngresar.Image = global::eventosPublicos.Properties.Resources.senal_prohibido_ingresar_;
            this.pxNoIngresar.Location = new System.Drawing.Point(103, 271);
            this.pxNoIngresar.Name = "pxNoIngresar";
            this.pxNoIngresar.Size = new System.Drawing.Size(207, 167);
            this.pxNoIngresar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pxNoIngresar.TabIndex = 2;
            this.pxNoIngresar.TabStop = false;
            // 
            // pxIngresar
            // 
            this.pxIngresar.Image = global::eventosPublicos.Properties.Resources.senal_puede_ingresar_;
            this.pxIngresar.Location = new System.Drawing.Point(103, 270);
            this.pxIngresar.Name = "pxIngresar";
            this.pxIngresar.Size = new System.Drawing.Size(207, 168);
            this.pxIngresar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pxIngresar.TabIndex = 3;
            this.pxIngresar.TabStop = false;
            // 
            // pxGratis
            // 
            this.pxGratis.Image = global::eventosPublicos.Properties.Resources.senal_gratis;
            this.pxGratis.Location = new System.Drawing.Point(103, 270);
            this.pxGratis.Name = "pxGratis";
            this.pxGratis.Size = new System.Drawing.Size(244, 168);
            this.pxGratis.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pxGratis.TabIndex = 4;
            this.pxGratis.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pxGratis);
            this.Controls.Add(this.pxIngresar);
            this.Controls.Add(this.pxNoIngresar);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Evaluador de entrada a eventos públicos";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pxNoIngresar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pxIngresar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pxGratis)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private TextBox txtEdad;
        private Label label1;
        private Label label2;
        private Button btnSalir;
        private Button btnNuevo;
        private Button btnPago;
        private TextBox txtPago;
        private PictureBox pxNoIngresar;
        private PictureBox pxIngresar;
        private PictureBox pxGratis;
    }
}
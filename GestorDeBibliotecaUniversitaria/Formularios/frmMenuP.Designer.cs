namespace GestorDeBibliotecaUniversitaria
{
    partial class frmMenuP
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMenuP));
            this.label1 = new System.Windows.Forms.Label();
            this.btnGestionarPersonas = new System.Windows.Forms.Button();
            this.btnGestionarLibros = new System.Windows.Forms.Button();
            this.btnGestionarPrestamos = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(23, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(340, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "¡Bienvenido a tu Biblioteca Virtual!";
            // 
            // btnGestionarPersonas
            // 
            this.btnGestionarPersonas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(235)))), ((int)(((byte)(220)))));
            this.btnGestionarPersonas.Location = new System.Drawing.Point(98, 85);
            this.btnGestionarPersonas.Name = "btnGestionarPersonas";
            this.btnGestionarPersonas.Size = new System.Drawing.Size(165, 60);
            this.btnGestionarPersonas.TabIndex = 1;
            this.btnGestionarPersonas.Text = "Gestionar personas";
            this.btnGestionarPersonas.UseVisualStyleBackColor = false;
            this.btnGestionarPersonas.Click += new System.EventHandler(this.btnGestionarPersonas_Click);
            // 
            // btnGestionarLibros
            // 
            this.btnGestionarLibros.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(235)))), ((int)(((byte)(220)))));
            this.btnGestionarLibros.Location = new System.Drawing.Point(98, 151);
            this.btnGestionarLibros.Name = "btnGestionarLibros";
            this.btnGestionarLibros.Size = new System.Drawing.Size(165, 60);
            this.btnGestionarLibros.TabIndex = 2;
            this.btnGestionarLibros.Text = "Gestionar Libros";
            this.btnGestionarLibros.UseVisualStyleBackColor = false;
            this.btnGestionarLibros.Click += new System.EventHandler(this.btnGestionarLibros_Click);
            // 
            // btnGestionarPrestamos
            // 
            this.btnGestionarPrestamos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(235)))), ((int)(((byte)(220)))));
            this.btnGestionarPrestamos.Location = new System.Drawing.Point(98, 218);
            this.btnGestionarPrestamos.Name = "btnGestionarPrestamos";
            this.btnGestionarPrestamos.Size = new System.Drawing.Size(165, 60);
            this.btnGestionarPrestamos.TabIndex = 3;
            this.btnGestionarPrestamos.Text = "Gestionar prestamos";
            this.btnGestionarPrestamos.UseVisualStyleBackColor = false;
            this.btnGestionarPrestamos.Click += new System.EventHandler(this.btnGestionarPrestamos_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(235)))), ((int)(((byte)(220)))));
            this.btnSalir.Location = new System.Drawing.Point(98, 284);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(165, 60);
            this.btnSalir.TabIndex = 4;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(269, 295);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(112, 110);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // frmMenuP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(57)))), ((int)(((byte)(83)))));
            this.ClientSize = new System.Drawing.Size(375, 408);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnGestionarPrestamos);
            this.Controls.Add(this.btnGestionarLibros);
            this.Controls.Add(this.btnGestionarPersonas);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmMenuP";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu principal";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnGestionarPersonas;
        private System.Windows.Forms.Button btnGestionarLibros;
        private System.Windows.Forms.Button btnGestionarPrestamos;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}


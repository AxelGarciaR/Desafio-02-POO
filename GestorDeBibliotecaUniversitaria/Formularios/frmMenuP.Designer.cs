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
            this.label1 = new System.Windows.Forms.Label();
            this.btnGestionarPersonas = new System.Windows.Forms.Button();
            this.btnGestionarLibros = new System.Windows.Forms.Button();
            this.btnGestionarPrestamos = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(100, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(142, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "¡Bienvenidos!";
            // 
            // btnGestionarPersonas
            // 
            this.btnGestionarPersonas.Location = new System.Drawing.Point(87, 96);
            this.btnGestionarPersonas.Name = "btnGestionarPersonas";
            this.btnGestionarPersonas.Size = new System.Drawing.Size(165, 60);
            this.btnGestionarPersonas.TabIndex = 1;
            this.btnGestionarPersonas.Text = "Gestionar personas";
            this.btnGestionarPersonas.UseVisualStyleBackColor = true;
            this.btnGestionarPersonas.Click += new System.EventHandler(this.btnGestionarPersonas_Click);
            // 
            // btnGestionarLibros
            // 
            this.btnGestionarLibros.Location = new System.Drawing.Point(87, 162);
            this.btnGestionarLibros.Name = "btnGestionarLibros";
            this.btnGestionarLibros.Size = new System.Drawing.Size(165, 60);
            this.btnGestionarLibros.TabIndex = 2;
            this.btnGestionarLibros.Text = "Gestionar Libros";
            this.btnGestionarLibros.UseVisualStyleBackColor = true;
            this.btnGestionarLibros.Click += new System.EventHandler(this.btnGestionarLibros_Click);
            // 
            // btnGestionarPrestamos
            // 
            this.btnGestionarPrestamos.Location = new System.Drawing.Point(87, 228);
            this.btnGestionarPrestamos.Name = "btnGestionarPrestamos";
            this.btnGestionarPrestamos.Size = new System.Drawing.Size(165, 60);
            this.btnGestionarPrestamos.TabIndex = 3;
            this.btnGestionarPrestamos.Text = "Gestionar prestamos";
            this.btnGestionarPrestamos.UseVisualStyleBackColor = true;
            this.btnGestionarPrestamos.Click += new System.EventHandler(this.btnGestionarPrestamos_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(87, 294);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(165, 60);
            this.btnSalir.TabIndex = 4;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // frmMenuP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(352, 408);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnGestionarPrestamos);
            this.Controls.Add(this.btnGestionarLibros);
            this.Controls.Add(this.btnGestionarPersonas);
            this.Controls.Add(this.label1);
            this.Name = "frmMenuP";
            this.Text = "Menu principal";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnGestionarPersonas;
        private System.Windows.Forms.Button btnGestionarLibros;
        private System.Windows.Forms.Button btnGestionarPrestamos;
        private System.Windows.Forms.Button btnSalir;
    }
}


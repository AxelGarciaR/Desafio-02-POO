namespace GestorDeBibliotecaUniversitaria.Formularios
{
    partial class frmAdminLibros
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAdminLibros));
            this.txtTituloLibro = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtEditorialLibro = new System.Windows.Forms.TextBox();
            this.txtAutorLibro = new System.Windows.Forms.TextBox();
            this.txtISBN = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.dgvAdminLibros = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.txtGeneroLibro = new System.Windows.Forms.TextBox();
            this.pbxAyuda = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAdminLibros)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxAyuda)).BeginInit();
            this.SuspendLayout();
            // 
            // txtTituloLibro
            // 
            this.txtTituloLibro.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(235)))), ((int)(((byte)(220)))));
            this.txtTituloLibro.Location = new System.Drawing.Point(88, 97);
            this.txtTituloLibro.MaxLength = 50;
            this.txtTituloLibro.Name = "txtTituloLibro";
            this.txtTituloLibro.Size = new System.Drawing.Size(287, 20);
            this.txtTituloLibro.TabIndex = 44;
            this.txtTituloLibro.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTituloLibro_KeyPress);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(17, 98);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(67, 15);
            this.label8.TabIndex = 43;
            this.label8.Text = "Titulo libro:";
            // 
            // txtEditorialLibro
            // 
            this.txtEditorialLibro.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(235)))), ((int)(((byte)(220)))));
            this.txtEditorialLibro.Location = new System.Drawing.Point(117, 139);
            this.txtEditorialLibro.MaxLength = 20;
            this.txtEditorialLibro.Name = "txtEditorialLibro";
            this.txtEditorialLibro.Size = new System.Drawing.Size(258, 20);
            this.txtEditorialLibro.TabIndex = 39;
            this.txtEditorialLibro.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtEditorialLibro_KeyPress);
            // 
            // txtAutorLibro
            // 
            this.txtAutorLibro.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(235)))), ((int)(((byte)(220)))));
            this.txtAutorLibro.Location = new System.Drawing.Point(88, 57);
            this.txtAutorLibro.MaxLength = 20;
            this.txtAutorLibro.Name = "txtAutorLibro";
            this.txtAutorLibro.Size = new System.Drawing.Size(287, 20);
            this.txtAutorLibro.TabIndex = 38;
            this.txtAutorLibro.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAutorLibro_KeyPress);
            // 
            // txtISBN
            // 
            this.txtISBN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(235)))), ((int)(((byte)(220)))));
            this.txtISBN.Location = new System.Drawing.Point(72, 17);
            this.txtISBN.MaxLength = 17;
            this.txtISBN.Name = "txtISBN";
            this.txtISBN.Size = new System.Drawing.Size(303, 20);
            this.txtISBN.TabIndex = 36;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(18, 140);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 15);
            this.label3.TabIndex = 31;
            this.label3.Text = "Editorial libro:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(17, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 15);
            this.label2.TabIndex = 30;
            this.label2.Text = "Autor libro:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(17, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 15);
            this.label1.TabIndex = 29;
            this.label1.Text = "ISBN:";
            // 
            // btnModificar
            // 
            this.btnModificar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(235)))), ((int)(((byte)(220)))));
            this.btnModificar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificar.Location = new System.Drawing.Point(438, 111);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(123, 40);
            this.btnModificar.TabIndex = 28;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = false;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(235)))), ((int)(((byte)(220)))));
            this.btnEliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.Location = new System.Drawing.Point(438, 65);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(123, 40);
            this.btnEliminar.TabIndex = 27;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(235)))), ((int)(((byte)(220)))));
            this.btnSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.Location = new System.Drawing.Point(438, 157);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(123, 40);
            this.btnSalir.TabIndex = 26;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(235)))), ((int)(((byte)(220)))));
            this.btnAgregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregar.Location = new System.Drawing.Point(438, 18);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(123, 41);
            this.btnAgregar.TabIndex = 25;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = false;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // dgvAdminLibros
            // 
            this.dgvAdminLibros.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(235)))), ((int)(((byte)(220)))));
            this.dgvAdminLibros.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAdminLibros.Location = new System.Drawing.Point(12, 213);
            this.dgvAdminLibros.Name = "dgvAdminLibros";
            this.dgvAdminLibros.Size = new System.Drawing.Size(549, 186);
            this.dgvAdminLibros.TabIndex = 24;
            this.dgvAdminLibros.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAdminLibros_CellClick);
            this.dgvAdminLibros.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAdminLibros_CellContentClick);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(18, 178);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 15);
            this.label4.TabIndex = 45;
            this.label4.Text = "Genero libro:";
            // 
            // txtGeneroLibro
            // 
            this.txtGeneroLibro.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(235)))), ((int)(((byte)(220)))));
            this.txtGeneroLibro.Location = new System.Drawing.Point(117, 177);
            this.txtGeneroLibro.MaxLength = 20;
            this.txtGeneroLibro.Name = "txtGeneroLibro";
            this.txtGeneroLibro.Size = new System.Drawing.Size(258, 20);
            this.txtGeneroLibro.TabIndex = 46;
            this.txtGeneroLibro.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtGeneroLibro_KeyPress);
            // 
            // pbxAyuda
            // 
            this.pbxAyuda.Image = ((System.Drawing.Image)(resources.GetObject("pbxAyuda.Image")));
            this.pbxAyuda.Location = new System.Drawing.Point(381, 17);
            this.pbxAyuda.Name = "pbxAyuda";
            this.pbxAyuda.Size = new System.Drawing.Size(22, 20);
            this.pbxAyuda.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxAyuda.TabIndex = 47;
            this.pbxAyuda.TabStop = false;
            this.pbxAyuda.Click += new System.EventHandler(this.pbxAyuda_Click);
            // 
            // frmAdminLibros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(57)))), ((int)(((byte)(83)))));
            this.ClientSize = new System.Drawing.Size(574, 416);
            this.Controls.Add(this.pbxAyuda);
            this.Controls.Add(this.txtGeneroLibro);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtTituloLibro);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtEditorialLibro);
            this.Controls.Add(this.txtAutorLibro);
            this.Controls.Add(this.txtISBN);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.dgvAdminLibros);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmAdminLibros";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Administrar libros";
            this.Load += new System.EventHandler(this.frmAdminLibros_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAdminLibros)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxAyuda)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtTituloLibro;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtEditorialLibro;
        private System.Windows.Forms.TextBox txtAutorLibro;
        private System.Windows.Forms.TextBox txtISBN;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.DataGridView dgvAdminLibros;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtGeneroLibro;
        private System.Windows.Forms.PictureBox pbxAyuda;
    }
}
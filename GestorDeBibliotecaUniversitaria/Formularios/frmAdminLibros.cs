using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GestorDeBibliotecaUniversitaria.Clases;
using GestorDeBibliotecaUniversitaria.Servicios;

namespace GestorDeBibliotecaUniversitaria.Formularios
{
    public partial class frmAdminLibros : Form
    {

        private readonly LibroService _libroService;
        private string libroSeleccionadoID = null;

        public frmAdminLibros()
        {
            InitializeComponent();
            string connectionString = "Server=localhost;Database=dbBiblioteca;encrypt=false;User=sa;password=;";
            var repository = new Data.LibrosRepositorio(connectionString);
            _libroService = new LibroService(repository);


        }

        private void frmAdminLibros_Load(object sender, EventArgs e)
        {

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            frmMenuP menu = new frmMenuP();     
            menu.Show();
            this.Close();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {

                Libro libro = new Libro();

                libro.ISBN = txtISBN.Text;
                libro.AutorLibro = txtAutorLibro.Text;
                libro.TituloLibro = txtTituloLibro.Text;
                libro.EditorialLibro = txtEditorialLibro.Text;
                libro.GeneroLibro = txtGeneroLibro.Text;

                _libroService.CrearUsuario(libro);
                MessageBox.Show("Usuario creado correctamente");
                

            }
            catch (Exception ex) {

                MessageBox.Show($"Error: {ex.Message}");

            }
        }

        private void CargarLibros()
        {
            var libros = _libroService.ListarLibros();
            dgvAdminLibros.DataSource = libros
                .Select(u => new { u.ISBN, u.AutorLibro, u.TituloLibro, u.EditorialLibro, u.GeneroLibro})
                .ToList();
        }


        private void dgvAdminLibros_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) 
            {
                DataGridViewRow fila = dgvAdminLibros.Rows[e.RowIndex];

                
                libroSeleccionadoID = fila.Cells["ISBN"].Value.ToString();

                
                txtISBN.Text = fila.Cells["ISBN"].Value.ToString();
                txtAutorLibro.Text = fila.Cells["Autor"].Value.ToString();
                txtTituloLibro.Text = fila.Cells["Titulo"].Value.ToString();
                txtEditorialLibro.Text = fila.Cells["Editorial"].Value.ToString();
                txtGeneroLibro.Text = fila.Cells["Genero"].Value.ToString();



            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(libroSeleccionadoID))
                {
                    MessageBox.Show("Seleccione un usuario de la lista para actualizar.");
                    return;
                }

                
                Libro libro = new Libro();
                libro.ISBN = libroSeleccionadoID;
                libro.AutorLibro = txtAutorLibro.Text;
                libro.TituloLibro = txtTituloLibro.Text;
                libro.EditorialLibro = txtEditorialLibro.Text;
                libro.GeneroLibro = txtGeneroLibro.Text;
                

                
                _libroService.ActualizarUsuario(libro);

                MessageBox.Show("Libro actualizado correctamente.");
                CargarLibros();

                
                libroSeleccionadoID = null;
                txtISBN.Clear();
                txtAutorLibro.Clear();
                txtTituloLibro.Clear();
                txtEditorialLibro.Clear();
                txtGeneroLibro.Clear();
                
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }

        private void dgvAdminLibros_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) 
            {
                DataGridViewRow fila = dgvAdminLibros.Rows[e.RowIndex];

                libroSeleccionadoID = fila.Cells["ISBN"].Value.ToString();

                txtISBN.Text = fila.Cells["ISBN"].Value.ToString();
                txtAutorLibro.Text = fila.Cells["Autor"].Value.ToString();
                txtTituloLibro.Text = fila.Cells["Titulo"].Value.ToString();
                txtEditorialLibro.Text = fila.Cells["Editorial"].Value.ToString();
                txtGeneroLibro.Text = fila.Cells["Genero"].Value.ToString();
            }
        }
    }
}

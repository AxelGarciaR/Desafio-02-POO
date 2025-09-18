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
            string connectionString = "Server=localhost;Database=dbBiblioteca;encrypt=false;User=sa;password=usuario1111;";
            var repository = new Data.LibrosRepositorio(connectionString);
            _libroService = new LibroService(repository);
            CargarLibros();
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

                _libroService.CrearLibro(libro);
                MessageBox.Show("Libro creado correctamente");

                txtISBN.Clear();
                txtAutorLibro.Clear();
                txtTituloLibro.Clear();
                txtEditorialLibro.Clear();
                txtGeneroLibro.Clear();

                CargarLibros();

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
                txtAutorLibro.Text = fila.Cells["AutorLibro"].Value.ToString();
                txtTituloLibro.Text = fila.Cells["TituloLibro"].Value.ToString();
                txtEditorialLibro.Text = fila.Cells["EditorialLibro"].Value.ToString();
                txtGeneroLibro.Text = fila.Cells["GeneroLibro"].Value.ToString();



            }
        }


        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                MessageBox.Show(libroSeleccionadoID);

                if (string.IsNullOrEmpty(libroSeleccionadoID))
                {
                    MessageBox.Show("Seleccione un usuario de la lista para eliminar.");
                    return;
                }

                Libro libro = new Libro();


                libro.ISBN = libroSeleccionadoID;
                libro.AutorLibro = txtAutorLibro.Text;
                libro.TituloLibro = txtTituloLibro.Text;
                libro.EditorialLibro = txtEditorialLibro.Text;
                libro.GeneroLibro = txtGeneroLibro.Text;

                _libroService.EliminarLibro(libro);
                MessageBox.Show("Libro eliminado correctamente");

                libroSeleccionadoID = null;
                txtISBN.Clear();
                txtAutorLibro.Clear();
                txtTituloLibro.Clear();
                txtEditorialLibro.Clear();
                txtGeneroLibro.Clear();

                CargarLibros();


            }
            catch (Exception ex)
            {

                MessageBox.Show($"Error: {ex}");

            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            try
            {
                MessageBox.Show(libroSeleccionadoID);

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
                

                
                _libroService.ActualizarLibro(libro);

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
                txtAutorLibro.Text = fila.Cells["AutorLibro"].Value.ToString();
                txtTituloLibro.Text = fila.Cells["TituloLibro"].Value.ToString();
                txtEditorialLibro.Text = fila.Cells["EditorialLibro"].Value.ToString();
                txtGeneroLibro.Text = fila.Cells["GeneroLibro"].Value.ToString();

                MessageBox.Show(libroSeleccionadoID);

            }
        }

        private void txtISBN_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar))
            {

                e.Handled = false;

            }
            else if (char.IsControl(e.KeyChar))
            {

                e.Handled = false;

            }
            else if ((txtISBN.Text.Contains("-")))
            {

                e.Handled = false;

            }
            else if (char.IsSeparator(e.KeyChar))
            {

                e.Handled= false;
            }
            else { 
                
                e.Handled = true;
                MessageBox.Show("Solo se admiten numeros y guiones", "Validacion de formato", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            }

        }

        private void txtAutorLibro_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (char.IsLetter(e.KeyChar))
            {

                e.Handled = false;

            }
            else if (char.IsControl(e.KeyChar))
            {

                e.Handled = false;

            }
            else if (char.IsSeparator(e.KeyChar))
            {

                e.Handled = false;
            }
            else { 
                
                e.Handled= true;

            }


        }

        private void txtTituloLibro_KeyPress(object sender, KeyPressEventArgs e)
        {
            
            if (char.IsLetter(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (char.IsNumber(e.KeyChar)){

                e.Handled = false;
            }
            else if (char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (char.IsSeparator(e.KeyChar))
            {

                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }

        }

        private void txtEditorialLibro_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar))
            {

                e.Handled = false;

            }
            else if (char.IsControl(e.KeyChar))
            {

                e.Handled = false;

            }
            else if (char.IsSeparator(e.KeyChar))
            {

                e.Handled = false;
            }
            else
            {

                e.Handled = true;

            }
        }

        private void txtGeneroLibro_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar))
            {

                e.Handled = false;

            }
            else if (char.IsControl(e.KeyChar))
            {

                e.Handled = false;

            }
            else if (char.IsSeparator(e.KeyChar))
            {

                e.Handled = false;
            }
            else
            {

                e.Handled = true;

            }
        }
       

        private void pbxAyuda_Click(object sender, EventArgs e)
        {
            MessageBox.Show("El ISBN tiene un formato 000-0-00-000000-0");
        }
    }
}

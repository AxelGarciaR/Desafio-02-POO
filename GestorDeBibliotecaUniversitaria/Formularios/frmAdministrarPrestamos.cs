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
using GestorDeBibliotecaUniversitaria.Data;
using GestorDeBibliotecaUniversitaria.Servicios;

namespace GestorDeBibliotecaUniversitaria.Formularios
{
    public partial class frmAdministrarPrestamos : Form
    {
        private readonly PrestamoService _prestamoService;
        private string prestamoSeleccionadoId = null;
        public frmAdministrarPrestamos()
        {
            InitializeComponent();
            string connectionString = "Server=localhost;Database=dbBiblioteca;encrypt=false;User=sa;password=usuario1111;";
            var repository = new PrestamosRepositorio(connectionString);
            _prestamoService = new PrestamoService(repository);
            // aqui agregaremos el codigo para nuestro combobox "tipo de persona"
            // primero limpiamos cualquier item que pueda existir por defecto
            cbxTipoPersona.Items.Clear();

            // agregamos las opciones de tipo de persona (por medio de codigo para evitar excepciones)
            cbxTipoPersona.Items.Add("Estudiante");
            cbxTipoPersona.Items.Add("Profesor");


            CargarPrestamos();

        }

        private void CargarPrestamos()
        {
            try
            {
                var prestamos = _prestamoService.ListarPrestamos();
                dgvPrestamos.DataSource = prestamos
                    .Select(p => new
                    {
                        Carnet = p.CarnetPersona,
                        ISBN = p.ISBNLibro,
                        FechaPrestamo = p.FechaPrestamo.ToShortDateString(),
                        FinPrestamo = p.FinFechaPrestamo.ToShortDateString(),
                        MoraActiva = p.MoraActivaPrestamo,
                        ValorMora = p.ValorMoraPrestamo
                    }).ToList();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar los préstamos: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private Prestamo ObtenerPrestamoDesdeCampos(int? id = null)
        {
            decimal valorMora = 0;

            if (!string.IsNullOrEmpty(txtValorMora.Text))
            {
                if (!decimal.TryParse(txtValorMora.Text, out valorMora))
                {
                    MessageBox.Show("El valor de la mora debe ser un número válido.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return null;
                }
            }

            try
            {
                return new Prestamo
                {
                    FechaPrestamo = dtpFechaPrestamo.Value,
                    FinFechaPrestamo = dtpFinFechaPrestamo.Value,
                    MoraActivaPrestamo = chkMora.Checked,
                    ValorMoraPrestamo = valorMora,
                    CarnetPersona = txtCarnet.Text,
                    ISBNLibro = txtISBN.Text
                };
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message, "Error de validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return null;
            }
        }





        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            frmMenuP menu  = new frmMenuP();
            menu.Show();
            this.Close();
        }

        private void frmAdministrarPrestamos_Load(object sender, EventArgs e)
        {

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                Prestamo nuevo = ObtenerPrestamoDesdeCampos();
                if (nuevo == null) return;

                _prestamoService.CrearPrestamo(nuevo);

                MessageBox.Show("Préstamo agregado correctamente.");
                LimpiarCampos();
                CargarPrestamos();
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show($"Datos inválidos: {ex.Message}", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al agregar el préstamo: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            try
            {
                if (prestamoSeleccionadoId == null)
                {
                    MessageBox.Show("Seleccione un préstamo de la lista.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                Prestamo actualizado = ObtenerPrestamoDesdeCampos(int.Parse(prestamoSeleccionadoId));
                if (actualizado == null) return;

                _prestamoService.ActualizarPrestamo(actualizado);

                MessageBox.Show("Préstamo actualizado correctamente.");
                LimpiarCampos();
                CargarPrestamos();
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show($"Datos inválidos: {ex.Message}", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al actualizar el préstamo: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            MessageBox.Show(prestamoSeleccionadoId);
            try
            {
                if (prestamoSeleccionadoId == null)
                {
                    MessageBox.Show("Seleccione un préstamo de la lista.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                DialogResult confirmacion = MessageBox.Show(
                    "¿Seguro que desea eliminar este préstamo?",
                    "Confirmar Eliminación",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question
                );

                if (confirmacion == DialogResult.Yes)
                {
                    Prestamo p = new Prestamo();
                    _prestamoService.EliminarPrestamo(p);

                    MessageBox.Show("Préstamo eliminado correctamente.");
                    LimpiarCampos();
                    CargarPrestamos();
                    prestamoSeleccionadoId = null;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al eliminar el préstamo: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void dgvPrestamos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow fila = dgvPrestamos.Rows[e.RowIndex];
                prestamoSeleccionadoId = fila.Cells["Carnet"].Value.ToString();
                txtCarnet.Text = fila.Cells["Carnet"].Value.ToString();
                txtISBN.Text = fila.Cells["ISBN"].Value.ToString();
                dtpFechaPrestamo.Value = DateTime.Parse(fila.Cells["FechaPrestamo"].Value.ToString());
                dtpFinFechaPrestamo.Value = DateTime.Parse(fila.Cells["FinPrestamo"].Value.ToString());
                chkMora.Checked = (bool)fila.Cells["MoraActiva"].Value;
                txtValorMora.Text = fila.Cells["ValorMora"].Value.ToString();
            }
        }

        private void LimpiarCampos()
        {
            txtCarnet.Clear();
            txtISBN.Clear();
            txtValorMora.Clear();
            chkMora.Checked = false;
            prestamoSeleccionadoId = null;
        }

    }
}

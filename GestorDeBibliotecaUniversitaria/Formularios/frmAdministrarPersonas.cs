using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using GestorDeBibliotecaUniversitaria.Clases;
using GestorDeBibliotecaUniversitaria.Servicios;
using GestorDeBibliotecaUniversitaria.Data;

namespace GestorDeBibliotecaUniversitaria.Formularios
{
    public partial class frmAdministrarPersonas : Form
    {
        private readonly PersonaService _personaService;
        private string personaSeleccionadaId = null; 



        public frmAdministrarPersonas()
        {
            InitializeComponent();
            string connectionString = "Server=localhost;Database=dbBiblioteca;encrypt=false;User=sa;password=GR250186;";
            var repository = new PersonasRepositorio(connectionString);
            _personaService = new PersonaService(repository);
            // aqui agregaremos el codigo para nuestro combobox "tipo de persona"
            // primero limpiamos cualquier item que pueda existir por defecto
            cbxTipoPersona.Items.Clear();

            // agregamos las opciones de tipo de persona (por medio de codigo para evitar excepciones)
            cbxTipoPersona.Items.Add("Estudiante");
            cbxTipoPersona.Items.Add("Profesor");

            CargarPersonas();
        }

        private void frmAdministrarPedidos_Load(object sender, EventArgs e)
        {
           
        }

        private void CargarPersonas()
        {
            try
            {
                var personas = _personaService.ListarPersonas();
                dgvPersonas.DataSource = personas
                    .Select(p => new { id = p.id, nombre = p.nombre, correo = p.correo, tipoPersona = p.tipoPersona })
                    .ToList();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar a las personas: {ex.Message}", "Error.", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // para el boton agregar
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                // validación para los campos vacíos
                if (string.IsNullOrEmpty(txtCarnet.Text) || string.IsNullOrEmpty(txtNombre.Text) || string.IsNullOrEmpty(txtCorreo.Text))
                {
                    MessageBox.Show("Todos los campos son obligatorios.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // validación para el formato de los nombres
                string patronNombre = @"^[a-zA-Z\s]+$";
                if (!Regex.IsMatch(txtNombre.Text, patronNombre))
                {
                    MessageBox.Show("El campo de nombre solo puede contener letras y espacios.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // validación de formato para los correos electrónicos
                string patronCorreo = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";
                if (!Regex.IsMatch(txtCorreo.Text, patronCorreo))
                {
                    MessageBox.Show("El formato ingresado para tu correo electrónico es invalido.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                Persona nuevaPersona = new Persona(txtCarnet.Text, txtNombre.Text, txtCorreo.Text, cbxTipoPersona.SelectedItem.ToString());
                _personaService.CrearPersona(nuevaPersona);
                MessageBox.Show("Persona agregada correctamente.");

                LimpiarCampos();
                CargarPersonas();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al agregar a la persona: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }
        

        // para el boton eliminar
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(personaSeleccionadaId))
                {
                    MessageBox.Show("Seleccione una persona de la lista para poder eliminar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                DialogResult confirmacion = MessageBox.Show("¿Estás seguro de que deseas eliminar esta persona?, esta accion no se puede revertir", "Confirmar Eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (confirmacion == DialogResult.Yes)
                {
                    _personaService.EliminarPersona(personaSeleccionadaId);
                    MessageBox.Show("La persona fue eliminada correctamente del registrp.");

                    LimpiarCampos();
                    CargarPersonas();
                    personaSeleccionadaId = null;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al eliminar a la persona: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        // para el boton modificar
        private void btnModificar_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(personaSeleccionadaId))
                {
                    MessageBox.Show("Seleccione una persona de la lista para poder actualizar los datos.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (string.IsNullOrEmpty(txtCarnet.Text) || string.IsNullOrEmpty(txtNombre.Text) || string.IsNullOrEmpty(txtCorreo.Text))
                {
                    MessageBox.Show("Todos los campos son obligatorios.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Las validaciones de nombre y correo son las mismas que definimos para el boton agregar
                string patronNombre = @"^[a-zA-Z\s]+$";
                if (!Regex.IsMatch(txtNombre.Text, patronNombre))
                {
                    MessageBox.Show("El campo nombre solo puede contener letras y espacios.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                string patronCorreo = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";
                if (!Regex.IsMatch(txtCorreo.Text, patronCorreo))
                {
                    MessageBox.Show("El formato ingresado para tu correo electrónico es invalido.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // en esta parte tomamos en cuenta que si el ID cambia, se trata de una nueva persona, no de una actualización de datos de una ya existente
                if (txtCarnet.Text != personaSeleccionadaId)
                {
                    MessageBox.Show("El carnet de una persona no puede ser modificado. Para cambiarlo, por favor elimine y agregue una nueva persona.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                Persona personaActualizada = new Persona(txtCarnet.Text, txtNombre.Text, txtCorreo.Text, cbxTipoPersona.SelectedItem.ToString());
                _personaService.ActualizarPersona(personaActualizada);
                MessageBox.Show("Persona actualizada correctamente.");

                LimpiarCampos();
                CargarPersonas();
                personaSeleccionadaId = null;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al actualizar persona: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



        // este metodo sirve para cargar nuevamente los datos de la fila seleccionada por el usuario en los TextBox
        private void dgvPersonas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow fila = dgvPersonas.Rows[e.RowIndex];
                personaSeleccionadaId = fila.Cells["Id"].Value.ToString();
                txtCarnet.Text = fila.Cells["Id"].Value.ToString();
                txtNombre.Text = fila.Cells["Nombre"].Value.ToString();
                txtCorreo.Text = fila.Cells["Correo"].Value.ToString();
                cbxTipoPersona.SelectedItem = fila.Cells["TipoPersona"].Value.ToString();
            }

        }



        // este metodo sirve para limpiar los campos del formulario
        private void LimpiarCampos()
        {
            txtCarnet.Clear();
            txtNombre.Clear();
            txtCorreo.Clear();
            cbxTipoPersona.SelectedIndex = -1; // con esto se deselecciona el item 
        }


        // para el boton salir
        private void btnSalir_Click(object sender, EventArgs e)
        {
            frmMenuP menu = new frmMenuP();
            menu.Show();
            this.Close();

        }

       
    }
}

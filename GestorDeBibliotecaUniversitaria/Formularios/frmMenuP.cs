using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GestorDeBibliotecaUniversitaria.Formularios;

namespace GestorDeBibliotecaUniversitaria
{
    public partial class frmMenuP : Form
    {
        public frmMenuP()
        {
            InitializeComponent();
        }

        private void btnGestionarPersonas_Click(object sender, EventArgs e)
        {
            frmAdministrarPersonas adminPersonas = new frmAdministrarPersonas();
            adminPersonas.Show();
            this.Hide();
        }

        private void btnGestionarLibros_Click(object sender, EventArgs e)
        {
            frmAdminLibros adminLibros = new frmAdminLibros();
            adminLibros.Show(); 
            this.Hide();    
        }

        private void btnGestionarPrestamos_Click(object sender, EventArgs e)
        {
            frmAdministrarPrestamos adminPrestamos = new frmAdministrarPrestamos();
            adminPrestamos.Show();
            this.Hide();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();   
        }
    }
}

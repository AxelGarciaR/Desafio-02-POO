using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestorDeBibliotecaUniversitaria.Formularios
{
    public partial class frmAdministrarPersonas : Form
    {
        public frmAdministrarPersonas()
        {
            InitializeComponent();
        }

        private void frmAdministrarPedidos_Load(object sender, EventArgs e)
        {

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            frmMenuP menu = new frmMenuP();
            menu.Show();
            this.Close();

        }
    }
}

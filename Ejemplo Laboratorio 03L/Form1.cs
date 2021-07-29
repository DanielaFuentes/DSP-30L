using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejemplo_Laboratorio_03L
{
    public partial class ejemploFormulario : Form
    {
        public ejemploFormulario()
        {
            InitializeComponent();
        }

        private void btnSaludo_Click(object sender, EventArgs e)
        {
            lblSaludo.Text = "Hola buenas tardes, este es el grupo 03L";
        }

        private void lblSaludo_TextChanged(object sender, EventArgs e)
        {
            lblActualizar.Text = "El valor del label anterior ha cambiado";
        }

        private void cbMaterias_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblActualizar.Text = cbMaterias.Text;
        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {
            lblNombre.Text = "Su nombre es: " + txtNombre.Text
                             + " Y la materia inscrita es: " + cbMaterias.Text;
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ColaListaEnlazada
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Cola colaDinamica = new Cola();
        private void btnAdd_Click(object sender, EventArgs e)
        {
            colaDinamica.Agregar(txtDato.Text);
            txtCola.Text = colaDinamica.ToString();
            txtDato.Clear();
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            colaDinamica.Eliminar();
            txtCola.Text = colaDinamica.ToString();
        }
    }
}

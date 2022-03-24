using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pokedex2022_CSharp
{
    public partial class Ventana2 : Form
    {
        public void cambiaDescripcionPokemon(String descripcion)
        {
            cajaDescripcion.Text = descripcion;
        }

        public Ventana2()
        {
            InitializeComponent();

        }

        private void Ventana2_Load(object sender, EventArgs e)
        {

        }
    }
}

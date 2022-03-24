using Pokedex2022_CSharp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pokedex
{
    public partial class VentanaPrincipal : Form
        
    {
        Conexion miConexion = new Conexion();
        DataTable misPokemons = new DataTable();
        int idActual = 1; //Guarda el id del pokemon que se está
        public VentanaPrincipal()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            idActual--;
            misPokemons = miConexion.getPokemonPorId(idActual);
            nombrePokemon.Text = misPokemons.Rows[0]["nombre"].ToString();
            pictureBox1.Image = convierteBlobAImagen((byte[])misPokemons.Rows[0]["imagen"]);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            idActual++;
            misPokemons = miConexion.getPokemonPorId(idActual);
            nombrePokemon.Text = misPokemons.Rows[0]["nombre"].ToString();
            pictureBox1.Image = convierteBlobAImagen((byte[])misPokemons.Rows[0]["imagen"]);
        }

        private Image convierteBlobAImagen(byte[] img)
        {
            MemoryStream ms = new System.IO.MemoryStream(img);
            return (Image.FromStream(ms));
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }
        private void botonInfo_Click(object sender, EventArgs e)
        {

            Ventana2 v = new Ventana2();

            v.cambiaDescripcionPokemon(misPokemons.Rows[0]["descripcion"].ToString());
            v.Show();
        }

    }
}

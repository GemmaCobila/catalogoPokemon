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
using dominio;
using negocio;
using System.Configuration;

namespace TrabajoEjemploPokemon
{
    public partial class planillaPokemon : Form
    {
        private Pokemon pokemon = null;
        private OpenFileDialog archivo = null;
        public planillaPokemon()
        {
            InitializeComponent();
            Text = "Nuevo Pokemon";
        }

        public planillaPokemon(Pokemon pokemon)
        {
            InitializeComponent();
            this.pokemon = pokemon;
            Text = "Modificar Pokemon";
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            //Pokemon poke = new Pokemon();
            pokemonNegocio negocio = new pokemonNegocio();
            try
            {
                if (pokemon == null)
                    pokemon = new Pokemon();

                pokemon.numero = int.Parse(tbNumero.Text);
                pokemon.nombre = tbNombre.Text;
                pokemon.descripcion = tbDescripcion.Text;
                pokemon.urlimagen = tbUrlImagen.Text;
                pokemon.Tipo = (Elementos)cboTipo.SelectedItem;
                pokemon.Debilidad = (Elementos)cboDebilidad.SelectedItem;
                
                if (pokemon.Id!=0)
                {
                    negocio.modificar(pokemon);
                    MessageBox.Show("pokemon modificado exitosamente");
                }
                else
                {
                    negocio.agregar(pokemon);
                    MessageBox.Show("pokemon agregado");
                }

                if (archivo != null && !(tbUrlImagen.Text.ToUpper().Contains("HTTP")))
                    File.Copy(archivo.FileName, ConfigurationManager.AppSettings["images-poke"] + archivo.SafeFileName);
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void planillaPokemon_Load(object sender, EventArgs e)
        {
            elementoNegocio ElementoNegocio = new elementoNegocio();
            try
            {
                cboTipo.DataSource = ElementoNegocio.listar();
                cboTipo.ValueMember = "Id";
                cboTipo.DisplayMember = "Descripcion";
                cboDebilidad.DataSource = ElementoNegocio.listar();
                cboDebilidad.ValueMember = "Id";
                cboDebilidad.DisplayMember = "Descripcion";


                if (pokemon != null)
                {
                    tbNumero.Text = pokemon.numero.ToString();
                    tbNombre.Text = pokemon.nombre;
                    tbDescripcion.Text = pokemon.descripcion;
                    tbUrlImagen.Text = pokemon.urlimagen;
                    CargarImagen(pokemon.urlimagen);
                    cboTipo.SelectedValue = pokemon.Tipo.Id;
                    cboDebilidad.SelectedValue = pokemon.Debilidad.Id;
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }

        private void tbUrlImagen_Leave(object sender, EventArgs e)
        {
            CargarImagen(tbUrlImagen.Text);
        }

        private void CargarImagen(string imagen)
        {
            try
            {
                pbxPokemon.Load(imagen);
            }
            catch (Exception)
            {
                pbxPokemon.Load("https://img.freepik.com/vector-premium/vector-icono-imagen-predeterminado-pagina-imagen-faltante-diseno-sitio-web-o-aplicacion-movil-no-hay-foto-disponible_87543-11093.jpg");
            }
        }

        private void btnCargarImagen_Click(object sender, EventArgs e)
        {
            archivo = new OpenFileDialog();
            archivo.Filter = "jpg|*.jpg;|png|*.png";
            if (archivo.ShowDialog() == DialogResult.OK)
            {
                tbUrlImagen.Text = archivo.FileName;
                CargarImagen(archivo.FileName);
            }
            
        }
    }
}

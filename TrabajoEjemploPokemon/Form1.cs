using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using dominio;
using negocio;

namespace TrabajoEjemploPokemon
{
    public partial class Form1 : Form
    {
        private Pokemon pokemon = null;
        private List<Pokemon> ListaPokemon;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cargar();
            cboCampo.Items.Add("Numero");
            cboCampo.Items.Add("Nombre");
            cboCampo.Items.Add("Descripcion");
        }

        private void cargar()
        {
            pokemonNegocio negocio = new pokemonNegocio();
            ListaPokemon = negocio.listar();
            dgvPokemon.DataSource = ListaPokemon;
            eliminarColumnas();
            //dgvPokemon.Columns["IdTipo"].Visible = false;
            CargarImagen(ListaPokemon[0].urlimagen);
        }

        private void eliminarColumnas()
        {
            dgvPokemon.Columns["UrlImagen"].Visible = false;
            dgvPokemon.Columns["Id"].Visible = false;
        }

        private void dgvPokemon_SelectionChanged(object sender, EventArgs e)
        {
            if(dgvPokemon.CurrentRow!=null)
            {
            Pokemon selecionado = (Pokemon)dgvPokemon.CurrentRow.DataBoundItem;
            CargarImagen(selecionado.urlimagen);
            }
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
     
        private void btnAgregarPokeLista_Click(object sender, EventArgs e)
        {
            planillaPokemon alta = new planillaPokemon();
            alta.ShowDialog();
            cargar();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            Pokemon seleccionado;
            seleccionado = (Pokemon)dgvPokemon.CurrentRow.DataBoundItem;

            planillaPokemon modificar = new planillaPokemon(seleccionado);
            modificar.ShowDialog();
            cargar();
        }

        private void eliminar (bool logico = false)
        {
            pokemonNegocio negocio = new pokemonNegocio();
            Pokemon seleccinado;

            try
            {
                DialogResult respuesta = MessageBox.Show("¿Esta seguro de eliminar este pokemon?", "eliminando", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                seleccinado = (Pokemon)dgvPokemon.CurrentRow.DataBoundItem;

                if (respuesta == DialogResult.Yes)
                {
                    if(logico)
                        negocio.eliminarLogico(seleccinado.Id);
                    else
                        negocio.eliminar(seleccinado.Id);
                   
                 cargar();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void btnEliminarFisico_Click(object sender, EventArgs e)
        {
            eliminar();
        }

        private void btnElimnarLogico_Click(object sender, EventArgs e)
        {
            eliminar(true);
        }

        private void btnFiltro_Click(object sender, EventArgs e)
        {
            pokemonNegocio negocio = new pokemonNegocio();
            try
            {
                string campo = cboCampo.SelectedItem.ToString();
                string criterio = cboCriterio.SelectedItem.ToString();
                string filtro = tboFiltroAvanzado.Text;

                dgvPokemon.DataSource = negocio.filtrar(campo, criterio, filtro);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        private void tbxFiltro_TextChanged(object sender, EventArgs e)
        {
            List<Pokemon> listaFiltrada;
            string filtro = tbxFiltro.Text;

            if (filtro.Length>=3)
                listaFiltrada = ListaPokemon.FindAll(Y => Y.nombre.ToUpper().Contains(filtro.ToUpper()) || Y.Tipo.descripcion.ToUpper().Contains(filtro.ToUpper()));
            else
                listaFiltrada = ListaPokemon;

            dgvPokemon.DataSource = null;
            dgvPokemon.DataSource = listaFiltrada;
            eliminarColumnas();
        }

        private void cboCampo_SelectedIndexChanged(object sender, EventArgs e)
        {
            string opcion = cboCampo.SelectedItem.ToString();
            if (opcion == "Numero")
            {
                cboCriterio.Items.Clear();
                cboCriterio.Items.Add("Mayor a ");
                cboCriterio.Items.Add("Menor a ");
                cboCriterio.Items.Add("Igual a ");
            }
            else
            {
                cboCriterio.Items.Clear();
                cboCriterio.Items.Add("Comienza con ");
                cboCriterio.Items.Add("Termina con ");
                cboCriterio.Items.Add("Contiene ");
            }
        }
    }
}

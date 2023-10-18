using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using dominio;

namespace negocio
{
    public class pokemonNegocio
    {
        public List<Pokemon> listar()
        {
            List<Pokemon> lista = new List<Pokemon>();
            SqlConnection conexion  = new SqlConnection();
            SqlCommand comando = new SqlCommand();
            SqlDataReader lector;

            try
            {
                conexion.ConnectionString = "server=.\\SQLEXPRESS; database=POKEDEX_DB; integrated security=true";
                comando.CommandType = System.Data.CommandType.Text;
                comando.CommandText = "Select Numero, Nombre, P.Descripcion, UrlImagen, E.Descripcion Tipo, D.Descripcion Debilidad, P.IdTipo, P.IdDebilidad, P.Id From POKEMONS P, ELEMENTOS E, ELEMENTOS D Where E.Id = P.IdTipo And D.Id = P.IdDebilidad And P.Activo = 1";

                comando.Connection = conexion;
                conexion.Open();

                lector = comando.ExecuteReader();

                while (lector.Read())
                {
                    Pokemon aux = new Pokemon();
                    aux.numero = (int)lector["Numero"];
                    aux.Id = (int)lector["Id"];
                    aux.nombre = (string)lector["Nombre"];
                    aux.descripcion = (string)lector["Descripcion"];

                    if (!(lector["UrlImagen"] is DBNull))
                        aux.urlimagen = (string)lector["UrlImagen"];

                    aux.Tipo = new Elementos();
                    aux.Tipo.Id = (int)lector["IdTipo"];
                    aux.Tipo.descripcion = (string)lector["tipo"];
                    aux.Debilidad = new Elementos();
                    aux.Debilidad.Id = (int)lector["IdDebilidad"]; 
                    aux.Debilidad.descripcion = (string)lector["Debilidad"];
                    lista.Add(aux);
                }
                conexion.Close();
                return lista;
            }
            catch (Exception ex)
            { 
                throw ex;
            }
     
        }

        public void agregar(Pokemon nuevo)
        {
            accesoDatos datos = new accesoDatos();
            try
            {
                datos.setearConsulta("Insert into POKEMONS (Numero, Nombre, Descripcion, Activo, IdTipo, IdDebilidad, UrlImagen) values (" + nuevo.numero + ", '" + nuevo.nombre + "', '" + nuevo.descripcion + "', 1, @IdTipo, @IdDebilidad, @UrlImagen)");
                datos.setearParametros("@IdTipo", nuevo.Tipo.Id);
                datos.setearParametros("@IdDebilidad", nuevo.Debilidad.Id);
                datos.setearParametros("@UrlImagen", nuevo.urlimagen);
                datos.ejecutarAccion();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                datos.cerrarConexion();
            }
        }

        public void modificar (Pokemon poke)
        {
            accesoDatos datos = new accesoDatos();
            try
            {
                datos.setearConsulta("update POKEMONS set Numero = @numero, Nombre = @nombre, Descripcion = @descripcion, UrlImagen = @UrlImagen, IdTipo = @IdTipo, IdDebilidad = @IdDebilidad where Id = @Id");
                datos.setearParametros("@numero", poke.numero);
                datos.setearParametros("@nombre",poke.nombre);
                datos.setearParametros("@descripcion",poke.descripcion);
                datos.setearParametros("@UrlImagen",poke.urlimagen);
                datos.setearParametros("@IdTipo",poke.Tipo.Id);
                datos.setearParametros("@IdDebilidad",poke.Debilidad.Id);
                datos.setearParametros("@Id",poke.Id);

                datos.ejecutarAccion();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                datos.cerrarConexion();
            }
        }

        public void eliminar (int id)
        {
            accesoDatos datos = new accesoDatos();
            try
            {
            datos.setearConsulta("delete from POKEMONS where Id=@Id");
            datos.setearParametros("@id", id);
            datos.ejecutarAccion();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                datos.cerrarConexion();
            }
        }

        public void eliminarLogico (int id)
        {
            accesoDatos datos = new accesoDatos();
            try
            {
                datos.setearConsulta("update POKEMONS set Activo = 0 where Id = @Id");
                datos.setearParametros("@Id", id);
                datos.ejecutarAccion();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<Pokemon> filtrar (string campo, string criterio, string filtro)
        {
            List<Pokemon> lista = new List<Pokemon>();
            accesoDatos datos = new accesoDatos();
            try
            {
                string consulta = "Select Numero, Nombre, P.Descripcion, UrlImagen, E.Descripcion Tipo, D.Descripcion Debilidad, P.IdTipo, P.IdDebilidad, P.Id From POKEMONS P, ELEMENTOS E, ELEMENTOS D Where E.Id = P.IdTipo And D.Id = P.IdDebilidad And P.Activo = 1 And ";
                
                if (campo == "Numero")
                {
                    switch (criterio)
                    {
                        case "Mayor a ":
                            consulta += "Numero > " + filtro;
                            break;
                        case "Menor a ":
                            consulta += "Numero < " + filtro;
                            break;
                        default:
                            consulta += "Numero = " + filtro;
                            break;
                        
                    }
                }
                else if (campo == "Nombre")
                {
                    switch (criterio)
                    {
                        case "Comienza con ":
                            consulta += "Nombre like '" +filtro+"%'";
                            break;
                        case "Termina con ":
                            consulta += "Nombre like '%" + filtro + "'";
                            break;
                        default:
                            consulta += "Nombre like '%" + filtro + "%'";
                            break;
                    }                  
                }
                else
                {
                    switch (criterio)
                    {
                        case "Comienza con ":
                            consulta += "P.Descripcion like '" + filtro + "%'";
                            break;
                        case "Termina con ":
                            consulta += "P.Descripcion like '%" + filtro + "'";
                            break;
                        default:
                            consulta += "P.Descripcion like '%" + filtro + "%'";
                            break;
                    }
                }
                datos.setearConsulta(consulta);
                datos.ejecutarLectura();
                while (datos.Lector.Read())
                {
                    Pokemon aux = new Pokemon();
                    aux.numero = (int)datos.Lector["Numero"];
                    aux.Id = (int)datos.Lector["Id"];
                    aux.nombre = (string)datos.Lector["Nombre"];
                    aux.descripcion = (string)datos.Lector["Descripcion"];

                    if (!(datos.Lector["UrlImagen"] is DBNull))
                        aux.urlimagen = (string)datos.Lector["UrlImagen"];

                    aux.Tipo = new Elementos();
                    aux.Tipo.Id = (int)datos.Lector["IdTipo"];
                    aux.Tipo.descripcion = (string)datos.Lector["tipo"];
                    aux.Debilidad = new Elementos();
                    aux.Debilidad.Id = (int)datos.Lector["IdDebilidad"];
                    aux.Debilidad.descripcion = (string)datos.Lector["Debilidad"];
                    lista.Add(aux);
                }
                return lista;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

    }

}


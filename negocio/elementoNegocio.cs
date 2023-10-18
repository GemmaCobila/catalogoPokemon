using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using dominio;

namespace negocio
{
     public class elementoNegocio
    {
        public List<Elementos> listar()
        {
            List<Elementos> lista = new List<Elementos>();
            accesoDatos datos = new accesoDatos();
            try
            {
                datos.setearConsulta("select ID, Descripcion from ELEMENTOS");
                datos.ejecutarLectura();
                while (datos.Lector.Read())
                {
                    Elementos aux = new Elementos();
                    aux.Id = (int)datos.Lector["Id"];
                    aux.descripcion = (string)datos.Lector["Descripcion"];
                    lista.Add(aux);
                }
                return lista;
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
    }
}

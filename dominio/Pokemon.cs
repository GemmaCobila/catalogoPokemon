using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dominio
{
    public class Pokemon
    {
        public int Id { get; set; }
        [DisplayName ("Número")]
        public int numero { get; set; }
        public string nombre { get; set; }
        [DisplayName("Descripción")]
        public string descripcion { get; set; }
        public string urlimagen { get; set; }
        public Elementos Tipo { get; set; }
        public Elementos Debilidad { get; set; }
    }
}

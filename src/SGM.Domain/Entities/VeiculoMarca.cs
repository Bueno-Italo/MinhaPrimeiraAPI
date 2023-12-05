using System;
using System.Collections.Generic;
using System.Text;

namespace SGM.Domain.Entities
{
    public class VeiculoMarca
    {
        public int MarcaId { get; set; }
        public string Marca { get; set; }
        public int? PesoOrdenacao { get; set; }
    }
}

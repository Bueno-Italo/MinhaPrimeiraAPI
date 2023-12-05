using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SGM.ApplicationServices.ViewModels
{
    public class VeiculoViewModel
    {
        public int VeiculoId { get; set; }
        public Int64 CodigoFipe { get; set; }
        public int MarcaId { get; set; }
        public string Modelo { get; set; }
        public bool VeiculoAtivo { get; set; }
        public DateTime DataCadastro { get; set; }
    }
}

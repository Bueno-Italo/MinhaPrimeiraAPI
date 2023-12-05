using SGM.ApplicationServices.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SGM.ApplicationServices.Interfaces
{
    public interface IVeiculoServices
    {
        IEnumerable<VeiculoViewModel> GetByAll();
        VeiculoViewModel GetById(int veiculoId);
        IList<VeiculoViewModel> GetVeiculosByMarcaId(int marcaId);
        void InativarVeiculo(int veiculoId);
        int AtualizarOrSalvar(VeiculoViewModel model);
        VeiculoMarcaViewModel GetMarcaByMarcaId(int marcaId);
        IList<VeiculoMarcaViewModel> GetMarcasByAll();
        IList<VeiculoViewModel> GetVeiculoByDescricaoModelo(string descricaoModelo);
    }
}

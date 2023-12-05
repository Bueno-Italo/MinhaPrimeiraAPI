using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SGM.Infrastructure.Repositories.Interfaces
{
    public class IVeiculoRepository
    {
        IEnumerable<Veiculo> GetVeiculoByAll();
        Count GetVeiculoCount();
        Veiculo GetVeiculoById(int orcamentoId);
        IList<Veiculo> GetVeiculoByMarcaId(int marcaId);
        void InativarVeiculo(int veiculoId);
        int Salvar(Veiculo entidade);
        void Atualizar(Veiculo model);
        IList<Veiculo> GetVeiculoByDescricaoModelo(string descricaoModelo);
    }
}

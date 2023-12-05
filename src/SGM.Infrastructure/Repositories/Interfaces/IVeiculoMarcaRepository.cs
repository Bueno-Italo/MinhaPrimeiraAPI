using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SGM.Infrastructure.Repositories.Interfaces
{
    public interface IVeiculoMarcaRepository
    {
        VeiculoMarca GetById(int marcaId);
        IList<VeiculoMarca> GetMarcasByAll();
    }
}

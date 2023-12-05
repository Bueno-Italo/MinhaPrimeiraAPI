using SGM.Infrastructure.Context;
using SGM.Infrastructure.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SGM.Infrastructure.Repositories.Repository
{
    public class VeiculoMarcaRepository : IVeiculoMarcaRepository
    {
        private readonly SGMContext _SGMContext;

        public VeiculoMarcaRepository(SGMContext sGMContext)
        {
            _SGMContext = sGMContext;
        }
    }
}

using AutoMapper;
using SGM.ApplicationServices.Interfaces;
using SGM.ApplicationServices.ViewModels;
using SGM.Infrastructure.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SGM.ApplicationServices.Services
{
    public class VeiculoServices : IVeiculoServices
    {
        private readonly IVeiculoRepository _veiculoRepository;
        private readonly IVeiculoMarcaRepository _veiculoMarcaRepository;
        private readonly IMapper _mapper;

        public VeiculoServices(IVeiculoRepository veiculoRepository, IVeiculoMarcaRepository veiculoMarcaRepository, IMapper mapper)
        {
            _veiculoRepository = veiculoRepository;
            _veiculoMarcaRepository = veiculoMarcaRepository;
            _mapper = mapper;
        }
    }
}

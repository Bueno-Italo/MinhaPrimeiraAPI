using AutoMapper;
using SGM.ApplicationServices.ViewModels;
using SGM.Infrastructure.Repositories.Interfaces;

namespace SGM.ApplicationServices.Services
{
    public class ClienteServices : IClienteServices
    {
        private readonly IClienteRepository _clienteRepository;
        private readonly IMapper _mapper;

        public ClienteServices(IClienteRepository clienteRepository,IMapper mapper)
        {
            _clienteRepository = clienteRepository;
            _mapper = mapper;
        }

        public IEnumerable<CLienteViewModel> GetByAll()
        {
            return _mapper.Map<IEnumerable<ClienteViewModel>>(_clienteRepository.GetByAll());
        }

    }
}

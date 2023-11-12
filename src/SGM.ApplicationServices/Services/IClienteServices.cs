using SGM.ApplicationServices.ViewModels;

namespace SGM.ApplicationServices.Services
{
    public interface IClienteServices
    {
        IEnumerable<ClienteViewModel> GetByAll();
        ClienteViewModel GetById(int clienteId);
    }
}
using SGM.ApplicationServices.ViewModels;

namespace SGM.ApplicationServices.Interfaces
{
    public interface IClienteServices
    {
        void Atualizar(ClienteViewModel model);
        IEnumerable<ClienteViewModel> GetByAll();
        ClienteViewModel GetById(int clienteId);
        ClienteViewModel GetClienteByDocumentoCliente(string documentoCliente);
        void InativarCliente(int solicitacaoId);
        int Salvar(ClienteViewModel model);
    }
}
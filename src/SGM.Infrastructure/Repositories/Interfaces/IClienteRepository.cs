using SGM.Domain.Entities;

namespace SGM.Infrastructure.Repositories.Interfaces
{
    public interface IClienteRepository
    {
        IEnumerable<Cliente> GetByAll();
        Cliente? GetById(int clienteId);
        Cliente GetClienteByDocumentoCliente(string documentoCliente);
        void InativarCliente(int clienteId);
        int Salvar(Cliente entidade);
    }
}
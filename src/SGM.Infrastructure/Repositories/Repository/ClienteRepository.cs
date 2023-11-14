using Microsoft.EntityFrameworkCore;
using SGM.Domain.Entities;
using SGM.Infrastructure.Context;
using SGM.Infrastructure.Repositories.Interfaces;

namespace SGM.Infrastructure.Repositories.Repository
{
    public class ClienteRepository : IClienteRepository
    {
        private readonly SGMContext _SGMContext;
        public ClienteRepository(SGMContext context)
        {
            _SGMContext = context;
        }

        public IEnumerable<Cliente> GetByAll()
        {
            return _SGMContext.Cliente
                .AsNoTracking()
                .ToList();
        }

        public Cliente? GetById(int clienteId)
        {
            return _SGMContext.Cliente
                .AsNoTracking()
                .Where(x => x.ClienteId == clienteId)
                .FirstOrDefault();
        }

        public Cliente GetClienteByDocumentoCliente(string documentoCliente)
        {
            return _SGMContext.Cliente.AsNoTracking().Where(cliente => cliente.DocumentoCliente.Replace(".", "").Replace("-", "") == documentoCliente.Replace(".", "").Replace("-", "") && cliente.ClienteAtivo).FirstOrDefault();
        }

        public void InativarCliente(int clienteId)
        {
            var cliente = GetById(clienteId);

            cliente.DataAlteracao = DateTime.Now;
            cliente.ClienteAtivo = false;

            _SGMContext.Update(cliente);
            _SGMContext.SaveChanges();
        }
    }
}

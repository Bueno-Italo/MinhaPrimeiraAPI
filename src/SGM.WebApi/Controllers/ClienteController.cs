using Microsoft.AspNetCore.Mvc;
using SGM.ApplicationServices.Interfaces;

namespace SGM.WebApi.Controllers
{
    [ApiController]
    [Route("MinhaPrimeiraAPI")]
    [Produces("application/json")]
    public class ClienteController : ControllerBase
    {
        private readonly Serilog.ILogger _logger;
        private readonly IClienteServices _clienteServices;

        public ClienteController(Serilog.ILogger logger,
            IClienteServices clienteServices)
        {
            _logger = logger;
            _clienteServices = clienteServices;
        }

        [HttpGet]
        [Route("cliente")]
        public IActionResult GetClientesForAll()
        {
            try
            {
                _logger.Information("[ClienteController.GetClientesForAll] - Solicitação para buscar todos os clientes");

                var clientes = _clienteServices.GetByAll();
                return Ok(clientes);
            }

            catch (Exception ex)
            {
                _logger.Error(ex, $"[ClienteController.GetClienteForAll] - Erro ao efetuar a chamada para buscar todos os clientes: ", ex);

                return StatusCode(500, ex);
            }
        }

        [HttpGet]
        [Route("cliente/{clienteId}")]
        public IActionResult GetClienteById(int clienteId)
        {
            try
            {
                _logger.Information($"[ClienteController.GetClientesById] - Solicitando a busca do cliente com Id: {clienteId}");

                var cliente = _clienteServices.GetById(clienteId);

                return Ok(cliente);
            }
            catch (Exception ex)
            {
                _logger.Error(ex, $"[ClienteController.GetClientesById] - Erro ao efetuar a busca do cliente com o Id: {clienteId} Erro: {ex.Message}");

                return StatusCode(500, ex);
            }
        }

        [HttpGet]
        [Route("cliente/documento-cliente")]
        public IActionResult GetClienteByDocumentoCliente(string documentoCliente)
        {
            try
            {
                _logger.Information($"[ClienteController.GetClienteByDocumentoCliente] - Solicitação para buscar um cliente a partir do seu documento: {documentoCliente}");

                var cliente = _clienteServices.GetClienteByDocumentoCliente(documentoCliente);

                return Ok(cliente);
            }
            catch (Exception ex)
            {
                _logger.Error(ex, $"[ClienteController.GetClienteByDocumentoCliente] - Erro ao efetuar a busca do cliente a partir do seu documento: {documentoCliente} Erro: {ex.Message}");

                return StatusCode(500, ex);
            }
        }
    }
}
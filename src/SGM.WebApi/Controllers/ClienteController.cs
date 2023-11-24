using Microsoft.AspNetCore.Mvc;
using SGM.ApplicationServices.Interfaces;
using SGM.ApplicationServices.ViewModels;
using System.Text.Json;

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

        [HttpPut]
        [Route("cliente/inativar/{clienteId}")]

        public IActionResult InativarCliente(int clienteId) 
        {
            try
            {
                _logger.Information($"[ClienteController.InativarCliente] - Solicitação para inativar um cliente a partir do seu Id: {clienteId}");

                _clienteServices.InativarCliente(clienteId);

                return Ok();
            }
            catch (Exception ex)
            {
                _logger.Error(ex, $"[ClienteController.InativarCliente] - Erro ao efetuar a inativação do cliente a partir do seu Id: {clienteId} Erro: {ex.Message}");

                return StatusCode(500, ex);
                
            }
        }

        [HttpPost]
        [Route("cliente")]

        public IActionResult Salvar(ClienteViewModel model)
        {
            try
            {
                _logger.Information($"[ClienteController.Salvar] - Solicitação para salvar o cliente: {JsonSerializer.Serialize(model)}");

                var clienteId = _clienteServices.Salvar(model);

                return Created("", clienteId);
            }
            catch (Exception ex)
            {
                _logger.Error(ex, $"[ClienteController.Salvar] - Erro ao  tentar Salvar o Cliente: {JsonSerializer.Serialize(model)} Erro: {ex.Message}");

                return StatusCode(500, ex);
            }
        }

        [HttpPut]
        [Route("cliente/{clienteId}")]
        public IActionResult Atualizar(int clienteId, ClienteViewModel model)
        {
            try
            {
                _logger.Information($"[ClienteController.Atualizar] - Solicitação para Atualizar o Cliente de Id: {clienteId} com as seguintes informações: {JsonSerializer.Serialize(model)}");

                model.ClienteId = clienteId;
                _clienteServices.Atualizar(model);

                return Ok();
            }
            catch (Exception ex)
            {
                _logger.Error(ex, $"[ClienteController.Atualizar] - Erro ao  tentar Atualizar o Cliente: {JsonSerializer.Serialize(model)} Erro: {ex.Message}");

                return StatusCode(500, ex);
            }
        }
    }
}

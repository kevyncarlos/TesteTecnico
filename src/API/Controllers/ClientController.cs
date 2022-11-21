using API.Data.Entities;
using API.Models;
using API.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ClientController : ControllerBase
    {
        private readonly ILogger<ClientController> _logger;
        private readonly IClientService _clientService;

        public ClientController(ILogger<ClientController> logger, IClientService clientService)
        {
            _logger = logger;
            _clientService = clientService;
        }

        [HttpGet]
        public Response<IEnumerable<Client>> Get()
        {
            _logger.LogInformation($"{nameof(ClientController)} -> {nameof(Get)}");

            return _clientService.GetAll();
        }

        [HttpGet("{id}")]
        public Response<Client> GetById(int id)
        {
            _logger.LogInformation($"{nameof(ClientController)} -> {nameof(Get)}");

            return _clientService.GetById(id);
        }

        [HttpPost]
        public Response<Client> Post(Client client)
        {
            _logger.LogInformation($"{nameof(ClientController)} -> {nameof(Post)} - {nameof(client)}: {client}");

            return _clientService.Add(client);
        }

        [HttpPut]
        public Response<Client> Put(Client client)
        {
            _logger.LogInformation($"{nameof(ClientController)} -> {nameof(Put)} - {nameof(client)}: {client}");

            return _clientService.Update(client);
        }

        [HttpDelete("{id}")]
        public Response<bool> Delete(int id)
        {
            _logger.LogInformation($"{nameof(ClientController)} -> {nameof(Delete)} - {nameof(id)}: {id}");

            return _clientService.Delete(id);
        }
    }
}
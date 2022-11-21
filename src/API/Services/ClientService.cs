using API.Data.Entities;
using API.Data.Repositories.Interfaces;
using API.Models;
using API.Services.Interfaces;

namespace API.Services
{
    public class ClientService : IClientService
    {
        private readonly ILogger<ClientService> _logger;
        private readonly IClientRepository _clientRepository;

        public ClientService(ILogger<ClientService> logger, IClientRepository clientRepository)
        {
            _logger = logger;
            _clientRepository = clientRepository;
        }

        public Response<Client> Add(Client client)
        {
            _logger.LogInformation($"{nameof(ClientService)} -> {nameof(Add)} - {nameof(client)}: {client}");

            try
            {
                var result = _clientRepository.AddOrUpdate(client);
                _clientRepository.SaveChanges();

                return Response<Client>.GenerateWithSuccess("Client add is successful", result);
            }
            catch (Exception ex)
            {
                return Response<Client>.GenerateWithError("Client add has an error: " + ex.Message);
            }
        }

        public Response<bool> Delete(int id)
        {
            _logger.LogInformation($"{nameof(ClientService)} -> {nameof(Delete)} - {nameof(id)}: {id}");

            try
            {
                var result = _clientRepository.Delete(id);
                _clientRepository.SaveChanges();

                if (result == false)
                    throw new Exception($"Client with id: {id} not found.");

                return Response<bool>.GenerateWithSuccess("Client delete is successful", result);
            }
            catch (Exception ex)
            {
                return Response<bool>.GenerateWithError("Client add has an error: " + ex.Message);
            }
        }

        public Response<IEnumerable<Client>> GetAll()
        {
            _logger.LogInformation($"{nameof(ClientService)} -> {nameof(GetAll)}");

            try
            {
                var result = _clientRepository.GetAll();

                if(!result.Any())
                    throw new Exception($"Clients not found.");

                return Response<IEnumerable<Client>>.GenerateWithSuccess("Get all clients is successful", result);
            }
            catch (Exception ex)
            {
                return Response<IEnumerable<Client>>.GenerateWithError("Get all clients has an error: " + ex.Message);
            }
        }

        public Response<Client> GetById(int id)
        {
            _logger.LogInformation($"{nameof(ClientService)} -> {nameof(GetById)} - {nameof(id)}: {id}");

            try
            {
                var result = _clientRepository.GetById(id);

                if (result is null)
                    throw new Exception($"Client with id: {id} not found.");

                return Response<Client>.GenerateWithSuccess("Get client by id is successful", result);
            }
            catch (Exception ex)
            {
                return Response<Client>.GenerateWithError("Get client by id has an error: " + ex.Message);
            }
        }

        public Response<Client> Update(Client client)
        {
            _logger.LogInformation($"{nameof(ClientService)} -> {nameof(Update)} - {nameof(client)}: {client}");

            try
            {
                var result = _clientRepository.AddOrUpdate(client);
                _clientRepository.SaveChanges();

                return Response<Client>.GenerateWithSuccess("Client update is successful", result);
            }
            catch (Exception ex)
            {
                return Response<Client>.GenerateWithError("Client update has an error: " + ex.Message);
            }
        }
    }
}

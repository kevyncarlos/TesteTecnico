using API.Data.Entities;
using API.Models;

namespace API.Services.Interfaces
{
    public interface IClientService
    {
        public Response<IEnumerable<Client>> GetAll();
        public Response<Client> GetById(int id);
        public Response<Client> Add(Client client);
        public Response<Client> Update(Client client);
        public Response<bool> Delete(int id);
    }
}

using API.Data.Entities;
using API.Data.Repositories.Interfaces;

namespace API.Data.Repositories
{
    public class ClientRepository : RepositoryBase<Client>, IClientRepository
    {
        public ClientRepository(TesteDBContext context) : base(context) { }
    }
}

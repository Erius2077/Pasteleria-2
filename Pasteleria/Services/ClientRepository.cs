using Pasteleria.Data;
using Pasteleria.Models;

namespace Pasteleria.Services
{
    public class ClientRepository: GenericRepository<Client>, IClientRepository
    {
        public ClientRepository(ApplicationDbContext context) : base(context)
        {

        }
    }
}

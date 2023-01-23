using Pasteleria.Data;
using Pasteleria.Models;

namespace Pasteleria.Services
{
    public class CakeRepository: GenericRepository<Cake>, ICakeRepository
    {
        public CakeRepository(ApplicationDbContext context) : base(context)
        {

        }
    }
}

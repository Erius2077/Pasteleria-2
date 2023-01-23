using Pasteleria.Data;
using Pasteleria.Models;

namespace Pasteleria.Services
{
    public class CalendaryTimeRepository : GenericRepository<CalendaryTime>, ICalendaryTimeRepository
    {
        public CalendaryTimeRepository(ApplicationDbContext context) : base(context)
        {

        }
    }
}

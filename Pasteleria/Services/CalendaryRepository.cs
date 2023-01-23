using Microsoft.EntityFrameworkCore;
using Pasteleria.Data;
using Pasteleria.Models;

namespace Pasteleria.Services
{
    public class ScheduleRepository: GenericRepository<Calendary>, ICalendaryRepository
    {
        private readonly ApplicationDbContext _context;
        public CalendaryRepository(ApplicationDbContext context) : base(context)
        {
            _context = context;

        }
        public override async Task<IEnumerable<Calendary>> GetAllAsync()
        {
            var applicationDbContext = _context.Calendary.Include(s => s.User);
            return await applicationDbContext.ToListAsync();
        }
        public async Task<Calendary> GetByIdAsync(int id)
        {
            return await _context.Calendary
                .Include(s => s.User)
                .FirstOrDefaultAsync(m => m.Id == id);
        }
    }
}

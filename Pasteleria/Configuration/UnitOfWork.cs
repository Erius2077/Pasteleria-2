using Pasteleria.Data;
using Pasteleria.Services;

namespace Pasteleria.Configuration
{
    public class UnitOfWork : IUnitOfWork, IDisposable
    {
        private readonly ApplicationDbContext _context;
        public ICakeRepository CakeRepository { get; private set; }

        public ICalendaryTimeRepository CalendaryTimeRepository { get; private set; }

        public IClientRepository ClientRepository { get; private set; }

        public IUserRoleRepository UserRoleRepository { get; private set; }

        public ICalendaryRepository CalendaryRepository { get; private set; }

        public IReservationRepository ReservationRepository { get; private set; }

        public IReservationStatusRepository ReservationStatusRepository { get; private set; }

        public UnitOfWork(ApplicationDbContext context)
        {
            _context = context;
            CakeRepository = new CakeRepository(_context);
            CalendaryTimeRepository = new CalendaryTimeRepository(_context);
            ClientRepository = new ClientRepository(_context);
            UserRoleRepository = new UserRoleRepository(_context);
            ReservationRepository = new ReservationRepository(_context);
            ReservationStatusRepository = new ReservationStatusRepository(_context);
            CalendaryRepository = new CalendaryRepository(_context);


        }
        public void Commit()
        {
            _context.SaveChanges();

        }

        public void Dispose()
        {
           _context.Dispose();
        }
    }
}

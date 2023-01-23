using Pasteleria.Services;

namespace Pasteleria.Configuration
{
    public interface IUnitOfWork
    {
        ICakeRepository CakeRepository { get; }

        ICalendaryTimeRepository CalendaryTimeRepository { get; }

        IClientRepository ClientRepository { get; }

        IUserRoleRepository UserRoleRepository { get; }

        ICalendaryRepository CalendaryRepository { get; }

        IReservationRepository ReservationRepository { get; }

        IReservationStatusRepository ReservationStatusRepository { get; }


        void Commit();

        void Dispose();

    }
}
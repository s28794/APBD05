using AnimalsAPI.Models;

namespace AnimalsAPI.Repositories;

public interface IAppointmentRepository
{
    IEnumerable<Appointment> getAppointments();
    int AddAppointment(Appointment appointment);
}
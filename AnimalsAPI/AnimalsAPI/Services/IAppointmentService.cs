using AnimalsAPI.Models;

namespace AnimalsAPI.Services;

public interface IAppointmentService
{
    IEnumerable<Appointment> getAppointments();
    int AddAppointment(Appointment appointment);
}
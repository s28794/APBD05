using AnimalsAPI.Exceptions;
using AnimalsAPI.Models;
using AnimalsAPI.Repositories;

namespace AnimalsAPI.Services;

public class AppointmentService : IAppointmentService
{
    private readonly IAppointmentRepository _appointmentRepository;

    public AppointmentService(IAppointmentRepository appointmentRepository)
    {
        _appointmentRepository = appointmentRepository;
    }

    public IEnumerable<Appointment> getAppointments()
    {
        return _appointmentRepository.getAppointments();
    }

    public int AddAppointment(Appointment appointment)
    {
        var enumerable = _appointmentRepository.getAppointments();

        foreach (var x in enumerable)
        {
            if (x.Animal.IdAnimal == appointment.Animal.IdAnimal && x.VisitDate == appointment.VisitDate)
            {
                throw new NotUniqueIdException();
            }
        }

        return _appointmentRepository.AddAppointment(appointment);
    }
}
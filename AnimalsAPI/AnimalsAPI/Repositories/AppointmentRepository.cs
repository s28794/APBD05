using System.Runtime.InteropServices.JavaScript;
using AnimalsAPI.Models;

namespace AnimalsAPI.Repositories;

public class AppointmentRepository : IAppointmentRepository
{
    private static List<Appointment> _appointments;

    public AppointmentRepository()
    {
        _appointments = new List<Appointment>();
    }

    public IEnumerable<Appointment> getAppointments()
    {
        return _appointments;
    }

    public int AddAppointment(Appointment appointment)
    {
        (string visitDate, Animal animal, string description, double price) = appointment;
        Appointment newAppointment = new Appointment(visitDate, animal, description, price);
        _appointments.Add(newAppointment);
        return 1;
    }
}
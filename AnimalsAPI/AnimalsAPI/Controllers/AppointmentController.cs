using AnimalsAPI.Exceptions;
using AnimalsAPI.Models;
using AnimalsAPI.Services;
using Microsoft.AspNetCore.Mvc;

namespace AnimalsAPI.Controllers;


[Route("api/[controller]")]
[ApiController]
public class AppointmentController : ControllerBase
{
    private readonly IAppointmentService _appointmentService;

    public AppointmentController(IAppointmentService appointmentService)
    {
        _appointmentService = appointmentService;
    }

    [HttpGet]
    public IActionResult GetAppointments()
    {
        var appointments = _appointmentService.getAppointments();

        return Ok(appointments);
    }
    
    [HttpPost]
    public IActionResult AddAppointment(Appointment appointment)
    {
        try
        {
            _appointmentService.AddAppointment(appointment);
            return StatusCode(StatusCodes.Status201Created);
        }
        catch (NotUniqueIdException)
        {
            return StatusCode(StatusCodes.Status400BadRequest);
        }
            
    }
}


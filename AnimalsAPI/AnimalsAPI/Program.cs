using AnimalsAPI.Repositories;
using AnimalsAPI.Services;

public class Program
{
    public static void Main(string[] args)
    {
        var builder = WebApplication.CreateBuilder(args);

        builder.Services.AddEndpointsApiExplorer();
        builder.Services.AddSwaggerGen();
        builder.Services.AddControllers();
        builder.Services.AddScoped<IAnimalService, AnimalService>();
        builder.Services.AddScoped<IAppointmentService, AppointmentService>();
        builder.Services.AddSingleton<IAnimalRepository, AnimalRepository>();
        builder.Services.AddSingleton<IAppointmentRepository, AppointmentRepository>();

        var app = builder.Build();

        if (app.Environment.IsDevelopment())
        {
            app.UseSwagger();
            app.UseSwaggerUI();
        }

        app.UseHttpsRedirection();
        app.MapControllers();
        
        app.Run();
    }
}
using Models;

namespace DockerAutoPublish;

public class Program
{
    public static void Main(string[] args)
    {
        var builder = WebApplication.CreateBuilder(args);

        // Add services to the container.
        builder.Configuration.AddEnvironmentVariables().AddUserSecrets<Program>();

        builder.Services.AddControllers();
        // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
        builder.Services.AddEndpointsApiExplorer();
        builder.Services.AddSwaggerGen();
        builder.Services.Configure<AppSettings>(builder.Configuration.GetSection("AppSettings"));

        builder.Services.Configure<AppConfig>(builder.Configuration.GetSection(nameof(AppConfig)));
        var currentConfig = builder.Configuration
        .GetSection(nameof(AppSettings))
        .Get<AppSettings>();

        var app = builder.Build();
        var defaultConnection = Environment.GetEnvironmentVariables();

        // Configure the HTTP request pipeline.
        app.UseSwagger();
        app.UseSwaggerUI();


        app.UseAuthorization();

        app.MapControllers();

        app.Run();
    }
}

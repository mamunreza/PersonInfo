using FluentValidation;
using FluentValidation.AspNetCore;
using Microsoft.EntityFrameworkCore;
using PersonInfo.Data;
using PersonInfo.Service;
using PersonInfo.Validation;

namespace PersonInfo.Api
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
            ConfigurationManager configuration = builder.Configuration;
            IWebHostEnvironment environment = builder.Environment;

            builder.Services.AddControllers();

            builder.Services.AddFluentValidationAutoValidation();
            builder.Services.AddValidatorsFromAssemblyContaining<CreatePersonCommandValidator>();

            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();

            builder.Services.AddCors(options =>
            {
                options.AddDefaultPolicy(
                    b =>
                    {
                        b.WithOrigins("http://localhost:3000", "http://localhost:3001")
                            .AllowAnyHeader()
                            .AllowAnyMethod();
                    });
            });

            builder.Services.AddDbContext<PersonInfoContext>(item =>
                item.UseSqlServer(configuration.GetConnectionString("PersonInfoConnection"),
                    x => x.MigrationsAssembly("PersonInfo.Api")));

            builder.Services.AddScoped<ISectorService, SectorService>();
            builder.Services.AddScoped<IPersonService, PersonService>();

            var app = builder.Build();

            app.UseCors();
            app.UseSwagger();
            app.UseSwaggerUI();

            app.UseHttpsRedirection();

            app.UseAuthorization();


            app.MapControllers();

            app.Run();
        }
    }
}
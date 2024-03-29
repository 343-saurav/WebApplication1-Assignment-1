
using Microsoft.EntityFrameworkCore;
using WebApplication1_Assignment.DataContext;
using WebApplication1_Assignment.IRepo;
using WebApplication1_Assignment.Repo;

namespace WebApplication1_Assignment
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.

            builder.Services.AddControllers();
            builder.Services.AddDbContext<ApplicationContext>(x => x.UseSqlServer(builder.Configuration["ConnectionStrings:myConnection"]));
            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle has context menu
            builder.Services.AddTransient<ITaskListRepo, TaskListRepocs>();
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            app.UseAuthorization();


            app.MapControllers();

            app.Run();
        }
    }
}

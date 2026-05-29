using Microsoft.EntityFrameworkCore;

namespace learn
{
    public class Program
    {
        public static void Main(string[] args)
        {
            WebApplicationBuilder builder = WebApplication.CreateBuilder(args);

            // Add services to the container.

            builder.Services.AddControllers();

            builder.Services.AddDbContext<AppDbContext>(options =>
            options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

            WebApplication app = builder.Build();

            app.UseRouting();

            app.MapControllers();

            app.MapGet("/", () => "Hello pop");

            app.UseHttpsRedirection();

            app.UseAuthorization();

            app.Run();
        }
    }
}

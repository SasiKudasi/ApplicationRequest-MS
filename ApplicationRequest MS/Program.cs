using ApplicationRequest.DataAccess;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
namespace ApplicationRequest_MS
{
    public class Program
    {

        static void Main(string[] args)
        {
            /*
             * ToDo
             * Подключить ConnectionStrings +
             * Реализовать подлючение RabbitMQ
             * Обработать валидацию данных
             * Подумать о том как возвращать какие то данные в кор приложение
             */
            IConfiguration configuration = new ConfigurationBuilder()
              .AddJsonFile("appsettings.json", optional: true, reloadOnChange: true)
              .Build();
            var connectionString = configuration.GetConnectionString("DefaultConnection");
            var optionsBuilder = new DbContextOptionsBuilder<ApplicationRequestDbContext>();
            optionsBuilder.UseNpgsql(connectionString);


        }
    }
}

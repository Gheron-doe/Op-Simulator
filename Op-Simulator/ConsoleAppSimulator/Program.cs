using Microsoft.Extensions.Configuration;

namespace ConsoleAppSimulator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            var builder = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true);
            var config = builder.Build();
            string connectionString = config.GetConnectionString("SQLServerConnection");
            string AdresSourceFile = config.GetSection("AppSettings")["AdresSourceFile"];
            string VoornaamMSourceFile = config.GetSection("AppSettings")["VoornaamMSourceFile"];
            string VoornaamVSourceFile = config.GetSection("AppSettings")["VoornaamVSourceFile"];
            string FamilinaamSourceFile = config.GetSection("AppSettings")["FamilinaamSourceFile"];
            string ZipcodesSourceFile = config.GetSection("AppSettings")["ZipcodesSourceFile"];
            string AdresFileType = config.GetSection("AppSettings")["AdresFileType"];
            string VoornaamMFiletype = config.GetSection("AppSettings")["VoornaamMFiletype"];
            string VoornaamVFileType = config.GetSection("AppSettings")["VoornaamVFileType"];
            string FamilinaamFileType = config.GetSection("AppSettings")["FamilinaamFileType"];
            string ZipcodesFileType = config.GetSection("AppSettings")["ZipcodesFileType"];


        }
    }
}

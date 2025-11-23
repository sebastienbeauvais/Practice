using OopPractice_Library;
using OopPractice_Library.Data;
using Microsoft.Extensions.DependencyInjection;

namespace OopPractice_Library
{
    public class Program
    {
        
        public static void Main(string[] arg)
        {
            var serviceProvider = ConfigureServices();
            var lib = serviceProvider.GetRequiredService<Library>();
            lib.LaunchApp();
            
            Console.WriteLine("Closing program...");

        }
        private static ServiceProvider ConfigureServices()
        {
            var services = new ServiceCollection();

            services.AddScoped<PageDataSet, PageDataSet>();
            services.AddScoped<BookDataSet, BookDataSet>();
            services.AddScoped<Page, Page>();
            services.AddScoped<Book, Book>();
            services.AddScoped<Library, Library>();

            return services.BuildServiceProvider();
        } 
    }
}

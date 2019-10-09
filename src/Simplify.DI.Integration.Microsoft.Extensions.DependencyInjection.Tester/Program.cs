using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Hosting;

namespace Simplify.DI.Integration.Microsoft.Extensions.DependencyInjection.Tester
{
	public class Program
	{
		public static void Main(string[] args)
		{
			CreateHostBuilder(args).Build().Run();
		}

		public static IHostBuilder CreateHostBuilder(string[] args) =>
			Host.CreateDefaultBuilder(args)
				.ConfigureWebHostDefaults(webBuilder =>
				{
					webBuilder.UseStartup<Startup>();
				});
	}
}
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Configuration;
using Ecommerce.Infrastructure.Data;

namespace Ecommerce.Infrastructure.Extensions
{
	public static class ServiceCollectionExtensions
	{
		public static IServiceCollection AddInfrastructure(this IServiceCollection services, IConfiguration configuration)
		{
			// Register DbContext
			services.AddDbContext<ApplicationDbContext>(options =>
				options.UseSqlServer(configuration.GetConnectionString("MyConn"))
			);

			// Yaha aur DI register kar sakte ho
			// services.AddScoped<IProductRepository, ProductRepository>();

			return services;
		}
	}
}

using System;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;


namespace JonasTest.Web.Config
{
	public class ApiSettings
	{
		public int MaxTake { get; set; }
	}


	public static class ServiceCollectionExtensions
	{
		public static void AddAPISettingsService(this IServiceCollection services,
			IConfiguration configuration)
		{
			var settingsSection = configuration.GetSection("ApiSettings");

			// Inject AppIdentitySettings so that others can use too
			services.Configure<ApiSettings>(settingsSection);
		}
	}
}

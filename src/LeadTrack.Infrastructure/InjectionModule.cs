using LeadTrack.Domain.interfaces;
using LeadTrack.Infrastructure.dataBase;
using LeadTrack.Infrastructure.repositories;
using LeadTrack.Services.services;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace LeadTrack.Infrastructure
{
    public static class InjectionModule
    {
        public static IServiceCollection AddInfrastructure(this IServiceCollection services, string connectionString)
        {
            services.AddDbContext<LeadTrackContext>(options =>
                options.UseSqlServer(connectionString));

            services.AddScoped<ILeadRepository, LeadRepository>();
            services.AddScoped<LeadService>();

            return services;
        }
    }
}

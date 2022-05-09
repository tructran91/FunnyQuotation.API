using FunnyQuotation.Application.Common.Interfaces;
using FunnyQuotation.Application.Common.Interfaces.Repositories;
using FunnyQuotation.Infrastructure.Caching;
using FunnyQuotation.Infrastructure.Data;
using FunnyQuotation.Infrastructure.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace FunnyQuotation.Infrastructure
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddInfrastructure(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<ApplicationDbContext>(options =>
                options.UseSqlServer(configuration.GetConnectionString("DefaultConnection")));

            //services.AddIdentity<Author, IdentityRole>()
            //    .AddEntityFrameworkStores<ApplicationDbContext>()
            //    .AddUserManager<MyUserManager>()
            //    .AddSignInManager<MySignInManager>()
            //    .AddRoleManager<MyRoleManager>()
            //    .AddDefaultTokenProviders();

            //services.AddScoped<IEmailSender, EmailSender>();

            services.AddTransient(typeof(IRepository<>), typeof(Repository<>));
            services.AddTransient<ICategoryRepository, CategoryRepository>();
            //services.AddTransient<IQuotationRepository, QuotationRepository>();
            //services.AddTransient<IUserRepository, UserRepository>();

            services.AddMemoryCache();
            services.AddSingleton<IMemoryCacheManager, MemoryCacheManager>();

            return services;
        }
    }
}

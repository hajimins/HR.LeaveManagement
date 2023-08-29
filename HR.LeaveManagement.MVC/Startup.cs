using HR.LeaveManagement.MVC.Contracts;
using HR.LeaveManagement.MVC.Services.Base;
using System.Reflection;

namespace HR.LeaveManagement.MVC
{
    public class Startup
    {
        public IConfiguration Configuration { get; }
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddHttpClient<IClient, Client>(c1 => c1.BaseAddress = new Uri("https://localhost:44383"));
            services.AddAutoMapper(Assembly.GetExecutingAssembly());

            ////services.AddScoped<ILeaveTypeService, LeaveTypeService>();
            services.AddSingleton<ILocalStorageService, ILocalStorageService>();
            services.AddControllersWithViews();
        }
    }
}

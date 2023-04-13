namespace Sample.API;

public class Startup
{
    public Startup(IConfiguration configuration)
    {
        Configuration = configuration;
    }
    public IConfiguration Configuration { get; }

    public void ConfigureServices(IServiceCollection services)
    {
        services.AddControllers();

        services.AddEndpointsApiExplorer();
        services.AddSwaggerGenConfig("Sample API", "v1", string.Empty);

        var databaseInMemory = Configuration.GetSection("DatabaseInMemory").GetValue<bool>("enabled");
        var connectionString = Configuration.GetSection("ConnectionStrings").GetValue<string>("Default");

        if (databaseInMemory)
        {
            services.AddDbContext<DataDbContext>(option =>
            {
                option.UseInMemoryDatabase("People");
            });
        }
        else
        {
            services.AddDbContextPool<DataDbContext>(optionsBuilder =>
            {
                optionsBuilder.UseSqlite(connectionString);
            });
        }

        services.AddDbContextGenericsMethods<DataDbContext>();
        services.AddTransient<IPeopleService, PeopleService>();

        services.AddMediatR(cfg => cfg.RegisterServicesFromAssembly(typeof(CreatePersonHandler).Assembly));
        services.AddAutoMapper(typeof(PersonMapperProfile).Assembly);
    }

    public void Configure(WebApplication app)
    {
        IWebHostEnvironment env = app.Environment;

        app.UseHttpsRedirection();

        if (env.IsDevelopment())
        {
            app.AddUseSwaggerUI("Sample API v1");
        }

        app.UseRouting();
        app.UseEndpoints(endpoints =>
        {
            endpoints.MapControllers();
        });
    }
}
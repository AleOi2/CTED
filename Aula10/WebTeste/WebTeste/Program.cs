namespace deploy_sample
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
            var app = builder.Build();

            app.MapGet("/", () =>
            {

                var builder = WebApplication.CreateBuilder(args);
                builder.Services.AddControllers();
                var app = builder.Build();

                app.UseRouting();(app);
                app.UseEndpoints(endpoint => endpoint.MapGet("/", async context =>
                {
                    await context.Response.WriteAsync($"Deploy Sample ({app.Environment.EnvironmentName})");
                    endpoint.MapDefaultControllerRoute();
                }));


            });
            app.Run();
        }
    }
}

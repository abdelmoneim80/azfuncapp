using Microsoft.Azure.Functions.Worker;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.DependencyInjection;
using system;

var host = new HostBuilder()
    .ConfigureFunctionsWebApplication()
    .ConfigureServices(services => {
        services.AddApplicationInsightsTelemetryWorkerService();
        services.ConfigureFunctionsApplicationInsights();
    })
    .Build();

host.Run();

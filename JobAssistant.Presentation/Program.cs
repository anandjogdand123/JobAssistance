using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using JobAssistant.Application.UseCases;
using JobAssistant.Domain.Interfaces;
using JobAssistant.Infrastructure.Scrapers;
using JobAssistant.Infrastructure.Matchers;
using JobAssistant.Infrastructure.Appliers;

var host = Host.CreateDefaultBuilder(args)
    .ConfigureServices(services =>
    {
        services.AddScoped<IJobScraper, FakeScraper>();
        services.AddScoped<IJobMatcher, SimpleMatcher>();
        services.AddScoped<IJobApplier, ConsoleApplier>();

        services.AddScoped<ApplyJobsUseCase>();
    })
    .Build();

var useCase = host.Services.GetRequiredService<ApplyJobsUseCase>();

string resume = ".NET C# Azure SQL";

await useCase.ExecuteAsync(".NET Developer", resume);

Console.WriteLine("DONE");

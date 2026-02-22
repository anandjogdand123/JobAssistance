using JobAssistant.Domain.Entities;
using JobAssistant.Domain.Interfaces;

namespace JobAssistant.Infrastructure.Appliers;

public class ConsoleApplier : IJobApplier
{
    public Task ApplyAsync(JobPosting job)
    {
        Console.WriteLine($"Applying to {job.Company} - {job.Title}");
        return Task.CompletedTask;
    }
}

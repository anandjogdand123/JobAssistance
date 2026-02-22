using JobAssistant.Domain.Entities;
using JobAssistant.Domain.Interfaces;

namespace JobAssistant.Infrastructure.Scrapers;

public class FakeScraper : IJobScraper
{
    public Task<List<JobPosting>> ScrapeJobListingsAsync(string role)
    {
        var jobs = new List<JobPosting>
        {
            new()
            {
                Title = ".NET Developer",
                Company = "Microsoft",
                Location = "Remote",
                Description = "C# .NET backend work",
                ApplyLink = "https://example.com"
            }
        };

        return Task.FromResult(jobs);
    }
}

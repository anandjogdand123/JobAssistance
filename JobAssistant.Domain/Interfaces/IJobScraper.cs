using JobAssistant.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace JobAssistant.Domain.Interfaces
{
    public interface IJobScraper
    {
        Task<List<JobPosting>> ScrapeJobListingsAsync(string role);
    }
}

using System;
using System.Collections.Generic;
using System.Text;
using JobAssistant.Domain.Interfaces;

namespace JobAssistant.Application.UseCases
{
    public class ApplyJobsUseCase
    {
        private readonly IJobScraper _scraper;
        private readonly IJobMatcher _matcher;
        private readonly IJobApplier _applier;

        public ApplyJobsUseCase(IJobScraper scraper, IJobMatcher matcher, IJobApplier applier)
        {
            _scraper = scraper;
            _matcher = matcher;
            _applier = applier;
        }

        public async Task ExecuteAsync(string role, string resumeText)
        {
            var jobs = await _scraper.ScrapeJobListingsAsync(role);

            foreach (var job in jobs)
            {
                var score = await _matcher.MatchScoreAsync(job, resumeText);

                if (score >= 70)
                {
                    await _applier.ApplyAsync(job);
                }
            }
        }

    }
}

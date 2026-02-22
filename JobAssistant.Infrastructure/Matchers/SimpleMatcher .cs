using JobAssistant.Domain.Entities;
using JobAssistant.Domain.Interfaces;

namespace JobAssistant.Infrastructure.Matchers;

public class SimpleMatcher : IJobMatcher
{
    public Task<int> MatchScoreAsync(JobPosting job, string resumeText)
    {
        int score = resumeText.Contains(".NET") ? 80 : 40;
        return Task.FromResult(score);
    }
}

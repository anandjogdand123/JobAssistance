using JobAssistant.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace JobAssistant.Domain.Interfaces
{
    public interface IJobMatcher
    {
        Task<int> MatchScoreAsync(JobPosting job,string resumeText);
    }
}

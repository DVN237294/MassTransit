namespace MassTransit.Contracts.JobService
{
    using System;


    public interface SubmitJob<out TJob>
        where TJob : class
    {
        Guid JobId { get; }

        TJob Job { get; }

        /// <summary>
        /// An optional concurrency limitation key. Job types with the same key will not run concurrently 
        /// </summary>
        string ConcurrencyKey { get; }

        /// <summary>
        /// The priority with which this job should be executed.
        /// </summary>
        JobPriority JobPriority { get; }
    }
}

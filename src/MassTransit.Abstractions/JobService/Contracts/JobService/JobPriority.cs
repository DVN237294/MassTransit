namespace MassTransit.Contracts.JobService
{
    public enum JobPriority
    {
        Low = 0,
        BelowNormal = 1,
        Normal = 2,
        AboveNormal = 3,
        High = 4
    }
}

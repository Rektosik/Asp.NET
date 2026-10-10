namespace OrderSystem.Services;

public interface ITimeService
{
    DateTime GetCurrentTime();
}

public class TimeService : ITimeService
{
    public DateTime GetCurrentTime() => DateTime.Now;
}
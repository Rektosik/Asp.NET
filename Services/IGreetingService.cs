namespace OrderSystem.Services;

public interface IGreetingService
{
    string GetGreeting();
}

public class GreetingService : IGreetingService
{
    public string GetGreeting()
    {
        return $"Вітаємо в OrderSystem! Зараз {DateTime.Now:dd.MM.yyyy HH:mm}";
    }
}
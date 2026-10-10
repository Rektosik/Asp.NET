# OrderSystem

Навчальний ASP.NET Core MVC проєкт (лабораторна робота №1).

## Вимоги
- .NET SDK (перевірка: `dotnet --info`)

## Запуск
```bash
git clone <URL_репозиторію>
cd OrderSystem
git checkout lab01
dotnet run
```
Адреса застосунку буде виведена в консолі (наприклад, http://localhost:5202).

## Гілка lab01
Містить виконання лабораторної №1.

## Що зроблено
- Створено MVC-проєкт `OrderSystem`
- Додано middleware-логер (метод, шлях, код відповіді)
- Зареєстровано `ITimeService` через DI (Scoped)
- Додано `HomeController` з `Index` та view з поточним часом і посиланням на `/Products`
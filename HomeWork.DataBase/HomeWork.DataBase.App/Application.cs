using AutoFixture;
using HomeWork.DataBase.DataBase;
using HomeWork.DataBase.DataBase.Entities;

namespace HomeWork.DataBase.App;

public class Application
{
    /// <summary>
    /// Добавление данныех при пустой БД (можно вынести в миграцию)
    /// </summary>
    public static void SeedData()
    {
        using var db = new MyDbContext();

        if (!db.Users.Any())
        {
            var fixture = new Fixture();

            var vocabularys = fixture.CreateMany<Vocabulary>(5).ToList();
            db.AddRange(vocabularys);

            var banks = fixture.Build<Bank>()
                .With(b => b.Type, vocabularys[0])
                .Without(b => b.Id)
                .CreateMany(5)
                .ToList();
            db.Banks.AddRange(banks);

            var users = fixture.Build<User>()
                .With(u => u.Bank, banks[0])
                .Without(u => u.Id)
                .CreateMany(10)
                .ToList();
            db.Users.AddRange(users);

            db.SaveChanges();
        }
    }

    /// <summary>
    /// Получение пользователя по его Id
    /// </summary>
    /// <param name="id"></param>
    public void GetUserById(int id)
    {
        using var db = new MyDbContext();

        var user = db.Users.FirstOrDefault(u => u.Id == id);
        
        Console.WriteLine($"User name: {user.Name}, Bank: {user.Bank.Name}");
    }

    /// <summary>
    /// Добавить нового пользователя
    /// </summary>
    /// <param name="name"></param>
    /// <param name="bankId"></param>
    public void InsertUser(string name, int bankId)
    {
        using var db = new MyDbContext();

        var bank = db.Banks.FirstOrDefault(b => b.Id == bankId);
        var user = new User
        {
            Name = name,
            Bank = bank
        };

        db.Users.Add(user);

        db.SaveChanges();
        
        Console.WriteLine($"Inserted user name: {user.Name}, Bank: {user.Bank.Name}");
    }
}
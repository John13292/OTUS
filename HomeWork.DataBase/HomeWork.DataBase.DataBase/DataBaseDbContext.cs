using HomeWork.DataBase.DataBase.Entities;
using Microsoft.EntityFrameworkCore;

namespace HomeWork.DataBase.DataBase;

public class MyDbContext : DbContext 
{
    readonly string connectionString =
        "Host=host.docker.internal;Port=5432;Database=bank;Username=myuser;Password=mypassword;Application Name=HomeWork.DataBase.App;Command Timeout=600;Timeout=600;";


    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseNpgsql(connectionString);
    }

    public DbSet<User> Users { get; set; }
    public DbSet<Bank> Banks { get; set; }
}
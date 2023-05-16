namespace HomeWork.DataBase.DataBase.Entities;

public class User
{
    public int Id { get; set; }
    
    /// <summary>
    /// Имя пользователя
    /// </summary>
    public string Name { get; set; }
    
    /// <summary>
    /// Идентификатор банка
    /// </summary>
    public int BankId { get; set; }
    public Bank Bank { get; set; }
}
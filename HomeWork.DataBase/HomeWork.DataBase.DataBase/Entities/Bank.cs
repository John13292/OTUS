namespace HomeWork.DataBase.DataBase.Entities;

public class Bank
{
    public int Id { get; set; }
    
    /// <summary>
    /// Название банка
    /// </summary>
    public string Name { get; set; }
    
    /// <summary>
    /// Тип банка
    /// </summary>
    public int TypeId { get; set; }
    
    public Vocabulary Type { get; set; }
}
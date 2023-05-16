namespace HomeWork.DataBase.DataBase.Entities;

public class Vocabulary
{
    public int Id { get; set; }
    
    /// <summary>
    /// Описание
    /// </summary>
    public string Word { get; set; }
    
    /// <summary>
    /// Подробное описание
    /// </summary>
    public string Definition { get; set; }
}
namespace AllLabsApp;

public class Lab1 : ILabs
{
    /// <summary>
    /// Метод демонстрации всех заданий лабораторной работы
    /// </summary>    
    public void Demo()
    {
        // Console.WriteLine("Демо");
        // ход лабы
    }
    /// <summary>
    /// Метод возвращает описание заданий лабораторной работы
    /// </summary>
    /// <returns></returns>
    /// <returns>Описание лабы</returns>
    public string Description()
    {
        return "Задания лабы №1";
    }
    /// <summary>
    /// Метод возвращает номер лабораторной работы
    /// </summary>
    /// <returns>Номер лабы</returns>
    public int Id()
    {
        return 1;
    }
    /// <summary>
    /// Метод возвращает заголовок лабораторной работы
    /// </summary>
    /// <returns></returns>
    public string Title()
    {
        return "Лабораторная №1. Тема: _____";
    }
}

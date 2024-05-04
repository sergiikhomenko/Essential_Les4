namespace task2;
/*
 *Використовуючи Visual Studio, створіть проект за шаблоном Console Application.
 * Потрібно:
 * Створити клас AbstractHandler. У тілі класу створити методи void Open(), void Create(),
 * void Change(), void Save(). Створити похідні класи XMLHandler, TXTHandler, DOCHandler
 * від базового класу AbstractHandler. Написати програму, яка виконуватиме визначення
 * документа і для кожного формату мають бути методи відкриття, створення, редагування,
 * збереження певного формату документа.
 */
public abstract class AbstractHandler
{
    private string _fileName;

    public AbstractHandler(string fileName)
    {
        _fileName = fileName;
        Console.WriteLine(new string('*',30));
        Open();
        Change();
        Create();
        Save();
        Console.WriteLine(new string('-',30));
    }

    public string FileName
    {
        get { return _fileName; }
    }
    public abstract void Open();
    public abstract void Create();
    public abstract void Change();
    public abstract void Save();
}
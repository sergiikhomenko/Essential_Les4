namespace task2;

public class XMLHandler:AbstractHandler
{
    
    public XMLHandler(string nameFile):base(nameFile)
    {
        
    }
    public override void Open()
    {
        Console.WriteLine($"XMLHandler Open {FileName}");
    }

    public override void Change()
    {
        Console.WriteLine($"XMLHandler Change {FileName}");
    }

    public override void Create()
    {
        Console.WriteLine($"XMLHandler Create {FileName}");
    }

    public override void Save()
    {
        Console.WriteLine($"XMLHandler Save {FileName}");
    }
}
namespace task2;

public class TXTHandler:AbstractHandler
{
    
    public TXTHandler(string nameFile):base(nameFile)
    {
        
    }
    public override void Open()
    {
        Console.WriteLine($"TXTHandler Open {FileName}");
    }

    public override void Change()
    {
        Console.WriteLine($"TXTHandler Change {FileName}");
    }

    public override void Create()
    {
        Console.WriteLine($"TXTHandler Create {FileName}");
    }

    public override void Save()
    {
        Console.WriteLine($"TXTHandler Save {FileName}");
    }
}
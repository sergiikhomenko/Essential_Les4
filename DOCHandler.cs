namespace task2;

public class DOCHandler:AbstractHandler
{
  

    public DOCHandler(string nameFile):base(nameFile)
    {
        
    }
    public override void Open()
    {
        Console.WriteLine($"DOCHandler Open {FileName}");
    }

    public override void Change()
    {
        Console.WriteLine($"DOCHandler Change {FileName}");
    }

    public override void Create()
    {
        Console.WriteLine($"DOCHandler Create {FileName}");
    }

    public override void Save()
    {
        Console.WriteLine($"DOCHandler Save {FileName}");
    }
}
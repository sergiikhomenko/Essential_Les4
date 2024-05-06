namespace Classes;

public abstract class DocumentParts
{ 
    string _content;

  public  string Content
    {
        set
        {
            _content = value;
        }
        get
        {
            return _content;
        }
    }
  
  public abstract void Show();
}
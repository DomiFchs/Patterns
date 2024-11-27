namespace Patterns.Composite;

public class File : IFileSystemComponent
{
    private readonly string _name;

    public File(string name)
    {
        _name = name;
    }

    public string GetName()
    {
        return _name;
    }

    public void Display(string indent = "")
    {
        Console.WriteLine($"{indent}- File: {_name}");
    }
}
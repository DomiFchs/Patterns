namespace Patterns.Composite;

public interface IFileSystemComponent {
    string GetName();
    void Display(string indent = "");
}
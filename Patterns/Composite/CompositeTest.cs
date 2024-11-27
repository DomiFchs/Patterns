namespace Patterns.Composite;

public class CompositeTest {

    public void Test() {
        var file1 = new File("File1.txt");
        var file2 = new File("File2.txt");
        var file3 = new File("File3.txt");

        var folder1 = new Folder("Folder1");
        folder1.Add(file1);
        folder1.Add(file2);

        var folder2 = new Folder("Folder2");
        folder2.Add(file3);

        var rootFolder = new Folder("RootFolder");
        rootFolder.Add(folder1);
        rootFolder.Add(folder2);

        rootFolder.Display();
    }
}
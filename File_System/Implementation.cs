// Step1: Identify Entities
/*
Drives-> C:, D:, E:
Directory -> Users, MOvies, Documents
Files -> .txt, .mp4, .pdf

Notice that Directory and Files are both nodes in a tree.
This is perfect use case for the Composite Design Pattern.


*/

// Step2: Common base classes
public abstract class FileSystemItem
{
    public string Name { get; set; }
    public FileSystemItem(string name)
    {
        Name = name;
    }
}

public class FileItem : FileSystemItem
{
    public string Content { get; set; }
    public FileItem(string name, string content) : base(name)
    {
        Content = content;
    }
}

public class DirectoryItem: FileSystemItem
{
    public List<FileSystemItem> Children { get; set; }
    public DirectoryItem(string name) : base(name)
    {
        Children = new List<FileSystemItem>();
    }

    public void Add(FileSystemItem item)
    {
        Children.Add(item);
    }

    public void Remove(FileSystemItem item)
    {
        Children.Remove(item);
    }
}

public class Drive
{
    public string Name { get; set; }
    public DirectoryItem RootDirectory { get; set; }

    public Drive(string name)
    {
        Name = name;
        RootDirectory = new DirectoryItem(name);
    }
}

public class Filesystem
{
    private readonly List<Drive> drives = new();

    public void AddDrive(Drive drive)
    {
        drives.Add(drive);
    }
}

public interface IFileActivities
{
    FileItem Search(string fileName);
    void CreateFile(DirectoryItem directory, string fileName);
    void DeleteFile(FileItem file);
    void CopyFile(FileItem source, DirectoryItem destination);
    void MoveFile(FileItem source, DirectoryItem destination);
}

public class FileActivities : IFileActivities
{
    public FileItem Search(string fileName)
    {
        // Implement search logic here
        return null;
    }

    public void CreateFile(DirectoryItem directory, string fileName)
    {
        var newFile = new FileItem(fileName, string.Empty);
        directory.Add(newFile);
    }

    public void DeleteFile(FileItem file)
    {
        // Implement delete logic here
    }

    public void CopyFile(FileItem source, DirectoryItem destination)
    {
        var copiedFile = new FileItem(source.Name, source.Content);
        destination.Add(copiedFile);
    }

    public void MoveFile(FileItem source, DirectoryItem destination)
    {
        CopyFile(source, destination);
        DeleteFile(source);
    }
}
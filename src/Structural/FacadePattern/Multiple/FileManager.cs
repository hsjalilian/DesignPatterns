namespace FacadePattern.Multiple;
internal class FileManager
{
    public byte[] ReadFile(string path)
    {
        if (!IsFileExist(path))
            throw new Exception("file is not exist!");

        if (!IsFileTypeValid(path))
            throw new Exception("file type is not valid!");

        Console.WriteLine($"Open and read file from input path: {path}");
        return Array.Empty<byte>();
    }

    private bool IsFileExist(string path)
    {
        Console.WriteLine($"Check file is exist: {path}");
        return true;
    }

    private bool IsFileTypeValid(string path)
    {
        Console.WriteLine($"Check file type is valid for load: {path}");
        return true;
    }
}

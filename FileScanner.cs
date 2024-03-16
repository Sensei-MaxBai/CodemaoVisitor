using System.IO;

public class FileScanner
{
    public bool Scan(string path, out string result)
    {
        result = "invalid";
        if (!File.Exists(path))
        {
            return false;
        }
        
        using (var reader = new StreamReader(path))
        {
            result = reader.ReadToEnd();
        }
        return true;
    }
}
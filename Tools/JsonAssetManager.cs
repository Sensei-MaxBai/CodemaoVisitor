using System.Collections.Generic;
using System.IO;

public class JsonAssetManager
{
    private string path
    {
        get
        {
            if (!Directory.Exists("Assets/Json"))
            {
                Directory.CreateDirectory("Assets/Json");
            }
            
            return "Assets/Json";
        }
    }

    private string file
    {
        get
        {
            if (!File.Exists($"{path}/dicts.json"))
            {
                using (FileStream fs = File.Create($"{path}/dicts.json"))
                {
                    fs.Close();
                }
                //File.Create($"{path}/dicts.json");
            }
            
            return $"{path}/dicts.json";
        }
    }
    
    public List<DictionaryCreator> Load()
    {
        using (FileStream fs = File.Open(file, FileMode.Open, FileAccess.Read, FileShare.ReadWrite))
        {
            if (fs.Length == 0)
            {
                return new List<DictionaryCreator>();
            }
            
            using (StreamReader sr = new StreamReader(fs))
            {
                return Newtonsoft.Json.JsonConvert.DeserializeObject<List<DictionaryCreator>>(sr.ReadToEnd());
            }
        }
        //string json = File.ReadAllText(file);
        //return Newtonsoft.Json.JsonConvert.DeserializeObject<List<DictionaryCreator>>(json);
    }
    
    public void Save(List<DictionaryCreator> dicts)
    {
        string json = Newtonsoft.Json.JsonConvert.SerializeObject(dicts);
        File.WriteAllText(file, json);
    }
}
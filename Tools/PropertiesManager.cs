using System.Collections.Generic;
using System.Linq;

public class DictionaryCreator
{
    [Newtonsoft.Json.JsonProperty("Name")]
    public string Name;
    
    [Newtonsoft.Json.JsonProperty("Dict")]
    public Dictionary<string, string> Dict;
    
    public DictionaryCreator(string name, Dictionary<string, string> dict)
    {
        Name = name;
        Dict = new Dictionary<string, string>(dict);
    }
}

public class PropertiesManager
{
    private Dictionary<string, Dictionary<string, string>> dictionaries;
    
    public PropertiesManager(List<DictionaryCreator> dicts)
    {
        dictionaries = new Dictionary<string, Dictionary<string, string>>();
        if (dicts == null)
        {
            return;
        }
        foreach (var dict in dicts)
        {
            if (dictionaries.ContainsKey(dict.Name))
            {
                throw new System.Exception("Duplicate name!");
            }
            dictionaries.Add(dict.Name, new Dictionary<string, string>(dict.Dict));
        }
    }
    
    public List<DictionaryCreator> Output()
    {
        List<DictionaryCreator> dicts = new List<DictionaryCreator>();
        foreach (var dict in dictionaries)
        {
            dicts.Add(new DictionaryCreator(dict.Key, dict.Value));
        }
        
        return dicts;
    }
    
    public string[] GetKeys(string name)
    {
        return dictionaries[name].Keys.ToArray();
    }
    
    public string Get(string name, string key)
    {
        return dictionaries[name][key];
    }
    
    public void Set(string name, string key, string value)
    {
        dictionaries[name][key] = value;
    }
    
    public bool AddDict(DictionaryCreator dictionaryCreator)
    {
        if (dictionaries.ContainsKey(dictionaryCreator.Name))
        {
            return false;
        }
        dictionaries.Add(dictionaryCreator.Name, new Dictionary<string, string>(dictionaryCreator.Dict));
        
        return true;
    }
    
    public bool RemoveDict(string name)
    {
        return dictionaries.Remove(name);
    }
    
    public bool AddKey(string name, string key, string value)
    {
        if (dictionaries[name].ContainsKey(key))
        {
            return false;
        }
        dictionaries[name].Add(key, value);
        
        return true;
    }
    
    public bool RemoveKey(string name, string key)
    {
        return dictionaries[name].Remove(key);
    }
    
    public bool RenameDict(string oldName, string newName)
    {
        if (dictionaries.ContainsKey(newName))
        {
            return false;
        }
        Dictionary<string, string> dict = dictionaries[oldName];
        dictionaries.Remove(oldName);
        dictionaries.Add(newName, dict);
        
        return true;
    }
    
    public bool RenameKey(string name, string oldKey, string newKey)
    {
        if (dictionaries[name].ContainsKey(newKey))
        {
            return false;
        }
        string value = dictionaries[name][oldKey];
        dictionaries[name].Remove(oldKey);
        dictionaries[name].Add(newKey, value);
        
        return true;
    }
    
    public bool ChangeValue(string name, string key, string value)
    {
        if (!dictionaries[name].ContainsKey(key))
        {
            return false;
        }
        dictionaries[name][key] = value;
        
        return true;
    }
}
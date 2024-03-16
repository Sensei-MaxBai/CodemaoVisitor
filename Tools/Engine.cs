using System.Collections.Generic;
using System.Linq;

public class Engine
{
    private static Engine instance;
    
    public static Engine Instance
    {
        get
        {
            if (instance == null)
            {
                instance = new Engine();
            }
            return instance;
        }
    }
    
    private string format;
    private FormatResolvedObject[] savedResolvedObjects;
    
    public string Format => format;
    public FormatResolvedObject[] SavedResolvedObjects => savedResolvedObjects;
    
    public void Save(string format, FormatResolvedObject[] resolvedObjects)
    {
        this.format = format;
        savedResolvedObjects = resolvedObjects.Clone() as FormatResolvedObject[];
    }
    
    private FileScanner scanner;
    private FormatResolver resolver;
    private JsonAssetManager jsonAssetManager;
    private PropertiesManager propertiesManager;
    private FormatTranslator translator;

    public Engine()
    {
        scanner = new FileScanner();
        resolver = new FormatResolver();
        jsonAssetManager = new JsonAssetManager();
        propertiesManager = new PropertiesManager(jsonAssetManager.Load());
        translator = new FormatTranslator();
    }
    
    public bool Scan(string path, out string result)
    {
        return scanner.Scan(path, out result);
    }
    
    public bool Resolve(string content, out string format, out FormatResolvedObject[] resolvedObjects, out FormatResolvedObject[] combined)
    {
        return resolver.Resolve(content, out format, out resolvedObjects, out combined);
    }

    public void Save(List<DictionaryCreator> dicts)
    {
        jsonAssetManager.Save(dicts);
    }
    
    public PropertiesManager GetPropertiesManager() => propertiesManager;

    public string Translate(string format, FormatResolvedObject[] resolvedObjects, IEnumerable<string> configs)
    {
        return translator.Translate(propertiesManager, format, resolvedObjects, configs.ToArray());
    }
}
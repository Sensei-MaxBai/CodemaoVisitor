using System.Collections.Generic;

public class FormatTranslator
{
    public string Translate(PropertiesManager propertiesManager, string format, FormatResolvedObject[] resolvedObjects, string[] configs)
    {
        if (resolvedObjects.Length != configs.Length)
        {
            return "INVALID";
        }
        
        List<string> translatedProperties = new List<string>();
        int idx = 0;
        foreach (var obj in resolvedObjects)
        {
            if (obj.PropertyType == EPropertyType.Dict)
            {
                translatedProperties.Add(propertiesManager.Get(obj.DictName, configs[idx]));
            }
            else
            {
                translatedProperties.Add(configs[idx]);
            }

            idx++;
        }

        return string.Format(format, translatedProperties.ToArray());
    }
}
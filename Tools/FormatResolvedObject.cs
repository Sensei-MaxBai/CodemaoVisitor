public enum EPropertyType
{
    SingleString,
    Dict,
}

public class FormatResolvedObject
{
    public string ResolvedString
    {
        get;
        private set;
    }

    public string DisplayKey
    {
        get;
        private set;
    }
    
    public EPropertyType PropertyType
    {
        get;
        private set;
    }
    
    public string DictName
    {
        get;
        private set;
    }
    
    public FormatResolvedObject(string resolvedString)
    {
        ResolvedString = resolvedString;
        var split = ResolvedString.Split('-');
        if (split.Length == 1)
        {
            DisplayKey = split[0];
            PropertyType = EPropertyType.SingleString;
            DictName = null;
        }
        else if (split.Length == 2)
        {
            DisplayKey = split[1];
            PropertyType = EPropertyType.Dict;
            DictName = split[0];
        }
        else
        {
            throw new System.Exception("Invalid resolved string");
        }
    }

    public override string ToString()
    {
        return ResolvedString;
    }
}
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

public class FormatResolver
{
    public bool Resolve(string content, out string format, out FormatResolvedObject[] resolvedObjects, out FormatResolvedObject[] combined)
    {
        format = content;
        resolvedObjects = null;
        combined = null;
        StringBuilder sbfmt = new StringBuilder();
        StringBuilder sbobj = new StringBuilder();
        Dictionary<string, int> objs = new Dictionary<string, int>();
        List<FormatResolvedObject> lst = new List<FormatResolvedObject>();
        bool beginAppend = false;
        char brace = 'x';
        foreach (char c in content)
        {
            if (c == '{')
            {
                if (brace == 'x')
                {
                    brace = c;
                }
                else
                {
                    return false;
                }
                sbfmt.Append(c);
                beginAppend = true;
            }
            else if (c == '}')
            {
                if (brace == 'x')
                {
                    return false;
                }
                brace = 'x';
                beginAppend = false;
                string objName = sbobj.ToString();
                int idx = objs.ContainsKey(objName) ? objs[objName] : objs.Count;
                if (!objs.ContainsKey(objName))
                {
                    objs.Add(objName, idx);
                }
                lst.Add(new FormatResolvedObject(objName));
                sbfmt.Append(idx + "}");
                sbobj.Clear();
            }
            else
            {
                if (beginAppend)
                {
                    sbobj.Append(c);
                }
                else
                {
                    sbfmt.Append(c);
                }
            }
        }

        if (brace != 'x')
        {
            return false;
        }
        
        format = sbfmt.ToString();
        resolvedObjects = lst.ToArray();
        // 将resolvedObjects重复的项合并
        List<FormatResolvedObject> combinedList = new List<FormatResolvedObject>();
        HashSet<string> set = new HashSet<string>();
        foreach (var obj in resolvedObjects)
        {
            if (!set.Contains(obj.ResolvedString))
            {
                set.Add(obj.ResolvedString);
                combinedList.Add(obj);
            }
        }
        combined = combinedList.ToArray();
        
        return true;
    }
}
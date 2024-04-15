using System.Collections;
using System.Text.RegularExpressions;

class SearchWildcard
{
    public static ArrayList? SearchWithWildcard(string className, string propName, string keyword, bool exactSearch)
    {
        ArrayList results = new();
        if (keyword.Contains('?') || keyword.Contains('*'))
        {
            string pattern = keyword.Replace("?", "[a-z]").Replace("*", "[a-z]*");
            //string pattern = "^" + Regex.Escape(keyword).Replace("\\?", ".").Replace("\\*", ".*") + "$";

            dynamic? allRecords = Search.QueryAll(className);
            if (allRecords != null)
            {
                foreach (var record in allRecords)
                {
                    string strValue = SearchUtil.GetPropertiesFromClass(className)[propName].GetValue(record);
                    if (Regex.IsMatch(strValue, pattern, RegexOptions.IgnoreCase))
                    {
                        results.Add(record);
                    }
                }
                return results;
            }
            else
            {
                return null;
            }
        }
        else
        {
            return Search.SearchString(className, propName, keyword, exactSearch);
        }
    }
}
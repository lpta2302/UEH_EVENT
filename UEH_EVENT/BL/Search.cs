using System.Collections;

class Search
{
    public static object? QueryAll(string className)
    {
        object[] parameters = className.EndsWith("His") ? new object[] { true } : new object[] { false };
        return SearchUtil.StaticCallGenericVarType(nameof(Database), className, nameof(Database.Query), new Type[] { typeof(bool) }, parameters);
    }
    public static object? SearchString(string className, string propName, string keyword)
    {
        Type[] paramTypes = { typeof(Filterer), typeof(bool), typeof(bool) };
        object[] parameters = { new Filterer(propName, keyword, Filterer.FilterType.Equal), false, false };
        return SearchUtil.StaticCallGenericVarType(nameof(Database), className, nameof(Database.Query), paramTypes, parameters);
    }
    public static object? SearchInt(string className, string propName, char filterStr, int threshold)
    {
        Dictionary<char, Func<Filterer>> filterCases = new()
        {
            { '>', () => new Filterer(propName, threshold, Filterer.FilterType.GreaterThan) },
            { '=', () => new Filterer(propName, threshold, Filterer.FilterType.Equal) },
            { '<', () => new Filterer(propName, threshold, Filterer.FilterType.LessThan) }
        };
        Type[] paramTypes = { typeof(Filterer), typeof(bool), typeof(bool) };
        object[] parameters = { filterCases[filterStr].Invoke(), false, false };
        return SearchUtil.StaticCallGenericVarType(nameof(Database), className, nameof(Database.Query), paramTypes, parameters);
    }
    public static object? SearchInt(string className, string propName, string equalFilterStr, int threshold)
    {
        dynamic results = SearchInt(className, propName, '=', threshold)!;
        if (equalFilterStr == ">=")
        {
            dynamic greaterResults = SearchInt(className, propName, '>', threshold)!;
            results.AddRange(greaterResults);
        }
        if (equalFilterStr == "<=")
        {
            dynamic lesserResults = SearchInt(className, propName, '<', threshold)!;
            results.AddRange(lesserResults);
        }
        return results;
    }
    public static object? SearchInt(string className, string propName, int lowerBound, int upperBound)
    {
        dynamic fromLower = SearchInt(className, propName, ">=", lowerBound)!;
        dynamic toUpper = SearchInt(className, propName, "<=", upperBound)!;
        ArrayList results = new();
        for (int i = 0; i < fromLower.Count; i++)
        {
            for (int j = 0; j < toUpper.Count; j++)
            {
                if (SearchUtil.Equals(fromLower[i], toUpper[j])
                    && SearchUtil.GetHashCode(fromLower[i]) == SearchUtil.GetHashCode(toUpper[j]))
                {
                    results.Add(fromLower[i]);
                    break;
                }
            }
        }
        return results;
    }
}
using System.Reflection;

class SearchUtil
{
    public static new bool Equals(object? a, object? b)
    {
        if (a == null || b == null || a.GetType() != b.GetType())
        {
            return false;
        }
        foreach (var prop in GetPropertiesFromClass(a.GetType().Name))
        {
            if (prop.Value.GetType() == typeof(int) || prop.Value.GetType() == typeof(string))
            {
                if (prop.Value.GetValue(a) != prop.Value.GetValue(b))
                {
                    return false;
                }
            }
        }
        return GetHashCode(a) == GetHashCode(b);
    }
    public static int GetHashCode(object? x)
    {
        long lint = Convert.ToInt64(x?.GetType().GetProperties()[0].GetValue(x));
        int hash = (int)(lint % Convert.ToInt64(int.MaxValue));
        return x != null ? hash : 0;
    }
    public static T2? GetValueFromKey<T1, T2>(Dictionary<T1, T2> dict, T1 key)
        where T1 : notnull 
        where T2 : notnull
    {
        foreach (var pair in dict)
        {
            if (pair.Key.Equals(key))
            {
                return pair.Value;
            }
        }
        return default;
    }
    public static T1? GetKeyFromValue<T1, T2>(Dictionary<T1, T2> dict, T2 value) 
        where T1 : notnull
        where T2 : notnull
    {
        foreach (var pair in dict)
        {
            if (pair.Value.Equals(value))
            {
                return pair.Key;
            }
        }
        return default;
    }
    public static string[] GetDisplayClassNames()
    {
        List<string> display = new();
        foreach (var c in Constants.CLASS_NAMES)
        {
            display.Add(c.Value);
        }
        return display.ToArray();
    }
    public static string? GetClassNameFromDisplay(string displayName)
    {
        if (displayName != null)
        {
            return GetKeyFromValue(Constants.CLASS_NAMES, displayName);
        }
        else
        {
            return default;
        }
    }
    public static string[] GetPropertyNamesFromClass(string className)
    {
        List<string> properties = new() { "(select)" };
        Type? t = className != null ? Type.GetType(className) : null;
        if (t != null)
        {
            foreach (var prop in t.GetProperties())
            {
                properties.Add(prop.Name);
            }
        }
        return properties.ToArray();
    }
    public static Dictionary<string, PropertyInfo> GetPropertiesFromClass(string className)
    {
        Dictionary<string, PropertyInfo> properties = new();
        Type? t = className != null ? Type.GetType(className) : null;
        if (t != null)
        {
            foreach (var prop in t.GetProperties())
            {
                properties.Add(prop.Name, prop);
            }
        }
        return properties;
    }
    public static Type? GetTypeOfProperty(string className, string propName)
    {
        Dictionary<string, PropertyInfo> properties = GetPropertiesFromClass(className);
        PropertyInfo? prop = GetValueFromKey(properties, propName);
        return prop != null ? prop.PropertyType : default;
    }
    public static object? StaticCallGenericVarType(string exeClassName, string typeName, string methodName, Type[]? paramTypes, object[]? parameters)
    {
        Type? exeType = Type.GetType(exeClassName);
        Type? varType = Type.GetType(typeName);
        MethodInfo? method = (exeType != null && varType != null)
            ? (paramTypes != null 
                ? exeType.GetMethod(methodName, paramTypes)?.MakeGenericMethod(varType) 
                : exeType.GetMethod(methodName)?.MakeGenericMethod(varType))
            : default;
        return method?.Invoke(null, parameters);
    }
}
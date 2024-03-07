﻿using System;
using System.Reflection;

class Util
{
    public static T? GetProp<T>(object obj, string propertyName)
    {
        Type type = obj.GetType();
        PropertyInfo? propertyInfo = type.GetProperty(propertyName + (propertyName.EndsWith('s') ? "es" : "s"));

        if (propertyInfo != null)
        {
            object? value = propertyInfo.GetValue(obj);


            if (value != null)
            {
                return value is T typedValue ? typedValue : default;
            }
        }

        return default;
    }
}
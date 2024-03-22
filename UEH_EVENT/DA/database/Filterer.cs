using System.Collections;

public class Filterer
{
    private class FilterCondition
    {
        public string prop;
        public object value;
        public FilterType filterType;

        public FilterCondition(string prop, object value, FilterType filterType)
        {
            this.prop = prop;
            this.value = value;
            this.filterType = filterType;
        }
    }
    private List<FilterCondition> filterConditions = new List<FilterCondition>();
    public enum FilterType { Equal, GreaterThan, LessThan }
    public Filterer(string prop, object value, FilterType filterType)
    {
        filterConditions.Add(new FilterCondition(prop, value, filterType));
    }
    public Filterer(string[] props, object[] values, FilterType[] filterTypes)
    {
        for (int i = 0; i < props.Length; i++)
        {
            filterConditions.Add(new FilterCondition(props[i], values[i], filterTypes[i]));
        }
    }
    public void Add(string prop, object value, FilterType filterType)
    {
        filterConditions.Add(new FilterCondition(prop, value, filterType));
    }
    public void Add(string[] props, object[] values, FilterType[] filterTypes)
    {
        for (int i = 0; i < props.Length; i++)
        {
            filterConditions.Add(new FilterCondition(props[i], values[i], filterTypes[i]));
        }
    }
    public string GetProp(int index)
    {
        return filterConditions[index].prop;
    }
    public object GetValue(int index)
    {
        return filterConditions[index].value;
    }
    public FilterType GetFilterType(int index)
    {
        return filterConditions[index].filterType;
    }
    public int Count()
    {
        return filterConditions.Count;
    }
}
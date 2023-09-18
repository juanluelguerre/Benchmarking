using System.Collections;

public static class DictionaryExtensions
{
    public static bool CompareDictionaries<TKey, TValue>(this Dictionary<TKey, TValue> dict1,
        Dictionary<TKey, TValue> dict2) where TKey : notnull
    {
        if (dict1.Keys.SequenceEqual(dict2.Keys) == false)
        {
            return false;
        }

        foreach (var key in dict1.Keys)
        {
            var value1 = dict1[key];
            var value2 = dict2[key];

            if (value1 is IDictionary && value2 is IDictionary)
            {
                bool nestedDictionariesAreEqual = CompareDictionaries((dynamic)value1, value2);
                if (!nestedDictionariesAreEqual)
                {
                    return false;
                }
            }
            else if (value1 != null && !value1.Equals(value2))
            {
                return false;
            }
        }

        return true;
    }
}

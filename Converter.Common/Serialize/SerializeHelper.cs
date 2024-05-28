using Newtonsoft.Json;

namespace Converter.Common.Serialize;

public static class SerializeHelper
{
    /// <summary>
    /// Convert Object to String.
    /// </summary>
    /// <param name="obj"></param>
    /// <returns></returns>
    public static string SerializeToString<T>(this T obj)
    {
        return JsonConvert.SerializeObject(obj);
    }
    
    /// <summary>
    /// Convert Object to String.
    /// </summary>
    /// <param name="value"></param>
    /// <returns></returns>
    public static T? SerializeToObject<T>(this string value)
    {
        return JsonConvert.DeserializeObject<T>(value);
    }
}
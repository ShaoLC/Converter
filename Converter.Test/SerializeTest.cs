using Converter.Common.Serialize;

namespace Converter.Test;

public static class SerializeTest
{
    public static void Test()
    {
        var model = new SerializeTestObject
        {
            Id = 1,
            Name = "Name1"
        };
        var str = model.SerializeToString();
        var model1 = str.SerializeToObject<SerializeTestObject>();
    }
}

public class SerializeTestObject
{
    /// <summary>
    /// 
    /// </summary>
    public int Id { get; set; }

    /// <summary>
    /// 
    /// </summary>
    public string? Name { get; set; }
}
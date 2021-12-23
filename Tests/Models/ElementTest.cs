using WebApi.src.Models;
using Xunit;

public class ElementTest
{
    [Fact]
    public void OverrideType_PassTest()
    {
        var element1 = new Element { Type = "種別1", Volume = 0 };
        element1.OverrideType();
        Assert.True(element1.Type == "");

        var element2 = new Element { Type = "種別2", Volume = 100 };
        element2.OverrideType();
        Assert.True(element2.Type == "種別2");
    }
}

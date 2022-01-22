using BenchmarkDotNet.Attributes;
using MemoryDiagnoserTest.Enums;

[MemoryDiagnoser]
public class EnumProgram
{
    [Benchmark]
    public string EnumInterpolation()
    {
        return $"{TestEnum.One}";
    }

    [Benchmark]
    public string EnumToString()
    {
        return TestEnum.One.ToString();
    }

    [Benchmark]
    public string EnumNameOf()
    {
        return NameOfEnum(TestEnum.One);
    }

    private string NameOfEnum(TestEnum val)
    {
        return val switch
        {
            TestEnum.One => nameof(TestEnum.One),
            TestEnum.Two => nameof(TestEnum.Two),
            TestEnum.Three => nameof(TestEnum.Three),
            TestEnum.Four => nameof(TestEnum.Four),
            _ => ""
        };
    }
}
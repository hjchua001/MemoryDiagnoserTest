using BenchmarkDotNet.Attributes;
using Newtonsoft.Json;

[MemoryDiagnoser]
public class ExceptionStringProgram
{
    [Benchmark]
    public string ExToString()
    {
        try 
        { 
            throw new Exception();
        }
        catch (Exception ex)
        {
            return ex.ToString();
        }
    }

    [Benchmark]
    public string ExInterpolation()
    {
        try
        {
            throw new Exception();
        }
        catch (Exception ex)
        {
            return $"{ex}";
        }
    }

    [Benchmark]
    public string ExSerialize()
    {
        try
        {
            throw new Exception();
        }
        catch (Exception ex)
        {
            return $"{JsonConvert.SerializeObject(ex)}";
        }
    }
}
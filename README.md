# Result of BenchmarkDotNet

Test One: Enum

|            Method |       Mean |     Error |    StdDev |  Gen 0 | Allocated |
| ----------------- | ----------:| ---------:| ---------:| ------:| ---------:|
| EnumInterpolation | 74.8883 ns | 1.5657 ns | 1.9228 ns | 0.0134 |      56 B |
| EnumToString      | 24.2424 ns | 0.5169 ns | 0.7577 ns | 0.0057 |      24 B |
| EnumNameOf        | 0.0435 ns  | 0.0487 ns | 0.0380 ns |      - |         - |

Test Two: Exception
|          Method |     Mean |    Error |   StdDev |  Gen 0 | Allocated |
|---------------- |---------:|---------:|---------:|-------:|----------:|
|      ExToString | 22.42 us | 0.424 us | 0.435 us | 0.6714 |      3 KB |
| ExInterpolation | 24.15 us | 0.480 us | 1.102 us | 0.7935 |      3 KB |
|     ExSerialize | 32.34 us | 0.391 us | 0.346 us | 1.8921 |      8 KB |

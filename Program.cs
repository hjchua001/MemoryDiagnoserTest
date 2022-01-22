using BenchmarkDotNet.Running;

/// <summary>
/// Enum ToString / nameof() / Interpolation
/// 
/// |            Method |       Mean |     Error |    StdDev |  Gen 0 | Allocated |
/// | ----------------- | ----------:| ---------:| ---------:| ------:| ---------:|
/// | EnumInterpolation | 74.8883 ns | 1.5657 ns | 1.9228 ns | 0.0134 |      56 B |
/// | EnumToString      | 24.2424 ns | 0.5169 ns | 0.7577 ns | 0.0057 |      24 B |
/// | EnumNameOf        | 0.0435 ns  | 0.0487 ns | 0.0380 ns |      - |         - |
/// 
/// </summary>
BenchmarkRunner.Run<EnumProgram>();

/// <summary>
/// Exception ToString / Interpolation / Serialized
/// 
/// |          Method |     Mean |    Error |   StdDev |  Gen 0 | Allocated |
/// | --------------- | --------:| --------:| --------:| ------:| ---------:|
/// | ExToString      | 21.52 us | 0.357 us | 0.298 us | 0.6714 |      3 KB |
/// | ExInterpolation | 22.20 us | 0.415 us | 0.388 us | 0.7935 |      3 KB |
/// | ExSerialize     | 33.01 us | 0.620 us | 0.738 us | 1.8921 |      8 KB |
/// 
/// </summary>
BenchmarkRunner.Run<ExceptionStringProgram>();


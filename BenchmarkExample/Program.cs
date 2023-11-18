using BenchmarkDotNet.Running;
using BenchmarkExample;

var summary = BenchmarkRunner.Run<BenchmarkTest>();
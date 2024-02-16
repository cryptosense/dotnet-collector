# .NET Data Collection for CLR Profilers

This repository contains examples of [data collectors][data-collector] and test suites
that show how to attach a [CLR profiler][clr-profiling] to the .NET runtime (Core or
Framework) during a test session.

## How It Works

Test suites can be configured to use a data collector. The data collectors in this
repository set [CLR environment variables][clr-profiling-config] so that a profiler is
attached to the runtime. The profiler can then instrument the tests and generate a
execution trace.

## Instructions

### .NET Core

- Get a profiler DLL (`cs_dotnet_tracer.dll`).
- Build the `CoreSample` solution with `dotnet build` or Visual Studio.
- Adjust the paths in `CoreSample.Tests/collect.runsettings`.
- Remove the `[Ignore]` directive from the `TestEnv` case. This will ensure that the data
  collector was found and initialized by the test runner. Processor Architecture).
- Run the tests with `dotnet test --settings collect.runsettings` in `CoreSample.Tests`.
- Check that `trace.cst` and `cs_dotnet_tracer.log` have been created in the output
  directory (specified by `<OutputDir>` in `collect.runsettings`.

### .NET Framework

- Get a profiler DLL (`cs_dotnet_tracer.dll`).
- Build the Visual Studio solution `FrameworkSample`.
- Adjust the paths in `FrameworkSample.Tests/collect.runsettings`.
- Configure Visual Studio to use the settings (`Test` → `Test Settings` →
  `Select Test Settings File`).
- Remove the `[Ignore]` directive from the `TestEnv` case. This will ensure that the data
  collector was found and initialized by the test runner.
- Run the tests.
- Check that `trace.cst` and `cs_dotnet_tracer.log` have been created in the output
  directory (specified by `<OutputDir>` in `collect.runsettings`.

[clr-profiling-config]:
  https://github.com/microsoft/CLRInstrumentationEngine/blob/e4da6360219e5bb15a618e4b2c538e2315d3566d/docs/environment_variables.md
[clr-profiling]:
  https://docs.microsoft.com/en-us/dotnet/framework/unmanaged-api/profiling/profiling-overview
[data-collector]:
  https://github.com/microsoft/vstest/blob/main/docs/extensions/datacollector.md

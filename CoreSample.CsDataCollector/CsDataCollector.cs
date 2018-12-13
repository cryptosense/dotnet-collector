using System;
using System.Collections.Generic;
using System.IO;
using System.Xml;
using Microsoft.VisualStudio.TestPlatform.ObjectModel.DataCollection;

[DataCollectorFriendlyName("CsDataCollector")]
[DataCollectorTypeUri("my://sample/datacollector")]
public class CsDataCollector : DataCollector, ITestExecutionEnvironmentSpecifier
{
    private string tracerPath;
    private string outputDir;

    public override void Initialize(
        System.Xml.XmlElement configurationElement,
        DataCollectionEvents events,
        DataCollectionSink dataSink,
        DataCollectionLogger logger,
        DataCollectionEnvironmentContext environmentContext)
    {
        tracerPath = configurationElement["TracerPath"].InnerText;
        outputDir = configurationElement["OutputDir"].InnerText;
    }

    public IEnumerable<KeyValuePair<string, string>> GetTestExecutionEnvironmentVariables()
    {
        return new List<KeyValuePair<string, string>> {
            new KeyValuePair<string, string>("CORECLR_ENABLE_PROFILING", "1"),
            new KeyValuePair<string, string>("CORECLR_PROFILER", "{cf0d821e-299b-5307-a3d8-9ccb4916d2e5}"),
            new KeyValuePair<string, string>("CORECLR_PROFILER_PATH", tracerPath),
            new KeyValuePair<string, string>("CS_OUTPUT_DIR", outputDir),
        };
    }
}

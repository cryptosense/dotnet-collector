using System;
using System.Collections.Generic;
using System.IO;

using Microsoft.VisualStudio.TestPlatform.ObjectModel.DataCollection;

[DataCollectorFriendlyName("CsDataCollector")]
[DataCollectorTypeUri("my://sample/datacollector")]
public class CsDataCollector : DataCollector, ITestExecutionEnvironmentSpecifier
{
    public override void Initialize(
        System.Xml.XmlElement configurationElement,
        DataCollectionEvents events,
        DataCollectionSink dataSink,
        DataCollectionLogger logger,
        DataCollectionEnvironmentContext environmentContext)
    {
    }

    public IEnumerable<KeyValuePair<string, string>> GetTestExecutionEnvironmentVariables()
    {
        return new List<KeyValuePair<string, string>> { new KeyValuePair<string, string>("key", "value") };
    }
}

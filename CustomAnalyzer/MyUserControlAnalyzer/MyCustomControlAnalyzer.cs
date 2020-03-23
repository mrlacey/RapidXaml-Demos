using RapidXaml;

namespace ExampleDemoAnalyzer
{
    public class MyCustomControlAnalyzer : ICustomAnalyzer
    {
        public string TargetType() => "MyCustomControl";

        public AnalysisActions Analyze(RapidXamlElement element)
        {
            if (element.ContainsAttribute("Name"))
            {
                return AnalysisActions.None;
            }
            else
            {
                return AnalysisActions.AddAttribute(
                    errorType: RapidXamlErrorType.Warning,
                    code: "RXD001",
                    description: "Always set the 'Name' property on 'MyCustomControl'.",
                    actionText: "Add 'Name' attribute",
                    addAttributeName: "Name",
                    addAttributeValue: "MyDemoControl",
                    moreInfoUrl: "https://github.com/mrlacey/RapidXaml-Demos/blob/master/rxd001.md"
                    );
            }
        }
    }
}

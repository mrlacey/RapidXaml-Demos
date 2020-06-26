using RapidXaml;

namespace ExampleDemoAnalyzer
{
    public class MyControlAnalyzer : ICustomAnalyzer
    {
        public string TargetType() => "MyControl";

        public AnalysisActions Analyze(RapidXamlElement element, ExtraAnalysisDetails extraDetails)
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
                    description: "Always set the 'Name' property on 'MyControl'.",
                    actionText: "Add 'Name' attribute",
                    addAttributeName: "Name",
                    addAttributeValue: "MyAwesomeControl",
                    moreInfoUrl: "https://github.com/mrlacey/RapidXaml-Demos/blob/master/rxd001.md"
                    );
            }
        }
    }
}

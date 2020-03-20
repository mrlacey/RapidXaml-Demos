using System;
using RapidXaml;

namespace ExampleDemoAnalyzer
{
    public class MyUserControlAnalyzer : ICustomAnalyzer
    {
        public string TargetType() => "MyUserControl";

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
                    description: "Always set the 'Name' property on 'MyUserControl'.",
                    actionText: "Add 'Name' attribute",
                    addAttributeName: "Name",
                    addAttributeValue: "MyControl",
                    moreInfoUrl: "https://github.com/mrlacey/RapidXaml-Demos/blob/master/rxd001.md"
                    );
            }
        }
    }
}

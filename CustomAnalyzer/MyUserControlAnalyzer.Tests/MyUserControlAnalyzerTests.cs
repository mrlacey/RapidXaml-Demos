using Microsoft.VisualStudio.TestTools.UnitTesting;
using RapidXaml;
using RapidXaml.TestHelpers;

namespace ExampleDemoAnalyzer.Tests
{
    [TestClass]
    public class MyUserControlAnalyzerTests
    {
        [TestMethod]
        public void DoesReportWhenShould()
        {
            var analyzer = new MyUserControlAnalyzer();

            var testElement = CustomAnalysisTestHelper.StringToElement("<MyUserControl />");

            var analysisResult = analyzer.Analyze(testElement, new ExtraAnalysisDetails());

            Assert.AreEqual(1, analysisResult.Actions.Count);
            Assert.AreEqual(ActionType.AddAttribute, analysisResult.Actions[0].Action);
            Assert.AreEqual("Name", analysisResult.Actions[0].Name);
        }

        [TestMethod]
        public void DoesNotReportWhenShouldNot()
        {
            var analyzer = new MyUserControlAnalyzer();

            var testElement = CustomAnalysisTestHelper.StringToElement("<MyUserControl Name=\"something\" />");

            var analysisResult = analyzer.Analyze(testElement, new ExtraAnalysisDetails());

            Assert.IsTrue(analysisResult.IsNone);
        }
    }
}

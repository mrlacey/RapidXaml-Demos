using Microsoft.VisualStudio.TestTools.UnitTesting;
using RapidXaml;

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

            var analysisResult = analyzer.Analyze(testElement);

            Assert.AreEqual(1, analysisResult.Actions.Count);
            Assert.AreEqual(ActionType.AddAttribute, analysisResult.Actions[0].Action);
            Assert.AreEqual("Name", analysisResult.Actions[0].Name);
        }

        [TestMethod]
        public void DoesNotReportWhenShouldNot()
        {
            var analyzer = new MyUserControlAnalyzer();

            var testElement = CustomAnalysisTestHelper.StringToElement("<MyUserControl Name=\"something\" />");

            var analysisResult = analyzer.Analyze(testElement);

            Assert.IsTrue(analysisResult.IsNone);
        }
    }
}

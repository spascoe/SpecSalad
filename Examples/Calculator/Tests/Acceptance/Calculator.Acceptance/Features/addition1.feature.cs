// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by SpecFlow (http://www.specflow.org/).
//      SpecFlow Version:1.5.0.0
//      Runtime Version:4.0.30319.225
// 
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------
#region Designer generated code
namespace Calculator.Acceptance.Features
{
    using TechTalk.SpecFlow;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "1.5.0.0")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [NUnit.Framework.TestFixtureAttribute()]
    [NUnit.Framework.DescriptionAttribute("Addition")]
    public partial class AdditionFeature
    {
        
        private static TechTalk.SpecFlow.ITestRunner testRunner;
        
#line 1 "addition.feature"
#line hidden
        
        [NUnit.Framework.TestFixtureSetUpAttribute()]
        public virtual void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "Addition", "As callie. a calculating individual\nI want to quickly find out the sum of some nu" +
                    "mbers\nSo that I am not tired out by doing mental arithmetic all day", GenerationTargetLanguage.CSharp, ((string[])(null)));
            testRunner.OnFeatureStart(featureInfo);
        }
        
        [NUnit.Framework.TestFixtureTearDownAttribute()]
        public virtual void FeatureTearDown()
        {
            testRunner.OnFeatureEnd();
            testRunner = null;
        }
        
        public virtual void ScenarioSetup(TechTalk.SpecFlow.ScenarioInfo scenarioInfo)
        {
            testRunner.OnScenarioStart(scenarioInfo);
        }
        
        [NUnit.Framework.TearDownAttribute()]
        public virtual void ScenarioTearDown()
        {
            testRunner.OnScenarioEnd();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Find the sum of two numbers")]
        [NUnit.Framework.TestCaseAttribute("0", "0", "0")]
        [NUnit.Framework.TestCaseAttribute("0", "1", "1")]
        [NUnit.Framework.TestCaseAttribute("1", "0", "1")]
        [NUnit.Framework.TestCaseAttribute("1", "1", "2")]
        [NUnit.Framework.TestCaseAttribute("10", "9", "19")]
        public virtual void FindTheSumOfTwoNumbers(string first_Number, string second_Number, string result)
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Find the sum of two numbers", ((string[])(null)));
#line 6
this.ScenarioSetup(scenarioInfo);
#line 7
 testRunner.Given("I am a Calculating Individual");
#line 8
 testRunner.And("I was able to switch on the calculator");
#line 9
 testRunner.When(string.Format("I attempt to add: the number \'{0}\' to the number \'{1}\'", first_Number, second_Number));
#line 10
 testRunner.Then(string.Format("I should see the answer \'{0}\'", result));
#line hidden
            testRunner.CollectScenarioErrors();
        }
    }
}
#endregion
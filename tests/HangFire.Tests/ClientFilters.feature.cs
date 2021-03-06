﻿// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by SpecFlow (http://www.specflow.org/).
//      SpecFlow Version:1.9.0.77
//      SpecFlow Generator Version:1.9.0.0
//      Runtime Version:4.0.30319.18444
// 
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------
#region Designer generated code
#pragma warning disable
namespace HangFire.Tests
{
    using TechTalk.SpecFlow;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "1.9.0.77")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    public partial class ClientFiltersFeature : Xunit.IUseFixture<ClientFiltersFeature.FixtureData>, System.IDisposable
    {
        
        private static TechTalk.SpecFlow.ITestRunner testRunner;
        
#line 1 "ClientFilters.feature"
#line hidden
        
        public ClientFiltersFeature()
        {
            this.TestInitialize();
        }
        
        public static void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "Client filters", "\r\n  As a user, I expect that all defined client filters are executing\r\n  using th" +
                    "e following rules, when I create a job.", ProgrammingLanguage.CSharp, new string[] {
                        "redis"});
            testRunner.OnFeatureStart(featureInfo);
        }
        
        public static void FeatureTearDown()
        {
            testRunner.OnFeatureEnd();
            testRunner = null;
        }
        
        public virtual void TestInitialize()
        {
        }
        
        public virtual void ScenarioTearDown()
        {
            testRunner.OnScenarioEnd();
        }
        
        public virtual void ScenarioSetup(TechTalk.SpecFlow.ScenarioInfo scenarioInfo)
        {
            testRunner.OnScenarioStart(scenarioInfo);
        }
        
        public virtual void ScenarioCleanup()
        {
            testRunner.CollectScenarioErrors();
        }
        
        public virtual void FeatureBackground()
        {
#line 7
#line 8
    testRunner.Given("a client", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
        }
        
        public virtual void SetFixture(ClientFiltersFeature.FixtureData fixtureData)
        {
        }
        
        void System.IDisposable.Dispose()
        {
            this.ScenarioTearDown();
        }
        
        [Xunit.FactAttribute()]
        [Xunit.TraitAttribute("FeatureTitle", "Client filters")]
        [Xunit.TraitAttribute("Description", "Client filters should be executed when I create a job")]
        public virtual void ClientFiltersShouldBeExecutedWhenICreateAJob()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Client filters should be executed when I create a job", ((string[])(null)));
#line 10
this.ScenarioSetup(scenarioInfo);
#line 7
this.FeatureBackground();
#line 11
    testRunner.Given("the client filter \'test\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 12
     testRunner.When("I create a job", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
            TechTalk.SpecFlow.Table table1 = new TechTalk.SpecFlow.Table(new string[] {
                        "Method"});
            table1.AddRow(new string[] {
                        "test::OnCreating"});
            table1.AddRow(new string[] {
                        "test::OnCreated"});
#line 13
     testRunner.Then("the client filter methods should be executed in the following order:", ((string)(null)), table1, "Then ");
#line 17
      testRunner.And("the storage should contain the job", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Xunit.FactAttribute()]
        [Xunit.TraitAttribute("FeatureTitle", "Client filters")]
        [Xunit.TraitAttribute("Description", "Multiple client filters should be executed depending on their order")]
        public virtual void MultipleClientFiltersShouldBeExecutedDependingOnTheirOrder()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Multiple client filters should be executed depending on their order", ((string[])(null)));
#line 19
this.ScenarioSetup(scenarioInfo);
#line 7
this.FeatureBackground();
#line 20
    testRunner.Given("the client filter \'first\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 21
      testRunner.And("the client filter \'second\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 22
     testRunner.When("I create a job", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
            TechTalk.SpecFlow.Table table2 = new TechTalk.SpecFlow.Table(new string[] {
                        "Method"});
            table2.AddRow(new string[] {
                        "first::OnCreating"});
            table2.AddRow(new string[] {
                        "second::OnCreating"});
            table2.AddRow(new string[] {
                        "second::OnCreated"});
            table2.AddRow(new string[] {
                        "first::OnCreated"});
#line 23
     testRunner.Then("the client filter methods should be executed in the following order:", ((string)(null)), table2, "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Xunit.FactAttribute()]
        [Xunit.TraitAttribute("FeatureTitle", "Client filters")]
        [Xunit.TraitAttribute("Description", "I should be able to set a job parameter in the client filter")]
        public virtual void IShouldBeAbleToSetAJobParameterInTheClientFilter()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("I should be able to set a job parameter in the client filter", ((string[])(null)));
#line 30
this.ScenarioSetup(scenarioInfo);
#line 7
this.FeatureBackground();
#line hidden
            TechTalk.SpecFlow.Table table3 = new TechTalk.SpecFlow.Table(new string[] {
                        "Name",
                        "Value"});
            table3.AddRow(new string[] {
                        "Culture",
                        "en-US"});
            table3.AddRow(new string[] {
                        "UICulture",
                        "ru-RU"});
#line 31
    testRunner.Given("the client filter \'first\' that sets the following parameters in the OnCreating me" +
                    "thod:", ((string)(null)), table3, "Given ");
#line 35
     testRunner.When("I create a job", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 36
     testRunner.Then("it should have all of the above parameters encoded as JSON string", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Xunit.FactAttribute()]
        [Xunit.TraitAttribute("FeatureTitle", "Client filters")]
        [Xunit.TraitAttribute("Description", "When I specify an empty or null parameter name, an exception should be thrown")]
        public virtual void WhenISpecifyAnEmptyOrNullParameterNameAnExceptionShouldBeThrown()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("When I specify an empty or null parameter name, an exception should be thrown", ((string[])(null)));
#line 38
this.ScenarioSetup(scenarioInfo);
#line 7
this.FeatureBackground();
#line hidden
            TechTalk.SpecFlow.Table table4 = new TechTalk.SpecFlow.Table(new string[] {
                        "Name",
                        "Value"});
            table4.AddRow(new string[] {
                        "",
                        "en-US"});
#line 39
    testRunner.Given("the client filter \'first\' that sets the following parameters in the OnCreating me" +
                    "thod:", ((string)(null)), table4, "Given ");
#line 42
     testRunner.When("I create a job", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 43
     testRunner.Then("the CreateJobFailedException should be thrown by the client", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Xunit.FactAttribute()]
        [Xunit.TraitAttribute("FeatureTitle", "Client filters")]
        [Xunit.TraitAttribute("Description", "Client filter should be able to read the parameters that were set by one of the p" +
            "revious filters")]
        public virtual void ClientFilterShouldBeAbleToReadTheParametersThatWereSetByOneOfThePreviousFilters()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Client filter should be able to read the parameters that were set by one of the p" +
                    "revious filters", ((string[])(null)));
#line 45
this.ScenarioSetup(scenarioInfo);
#line 7
this.FeatureBackground();
#line hidden
            TechTalk.SpecFlow.Table table5 = new TechTalk.SpecFlow.Table(new string[] {
                        "Name",
                        "Value"});
            table5.AddRow(new string[] {
                        "Culture",
                        "en-GB"});
#line 46
    testRunner.Given("the client filter \'first\' that sets the following parameters in the OnCreating me" +
                    "thod:", ((string)(null)), table5, "Given ");
#line 49
      testRunner.And("the client filter \'second\' that reads all of the above parameters", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 50
     testRunner.When("I create a job", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 51
     testRunner.Then("the \'second\' client filter got the actual values of the parameters", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Xunit.FactAttribute()]
        [Xunit.TraitAttribute("FeatureTitle", "Client filters")]
        [Xunit.TraitAttribute("Description", "When I specify an empty or null parameter name in the GetParameter method call, a" +
            "n exception should be thrown")]
        public virtual void WhenISpecifyAnEmptyOrNullParameterNameInTheGetParameterMethodCallAnExceptionShouldBeThrown()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("When I specify an empty or null parameter name in the GetParameter method call, a" +
                    "n exception should be thrown", ((string[])(null)));
#line 53
this.ScenarioSetup(scenarioInfo);
#line 7
this.FeatureBackground();
#line hidden
            TechTalk.SpecFlow.Table table6 = new TechTalk.SpecFlow.Table(new string[] {
                        "Name",
                        "Value"});
            table6.AddRow(new string[] {
                        "",
                        "en-GB"});
#line 54
    testRunner.Given("the client filter \'first\' that gets the following parameters in the OnCreating me" +
                    "thod:", ((string)(null)), table6, "Given ");
#line 57
     testRunner.When("I create a job", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 58
     testRunner.Then("the CreateJobFailedException should be thrown by the client", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Xunit.FactAttribute()]
        [Xunit.TraitAttribute("FeatureTitle", "Client filters")]
        [Xunit.TraitAttribute("Description", "I should not be able to set parameters after the job was created")]
        public virtual void IShouldNotBeAbleToSetParametersAfterTheJobWasCreated()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("I should not be able to set parameters after the job was created", ((string[])(null)));
#line 60
this.ScenarioSetup(scenarioInfo);
#line 7
this.FeatureBackground();
#line hidden
            TechTalk.SpecFlow.Table table7 = new TechTalk.SpecFlow.Table(new string[] {
                        "Name",
                        "Value"});
            table7.AddRow(new string[] {
                        "Culture",
                        "en-US"});
#line 61
    testRunner.Given("the client filter \'first\' that sets the following parameters in the OnCreated met" +
                    "hod:", ((string)(null)), table7, "Given ");
#line 64
     testRunner.When("I create a job", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 65
     testRunner.Then("the CreateJobFailedException should be thrown by the client", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Xunit.FactAttribute()]
        [Xunit.TraitAttribute("FeatureTitle", "Client filters")]
        [Xunit.TraitAttribute("Description", "When client filter cancels the creation of the job, it should not be created")]
        public virtual void WhenClientFilterCancelsTheCreationOfTheJobItShouldNotBeCreated()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("When client filter cancels the creation of the job, it should not be created", ((string[])(null)));
#line 67
this.ScenarioSetup(scenarioInfo);
#line 7
this.FeatureBackground();
#line 68
    testRunner.Given("the client filter \'first\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 69
      testRunner.And("the client filter \'second\' that cancels the job", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 70
      testRunner.And("the client filter \'third\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 71
     testRunner.When("I create a job", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 72
     testRunner.Then("the storage should not contain the job", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            TechTalk.SpecFlow.Table table8 = new TechTalk.SpecFlow.Table(new string[] {
                        "Method"});
            table8.AddRow(new string[] {
                        "first::OnCreating"});
            table8.AddRow(new string[] {
                        "second::OnCreating"});
            table8.AddRow(new string[] {
                        "first::OnCreated (with the canceled flag set)"});
#line 73
      testRunner.And("only the following client filter methods should be executed:", ((string)(null)), table8, "And ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Xunit.FactAttribute()]
        [Xunit.TraitAttribute("FeatureTitle", "Client filters")]
        [Xunit.TraitAttribute("Description", "Client filter\'s OnCreated could be skipped if there was an exception")]
        public virtual void ClientFilterSOnCreatedCouldBeSkippedIfThereWasAnException()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Client filter\'s OnCreated could be skipped if there was an exception", ((string[])(null)));
#line 79
this.ScenarioSetup(scenarioInfo);
#line 7
this.FeatureBackground();
#line 80
    testRunner.Given("the client filter \'first\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 81
      testRunner.And("the client filter \'second\' that throws an exception", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 82
     testRunner.When("I create a job", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
            TechTalk.SpecFlow.Table table9 = new TechTalk.SpecFlow.Table(new string[] {
                        "Method"});
            table9.AddRow(new string[] {
                        "first::OnCreating"});
            table9.AddRow(new string[] {
                        "second::OnCreating"});
            table9.AddRow(new string[] {
                        "first::OnCreated"});
#line 83
     testRunner.Then("only the following client filter methods should be executed:", ((string)(null)), table9, "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Xunit.FactAttribute()]
        [Xunit.TraitAttribute("FeatureTitle", "Client filters")]
        [Xunit.TraitAttribute("Description", "When a client filter handles an exception, it should not be thrown outside")]
        public virtual void WhenAClientFilterHandlesAnExceptionItShouldNotBeThrownOutside()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("When a client filter handles an exception, it should not be thrown outside", ((string[])(null)));
#line 89
this.ScenarioSetup(scenarioInfo);
#line 7
this.FeatureBackground();
#line 90
    testRunner.Given("the client filter \'first\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 91
      testRunner.And("the client filter \'second\' that handles an exception", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 92
      testRunner.And("the client filter \'third\' that throws an exception", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 93
     testRunner.When("I create a job", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
            TechTalk.SpecFlow.Table table10 = new TechTalk.SpecFlow.Table(new string[] {
                        "Method"});
            table10.AddRow(new string[] {
                        "first::OnCreating"});
            table10.AddRow(new string[] {
                        "second::OnCreating"});
            table10.AddRow(new string[] {
                        "third::OnCreating"});
            table10.AddRow(new string[] {
                        "second::OnCreated"});
            table10.AddRow(new string[] {
                        "first::OnCreated"});
#line 94
     testRunner.Then("the client filter methods should be executed in the following order:", ((string)(null)), table10, "Then ");
#line 101
      testRunner.And("an exception should not be thrown by the client", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Xunit.FactAttribute()]
        [Xunit.TraitAttribute("FeatureTitle", "Client filters")]
        [Xunit.TraitAttribute("Description", "Client exception filters should be executed when there was an exception while cre" +
            "ating a job")]
        public virtual void ClientExceptionFiltersShouldBeExecutedWhenThereWasAnExceptionWhileCreatingAJob()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Client exception filters should be executed when there was an exception while cre" +
                    "ating a job", ((string[])(null)));
#line 103
this.ScenarioSetup(scenarioInfo);
#line 7
this.FeatureBackground();
#line 104
    testRunner.Given("the exception filter \'test\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 105
      testRunner.And("there is a buggy filter (for example)", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 106
     testRunner.When("I create a job", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 107
     testRunner.Then("the client exception filter should be executed", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 108
      testRunner.And("the CreateJobFailedException should be thrown by the client", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Xunit.FactAttribute()]
        [Xunit.TraitAttribute("FeatureTitle", "Client filters")]
        [Xunit.TraitAttribute("Description", "Multiple exception filters should be executed in the reversed order")]
        public virtual void MultipleExceptionFiltersShouldBeExecutedInTheReversedOrder()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Multiple exception filters should be executed in the reversed order", ((string[])(null)));
#line 110
this.ScenarioSetup(scenarioInfo);
#line 7
this.FeatureBackground();
#line 111
    testRunner.Given("the exception filter \'first\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 112
      testRunner.And("the exception filter \'second\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 113
      testRunner.And("there is a buggy filter (for example)", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 114
     testRunner.When("I create a job", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
            TechTalk.SpecFlow.Table table11 = new TechTalk.SpecFlow.Table(new string[] {
                        "Filter"});
            table11.AddRow(new string[] {
                        "second"});
            table11.AddRow(new string[] {
                        "first"});
#line 115
     testRunner.Then("the client exception filters should be executed in the following order:", ((string)(null)), table11, "Then ");
#line 119
      testRunner.And("the CreateJobFailedException should be thrown by the client", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Xunit.FactAttribute()]
        [Xunit.TraitAttribute("FeatureTitle", "Client filters")]
        [Xunit.TraitAttribute("Description", "When a client exception filter handles an exception, it should not be thrown outs" +
            "ide")]
        public virtual void WhenAClientExceptionFilterHandlesAnExceptionItShouldNotBeThrownOutside()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("When a client exception filter handles an exception, it should not be thrown outs" +
                    "ide", ((string[])(null)));
#line 121
this.ScenarioSetup(scenarioInfo);
#line 7
this.FeatureBackground();
#line 122
    testRunner.Given("the exception filter \'first\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 123
      testRunner.And("the exception filter \'second\' that handles an exception", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 124
      testRunner.And("the exception filter \'third\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 125
      testRunner.And("there is a buggy filter (for example)", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 126
     testRunner.When("I create a job", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
            TechTalk.SpecFlow.Table table12 = new TechTalk.SpecFlow.Table(new string[] {
                        "Filter"});
            table12.AddRow(new string[] {
                        "third"});
            table12.AddRow(new string[] {
                        "second"});
            table12.AddRow(new string[] {
                        "first"});
#line 127
     testRunner.Then("the following client exception filters should be executed:", ((string)(null)), table12, "Then ");
#line 132
      testRunner.And("an exception should not be thrown by the client", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "1.9.0.77")]
        [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
        public class FixtureData : System.IDisposable
        {
            
            public FixtureData()
            {
                ClientFiltersFeature.FeatureSetup();
            }
            
            void System.IDisposable.Dispose()
            {
                ClientFiltersFeature.FeatureTearDown();
            }
        }
    }
}
#pragma warning restore
#endregion

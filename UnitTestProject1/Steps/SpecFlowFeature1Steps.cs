using System;
using TechTalk.SpecFlow;

namespace UnitTestProject1.Steps
{
    [Binding]
    public class SpecFlowFeature1Steps
    {
        [Given(@"I login to web application")]
        public void GivenILoginToWebApplication()
        {
            Console.WriteLine("I login web application");
        }

        [Given(@"I enter username and password")]
        public void GivenIEnterUsernameAndPassword()
        {
            Console.WriteLine("I enter username and password");
        }

        [Given(@"I login to mobile application")]
        public void GivenILoginToMobileApplication()
        {
            Console.WriteLine("I login mobile application");
        }
    }
}

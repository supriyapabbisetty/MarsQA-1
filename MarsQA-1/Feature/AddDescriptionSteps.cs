using System;
using TechTalk.SpecFlow;

namespace MarsQA_1.Feature
{
    [Binding]
    public class AddDescriptionSteps
    {
        [Given(@"seller able to add Description to my profile")]
        public void GivenSellerAbleToAddDescriptionToMyProfile()
        {
            MarsQA_1.SpecflowPages.Pages.AddProfileDescription.AddDescription();
        }
        
        [Given(@"seller not able to save the Description successfully")]
        public void GivenSellerNotAbleToSaveTheDescriptionSuccessfully()
        {
            MarsQA_1.SpecflowPages.Pages.AddProfileDescription.AddDescriptionnotsuccessfull();
        }
    }
}

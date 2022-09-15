﻿///////////////////////////////////////////////////////////////////////////////
//
// This file was automatically generated by RANOREX.
// DO NOT MODIFY THIS FILE! It is regenerated by the designer.
// All your modifications will be lost!
// http://www.ranorex.com
//
///////////////////////////////////////////////////////////////////////////////

using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
using System.Drawing;
using System.Threading;
using WinForms = System.Windows.Forms;

using Ranorex;
using Ranorex.Core;
using Ranorex.Core.Testing;
using Ranorex.Core.Repository;

namespace TestWeb.REC
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    ///The AddAccountSuccess recording.
    /// </summary>
    [TestModule("9f0c22f7-789b-4ecf-88bc-3e7eaca0d363", ModuleType.Recording, 1)]
    public partial class AddAccountSuccess : ITestModule
    {
        /// <summary>
        /// Holds an instance of the global::TestWeb.TestWebRepository repository.
        /// </summary>
        public static global::TestWeb.TestWebRepository repo = global::TestWeb.TestWebRepository.Instance;

        static AddAccountSuccess instance = new AddAccountSuccess();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public AddAccountSuccess()
        {
            gender = "Mr.";
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static AddAccountSuccess Instance
        {
            get { return instance; }
        }

#region Variables

        string _gender;

        /// <summary>
        /// Gets or sets the value of variable gender.
        /// </summary>
        [TestVariable("e18f6c3e-593d-4b19-9b93-dcea887f0615")]
        public string gender
        {
            get { return _gender; }
            set { _gender = value; }
        }

#endregion

        /// <summary>
        /// Starts the replay of the static recording <see cref="Instance"/>.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCode("Ranorex", global::Ranorex.Core.Constants.CodeGenVersion)]
        public static void Start()
        {
            TestModuleRunner.Run(Instance);
        }

        /// <summary>
        /// Performs the playback of actions in this recording.
        /// </summary>
        /// <remarks>You should not call this method directly, instead pass the module
        /// instance to the <see cref="TestModuleRunner.Run(ITestModule)"/> method
        /// that will in turn invoke this method.</remarks>
        [System.CodeDom.Compiler.GeneratedCode("Ranorex", global::Ranorex.Core.Constants.CodeGenVersion)]
        void ITestModule.Run()
        {
            Mouse.DefaultMoveTime = 300;
            Keyboard.DefaultKeyPressTime = 20;
            Delay.SpeedFactor = 1.00;

            Init();

            // Create Account
            Report.Log(ReportLevel.Info, "Section", "Create Account", new RecordItemIndex(0));
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.HomePage.BtnSignIn' at Center.", repo.ApplicationUnderTest.HomePage.BtnSignInInfo, new RecordItemIndex(1));
            repo.ApplicationUnderTest.HomePage.BtnSignIn.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.AuthenticationPage.InputEmailAddressLeft' at Center.", repo.ApplicationUnderTest.AuthenticationPage.InputEmailAddressLeftInfo, new RecordItemIndex(2));
            repo.ApplicationUnderTest.AuthenticationPage.InputEmailAddressLeft.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence 'thanh+34543566676448@gmail.com' with focus on 'ApplicationUnderTest.AuthenticationPage.InputEmailAddressLeft'.", repo.ApplicationUnderTest.AuthenticationPage.InputEmailAddressLeftInfo, new RecordItemIndex(3));
            repo.ApplicationUnderTest.AuthenticationPage.InputEmailAddressLeft.PressKeys("thanh+34543566676448@gmail.com");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.AuthenticationPage.BtnCreateAccount' at Center.", repo.ApplicationUnderTest.AuthenticationPage.BtnCreateAccountInfo, new RecordItemIndex(4));
            repo.ApplicationUnderTest.AuthenticationPage.BtnCreateAccount.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Wait", "Waiting 10s to exist. Associated repository item: 'ApplicationUnderTest.AuthenticationPage.PersonalInfo.RadioTitle'", repo.ApplicationUnderTest.AuthenticationPage.PersonalInfo.RadioTitleInfo, new ActionTimeout(10000), new RecordItemIndex(5));
            repo.ApplicationUnderTest.AuthenticationPage.PersonalInfo.RadioTitleInfo.WaitForExists(10000);
            
            // Personal Info
            Report.Log(ReportLevel.Info, "Section", "Personal Info", new RecordItemIndex(6));
            
            SelectGender(gender);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence 'Thanh' with focus on 'ApplicationUnderTest.AuthenticationPage.PersonalInfo.InputFirstName'.", repo.ApplicationUnderTest.AuthenticationPage.PersonalInfo.InputFirstNameInfo, new RecordItemIndex(8));
            repo.ApplicationUnderTest.AuthenticationPage.PersonalInfo.InputFirstName.PressKeys("Thanh");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.AuthenticationPage.PersonalInfo.InputLastName' at Center.", repo.ApplicationUnderTest.AuthenticationPage.PersonalInfo.InputLastNameInfo, new RecordItemIndex(9));
            repo.ApplicationUnderTest.AuthenticationPage.PersonalInfo.InputLastName.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence 'Dang' with focus on 'ApplicationUnderTest.AuthenticationPage.PersonalInfo.InputLastName'.", repo.ApplicationUnderTest.AuthenticationPage.PersonalInfo.InputLastNameInfo, new RecordItemIndex(10));
            repo.ApplicationUnderTest.AuthenticationPage.PersonalInfo.InputLastName.PressKeys("Dang");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.AuthenticationPage.PersonalInfo.InputPassword' at Center.", repo.ApplicationUnderTest.AuthenticationPage.PersonalInfo.InputPasswordInfo, new RecordItemIndex(11));
            repo.ApplicationUnderTest.AuthenticationPage.PersonalInfo.InputPassword.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '123456' with focus on 'ApplicationUnderTest.AuthenticationPage.PersonalInfo.InputPassword'.", repo.ApplicationUnderTest.AuthenticationPage.PersonalInfo.InputPasswordInfo, new RecordItemIndex(12));
            repo.ApplicationUnderTest.AuthenticationPage.PersonalInfo.InputPassword.PressKeys("123456");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.AuthenticationPage.PersonalInfo.SelectDay' at 69;16.", repo.ApplicationUnderTest.AuthenticationPage.PersonalInfo.SelectDayInfo, new RecordItemIndex(13));
            repo.ApplicationUnderTest.AuthenticationPage.PersonalInfo.SelectDay.Click("69;16");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'LoginMyStoreGoogleChrome' at 433;819.", repo.LoginMyStoreGoogleChrome.SelfInfo, new RecordItemIndex(14));
            repo.LoginMyStoreGoogleChrome.Self.Click("433;819");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.AuthenticationPage.PersonalInfo.SelectMonth' at 70;11.", repo.ApplicationUnderTest.AuthenticationPage.PersonalInfo.SelectMonthInfo, new RecordItemIndex(15));
            repo.ApplicationUnderTest.AuthenticationPage.PersonalInfo.SelectMonth.Click("70;11");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'LoginMyStoreGoogleChrome' at 541;755.", repo.LoginMyStoreGoogleChrome.SelfInfo, new RecordItemIndex(16));
            repo.LoginMyStoreGoogleChrome.Self.Click("541;755");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.AuthenticationPage.PersonalInfo.SelectYear' at 65;13.", repo.ApplicationUnderTest.AuthenticationPage.PersonalInfo.SelectYearInfo, new RecordItemIndex(17));
            repo.ApplicationUnderTest.AuthenticationPage.PersonalInfo.SelectYear.Click("65;13");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'LoginMyStoreGoogleChrome' at 606;693.", repo.LoginMyStoreGoogleChrome.SelfInfo, new RecordItemIndex(18));
            repo.LoginMyStoreGoogleChrome.Self.Click("606;693");
            Delay.Milliseconds(0);
            
            // Your Address
            Report.Log(ReportLevel.Info, "Section", "Your Address", new RecordItemIndex(19));
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.AuthenticationPage.PersonalInfo.InputCompany' at 62;10.", repo.ApplicationUnderTest.AuthenticationPage.PersonalInfo.InputCompanyInfo, new RecordItemIndex(20));
            repo.ApplicationUnderTest.AuthenticationPage.PersonalInfo.InputCompany.Click("62;10");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence 'LTS' with focus on 'ApplicationUnderTest.AuthenticationPage.PersonalInfo.InputCompany'.", repo.ApplicationUnderTest.AuthenticationPage.PersonalInfo.InputCompanyInfo, new RecordItemIndex(21));
            repo.ApplicationUnderTest.AuthenticationPage.PersonalInfo.InputCompany.PressKeys("LTS");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.AuthenticationPage.PersonalInfo.InputAddress1' at 78;5.", repo.ApplicationUnderTest.AuthenticationPage.PersonalInfo.InputAddress1Info, new RecordItemIndex(22));
            repo.ApplicationUnderTest.AuthenticationPage.PersonalInfo.InputAddress1.Click("78;5");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence 'Address' with focus on 'ApplicationUnderTest.AuthenticationPage.PersonalInfo.InputAddress1'.", repo.ApplicationUnderTest.AuthenticationPage.PersonalInfo.InputAddress1Info, new RecordItemIndex(23));
            repo.ApplicationUnderTest.AuthenticationPage.PersonalInfo.InputAddress1.PressKeys("Address");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence ' 1' with focus on 'ApplicationUnderTest.AuthenticationPage.PersonalInfo.InputAddress1'.", repo.ApplicationUnderTest.AuthenticationPage.PersonalInfo.InputAddress1Info, new RecordItemIndex(24));
            repo.ApplicationUnderTest.AuthenticationPage.PersonalInfo.InputAddress1.PressKeys(" 1");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.AuthenticationPage.PersonalInfo.InputCity' at 45;10.", repo.ApplicationUnderTest.AuthenticationPage.PersonalInfo.InputCityInfo, new RecordItemIndex(25));
            repo.ApplicationUnderTest.AuthenticationPage.PersonalInfo.InputCity.Click("45;10");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence 'Ha Noi' with focus on 'ApplicationUnderTest.AuthenticationPage.PersonalInfo.InputCity'.", repo.ApplicationUnderTest.AuthenticationPage.PersonalInfo.InputCityInfo, new RecordItemIndex(26));
            repo.ApplicationUnderTest.AuthenticationPage.PersonalInfo.InputCity.PressKeys("Ha Noi");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.AuthenticationPage.PersonalInfo.SelectState' at 256;13.", repo.ApplicationUnderTest.AuthenticationPage.PersonalInfo.SelectStateInfo, new RecordItemIndex(27));
            repo.ApplicationUnderTest.AuthenticationPage.PersonalInfo.SelectState.Click("256;13");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'LoginMyStoreGoogleChrome' at 486;638.", repo.LoginMyStoreGoogleChrome.SelfInfo, new RecordItemIndex(28));
            repo.LoginMyStoreGoogleChrome.Self.Click("486;638");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.AuthenticationPage.PersonalInfo.InputZipCode' at 114;8.", repo.ApplicationUnderTest.AuthenticationPage.PersonalInfo.InputZipCodeInfo, new RecordItemIndex(29));
            repo.ApplicationUnderTest.AuthenticationPage.PersonalInfo.InputZipCode.Click("114;8");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '20022' with focus on 'ApplicationUnderTest.AuthenticationPage.PersonalInfo.InputZipCode'.", repo.ApplicationUnderTest.AuthenticationPage.PersonalInfo.InputZipCodeInfo, new RecordItemIndex(30));
            repo.ApplicationUnderTest.AuthenticationPage.PersonalInfo.InputZipCode.PressKeys("20022");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.AuthenticationPage.PersonalInfo.TextAreaAddInfo' at 102;8.", repo.ApplicationUnderTest.AuthenticationPage.PersonalInfo.TextAreaAddInfoInfo, new RecordItemIndex(31));
            repo.ApplicationUnderTest.AuthenticationPage.PersonalInfo.TextAreaAddInfo.Click("102;8");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Down item 'ApplicationUnderTest.AuthenticationPage.PersonalInfo.TextAreaAddInfo' at 106;14.", repo.ApplicationUnderTest.AuthenticationPage.PersonalInfo.TextAreaAddInfoInfo, new RecordItemIndex(32));
            repo.ApplicationUnderTest.AuthenticationPage.PersonalInfo.TextAreaAddInfo.MoveTo("106;14");
            Mouse.ButtonDown(System.Windows.Forms.MouseButtons.Left);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Up item 'ApplicationUnderTest.AuthenticationPage.PersonalInfo.TextAreaAddInfo' at -65;11.", repo.ApplicationUnderTest.AuthenticationPage.PersonalInfo.TextAreaAddInfoInfo, new RecordItemIndex(33));
            repo.ApplicationUnderTest.AuthenticationPage.PersonalInfo.TextAreaAddInfo.MoveTo("-65;11");
            Mouse.ButtonUp(System.Windows.Forms.MouseButtons.Left);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence 'nOne' with focus on 'LoginMyStoreGoogleChrome'.", repo.LoginMyStoreGoogleChrome.SelfInfo, new RecordItemIndex(34));
            repo.LoginMyStoreGoogleChrome.Self.PressKeys("nOne");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.AuthenticationPage.PersonalInfo.InputMobilePhone' at 79;2.", repo.ApplicationUnderTest.AuthenticationPage.PersonalInfo.InputMobilePhoneInfo, new RecordItemIndex(35));
            repo.ApplicationUnderTest.AuthenticationPage.PersonalInfo.InputMobilePhone.Click("79;2");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '096473399' with focus on 'ApplicationUnderTest.AuthenticationPage.PersonalInfo.InputMobilePhone'.", repo.ApplicationUnderTest.AuthenticationPage.PersonalInfo.InputMobilePhoneInfo, new RecordItemIndex(36));
            repo.ApplicationUnderTest.AuthenticationPage.PersonalInfo.InputMobilePhone.PressKeys("096473399");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.AuthenticationPage.PersonalInfo.InputAddressAlias' at 55;5.", repo.ApplicationUnderTest.AuthenticationPage.PersonalInfo.InputAddressAliasInfo, new RecordItemIndex(37));
            repo.ApplicationUnderTest.AuthenticationPage.PersonalInfo.InputAddressAlias.Click("55;5");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence 'Test' with focus on 'ApplicationUnderTest.AuthenticationPage.PersonalInfo.InputAddressAlias'.", repo.ApplicationUnderTest.AuthenticationPage.PersonalInfo.InputAddressAliasInfo, new RecordItemIndex(38));
            repo.ApplicationUnderTest.AuthenticationPage.PersonalInfo.InputAddressAlias.PressKeys("Test");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.AuthenticationPage.PersonalInfo.BtnRegister' at Center.", repo.ApplicationUnderTest.AuthenticationPage.PersonalInfo.BtnRegisterInfo, new RecordItemIndex(39));
            repo.ApplicationUnderTest.AuthenticationPage.PersonalInfo.BtnRegister.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (InnerText='Welcome to your account. Here you can manage all of your personal information and orders.') on item 'ApplicationUnderTest.ContactUsPage.ValidateWelcomeToYourAccountHereYouCanMa'.", repo.ApplicationUnderTest.ContactUsPage.ValidateWelcomeToYourAccountHereYouCanMaInfo, new RecordItemIndex(40));
            Validate.AttributeEqual(repo.ApplicationUnderTest.ContactUsPage.ValidateWelcomeToYourAccountHereYouCanMaInfo, "InnerText", "Welcome to your account. Here you can manage all of your personal information and orders.");
            Delay.Milliseconds(100);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}

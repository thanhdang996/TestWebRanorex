///////////////////////////////////////////////////////////////////////////////
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
    ///The ContactUs recording.
    /// </summary>
    [TestModule("d1078154-c425-4b16-bf55-38d66e45ea64", ModuleType.Recording, 1)]
    public partial class ContactUs : ITestModule
    {
        /// <summary>
        /// Holds an instance of the global::TestWeb.TestWebRepository repository.
        /// </summary>
        public static global::TestWeb.TestWebRepository repo = global::TestWeb.TestWebRepository.Instance;

        static ContactUs instance = new ContactUs();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public ContactUs()
        {
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static ContactUs Instance
        {
            get { return instance; }
        }

#region Variables

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

            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.ContactUsPage.ContactUs' at 45;19.", repo.ApplicationUnderTest.ContactUsPage.ContactUsInfo, new RecordItemIndex(0));
            repo.ApplicationUnderTest.ContactUsPage.ContactUs.Click("45;19");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.ContactUsPage.ShowOptionSpan' at 222;13.", repo.ApplicationUnderTest.ContactUsPage.ShowOptionSpanInfo, new RecordItemIndex(1));
            repo.ApplicationUnderTest.ContactUsPage.ShowOptionSpan.Click("222;13");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ContactUsMyStoreGoogleChrome' at 489;685.", repo.ContactUsMyStoreGoogleChrome.SelfInfo, new RecordItemIndex(2));
            repo.ContactUsMyStoreGoogleChrome.Self.Click("489;685");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.ContactUsPage.FileUpload' at 241;8.", repo.ApplicationUnderTest.ContactUsPage.FileUploadInfo, new RecordItemIndex(3));
            repo.ApplicationUnderTest.ContactUsPage.FileUpload.Click("241;8");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'Open.BaselineImage' at 69;66.", repo.Open.BaselineImageInfo, new RecordItemIndex(4));
            repo.Open.BaselineImage.Click("69;66");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'Open.ButtonOpen' at 26;5.", repo.Open.ButtonOpenInfo, new RecordItemIndex(5));
            repo.Open.ButtonOpen.Click("26;5");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.ContactUsPage.Message' at 59;42.", repo.ApplicationUnderTest.ContactUsPage.MessageInfo, new RecordItemIndex(6));
            repo.ApplicationUnderTest.ContactUsPage.Message.Click("59;42");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence 'GG' with focus on 'ApplicationUnderTest.ContactUsPage.Message'.", repo.ApplicationUnderTest.ContactUsPage.MessageInfo, new RecordItemIndex(7));
            repo.ApplicationUnderTest.ContactUsPage.Message.PressKeys("GG");
            Delay.Milliseconds(0);
            
            // Send And Validate
            Report.Log(ReportLevel.Info, "Section", "Send And Validate", new RecordItemIndex(8));
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.ContactUsPage.Send' at 57;22.", repo.ApplicationUnderTest.ContactUsPage.SendInfo, new RecordItemIndex(9));
            repo.ApplicationUnderTest.ContactUsPage.Send.Click("57;22");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (InnerText='Your message has been successfully sent to our team.') on item 'ApplicationUnderTest.ContactUsPage.YourMessageHasBeenSuccessfullySent'.", repo.ApplicationUnderTest.ContactUsPage.YourMessageHasBeenSuccessfullySentInfo, new RecordItemIndex(10));
            Validate.AttributeEqual(repo.ApplicationUnderTest.ContactUsPage.YourMessageHasBeenSuccessfullySentInfo, "InnerText", "Your message has been successfully sent to our team.");
            Delay.Milliseconds(100);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}

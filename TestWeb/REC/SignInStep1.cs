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
    ///The SignInStep1 recording.
    /// </summary>
    [TestModule("7e086411-389e-40d3-8334-5819e5c3b212", ModuleType.Recording, 1)]
    public partial class SignInStep1 : ITestModule
    {
        /// <summary>
        /// Holds an instance of the global::TestWeb.TestWebRepository repository.
        /// </summary>
        public static global::TestWeb.TestWebRepository repo = global::TestWeb.TestWebRepository.Instance;

        static SignInStep1 instance = new SignInStep1();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public SignInStep1()
        {
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static SignInStep1 Instance
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

            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.HomePage.BtnSignIn' at 28;19.", repo.ApplicationUnderTest.HomePage.BtnSignInInfo, new RecordItemIndex(0));
            repo.ApplicationUnderTest.HomePage.BtnSignIn.Click("28;19");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.AuthenticationPage.InputEmailAddressLeft' at 150;10.", repo.ApplicationUnderTest.AuthenticationPage.InputEmailAddressLeftInfo, new RecordItemIndex(1));
            repo.ApplicationUnderTest.AuthenticationPage.InputEmailAddressLeft.Click("150;10");
            Delay.Milliseconds(0);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}

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
    ///The SearchOne recording.
    /// </summary>
    [TestModule("e853f1fe-cab0-4808-85d0-55e7cb10a61f", ModuleType.Recording, 1)]
    public partial class SearchOne : ITestModule
    {
        /// <summary>
        /// Holds an instance of the global::TestWeb.TestWebRepository repository.
        /// </summary>
        public static global::TestWeb.TestWebRepository repo = global::TestWeb.TestWebRepository.Instance;

        static SearchOne instance = new SearchOne();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public SearchOne()
        {
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static SearchOne Instance
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

            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.HomePage.Search.SearchQueryTop' at 54;27.", repo.ApplicationUnderTest.HomePage.Search.SearchQueryTopInfo, new RecordItemIndex(0));
            repo.ApplicationUnderTest.HomePage.Search.SearchQueryTop.Click("54;27");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence 'Dress' with focus on 'ApplicationUnderTest.HomePage.Search.SearchQueryTop'.", repo.ApplicationUnderTest.HomePage.Search.SearchQueryTopInfo, new RecordItemIndex(1));
            repo.ApplicationUnderTest.HomePage.Search.SearchQueryTop.PressKeys("Dress");
            Delay.Milliseconds(0);
            
            CheckIsContainValueSearch(repo.ApplicationUnderTest.HomePage.Search.ResultSearchInfo, "Dress");
            Delay.Milliseconds(0);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
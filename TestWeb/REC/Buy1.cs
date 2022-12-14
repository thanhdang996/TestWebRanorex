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
    ///The Buy1 recording.
    /// </summary>
    [TestModule("b6fecd3d-f083-42ea-94d9-5d6cf28b8f69", ModuleType.Recording, 1)]
    public partial class Buy1 : ITestModule
    {
        /// <summary>
        /// Holds an instance of the global::TestWeb.TestWebRepository repository.
        /// </summary>
        public static global::TestWeb.TestWebRepository repo = global::TestWeb.TestWebRepository.Instance;

        static Buy1 instance = new Buy1();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public Buy1()
        {
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static Buy1 Instance
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

            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Move item 'ApplicationUnderTest.ShoppingCardSumary.ItemSelect.Item1' at Center.", repo.ApplicationUnderTest.ShoppingCardSumary.ItemSelect.Item1Info, new RecordItemIndex(0));
            repo.ApplicationUnderTest.ShoppingCardSumary.ItemSelect.Item1.MoveTo();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.ShoppingCardSumary.Homefeatured.AddToCart' at 76;21.", repo.ApplicationUnderTest.ShoppingCardSumary.Homefeatured.AddToCartInfo, new RecordItemIndex(1));
            repo.ApplicationUnderTest.ShoppingCardSumary.Homefeatured.AddToCart.Click("76;21");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.ShoppingCardSumary.ContinueShopping' at 107;19.", repo.ApplicationUnderTest.ShoppingCardSumary.ContinueShoppingInfo, new RecordItemIndex(2));
            repo.ApplicationUnderTest.ShoppingCardSumary.ContinueShopping.Click("107;19");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Move item 'ApplicationUnderTest.ShoppingCardSumary.ItemSelect.Item2' at Center.", repo.ApplicationUnderTest.ShoppingCardSumary.ItemSelect.Item2Info, new RecordItemIndex(3));
            repo.ApplicationUnderTest.ShoppingCardSumary.ItemSelect.Item2.MoveTo();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.ShoppingCardSumary.Homefeatured.AddToCart1' at 74;25.", repo.ApplicationUnderTest.ShoppingCardSumary.Homefeatured.AddToCart1Info, new RecordItemIndex(4));
            repo.ApplicationUnderTest.ShoppingCardSumary.Homefeatured.AddToCart1.Click("74;25");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.ShoppingCardSumary.ContinueShopping' at 56;26.", repo.ApplicationUnderTest.ShoppingCardSumary.ContinueShoppingInfo, new RecordItemIndex(5));
            repo.ApplicationUnderTest.ShoppingCardSumary.ContinueShopping.Click("56;26");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Move item 'ApplicationUnderTest.ShoppingCardSumary.ItemSelect.Item3' at Center.", repo.ApplicationUnderTest.ShoppingCardSumary.ItemSelect.Item3Info, new RecordItemIndex(6));
            repo.ApplicationUnderTest.ShoppingCardSumary.ItemSelect.Item3.MoveTo();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.ShoppingCardSumary.Homefeatured.AddToCart2' at 50;22.", repo.ApplicationUnderTest.ShoppingCardSumary.Homefeatured.AddToCart2Info, new RecordItemIndex(7));
            repo.ApplicationUnderTest.ShoppingCardSumary.Homefeatured.AddToCart2.Click("50;22");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.ShoppingCardSumary.ContinueShopping' at 101;28.", repo.ApplicationUnderTest.ShoppingCardSumary.ContinueShoppingInfo, new RecordItemIndex(8));
            repo.ApplicationUnderTest.ShoppingCardSumary.ContinueShopping.Click("101;28");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Move item 'ApplicationUnderTest.ShoppingCardSumary.ItemSelect.HoverCart' at Center.", repo.ApplicationUnderTest.ShoppingCardSumary.ItemSelect.HoverCartInfo, new RecordItemIndex(9));
            repo.ApplicationUnderTest.ShoppingCardSumary.ItemSelect.HoverCart.MoveTo();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.ShoppingCardSumary.SpanTagCheckOut' at 162;16.", repo.ApplicationUnderTest.ShoppingCardSumary.SpanTagCheckOutInfo, new RecordItemIndex(10));
            repo.ApplicationUnderTest.ShoppingCardSumary.SpanTagCheckOut.Click("162;16");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Move item 'ApplicationUnderTest.ShoppingCardSumary.ItemSelect.HoverCart' at Center.", repo.ApplicationUnderTest.ShoppingCardSumary.ItemSelect.HoverCartInfo, new RecordItemIndex(11));
            repo.ApplicationUnderTest.ShoppingCardSumary.ItemSelect.HoverCart.MoveTo();
            Delay.Milliseconds(0);
            
            ValidateQuantity(repo.ApplicationUnderTest.ShoppingCardSumary.QuantityItem.QuantityItemRepoInfo, repo.ApplicationUnderTest.ShoppingCardSumary.QuantityItem.TotalQuantityItemInfo);
            Delay.Milliseconds(0);
            
            ValidateTotalMoney(repo.ApplicationUnderTest.ShoppingCardSumary.QuantityItem.ItemPriceInfo, repo.ApplicationUnderTest.ShoppingCardSumary.QuantityItem.TotalProductsInfo, repo.ApplicationUnderTest.ShoppingCardSumary.QuantityItem.TotalShippingInfo, repo.ApplicationUnderTest.ShoppingCardSumary.QuantityItem.TotalPriceWithoutTaxInfo, repo.ApplicationUnderTest.ShoppingCardSumary.QuantityItem.TaxPriceInfo, repo.ApplicationUnderTest.ShoppingCardSumary.QuantityItem.TotalPriceInfo);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.ShoppingCardSumary.CenterColumn.ProceedToCheckout' at 87;29.", repo.ApplicationUnderTest.ShoppingCardSumary.CenterColumn.ProceedToCheckoutInfo, new RecordItemIndex(14));
            repo.ApplicationUnderTest.ShoppingCardSumary.CenterColumn.ProceedToCheckout.Click("87;29");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.ShoppingCardSumary.TextAreaAddComment' at 307;51.", repo.ApplicationUnderTest.ShoppingCardSumary.TextAreaAddCommentInfo, new RecordItemIndex(15));
            repo.ApplicationUnderTest.ShoppingCardSumary.TextAreaAddComment.Click("307;51");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence 'None' with focus on 'ApplicationUnderTest.ShoppingCardSumary.TextAreaAddComment'.", repo.ApplicationUnderTest.ShoppingCardSumary.TextAreaAddCommentInfo, new RecordItemIndex(16));
            repo.ApplicationUnderTest.ShoppingCardSumary.TextAreaAddComment.PressKeys("None");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.ShoppingCardSumary.CenterColumn.ProceedToCheckout' at 143;32.", repo.ApplicationUnderTest.ShoppingCardSumary.CenterColumn.ProceedToCheckoutInfo, new RecordItemIndex(17));
            repo.ApplicationUnderTest.ShoppingCardSumary.CenterColumn.ProceedToCheckout.Click("143;32");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.ShoppingCardSumary.InputTagCgv' at 12;7.", repo.ApplicationUnderTest.ShoppingCardSumary.InputTagCgvInfo, new RecordItemIndex(18));
            repo.ApplicationUnderTest.ShoppingCardSumary.InputTagCgv.Click("12;7");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.ShoppingCardSumary.CenterColumn.ProceedToCheckout' at 84;26.", repo.ApplicationUnderTest.ShoppingCardSumary.CenterColumn.ProceedToCheckoutInfo, new RecordItemIndex(19));
            repo.ApplicationUnderTest.ShoppingCardSumary.CenterColumn.ProceedToCheckout.Click("84;26");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.ShoppingCardSumary.CenterColumn.PayByCheck' at 375;24.", repo.ApplicationUnderTest.ShoppingCardSumary.CenterColumn.PayByCheckInfo, new RecordItemIndex(20));
            repo.ApplicationUnderTest.ShoppingCardSumary.CenterColumn.PayByCheck.Click("375;24");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.ShoppingCardSumary.IConfirmMyOrder' at 64;20.", repo.ApplicationUnderTest.ShoppingCardSumary.IConfirmMyOrderInfo, new RecordItemIndex(21));
            repo.ApplicationUnderTest.ShoppingCardSumary.IConfirmMyOrder.Click("64;20");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (InnerText='Your order on My Store is complete.') on item 'ApplicationUnderTest.ShoppingCardSumary.CenterColumn.YourOrderOnMyStoreIsComplete'.", repo.ApplicationUnderTest.ShoppingCardSumary.CenterColumn.YourOrderOnMyStoreIsCompleteInfo, new RecordItemIndex(22));
            Validate.AttributeEqual(repo.ApplicationUnderTest.ShoppingCardSumary.CenterColumn.YourOrderOnMyStoreIsCompleteInfo, "InnerText", "Your order on My Store is complete.");
            Delay.Milliseconds(100);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}

﻿// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by coded UI test builder.
//      Version: 14.0.0.0
//
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------

namespace CodedUITestProject1
{
    using System;
    using System.CodeDom.Compiler;
    using System.Collections.Generic;
    using System.Drawing;
    using System.Text.RegularExpressions;
    using System.Windows.Input;
    using Microsoft.VisualStudio.TestTools.UITest.Extension;
    using Microsoft.VisualStudio.TestTools.UITesting;
    using Microsoft.VisualStudio.TestTools.UITesting.WinControls;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using Keyboard = Microsoft.VisualStudio.TestTools.UITesting.Keyboard;
    using Mouse = Microsoft.VisualStudio.TestTools.UITesting.Mouse;
    using MouseButtons = System.Windows.Forms.MouseButtons;
    
    
    [GeneratedCode("Coded UITest Builder", "14.0.23107.0")]
    public partial class UIMap
    {
        
        /// <summary>
        /// Testing simple addition of two integers in Alternate Calculator Application
        /// </summary>
        public void AdditionOperation()
        {
            #region Variable Declarations
            WinClient uICalculatorClient = this.UICalculatorWindow.UIItemWindow.UICalculatorClient;
            WinClient uICalculatorClient1 = this.UICalculatorWindow.UIItemWindow1.UICalculatorClient;
            WinClient uICalculatorClient2 = this.UICalculatorWindow.UIItemWindow2.UICalculatorClient;
            WinClient uICalculatorClient3 = this.UICalculatorWindow.UIItemWindow3.UICalculatorClient;
            WinClient uICalculatorClient4 = this.UICalculatorWindow.UIItemWindow4.UICalculatorClient;
            WinClient uICalculatorClient5 = this.UICalculatorWindow.UIItemWindow5.UICalculatorClient;
            #endregion

            // Click 'Calculator' client
            Mouse.Click(uICalculatorClient, new Point(18, 26));

            // Click 'Calculator' client
            Mouse.Click(uICalculatorClient1, new Point(21, 20));

            // Click 'Calculator' client
            Mouse.Click(uICalculatorClient2, new Point(20, 20));

            // Click 'Calculator' client
            Mouse.Click(uICalculatorClient3, new Point(16, 25));

            // Click 'Calculator' client
            Mouse.Click(uICalculatorClient4, new Point(26, 22));

            // Click 'Calculator' client
            Mouse.Click(uICalculatorClient5, new Point(26, 28));
        }
        
        /// <summary>
        /// This method is to check if the addition is generating a value of 40
        /// </summary>
        public void AssertAddition()
        {
            #region Variable Declarations
            WinEdit uIItemEdit = this.UICalculatorWindow.UIItem0Window.UIItemEdit;
            #endregion

            // Verify that the 'ControlType' property of text box equals '40'
            Assert.AreEqual(this.AssertAdditionExpectedValues.UIItemEditControlType, uIItemEdit.ControlType.ToString(), "The test value should be 40 else the test in not successful");
        }
        
        #region Properties
        public virtual AssertAdditionExpectedValues AssertAdditionExpectedValues
        {
            get
            {
                if ((this.mAssertAdditionExpectedValues == null))
                {
                    this.mAssertAdditionExpectedValues = new AssertAdditionExpectedValues();
                }
                return this.mAssertAdditionExpectedValues;
            }
        }
        
        public UICalculatorWindow UICalculatorWindow
        {
            get
            {
                if ((this.mUICalculatorWindow == null))
                {
                    this.mUICalculatorWindow = new UICalculatorWindow();
                }
                return this.mUICalculatorWindow;
            }
        }
        #endregion
        
        #region Fields
        private AssertAdditionExpectedValues mAssertAdditionExpectedValues;
        
        private UICalculatorWindow mUICalculatorWindow;
        #endregion
    }
    
    /// <summary>
    /// Parameters to be passed into 'AssertAddition'
    /// </summary>
    [GeneratedCode("Coded UITest Builder", "14.0.23107.0")]
    public class AssertAdditionExpectedValues
    {
        
        #region Fields
        /// <summary>
        /// Verify that the 'ControlType' property of text box equals '40'
        /// </summary>
        public string UIItemEditControlType = "40";
        #endregion
    }
    
    [GeneratedCode("Coded UITest Builder", "14.0.23107.0")]
    public class UICalculatorWindow : WinWindow
    {
        
        public UICalculatorWindow()
        {
            #region Search Criteria
            this.SearchProperties[WinWindow.PropertyNames.Name] = "Calculator";
            this.SearchProperties[WinWindow.PropertyNames.ClassName] = "TFrmCalculator";
            this.WindowTitles.Add("Calculator");
            #endregion
        }
        
        #region Properties
        public UIItemWindow UIItemWindow
        {
            get
            {
                if ((this.mUIItemWindow == null))
                {
                    this.mUIItemWindow = new UIItemWindow(this);
                }
                return this.mUIItemWindow;
            }
        }
        
        public UIItemWindow1 UIItemWindow1
        {
            get
            {
                if ((this.mUIItemWindow1 == null))
                {
                    this.mUIItemWindow1 = new UIItemWindow1(this);
                }
                return this.mUIItemWindow1;
            }
        }
        
        public UIItemWindow2 UIItemWindow2
        {
            get
            {
                if ((this.mUIItemWindow2 == null))
                {
                    this.mUIItemWindow2 = new UIItemWindow2(this);
                }
                return this.mUIItemWindow2;
            }
        }
        
        public UIItemWindow3 UIItemWindow3
        {
            get
            {
                if ((this.mUIItemWindow3 == null))
                {
                    this.mUIItemWindow3 = new UIItemWindow3(this);
                }
                return this.mUIItemWindow3;
            }
        }
        
        public UIItemWindow4 UIItemWindow4
        {
            get
            {
                if ((this.mUIItemWindow4 == null))
                {
                    this.mUIItemWindow4 = new UIItemWindow4(this);
                }
                return this.mUIItemWindow4;
            }
        }
        
        public UIItemWindow5 UIItemWindow5
        {
            get
            {
                if ((this.mUIItemWindow5 == null))
                {
                    this.mUIItemWindow5 = new UIItemWindow5(this);
                }
                return this.mUIItemWindow5;
            }
        }
        
        public UIItem0Window UIItem0Window
        {
            get
            {
                if ((this.mUIItem0Window == null))
                {
                    this.mUIItem0Window = new UIItem0Window(this);
                }
                return this.mUIItem0Window;
            }
        }
        #endregion
        
        #region Fields
        private UIItemWindow mUIItemWindow;
        
        private UIItemWindow1 mUIItemWindow1;
        
        private UIItemWindow2 mUIItemWindow2;
        
        private UIItemWindow3 mUIItemWindow3;
        
        private UIItemWindow4 mUIItemWindow4;
        
        private UIItemWindow5 mUIItemWindow5;
        
        private UIItem0Window mUIItem0Window;
        #endregion
    }
    
    [GeneratedCode("Coded UITest Builder", "14.0.23107.0")]
    public class UIItemWindow : WinWindow
    {
        
        public UIItemWindow(UITestControl searchLimitContainer) : 
                base(searchLimitContainer)
        {
            #region Search Criteria
            this.SearchProperties[WinWindow.PropertyNames.ClassName] = "TxpButton";
            this.SearchProperties[WinWindow.PropertyNames.Instance] = "32";
            this.WindowTitles.Add("Calculator");
            #endregion
        }
        
        #region Properties
        public WinClient UICalculatorClient
        {
            get
            {
                if ((this.mUICalculatorClient == null))
                {
                    this.mUICalculatorClient = new WinClient(this);
                    #region Search Criteria
                    this.mUICalculatorClient.WindowTitles.Add("Calculator");
                    #endregion
                }
                return this.mUICalculatorClient;
            }
        }
        #endregion
        
        #region Fields
        private WinClient mUICalculatorClient;
        #endregion
    }
    
    [GeneratedCode("Coded UITest Builder", "14.0.23107.0")]
    public class UIItemWindow1 : WinWindow
    {
        
        public UIItemWindow1(UITestControl searchLimitContainer) : 
                base(searchLimitContainer)
        {
            #region Search Criteria
            this.SearchProperties[WinWindow.PropertyNames.ClassName] = "TxpButton";
            this.SearchProperties[WinWindow.PropertyNames.Instance] = "30";
            this.WindowTitles.Add("Calculator");
            #endregion
        }
        
        #region Properties
        public WinClient UICalculatorClient
        {
            get
            {
                if ((this.mUICalculatorClient == null))
                {
                    this.mUICalculatorClient = new WinClient(this);
                    #region Search Criteria
                    this.mUICalculatorClient.WindowTitles.Add("Calculator");
                    #endregion
                }
                return this.mUICalculatorClient;
            }
        }
        #endregion
        
        #region Fields
        private WinClient mUICalculatorClient;
        #endregion
    }
    
    [GeneratedCode("Coded UITest Builder", "14.0.23107.0")]
    public class UIItemWindow2 : WinWindow
    {
        
        public UIItemWindow2(UITestControl searchLimitContainer) : 
                base(searchLimitContainer)
        {
            #region Search Criteria
            this.SearchProperties[WinWindow.PropertyNames.ClassName] = "TxpButton";
            this.SearchProperties[WinWindow.PropertyNames.Instance] = "21";
            this.WindowTitles.Add("Calculator");
            #endregion
        }
        
        #region Properties
        public WinClient UICalculatorClient
        {
            get
            {
                if ((this.mUICalculatorClient == null))
                {
                    this.mUICalculatorClient = new WinClient(this);
                    #region Search Criteria
                    this.mUICalculatorClient.WindowTitles.Add("Calculator");
                    #endregion
                }
                return this.mUICalculatorClient;
            }
        }
        #endregion
        
        #region Fields
        private WinClient mUICalculatorClient;
        #endregion
    }
    
    [GeneratedCode("Coded UITest Builder", "14.0.23107.0")]
    public class UIItemWindow3 : WinWindow
    {
        
        public UIItemWindow3(UITestControl searchLimitContainer) : 
                base(searchLimitContainer)
        {
            #region Search Criteria
            this.SearchProperties[WinWindow.PropertyNames.ClassName] = "TxpButton";
            this.SearchProperties[WinWindow.PropertyNames.Instance] = "31";
            this.WindowTitles.Add("Calculator");
            #endregion
        }
        
        #region Properties
        public WinClient UICalculatorClient
        {
            get
            {
                if ((this.mUICalculatorClient == null))
                {
                    this.mUICalculatorClient = new WinClient(this);
                    #region Search Criteria
                    this.mUICalculatorClient.WindowTitles.Add("Calculator");
                    #endregion
                }
                return this.mUICalculatorClient;
            }
        }
        #endregion
        
        #region Fields
        private WinClient mUICalculatorClient;
        #endregion
    }
    
    [GeneratedCode("Coded UITest Builder", "14.0.23107.0")]
    public class UIItemWindow4 : WinWindow
    {
        
        public UIItemWindow4(UITestControl searchLimitContainer) : 
                base(searchLimitContainer)
        {
            #region Search Criteria
            this.SearchProperties[WinWindow.PropertyNames.ClassName] = "TxpButton";
            this.SearchProperties[WinWindow.PropertyNames.Instance] = "24";
            this.WindowTitles.Add("Calculator");
            #endregion
        }
        
        #region Properties
        public WinClient UICalculatorClient
        {
            get
            {
                if ((this.mUICalculatorClient == null))
                {
                    this.mUICalculatorClient = new WinClient(this);
                    #region Search Criteria
                    this.mUICalculatorClient.WindowTitles.Add("Calculator");
                    #endregion
                }
                return this.mUICalculatorClient;
            }
        }
        #endregion
        
        #region Fields
        private WinClient mUICalculatorClient;
        #endregion
    }
    
    [GeneratedCode("Coded UITest Builder", "14.0.23107.0")]
    public class UIItemWindow5 : WinWindow
    {
        
        public UIItemWindow5(UITestControl searchLimitContainer) : 
                base(searchLimitContainer)
        {
            #region Search Criteria
            this.SearchProperties[WinWindow.PropertyNames.ClassName] = "TxpButton";
            this.SearchProperties[WinWindow.PropertyNames.Instance] = "17";
            this.WindowTitles.Add("Calculator");
            #endregion
        }
        
        #region Properties
        public WinClient UICalculatorClient
        {
            get
            {
                if ((this.mUICalculatorClient == null))
                {
                    this.mUICalculatorClient = new WinClient(this);
                    #region Search Criteria
                    this.mUICalculatorClient.WindowTitles.Add("Calculator");
                    #endregion
                }
                return this.mUICalculatorClient;
            }
        }
        #endregion
        
        #region Fields
        private WinClient mUICalculatorClient;
        #endregion
    }
    
    [GeneratedCode("Coded UITest Builder", "14.0.23107.0")]
    public class UIItem0Window : WinWindow
    {
        
        public UIItem0Window(UITestControl searchLimitContainer) : 
                base(searchLimitContainer)
        {
            #region Search Criteria
            this.SearchProperties[WinWindow.PropertyNames.Name] = "0";
            this.SearchProperties[WinWindow.PropertyNames.ClassName] = "TMaskEdit";
            this.WindowTitles.Add("Calculator");
            #endregion
        }
        
        #region Properties
        public WinEdit UIItemEdit
        {
            get
            {
                if ((this.mUIItemEdit == null))
                {
                    this.mUIItemEdit = new WinEdit(this);
                    #region Search Criteria
                    this.mUIItemEdit.WindowTitles.Add("Calculator");
                    #endregion
                }
                return this.mUIItemEdit;
            }
        }
        #endregion
        
        #region Fields
        private WinEdit mUIItemEdit;
        #endregion
    }
}

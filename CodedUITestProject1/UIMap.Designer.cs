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
        /// RecordedMethod1
        /// </summary>
        public void RecordedMethod1()
        {
            #region Variable Declarations
            WinClient uIInputCaptureWindowClient = this.UIXDEWindow.UIItemWindow.UIRdpClientClient.UIInputCaptureWindowClient;
            #endregion

            // Click 'Input Capture Window' client
            Mouse.Click(uIInputCaptureWindowClient, new Point(178, 489));

            // Click 'Input Capture Window' client
            Mouse.Click(uIInputCaptureWindowClient, new Point(77, 95));

            // Click 'Input Capture Window' client
            Mouse.Click(uIInputCaptureWindowClient, new Point(70, 53));

            // Click 'Input Capture Window' client
            Mouse.Click(uIInputCaptureWindowClient, new Point(35, 142));

            // Click 'Input Capture Window' client
            Mouse.Click(uIInputCaptureWindowClient, new Point(51, 209));
        }
        
        #region Properties
        public UIXDEWindow UIXDEWindow
        {
            get
            {
                if ((this.mUIXDEWindow == null))
                {
                    this.mUIXDEWindow = new UIXDEWindow();
                }
                return this.mUIXDEWindow;
            }
        }
        #endregion
        
        #region Fields
        private UIXDEWindow mUIXDEWindow;
        #endregion
    }
    
    [GeneratedCode("Coded UITest Builder", "14.0.23107.0")]
    public class UIXDEWindow : WinWindow
    {
        
        public UIXDEWindow()
        {
            #region Search Criteria
            this.SearchProperties[WinWindow.PropertyNames.Name] = "XDE";
            this.SearchProperties.Add(new PropertyExpression(WinWindow.PropertyNames.ClassName, "WindowsForms10.Window", PropertyExpressionOperator.Contains));
            this.WindowTitles.Add("XDE");
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
        #endregion
        
        #region Fields
        private UIItemWindow mUIItemWindow;
        #endregion
    }
    
    [GeneratedCode("Coded UITest Builder", "14.0.23107.0")]
    public class UIItemWindow : WinWindow
    {
        
        public UIItemWindow(UITestControl searchLimitContainer) : 
                base(searchLimitContainer)
        {
            #region Search Criteria
            this.SearchProperties[WinWindow.PropertyNames.ClassName] = "UIContainerClass";
            this.WindowTitles.Add("XDE");
            #endregion
        }
        
        #region Properties
        public UIRdpClientClient UIRdpClientClient
        {
            get
            {
                if ((this.mUIRdpClientClient == null))
                {
                    this.mUIRdpClientClient = new UIRdpClientClient(this);
                }
                return this.mUIRdpClientClient;
            }
        }
        #endregion
        
        #region Fields
        private UIRdpClientClient mUIRdpClientClient;
        #endregion
    }
    
    [GeneratedCode("Coded UITest Builder", "14.0.23107.0")]
    public class UIRdpClientClient : WinClient
    {
        
        public UIRdpClientClient(UITestControl searchLimitContainer) : 
                base(searchLimitContainer)
        {
            #region Search Criteria
            this.WindowTitles.Add("XDE");
            #endregion
        }
        
        #region Properties
        public WinClient UIInputCaptureWindowClient
        {
            get
            {
                if ((this.mUIInputCaptureWindowClient == null))
                {
                    this.mUIInputCaptureWindowClient = new WinClient(this);
                    #region Search Criteria
                    this.mUIInputCaptureWindowClient.SearchProperties[WinControl.PropertyNames.Name] = "Input Capture Window";
                    this.mUIInputCaptureWindowClient.WindowTitles.Add("XDE");
                    #endregion
                }
                return this.mUIInputCaptureWindowClient;
            }
        }
        #endregion
        
        #region Fields
        private WinClient mUIInputCaptureWindowClient;
        #endregion
    }
}
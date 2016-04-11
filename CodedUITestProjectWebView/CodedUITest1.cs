using System;
using Microsoft.VisualStudio.TestTools.UITesting;
using Microsoft.VisualStudio.TestPlatform.UnitTestFramework;
using Microsoft.VisualStudio.TestTools.UITest.Input;
using Microsoft.VisualStudio.TestTools.UITest.Extension;
using Microsoft.VisualStudio.TestTools.UITesting.WindowsRuntimeControls;


namespace CodedUITestProjectWebView
{
    /// <summary>
    /// Summary description for CodedUITest1
    /// </summary>
    [CodedUITest]
    public class CodedUITest1
    {
        public CodedUITest1()
        {
            XamlWindow myAppWindow = XamlWindow.Launch("53fc6321-07ff-4efe-8cd3-d946d18d8643_5smkd5rccf47t!App");
        }

        [TestMethod]
        public void CodedUITestMethod1()
        {
        }

        [TestMethod]
        public void ClickEnBoton()
        {
            Playback.Wait(180);
            Gesture.Tap(this.UIMap.UIWebViewTestWindow.UIButtonButton);

            Playback.Wait(3000);

          ClickEnBoton2();
        }

        [TestMethod]
        public void ClickEnBoton2()
        {
            Playback.Wait(180);

            Gesture.Tap(this.UIMap.UIWebViewTestWindow.UIButtonButton1);

            
            Playback.Wait(3600);
        }

        public UIMap UIMap
        {
            {
                if ((this.map == null))
                {
                    this.map = new UIMap();
                }

                return this.map;
            }
        }

        private UIMap map;
    }
}

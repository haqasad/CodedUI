using Microsoft.VisualStudio.TestTools.UITesting;
using Microsoft.VisualStudio.TestTools.UITesting.WinControls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace CodedUITestProject3
{
    class CustomCaller
    {
        public static void ButtonClick()
        {
            // Instance for WinWindow
            WinWindow calcWindow = new WinWindow();
            calcWindow.SearchProperties[WinWindow.PropertyNames.Name] = "Calculator";
            calcWindow.SearchProperties[WinWindow.PropertyNames.ClassName] = "TFrmCalculator";

            // Instance for WinWindow
            CodedUITestProject2.CustomUIItemWindow uiItemWindow = new CodedUITestProject2.CustomUIItemWindow(calcWindow);
            //uiItemWindow.SearchProperties[WinWindow.PropertyNames.ClassName] = "TxpButton";
            //uiItemWindow.SearchProperties[WinWindow.PropertyNames.Instance] = "12";

            //WinClient btn = new WinClient();
            //btn.SearchProperties[UITestControl.PropertyNames.Name = "Calculator"];
            //btn.SearchProperties[WinClient.PropertyNames.Name = "Calculator"];

            Mouse.Click(uiItemWindow.UICalculatorClient);
        }
    }
}

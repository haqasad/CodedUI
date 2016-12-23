using Microsoft.VisualStudio.TestTools.UITesting.WinControls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodedUITestProject2
{

    public class CustomUICalcWindow : WinWindow
    {

        public CustomUICalcWindow()
        {
            #region Search Criteria
            this.SearchProperties[WinWindow.PropertyNames.Name] = "Calculator";
            this.SearchProperties[WinWindow.PropertyNames.ClassName] = "TFrmCalculator";
            this.WindowTitles.Add("Calculator");
            #endregion
        }
    }
}

using Microsoft.VisualStudio.TestTools.UITesting;
using Microsoft.VisualStudio.TestTools.UITesting.WinControls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodedUITestProject2
{
    public class CustomUIItemWindow : WinWindow
    {
        public CustomUIItemWindow(UITestControl searchLimitContainer) : 
                base(searchLimitContainer)
        {
            #region Search Criteria
            this.SearchProperties[WinWindow.PropertyNames.ClassName] = "TxpButton";
            this.SearchProperties[WinWindow.PropertyNames.Instance] = "12";
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


}

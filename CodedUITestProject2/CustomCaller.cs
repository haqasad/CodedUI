using Microsoft.VisualStudio.TestTools.UITesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodedUITestProject2
{
    class CustomCaller
    {
        public static void ButtonClick()
        {
            //Instance for Calc Window
            CustomUICalcWindow calcWindow = new CustomUICalcWindow();

            //Instance for Custom UI Item Window
            CustomUIItemWindow custItemWind = new CustomUIItemWindow(calcWindow);

            Mouse.Click(custItemWind.UICalculatorClient);
        }        
    }
}

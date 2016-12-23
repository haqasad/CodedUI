using Microsoft.VisualStudio.TestTools.UITesting;
using Microsoft.VisualStudio.TestTools.UITest.Extension;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

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
            custItemWind.instance = "32";

            //CustomUIItemWindow custItemWind1 = new CustomUIItemWindow(calcWindow);
            //custItemWind1.instance = "32";

            try
            {
                Mouse.Click(custItemWind.UICalculatorClient);
            }
            catch
            {
                Console.WriteLine("Mouse Click is not working");
            }
            
            //Thread.Sleep(1000);
            //Mouse.Click(custItemWind1.UICalculatorClient);
        }        
    }
}

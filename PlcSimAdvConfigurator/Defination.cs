using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlcSimAdvConfigurator
{
    class Defination
    {
        public static Dictionary<string, string> getButton()
        {
            Dictionary<string, string> result = new Dictionary<string, string>
            {
                { "ID" , "" },
                { "Control", "cButton" },
                { "Text", "Button" },
                { "Size", "100x50" },
                { "Location", "20,20" },
                { "Button", "" },
                { "Output_Q", "" },
                { "Output_nQ", "" },
                { "ActiveColor", "" }
            };

            return result;
        }
        public static Dictionary<string, string> getToggleButton()
        {
            Dictionary<string, string> result = new Dictionary<string, string>
            {
                { "ID" , "" },
                { "Control", "cToggleButton" },
                { "Text", "ToggleButton" },
                { "Size", "100x50" },
                { "Location", "20,20" },
                { "Button", "" },
                { "Output_Q", "" },
                { "Output_nQ", "" },
                { "ActiveColor", "" },
                { "Value", "False" }
            };

            return result;
        }
        public static Dictionary<string, string> getButtonLamp()
        {
            Dictionary<string, string> result = new Dictionary<string, string>
            {
                { "ID" , "" },
                { "Control", "cButtonLamp" },
                { "Text", "ButtonLamp" },
                { "Size", "100x50" },
                { "Location", "20,20" },
                { "Button", "" },
                { "Lamp", "" },
                { "Output_Q", "" },
                { "Output_nQ", "" },
                { "ActiveColor", "" }
            };

            return result;
        }
        public static Dictionary<string, string> getLamp()
        {
            Dictionary<string, string> result = new Dictionary<string, string>
            {
                { "ID" , "" },
                { "Control", "cLamp" },
                { "Text", "ButtonLamp" },
                { "Size", "50x50" },
                { "Location", "20,20" },
                { "Lamp", "" },
                { "ActiveColor", "" },
                { "Output_Q", "" },
                { "Output_nQ", "" }
            };

            return result;
        }
        public static Dictionary<string, string> getCheckBox()
        {
            Dictionary<string, string> result = new Dictionary<string, string>
            {
                { "ID" , "" },
                { "Control", "cCheckBox" },
                { "Text", "ButtonLamp" },
                { "Size", "100x50" },
                { "Location", "20,20" },
                { "Button", "" },
                { "Output_Q", "" },
                { "Output_nQ", "" },
                { "Value", "False" }
            };

            return result;
        }
        public static Dictionary<string, string> getLabel()
        {
            Dictionary<string, string> result = new Dictionary<string, string>
            {
                { "ID" , "" },
                { "Control", "cLabel" },
                { "Text", "Button" },
                { "Size", "100x50" },
                { "Location", "20,20" },
                { "FontSize", "15" },
                { "BackColor", "" },
            };

            return result;
        }
        public static Dictionary<string, string> getPulse()
        {
            Dictionary<string, string> result = new Dictionary<string, string>
            {
                { "ID" , "" },
                { "Control", "cPulse" },
                { "Text", "Pulse Generator" },
                { "Size", "100x100" },
                { "Location", "20,20" },
                { "TimeMS" , "1000" },
                { "Output_Q", "" },
                { "Output_nQ", "" }
            };

            return result;
        }
        public static Dictionary<string, string> getTrackbar()
        {
            Dictionary<string, string> result = new Dictionary<string, string>
            {
                { "ID" , "" },
                { "Control", "cTrackBar" },
                { "Text", "Trackbar" },
                { "Size", "100x100" },
                { "Location", "20,20" },
                { "Max" , "27000" },
                { "Min" , "0" },
                { "Output", "" },
                { "Value", "" }
            };

            return result;
        }
        public static Dictionary<string, string> getIntregator()
        {
            Dictionary<string, string> result = new Dictionary<string, string>
            {
                { "ID" , "" },
                { "Control", "cIntregrator" },
                { "Text", "Intregrator" },
                { "Size", "100x100" },
                { "Location", "20,20" },
                { "Output", "" },
                { "Value" , "" },
                { "Gradiant","" },
                { "SetPoint", "" },
                { "Target", "" },
                { "Set", "" },
                { "Start", "" }
            };

            return result;
        }

    }
}

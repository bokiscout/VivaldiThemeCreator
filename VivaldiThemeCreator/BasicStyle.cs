using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VivaldiThemeCreator
{
    class BasicStyle : Style
    {
        String name { get; set; }

        public BasicStyle()
        {
            name = "Basic";
        }

        public String GetName()
        {
            return name;
        }

        public void ApplyStyle()
        {
            throw new NotImplementedException();
        }

        public void ApplyCustomColors()
        {
            throw new NotImplementedException();
        }

        public void FixWideAdressbarColor()
        {
            throw new NotImplementedException();
        }

        public void SetFrameColor(System.Drawing.Color color)
        {
            throw new NotImplementedException();
        }

        public void SetPanelColor(System.Drawing.Color color)
        {
            throw new NotImplementedException();
        }

        public void SetActiveTabColor(System.Drawing.Color color)
        {
            throw new NotImplementedException();
        }

        public void SetInactiveTabColor(System.Drawing.Color color)
        {
            throw new NotImplementedException();
        }

        public override string ToString()
        {
            return name;
        }
    }
}

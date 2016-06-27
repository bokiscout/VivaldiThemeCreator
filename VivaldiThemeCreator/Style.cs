using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace VivaldiThemeCreator
{
    interface Style
    {
        void ApplyStyle();

        String GetName();

        void ApplyCustomColors();

        void FixWideAdressbarColor();

        void SetFrameColor(Color color);

        void SetPanelColor(Color color);

        void SetActiveTabColor(Color color);

        void SetInactiveTabColor(Color color);


    }
}

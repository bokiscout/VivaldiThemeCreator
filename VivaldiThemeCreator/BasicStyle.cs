using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace VivaldiThemeCreator
{
    class BasicStyle : Style
    {
        private String name { get; set; }
        private String customCss { get; set; }
        private String templateLocation { get; set; }

        Color frameColor { get; set; }
        Color activeTabColor { get; set; }
        Color inactiveTabsColor { get; set; }
        Color panelColor { get; set; }

        public BasicStyle(String customCss, String template)
        {
            name = "Basic";

            this.customCss = customCss;
            this.templateLocation = template;
        }

        public String GetName()
        {
            return name;
        }

        public void SetFrameColor(System.Drawing.Color color)
        {
            frameColor = color;
        }

        public void SetPanelColor(System.Drawing.Color color)
        {
            panelColor = color;
        }

        public void SetActiveTabColor(System.Drawing.Color color)
        {
            activeTabColor = color;
        }

        public void SetInactiveTabColor(System.Drawing.Color color)
        {
            inactiveTabsColor = color;
        }

        // this style do not use any template (like InternetExplorerStyle does for example)
        // this style only add custom colors but that is handled in 'ApplyCostomColors()' wich is called just after 'ApplyStyle' in Form.cs
        public void ApplyStyle()
        {
            // note1: use empty using statement to create new empty document and avoid using of Dispose()
            // note2: if we do not create new empty file, we might endup using template from other style
            using (System.IO.File.Create(customCss)) ;
        }

        public void ApplyCustomColors()
        {
            using (System.IO.StreamWriter sw = System.IO.File.AppendText(customCss))
            {
                if (frameColor != null)
                {
                    int R = frameColor.R;
                    int G = frameColor.G;
                    int B = frameColor.B;

                    sw.WriteLine("");
                    sw.WriteLine("#header{");
                    sw.WriteLine("background-color:  rgb" + "(" + R + "," + G + "," + B + ");");
                    sw.WriteLine("}");
                    sw.WriteLine("");
                }
                if (panelColor != null)
                {
                    int R = panelColor.R;
                    int G = panelColor.G;
                    int B = panelColor.B;

                    sw.WriteLine("");
                    sw.WriteLine("#main.left > .toolbar{");
                    sw.WriteLine("background-color:  rgb" + "(" + R + "," + G + "," + B + ");");
                    sw.WriteLine("}");
                    sw.WriteLine("");
                }
                if (activeTabColor != null)
                {
                    int R = activeTabColor.R;
                    int G = activeTabColor.G;
                    int B = activeTabColor.B;

                    sw.WriteLine("");
                    sw.WriteLine(".tab.active{");
                    sw.WriteLine("background-color:  rgb" + "(" + R + "," + G + "," + B + ") !important;");
                    sw.WriteLine("}");
                    sw.WriteLine("");
                }
                if (inactiveTabsColor != null)
                {
                    int R = inactiveTabsColor.R;
                    int G = inactiveTabsColor.G;
                    int B = inactiveTabsColor.B;

                    sw.WriteLine("");
                    sw.WriteLine(".tab{");
                    // sw.WriteLine(".tab-position .tab{");
                    // sw.WriteLine(".ui-dark .tab-position .tab{");
                    sw.WriteLine("background-color:  rgb" + "(" + R + "," + G + "," + B + ") !important;");
                    sw.WriteLine("}");
                    sw.WriteLine("");
                }
            }
        }

        // there is nothig to be fixed in this style
        public void FixWideAdressbarColor()
        {
        }

        public override string ToString()
        {
            return name;
        }
    }
}

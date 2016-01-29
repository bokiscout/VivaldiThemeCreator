using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace VivaldiThemeCreator
{
    class InternetExplorerStyle : Style
    {
        private String name { get; set; }
        private String customCss { get; set; }
        private String templateLocation { get; set; }

        Color frameColor { get; set; }
        Color activeTabColor { get; set; }
        Color inactiveTabsColor { get; set; }
        Color panelColor { get; set; }

        public InternetExplorerStyle(String customCss, String template)
        {
            name = "Internet Explorer";

            this.customCss = customCss;
            this.templateLocation = template;
        }

        public String GetName()
        {
            return name;
        }

        public void SetFrameColor(Color color)
        {
            frameColor = color;
        }

        public void SetPanelColor(Color color)
        {
            panelColor = color;
        }

        public void SetActiveTabColor(Color color)
        {
            activeTabColor = color;
        }

        public void SetInactiveTabColor(Color color)
        {
            inactiveTabsColor = color;
        }

        // note1: this method might throw exception while readiing or writing to a file
        // note2: the exception is handled in Form1.cs
        public void ApplyStyle()
        {
            // note1: use empty using statement to create new empty document and avoid using of Dispose()
            using (System.IO.File.Create(customCss)) ;
            String[] template = System.IO.File.ReadAllLines(templateLocation);

            using (System.IO.StreamWriter file = new System.IO.StreamWriter(customCss, true))
            {
                foreach (String s in template)
                {
                    file.Write(s);
                    file.Write("\n");
                }
            }
        }

        // note1: this method might throw exception while reading or writing to a file
        // note2: the exception is handled in Form1.cs
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

        // note1: this method might throw exception while reading or writing to a file
        // note2: the exception is handled in Form1.cs
        public void FixWideAdressbarColor()
        {
            using (System.IO.StreamWriter sw = System.IO.File.AppendText(customCss))
            {
                int R = activeTabColor.R;
                int G = activeTabColor.G;
                int B = activeTabColor.B;

                sw.WriteLine("");
                sw.WriteLine("@media screen and (max-width: 950px) {");
                sw.WriteLine("#main.left > .toolbar{");
                sw.WriteLine("background-color:  rgb" + "(" + R + "," + G + "," + B + ") !important;");
                sw.WriteLine("}");
                sw.WriteLine("}");
                sw.WriteLine("");
            }
        }

        public override string ToString()
        {
            return name;
        }
    }
}

﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VivaldiThemeCreator
{
    class InternetExplorerTemplate
    {
        private String template;

        // default constructor start here
        // default constructor set the template
        public InternetExplorerTemplate(){
            template =
@"/* everything in one row is not usable on small screens/windows */
@media screen and (max-width: 950px) {
  #tabs-container{
    width: 100% !important;
    margin-left: 0px !important;
  }

  #main.left > .toolbar{
    width: 100% !important;
    position: static !important;
    top: 50px !important;
    left: 34px !important;
    /*background-color: rgba(255, 0, 0, 0) !important;*/
  }
}

/*
/////////////////////////
///                   ///
///      titlebar     ///
///                   ///
/////////////////////////
*/

#header{
  /*background-color: gray;*/
}


/*
/////////////////////////
///                   ///
///      adressbar    ///
///                   ///
/////////////////////////
*/

#main.left > .toolbar{
  width: 50%;
  padding-right: -100px;
  position: absolute;
  top: -34px;
  left: 34px;
  background-color: rgba(255, 0, 0, 0);
}

#tabs-container{
  width: 50%;
  float: right;
}

/*move tabs right some pixeles to prevent overlap with adressbar*/
#tabs-container > .resize{
  margin-left: 135px;
}


/*
/////////////////////////
///                   ///
///    searchfield    ///
///                   ///
/////////////////////////
*/
.searchfield{
  display: none !important;
}
";
        } // default constructor ends here

        public String GetTemplate()
        {
            return template;
        }
    }
}
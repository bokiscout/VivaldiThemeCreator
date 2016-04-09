using System;
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
@"/*
/////////////////////////
///                   ///
///    small window   ///
///                   ///
/////////////////////////
*/
@media screen and (max-width: 950px) {
  #tabs-container{
    width: 100% !important;
    margin-left: 0px !important;
  }

/*  #tabs-container .resize{
    left: 40px !important;
  }*/

  #main{
    margin-top: 0px !important;
  }

  #main.left > .toolbar{
    width: 100% !important;
    /*left: 34px !important;*/
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
#main{
    margin-top: -34px;
    z-index: 10;
}

#main.left > .toolbar{
  width: 40%;
  padding-right: -100px;
  background-color: rgba(255, 0, 0, 0);
}

#tabs-container{
  width: 60%;
  float: right;
}

/*move tabs right some pixeles to prevent overlap with adressbar*/
#tabs-container > .resize{
  margin-left: 140px;
  z-index: 12;
}

/*remove botom border/shadow from toolar */
.toolbar.toolbar-addressbar:after{
  background-color: rgba(0, 0, 0, 0) !important;
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


/*
/////////////////////////
///                   ///
///   vivaldi button  ///
///                   ///
/////////////////////////
*/
.vivaldi{
  display: none;
}

.window-buttongroup{
  z-index: 99999;
}
/* end */
";
        } // default constructor ends here

        public String GetTemplate()
        {
            return template;
        }
    }
}

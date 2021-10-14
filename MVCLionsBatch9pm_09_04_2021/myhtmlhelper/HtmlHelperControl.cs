using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCLionsBatch9pm_09_04_2021.myhtmlhelper
{
    public static class HtmlHelperControl
    {
        public static IHtmlString MyLabel(string content,string color)
        {
            string htmlstring = String.Format("<label style='color:red'>{0}</label>", content);
            return new HtmlString(htmlstring);

        }

        public static IHtmlString createUrControl(this HtmlHelper helper, string content)
        {
            string htmlstring = "<input type=" + content + ">";
            return new HtmlString(htmlstring);
        }

    }
}
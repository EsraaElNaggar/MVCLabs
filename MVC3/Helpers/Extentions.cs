using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVC3.Helpers
{
    public static class Extentions
    {
        public static string Tobla(this string caller)
        {
            return "Welcome" + caller ;
        }
    }
}
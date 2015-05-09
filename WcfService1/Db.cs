using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Service.Models;

namespace Service
{
    public static class Db
    {
        private static readonly WebApContext webApContext = new WebApContext();

        public static WebApContext Table
        {
            get
            {
                return webApContext;
            }
        }

    }
}
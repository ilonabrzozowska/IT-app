using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Service;
using Service.Models;
using Service.DataManagers;

namespace WpfApplication
{
    public static class WcfService
    {
        private static readonly OurService service = new OurService();

        public static OurService Instance
        {
            get
            {
                return service;
            }
        }
    }
}

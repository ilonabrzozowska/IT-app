using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLayer.Models;

namespace DataLayer
{
    public static class Db
    {
        private static readonly ThreeTierContext ThreeTierContext = new ThreeTierContext();

        public static ThreeTierContext Table
        {
            get
            {
                return ThreeTierContext;
            }
        }

    }
}

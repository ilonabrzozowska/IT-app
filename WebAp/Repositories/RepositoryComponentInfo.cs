using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebAp.Repositories
{
    public class RepositoryComponentInfo
    {
        public string Name { get; set; }
        public System.Type Service { get; set; }
        public System.Type Implementation { get; set; }

        public RepositoryComponentInfo(string name, System.Type service, System.Type implementation)
        {
            this.Name = name;
            this.Service = service;
            this.Implementation = implementation;
        }

    }   
}
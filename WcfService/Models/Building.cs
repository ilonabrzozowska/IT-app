using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Runtime.Serialization;
using System.ComponentModel.DataAnnotations;
using System.ServiceModel;

namespace WebAp.Models
{
    [DataContract]
    public class Building
    {
        [DataMember, Key, Required]
        public int BuildingID { get; set; }

        [DataMember, MaxLength(127), Required]
        public string District { get; set; }

        [DataMember, MaxLength(127), Required]
        public string Street { get; set; }

        [DataMember, MaxLength(127), Required]
        public string City { get; set; }

        [DataMember, MaxLength(127), Required]
        public string PostCode { get; set; }

        [DataMember, MaxLength(127), Required]
        public string FlatCount { get; set; }

        [DataMember, MaxLength(127), Required]
        public string BuildingNumber { get; set; }

        [DataMember]
        public virtual ICollection<Client> Clients { get; set; }
    }
}
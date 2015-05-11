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
    public class Bill
    {
        [DataMember, Key, Required]
        public int BillID { get; set; }

        [DataMember, Required]
        public int ClientID { get; set; }

        [DataMember, Required]
        public DateTime DateIssue { get; set; }

        [DataMember, Required]
        public float Quantity { get; set; }

        [DataMember, Required]
        public int ItemId { get; set; }

        [DataMember, Required]
        public DateTime PayDate { get; set; }
    }
}
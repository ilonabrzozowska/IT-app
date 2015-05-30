using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Runtime.Serialization;
using System.ComponentModel.DataAnnotations;

namespace DataLayer.Models
{
    [DataContract]
    public class Bill
    {
        [DataMember, Key, Required]
        public int BillId { get; set; }

        [DataMember, Required]
        public int ClientId { get; set; }

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
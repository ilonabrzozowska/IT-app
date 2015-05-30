using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Runtime.Serialization;
using System.ComponentModel.DataAnnotations;

namespace DataLayer.Models
{
    [DataContract]
    public class Item
    {
        [DataMember, Key, Required]
        public int ItemId { get; set; }

        [DataMember, MaxLength(127), Required]
        public string Name { get; set; }

        [DataMember, Required]
        public float PricePerUnit { get; set; }

        [DataMember, Required]
        public DateTime OccurDate { get; set; }
    }
}
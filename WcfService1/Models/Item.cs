using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Runtime.Serialization;
using System.ComponentModel.DataAnnotations;
using System.ServiceModel;

namespace Service.Models
{
    [DataContract]
    public class Item
    {
        [DataMember, Key, Required]
        public int ItemID { get; set; }

        [DataMember, MaxLength(127), Required]
        public string Name { get; set; }

        [DataMember, Required]
        public float Price { get; set; }

        [DataMember]
        public virtual ICollection<Position> Positions { get; set; }

        [DataMember]
        public virtual ICollection<ItemDate> ItemDates { get; set; }
    }
}
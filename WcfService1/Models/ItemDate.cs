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
    public class ItemDate
    {
        [DataMember, Key]
        public int ItemDateID { get; set; }

        [DataMember, Required]
        public int ItemID { get; set; }

        [DataMember, Required]
        public DateTime From { get; set; }

        [DataMember]
        public DateTime To { get; set; }

        [DataMember]
        public virtual Item Item { get; set; }

    }
}
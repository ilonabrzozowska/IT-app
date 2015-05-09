using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Runtime.Serialization;
using System.ComponentModel.DataAnnotations;
using System.ServiceModel;


namespace Service.Models
{
    public class Message
    {
        [DataMember, Key, Required]
        public int MessageID { get; set; }

        [DataMember, MaxLength(256), Required]
        public String Content { get; set; }

        [DataMember, Required]
        public DateTime DeliveryDate { get; set; }

        [DataMember]
        public virtual Client Client { get; set; }

    }
}
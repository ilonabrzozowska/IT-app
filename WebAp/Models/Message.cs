using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Runtime.Serialization;
using System.ComponentModel.DataAnnotations;
using System.ServiceModel;


namespace WebAp.Models
{
    public class Message
    {
        [DataMember, Key, Required]
        public int MessageID { get; set; }

        [DataMember, MaxLength(256), Required]
        public String Content { get; set; }

        [DataMember, Required]
        public DateTime DeliveryDate { get; set; }

        [DataMember, Required]
        public int ClientId { get; set; }

    }
}
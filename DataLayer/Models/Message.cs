using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Runtime.Serialization;
using System.ComponentModel.DataAnnotations;


namespace DataLayer.Models
{
    public class Message
    {
        [DataMember, Key, Required]
        public int MessageId { get; set; }

        [DataMember, MaxLength(256), Required]
        public String Content { get; set; }

        [DataMember, Required]
        public DateTime DeliveryDate { get; set; }

        [DataMember, Required]
        public int ClientId { get; set; }

    }
}
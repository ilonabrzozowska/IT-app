﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Runtime.Serialization;
using System.ComponentModel.DataAnnotations;

namespace DataLayer.Models
{
    [DataContract]
    public class Client
    {
        [DataMember, Key, Required]
        public int ClientId { get; set; }

        [DataMember, MaxLength(32), Required]
        public string Password { get; set; }

        [DataMember, MaxLength(63), Required]
        public string Name { get; set; }

        [DataMember, MaxLength(63), Required]
        public string Surname { get; set; }

        [DataMember, MaxLength(127), Required]
        public string Email { get; set; }

        [DataMember, MaxLength(15)]
        public string FlatNumber { get; set; }

        [DataMember, Required]
        public int BuildingId { get; set; }

        [DataMember, MaxLength(15)]
        public string Phone { get; set; }

        [DataMember]
        public virtual Building Building { get; set; }

        [DataMember]
        public virtual ICollection<Bill> Bills { get; set; }

        [DataMember]
        public virtual ICollection<Message> Messages { get; set; }

    }
}
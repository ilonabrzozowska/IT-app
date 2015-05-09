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
    public class Bill
    {
        [DataMember, Key, Required]
        public string BillID { get; set; }

        [DataMember, StringLength(11), Required]
        public string PESEL { get; set; }

        [DataMember, Required]
        public DateTime DateIssue { get; set; }

        [DataMember]
        public virtual Client Client { get; set; }

        [DataMember]
        public virtual ICollection<Position> Positions { get; set; }
    }
}
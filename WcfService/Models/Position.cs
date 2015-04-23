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
    public class Position
    {
        [DataMember, Key, Required]
        public int PositionID { get; set; }

        [DataMember, Required]
        public int BillID { get; set; }

        [DataMember, Required]
        public int ItemID { get; set; }

        [DataMember, Required]
        public int Quantity { get; set; }

        [DataMember, Required]
        public DateTime DatePay { get; set; }

        [DataMember]
        public virtual Bill Bill { get; set; }

        [DataMember]
        public virtual Item Item { get; set; }
    }
}
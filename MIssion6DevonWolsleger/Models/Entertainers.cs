using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Final.Models
{
 //certain feilds are requiered
    public class Entertainers
    {
        [Key]
        public int EntertainerID { get; set; }
        public string EntStageName { get; set; }
        public string EntSSN { get; set; }
        public string EntStreetAddress { get; set; }
        public string EntCity { get; set; }
        public string EntState { get; set; }
        public string EntZipCode { get; set; }
        public string EntPhoneNumber { get; set; }
        public string EntWebPage { get; set; }
        public string EntEMailAddress { get; set; }
        public string DateEntered { get; set; }
    }
}

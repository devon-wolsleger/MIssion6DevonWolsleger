using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;


//This is where the second table is
namespace MIssion6DevonWolsleger.Models
{
    public class Catagory
    {
        [Key]
        [Required]

        public int CatagoryId { get; set; }
        public string CatagoryName { get; set; }
    }
}

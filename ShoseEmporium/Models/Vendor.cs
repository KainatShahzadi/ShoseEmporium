using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ShoseEmporium.Models
{
    public class Vendor
    {
        [Key]
        public int Vendor_Id { get; set; }
        [Required]
        public int Vendor_name{ get; set; }
    }
}

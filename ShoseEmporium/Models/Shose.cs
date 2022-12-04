using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ShoseEmporium.Models
{
    public class Shose
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Title { get; set; }
        [Required]
        public string URL { get; set; }
        [Required]
        public int Price { get; set; }

        [ForeignKey("ShoseVendor")]
        public int Vendor_Id { get; set; }
        public virtual Vendor ShoseVendor {get; set;}
    }
}

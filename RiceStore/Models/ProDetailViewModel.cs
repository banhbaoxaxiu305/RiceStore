using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace RiceStore.Models
{
    public class ProDetailViewModel
    {
        [Key]
        public int ProID { get; set; }  
        public string ProName { get; set; }
        public string ProImage { get; set; }
        public string NameDecription { get; set; }
        public System.DateTime CreatedDate { get; set; }
        public double Price { get; set; }
    }
}
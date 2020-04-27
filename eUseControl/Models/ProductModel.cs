using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace eUseControl.Models
{
    [Table("UserDbTable")]
    public class ProductModel
    {
        public string TipProdus { get; set; }
        public string NumeProdus { get; set; }
        public float PretProdus { get; set; }
    }
}
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel;
using System.Collections.Generic;
namespace MvcMovie.Models
{
    [Table("Product")]
    public class Product
    {
        [Key]
        public string ProductID { get; set; }
        [DisplayName("Tên sản phẩm")]
        public string ProductName { get; set; }
        [DisplayName("Giá bán")]
        public float UnitPrice { get; set; }
        [DisplayName("Số lượng")]
        public int Quantity { get; set; }
    }
}
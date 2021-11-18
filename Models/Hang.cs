using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel;
using System.Collections.Generic;
namespace MvcMovie.Models
{
    [Table("Hang")]
    public class Hang
    {
        [Key]
        public string HangID { get; set; }
        [DisplayName("Tên Hàng")]
        public string HangName { get; set; }
        [DisplayName("Giá bán")]
        public float Gia { get; set; }
        [DisplayName("Số lượng")]
        public int Soluong { get; set; }
        public string CategoryID { get; set; }
        [DisplayName("Loại Hàng")]
        public Category Category { get; set; }
    }
}
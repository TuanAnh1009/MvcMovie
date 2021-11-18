using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel;
using System.Collections.Generic;
namespace MvcMovie.Models
{
    [Table("Category")]
    public class Category
    {
        [Key]
        [DisplayName("Mã hàng")]
        public string CategoryID { get; set; }
        [DisplayName("Loại hàng")]
        public string CategoryName { get; set; }
        public ICollection<Hang> Hang { get; set; }
    }
}
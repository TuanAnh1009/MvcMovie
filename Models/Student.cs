using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace MvcMovie.Models
{
    [Table("Students")]
    public class Student
    {
        public int StudentId { get; set; }
        public string Hoten { get; set; }

        [DataType(DataType.Date)]
        public DateTime Namsinh { get; set; }
        public string GioiTinh { get; set; }
        public decimal Sodienthoai { get; set; }
    }
}
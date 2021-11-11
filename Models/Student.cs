using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.Generic;
using System.ComponentModel;
namespace MvcMovie.Models
{
    [Table("Students")]
    public class Student
    {
        [Key]
        public int StudentId { get; set; }
        [DisplayName("Họ tên sinh viên")]
        public string Hoten { get; set; }
        [DisplayName("Năm sinh")]

        [DataType(DataType.Date)]
        public DateTime Namsinh { get; set; }
        [DisplayName("Giới tính")]
        public string GioiTinh { get; set; }
        [DisplayName("Số điện thoại")]
        public decimal Sodienthoai { get; set; }
    }
}
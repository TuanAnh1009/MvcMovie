using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel;
using System.Collections.Generic;
namespace MvcMovie.Models
{
    [Table("Employee")]
    public class Employee
    {
        [Key]
        public int EmployeeID { get; set; }
        [DisplayName("Họ tên khách hàng")]
        public string EmployeeName { get; set; }
        [DisplayName("Số điện thoại")]
        public int PhoneNumber { get; set; }
    }
}
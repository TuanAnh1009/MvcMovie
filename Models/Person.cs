using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel;
using System.Collections.Generic;

namespace MvcMovie.Models{
    [Table("Person")]
    public class Person
    {
        [Key]
        public string PersonID { get; set; }
        [DisplayName("Họ và Tên")]
    
        public string PersonName { get; set; }
    }
}
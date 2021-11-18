using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.Generic;
using System.ComponentModel;
namespace MvcMovie.Models
{
    public class People : Person
    {
        public int PeopleId { get; set; }
        [DisplayName("Địa chỉ")]
        public string Address { get; set; }
        [DisplayName("Đại học")]
        public string University { get; set; }
    }
}
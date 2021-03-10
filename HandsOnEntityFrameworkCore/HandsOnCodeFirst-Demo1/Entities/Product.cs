using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace HandsOnCodeFirst_Demo1.Entities
{
    [Table("tbl_products")]
    class Product
    {
       [Key] //set primary key
        public int Pid { get; set; }
        [StringLength(30)]
        [Required] //not null
        public string Pname { get; set; }
        public int? Price { get; set; } //to set columns as null type
    }
}

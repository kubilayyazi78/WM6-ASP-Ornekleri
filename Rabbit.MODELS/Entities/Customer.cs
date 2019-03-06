﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rabbit.MODELS.Entities
{
    [Table("Customers")]
    public class Customer
    {
        [Key]
        public Guid Id { get; set; } = Guid.NewGuid();



        [Required,StringLength(50)]

        public string Name { get; set; }



        [Required, StringLength(50)]
        public string Surname { get; set; }



        [Required, StringLength(11)]
        public string Phone { get; set; }



        [Required, StringLength(50)]
       
        public string Email { get; set; }



        [Required, StringLength(150)]
        public string Address { get; set; }



        public DateTime RegisterDate { get; set; } = DateTime.Now;



    }
}

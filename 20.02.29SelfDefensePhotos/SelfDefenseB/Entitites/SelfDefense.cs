﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace SelfDefenseB.Entites
{
    [Table("tblSelfDefense")]
    public class SelfDefense
    {
        [Key]
        public int Id { get; set; }
        [Required, StringLength(50)]
        public string Name { get; set; }
        [Required, StringLength(50)]
        public string Type { get; set; }
        [Required]
        public decimal Price { get; set; }
        [StringLength(2000)]
        public string Description { get; set; }
        public string Image { get; set; }
    }
}
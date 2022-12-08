﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GroceryStore
{
    [Table("product")] //Tells Dapper what table to use.
    public class Product
    {
        [Key]
        public int id { get; set; }
        public string name { get; set; }
        public string description { get; set; } 
        public decimal price { get; set; }
        public int inventory { get; set; }
        public string category { get; set; }

        public override string ToString()
        {
            return $"{id} {name} {description} ${price} {inventory} {category}";
        }
    }
}

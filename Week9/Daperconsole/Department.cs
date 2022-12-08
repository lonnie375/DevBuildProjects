﻿using Dapper.Contrib.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Daperconsole
{
    [Table("department")] //Tells Dapper what table to use.
    public class Department
    {
        [Key]
        public string id { get; set; }
        public string name { get; set; }
        public string location { get; set; }

        public override string ToString()
        {
            return $"{id} {name} {location}";
        }
    }
}

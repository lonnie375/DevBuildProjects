﻿using Dapper.Contrib.Extensions;

namespace BusinessCRUDDemo.Models
{
    [Table("department")]
    public class Department
    {
        [ExplicitKey]
        public string id { get; set; }

        public string name { get; set; }
        public string location { get; set; }
    }
}

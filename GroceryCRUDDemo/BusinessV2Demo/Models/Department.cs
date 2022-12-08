using Dapper.Contrib.Extensions;
using System.ComponentModel.DataAnnotations.Schema;
using TableAttribute = Dapper.Contrib.Extensions.TableAttribute;

namespace BusinessV2Demo.Models
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


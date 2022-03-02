using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRI.WebAPI.Food.API2._0.Entities
{
    public class Category : BaseEntity
    {
        [Required]
        public string Name { get; set; }

    }
}

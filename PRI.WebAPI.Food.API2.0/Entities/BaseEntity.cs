using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRI.WebAPI.Food.API2._0.Entities
{
    public class BaseEntity
    {
        public Guid Id { get; set; }

        [Required]
        public DateTime CreatedOn { get; set; }

        [Required]
        public DateTime LastEditedOn { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace FinalProject.Models
{
    public class orderstatus
    {
        [Key]
        public int orderstatusId { get; set; }

        [MaxLength(50)]
        public string status { get; set; }

    }
}

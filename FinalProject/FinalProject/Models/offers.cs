using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace FinalProject.Models
{
    public class offers
    {
        [Key]
        public int offerId { get; set; }

        [Required(ErrorMessageResourceName = "offerValue", ErrorMessageResourceType = typeof(Resource))]
        public string offerValue { get; set; }
    }
}

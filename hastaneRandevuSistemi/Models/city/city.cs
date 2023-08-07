using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace hastaneRandevuSistemi.Models.city
{
    public class city
    {

        [Key]
        public int cityId { get; set; }
        public string cityName {get; set;}
        public string county { get; set; }
        

    }
}

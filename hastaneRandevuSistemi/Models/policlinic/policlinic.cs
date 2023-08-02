using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace hastaneRandevuSistemi.Models.policlinic
{
    public class policlinic
    {   [Key]
        public int policlinicId { get; set; } 

        public string policlinicName { get; set; }

        public string policlinicNo { get; set; }


    }
}

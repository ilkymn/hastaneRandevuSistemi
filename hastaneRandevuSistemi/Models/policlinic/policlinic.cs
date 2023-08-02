using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace hastaneRandevuSistemi.Models.policlinic
{
    public class policlinic
    {
        public int policlinicId { get; set; }


        [Display(Name = "Poliklinik Adı")]
        [Required(ErrorMessage = "Bu alanı boş bırakamazsınız!")]
        public string policlinicName { get; set; }

        [Display(Name = "Poliklinik Numarası")]
        [Required(ErrorMessage = "Bu alanı boş bırakamazsınız!")]
        public string policlinicNo { get; set; }


    }
}

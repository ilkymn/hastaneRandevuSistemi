using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;


namespace hastaneRandevuSistemi.Models.login
{
    public class login
    {

        [Display (Name ="Hasta TC Kimlik Numarası")]
        [Required (ErrorMessage ="Bu alanı boş bırakamazsınız!")]
        public long patientTc { get; set; }

        [Display(Name = "Hasta Adı")]
        [Required(ErrorMessage = "Bu alanı boş bırakamazsınız!")]
        public string patientName { get; set; }

        [Display(Name = "Hasta Soyadı")]
        [Required(ErrorMessage = "Bu alanı boş bırakamazsınız!")]
        public string patientSurname { get; set; }

        [Display(Name = "Hasta Parola")]
        [Required(ErrorMessage = "Bu alanı boş bırakamazsınız!")]
        public string patientParola { get; set; }
       

    }
}

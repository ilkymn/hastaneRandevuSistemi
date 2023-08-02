using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace hastaneRandevuSistemi.Models.login
{
    public class login
    {
        public int patientId { get; set; }

       

        [Display(Name = "Hasta Adı")]
        [Required(ErrorMessage = "Bu alanı boş bırakamazsınız!")]
        public string patientName { get; set; }

        [Display(Name = "Hasta Soyadı")]
        [Required(ErrorMessage = "Bu alanı boş bırakamazsınız!")]
        public string patientSurname { get; set; }

        [Display(Name = "Hasta Parola")]
        [Required(ErrorMessage = "Bu alanı boş bırakamazsınız!")]
        [PasswordPropertyText]
        public string patientParola { get; set; }
       

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace hastaneRandevuSistemi.Models.signUp
{
    public class signUp
    {
        public int  patientId { get; set; }

        [Display (Name ="Hasta Tc Kimlik No:")]
        [Required(ErrorMessage = "Bu alanı boş bırakamazsınız!")]
        public long patientTc { get; set; }

        [Display(Name = "Hasta Adı:")]
        [Required(ErrorMessage = "Bu alanı boş bırakamazsınız!")]
        public string patientName { get; set; }

        [Display(Name = "Hasta Soyadı:")]
        [Required(ErrorMessage = "Bu alanı boş bırakamazsınız!")]
        public string patientSurname { get; set; }

        [Display(Name = "Hasta Doğum Tarihi:")]
        [Required(ErrorMessage = "Bu alanı boş bırakamazsınız!")]
        public DateTime patientBirthday { get; set; }

        [Display(Name = "Hasta Telefon Numarası:")]
        [Required(ErrorMessage = "Bu alanı boş bırakamazsınız!")]
        [Phone]
        public int patientPhoneNo { get; set; }

        [Display(Name = "Hasta Mail Adresi:")]
        [EmailAddress]
        public string patientEmail { get; set; }

        [Display(Name = "Hasta Parola:")]
        [Required(ErrorMessage = "Bu alanı boş bırakamazsınız!")]
        [PasswordPropertyText]
        public string patientParola { get; set; }

        [Display(Name = "Hasta Tekrar Parola:")]
        [Required(ErrorMessage = "Bu alanı boş bırakamazsınız!")]
        [PasswordPropertyText]
        public string patientTeParola { get; set; }

        [Display(Name = "Hastanın Yaşadığı Şehir:")]
        [Required(ErrorMessage = "Bu alanı boş bırakamazsınız!")]
        public string patientCity { get; set; }
    }
}

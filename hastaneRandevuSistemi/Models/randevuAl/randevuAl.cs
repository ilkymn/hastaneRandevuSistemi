using System.ComponentModel.DataAnnotations;

namespace hastaneRandevuSistemi.Models.randevuAl
{
    public class randevuAl
    {
        public int hospitalId { get; set; }



        public int hospitalNumber { get; set; }


        [Display(Name = "Hastaneler")]
        [Required(ErrorMessage = "Bu alanı boş bırakamazsınız!")]
        public string hospitalName { get; set; }

        public int policlinicId { get; set; }



        [Display(Name = "Poliklinikler")]
        [Required(ErrorMessage = "Bu alanı boş bırakamazsınız!")]
        public string policlinicName { get; set; }

        [Display(Name = "Poliklinik Numarası")]
        [Required(ErrorMessage = "Bu alanı boş bırakamazsınız!")]
        public string policlinicNo { get; set; }



        public int DoctorId { get; set; }

        [Display(Name = "Doktorlar")]
        [Required(ErrorMessage = "Bu alanı boş bırakamazsınız!")]
        public string DoctorName { get; set; }


    }
}
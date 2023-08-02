using System.ComponentModel.DataAnnotations;

namespace hastaneRandevuSistemi.Models.doctors
{
    public class Doctors
    {
        [Key]
        public int DoctorId { get; set; }
        public string DoctorName { get; set; }
        public string DoctorAlan { get; set;}
        
    }
}

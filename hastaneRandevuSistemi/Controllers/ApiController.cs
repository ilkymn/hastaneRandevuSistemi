using hastaneRandevuSistemi.Models.city;
using hastaneRandevuSistemi.Models.doctors;
using hastaneRandevuSistemi.Models.hospital;
using hastaneRandevuSistemi.Models.patientsModel;
using hastaneRandevuSistemi.Models.policlinic;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;


namespace hastaneRandevuSistemi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ApiController : ControllerBase
    {
       public static List<cityContext> city = new List<cityContext>();
       public static List<doctorsContext> doctors = new List<doctorsContext>();
       public static List<HospitalContext> Hospital = new List<HospitalContext>();
       public static List<PatientsContext> Patients = new List<PatientsContext>();
       public static List<PoliclinicContext> Policlinic = new List<PoliclinicContext>();
  
        /*cityContext c = new cityContext();
        [HttpGet]
        public IEnumerable<string> Get() { 
        var city = c.city.ToList();
            return new string[]("value1,value2");
        }
        [HttpGet("{id}")]
        public string Get(int id)
        {
            var city = c.city.FirstOrDefault(x=>x.cityId==id  ); 
            return "value";
        }*/

    }

}

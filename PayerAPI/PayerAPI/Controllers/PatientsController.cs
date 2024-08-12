using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using PayerAPI.Model;
using System.Linq;

namespace PayerAPI.Controllers

{
    [Route("api/[controller]")]
    [ApiController]
    public class PatientsController : ControllerBase
    {
        private static readonly List<PatientModel> model = new List<PatientModel>
        {
            new PatientModel { Id=1,PatientName="abc"}

        };

        

        [HttpGet("GetList")]
        public IActionResult Get()
        {

            return Ok(model);
        }


        [HttpGet("GetPatient/{id}")]
        public IActionResult Get(int id)
        {
            var y = model.Where<PatientModel>(x => x.Id == id);
           
            if (y.Any())
            return Ok(model.Where<PatientModel>(x => x.Id == id));
            return NotFound("No Data Avaliable");


        }


        [HttpPost("AddPatient")]
        public IActionResult Post(PatientModel value)
        {
            var y = model.Where<PatientModel>(x => x.Id == value.Id);

            if (y.Any())
                return BadRequest("AlreadyExist");


                model.Add(value);

            return Ok("PatientAddedSucessfully");
        }

        [HttpPut("UpdatePatient")]
        public IActionResult UpdatePatient(PatientModel value)
        {
            var y = model.Where<PatientModel>(x => x.Id == value.Id);
            
            if (y.Any())
            {
                var z=  (PatientModel)model.Where<PatientModel>(x => x.Id == value.Id);
                model.Remove(z);
                model.Add(value);
                return Ok("PatientAddedSucessfully");
            }
            else
                return BadRequest("NotFound");


        }
    }
}

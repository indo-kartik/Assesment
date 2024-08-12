using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using PayerAPI.Model;
using PayerAPI.Service;
using System.Linq;


namespace PayerAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PayerController : ControllerBase
    {
        private static readonly List<PayerModel> model = new List<PayerModel>
        {
            new PayerModel { Id=1,PayerName="Kartik"}

        };


       

        [HttpGet("GetList")]
        public IActionResult Get()
        {

            return Ok(model);
        }

        
        [HttpGet("GetPayer/{id}")]
        public IActionResult Get(int id)
        {

            var y = model.Where<PayerModel>(x => x.Id == id);

            if (y.Any())
            return Ok(model.Where<PayerModel>(x => x.Id == id));

            return BadRequest("NotFound");
        }


        [HttpPost("AddPayer")]
        public IActionResult Post(PayerModel value)
        {

            var y = model.Where<PayerModel>(x => x.Id == value.Id);

            if (y.Any())
                return BadRequest("PayerAlreadyExist");
                model.Add(value);

            return Ok("PayerAddedSucessfully");
        }

       
    }
}

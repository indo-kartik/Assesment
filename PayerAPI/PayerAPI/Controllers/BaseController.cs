using Microsoft.AspNetCore.Mvc;
using PayerAPI.Model;

namespace PayerAPI.Controllers
{
    public class BaseController : ControllerBase
    {
        private static readonly List<PatientModel> model = new List<PatientModel>
        {
            new PatientModel { Id=1,PatientName="abc"}

        };
    }
}

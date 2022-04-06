using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Web.BE.Model.Trainings;

namespace Web.BE.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TrainingController : ControllerBase
    {
        [HttpGet]
        public IActionResult GetTrainings()
        {
            var trainings = new List<Training>();
            trainings.Add(new Training()
            {
                Description = "Test",
                IssuedDate = DateTime.Now,
                Issuer = "UBT",
                Title = "Test",

            });
            return Ok(trainings);
        }
    }
}

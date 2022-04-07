using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Web.BE.Model.Trainings;
using Web.BE.Services;

namespace Web.BE.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TrainingController : ControllerBase
    {
        private readonly TrainingService _trainingService;
        public TrainingController(TrainingService trainingService)
        {
            _trainingService = trainingService;
        }


        [HttpGet]
        public async Task<ActionResult<List<Model.Trainings.Training>>> GetTrainings()
        {
            var trainings = await _trainingService.GetTrainingsAsync();
            if (trainings != null)
                return Ok(trainings);

            return NotFound("No trainings were found");
        }
    }
}


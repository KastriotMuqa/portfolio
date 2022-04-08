using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Web.BE.Model.Trainings;
using Web.BE.Services;

namespace Web.BE.Controllers
{
    [Route("api")]
    [ApiController]
    public class TrainingsController : ControllerBase
    {
        private readonly TrainingService _trainingService;
        public TrainingsController(TrainingService trainingService)
        {
            _trainingService = trainingService;
        }


        [HttpGet("trainings")]
        [ProducesResponseType(200)]
        [ProducesResponseType(404)]
        public async Task<ActionResult<List<Model.Trainings.TrainingDto>>> GetTrainings()
        {
            var trainings = await _trainingService.GetTrainingsAsync();
            if (trainings != null)
                return Ok(trainings);

            return NotFound("No trainings were found");
        }


        [HttpGet("trainings/{id:int}")]
        [ProducesResponseType(200)]
        [ProducesResponseType(404)]
        public async Task<ActionResult<Model.Trainings.TrainingDto>> GetTraining(int id)
        {
            var training = await _trainingService.GetTrainingAsync(id);
            if (training != null)
                return Ok(training);

            return NotFound("No trainings was found");
        }

        [HttpPost("trainings")]
        [ProducesResponseType(201)]
        [ProducesResponseType(404)]
        public async Task<ActionResult<Model.Trainings.TrainingDto>> CreateTraining([FromForm]TrainingDto training)
        {
            var trainingDto = await _trainingService.CreateTrainingAsync(training);
            if (trainingDto !=null)
                return CreatedAtAction(nameof(GetTraining), new { id = training.Id }, training);

            return BadRequest("Bad request");
        }
    }
}


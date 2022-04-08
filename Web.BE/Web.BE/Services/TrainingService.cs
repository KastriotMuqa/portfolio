using AutoMapper;
using Web.BE.Repository;

namespace Web.BE.Services
{
    public class TrainingService
    {
        private readonly TrainingRepository _repository;
        private readonly IMapper _mapper;

        public TrainingService(TrainingRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task<List<Model.Trainings.TrainingDto>> GetTrainingsAsync()
        {
            var trainings = await _repository.GetTrainingsAsync();
            var trainingDtos = _mapper.Map<List<Model.Trainings.TrainingDto>>(trainings);
            return trainingDtos;
        }

        public async Task<Model.Trainings.TrainingDto> GetTrainingAsync(int id)
        {
            var training = await _repository.GetTrainingAsync(id);
            var trainingDto = _mapper.Map<Model.Trainings.TrainingDto>(training);
            return trainingDto;
        }

        public async Task<Model.Trainings.TrainingDto?> CreateTrainingAsync(Model.Trainings.TrainingDto training)
        {
            if (training == null && training?.Title == null && training?.Issuer == null) return null;

            var trainingEntity = _mapper.Map<Model.Entities.Training>(training);
            await _repository.AddTrainingAsync(trainingEntity);
            await _repository.SaveChangesAsync();

            return _mapper.Map<Model.Trainings.TrainingDto>(trainingEntity);
        }
    }
}

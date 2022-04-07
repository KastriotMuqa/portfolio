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


        public async Task<List<Model.Trainings.Training>> GetTrainingsAsync()
        {
            var trainings = await _repository.GetTrainingAsync();
            var trainingDtos = _mapper.Map<List<Model.Trainings.Training>>(trainings);

            return trainingDtos;
        }
    }
}

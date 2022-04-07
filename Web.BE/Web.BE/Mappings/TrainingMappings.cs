using AutoMapper;

namespace Web.BE.Mappings
{
    public class TrainingMappings : Profile
    {
        public TrainingMappings()
        {
            _ = CreateMap<Model.Entities.Training, Model.Trainings.Training>();
        }
    }
}

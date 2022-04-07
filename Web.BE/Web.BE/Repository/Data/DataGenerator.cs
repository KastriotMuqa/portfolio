using Microsoft.EntityFrameworkCore;
using Web.BE.Repository.Context;

namespace Web.BE.Repository.Data
{
    public class DataGenerator
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new AppDbContext(
                serviceProvider.GetRequiredService<DbContextOptions<AppDbContext>>()))
            {
                if (context.Trainings.Any())
                {
                    return;
                }

                context.Trainings.AddRange(
                    new Model.Entities.Training
                    {
                        Description = "",
                        IssuedDate = DateTime.Parse("2021-10-10"),
                        Id = 1,
                        Issuer = "Ubt College",
                        Title = "Java Course"
                    },
                    new Model.Entities.Training
                    {
                        Description = "",
                        IssuedDate = DateTime.Parse("2021-06-03"),
                        Id = 2,
                        Issuer = "ICK",
                        Title = "Cyber Unity"
                    },
                    new Model.Entities.Training
                    {
                        Description = "",
                        IssuedDate = DateTime.Parse("2022-02-01"),
                        Id = 3,
                        Issuer = "Datacamp",
                        Title = "Training:SQDeveloperL Path for"
                    },
                   new Model.Entities.Training
                   {
                       Description = "",
                       IssuedDate = DateTime.Parse("2021-10-10"),
                       Id = 4,
                       Issuer = "Ubt College",
                       Title = "Java Course"
                   },
                    new Model.Entities.Training
                    {
                        Description = "",
                        IssuedDate = DateTime.Parse("2021-10-10"),
                        Id = 5,
                        Issuer = "Ubt College",
                        Title = "Java Course"
                    },
                    new Model.Entities.Training
                    {
                        Description = "",
                        IssuedDate = DateTime.Parse("2021-10-10"),
                        Id = 6,
                        Issuer = "Ubt College",
                        Title = "Java Course"
                    });

                context.SaveChanges();
            }
        }
    }
}

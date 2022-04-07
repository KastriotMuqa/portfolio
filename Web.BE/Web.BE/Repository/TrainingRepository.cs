﻿using Microsoft.EntityFrameworkCore;
using Web.BE.Repository.Context;

namespace Web.BE.Repository
{
    public class TrainingRepository
    {
        private readonly AppDbContext _context;

        public TrainingRepository(AppDbContext context)
        {
            _context = context;
        }

        public async Task<List<Model.Entities.Training>> GetTrainingsAsync()
        {
            return await _context.Trainings.ToListAsync();
        }

        public async Task<Model.Entities.Training> GetTrainingAsync(int id)
        {
            return await _context.Trainings.FindAsync(id);
        }
    }
}

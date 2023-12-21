using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using System.Numerics;
using Gatekeeper.Models;
using Gatekeeper.Interfaces;

namespace Gatekeeper.Services
{
    public class LkProcessingdeficiencyService : ILkProcessingdeficiencyService
    {
        private AppDbContext _context;

        public LkProcessingdeficiencyService(AppDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<LkProcessingdeficiency>> GetLkProcessingdeficiencyList()
        {
            return await _context.LkProcessingdeficiencies
                    .ToListAsync();
        }
    
        public async Task<LkProcessingdeficiency> GetLkProcessingdeficiencyById(int id)
        {
            return await _context.LkProcessingdeficiencies
                .FirstOrDefaultAsync(x => x.Id == id);
        }

        public async Task<LkProcessingdeficiency> CreateLkProcessingdeficiency(LkProcessingdeficiency lkprocessingdeficiency)
        {
            _context.LkProcessingdeficiencies.Add(lkprocessingdeficiency);
            await _context.SaveChangesAsync();
            return lkprocessingdeficiency;
        }
        public async System.Threading.Tasks.Task UpdateLkProcessingdeficiency(LkProcessingdeficiency lkprocessingdeficiency)
        {
            _context.LkProcessingdeficiencies.Update(lkprocessingdeficiency);
            await _context.SaveChangesAsync();
        }

        public async System.Threading.Tasks.Task DeleteLkProcessingdeficiency(LkProcessingdeficiency lkprocessingdeficiency)
        {
            _context.LkProcessingdeficiencies.Remove(lkprocessingdeficiency);
            await _context.SaveChangesAsync();
        }

    }
}

using Microsoft.EntityFrameworkCore;
using personaapi_dotnet.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace personaapi_dotnet.Repositories
{
    public class ProfesionRepository : IProfesionRepository
    {
        private readonly MasterContext _context;

        public ProfesionRepository(MasterContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Profesion>> GetAllProfesiones()
        {
            return await _context.Profesions.ToListAsync();
        }

        public async Task<Profesion> GetProfesionById(int id)
        {
            return await _context.Profesions.FindAsync(id);
        }

        public async Task AddProfesion(Profesion profesion)
        {
            _context.Add(profesion);
            await _context.SaveChangesAsync();
        }

        public async Task UpdateProfesion(Profesion profesion)
        {
            _context.Update(profesion);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteProfesion(int id)
        {
            var profesion = await _context.Profesions.FindAsync(id);
            if (profesion != null)
            {
                _context.Profesions.Remove(profesion);
                await _context.SaveChangesAsync();
            }
        }

        public bool ProfesionExists(int id)
        {
            return _context.Profesions.Any(e => e.Id == id);
        }
    }
}

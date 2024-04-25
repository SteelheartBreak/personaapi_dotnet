using Microsoft.EntityFrameworkCore;
using personaapi_dotnet.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace personaapi_dotnet.Repositories
{
    public class TelefonoRepository : ITelefonoRepository
    {
        private readonly MasterContext _context;

        public TelefonoRepository(MasterContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Telefono>> GetAllTelefonos()
        {
            return await _context.Telefonos.ToListAsync();
        }

        public async Task<Telefono> GetTelefonoById(string id)
        {
            return await _context.Telefonos.FindAsync(id);
        }

        public async Task AddTelefono(Telefono telefono)
        {
            _context.Add(telefono);
            await _context.SaveChangesAsync();
        }

        public async Task UpdateTelefono(Telefono telefono)
        {
            _context.Update(telefono);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteTelefono(string id)
        {
            var telefono = await _context.Telefonos.FindAsync(id);
            if (telefono != null)
            {
                _context.Telefonos.Remove(telefono);
                await _context.SaveChangesAsync();
            }
        }

        public bool TelefonoExists(string id)
        {
            return _context.Telefonos.Any(e => e.Num == id);
        }
    }
}

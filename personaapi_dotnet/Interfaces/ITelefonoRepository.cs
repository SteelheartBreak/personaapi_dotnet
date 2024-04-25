using personaapi_dotnet.Models.Entities;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace personaapi_dotnet.Repositories
{
    public interface ITelefonoRepository
    {
        Task<IEnumerable<Telefono>> GetAllTelefonos();
        Task<Telefono> GetTelefonoById(string id);
        Task AddTelefono(Telefono telefono);
        Task UpdateTelefono(Telefono telefono);
        Task DeleteTelefono(string id);
        bool TelefonoExists(string id);
    }
}

using personaapi_dotnet.Models.Entities;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace personaapi_dotnet.Repositories
{
    public interface IPersonaRepository
    {
        Task<IEnumerable<Persona>> GetAllPersonas();
        Task<Persona> GetPersonaByCc(int cc);
        Task<Persona> GetPersonaById(int id);
        Task AddPersona(Persona persona);
        Task UpdatePersona(Persona persona);
        Task DeletePersona(int id);
        bool PersonaExists(int id);
    }
}

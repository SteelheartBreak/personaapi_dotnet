using personaapi_dotnet.Models.Entities;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace personaapi_dotnet.Repositories
{
    public interface IProfesionRepository
    {
        Task<IEnumerable<Profesion>> GetAllProfesiones();
        Task<Profesion> GetProfesionById(int id);
        Task AddProfesion(Profesion profesion);
        Task UpdateProfesion(Profesion profesion);
        Task DeleteProfesion(int id);
        bool ProfesionExists(int id);
    }
}

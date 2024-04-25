using personaapi_dotnet.Models.Entities;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace personaapi_dotnet.Repositories
{
    public interface IEstudioRepository
    {
        Task<IEnumerable<Estudio>> GetAllEstudios();
        Task<Estudio> GetEstudioById(int idProf, int ccPer);
        Task AddEstudio(Estudio estudio);
        Task UpdateEstudio(Estudio estudio);
        Task DeleteEstudio(int idProf, int ccPer);
        bool EstudioExists(int id);
    }
}

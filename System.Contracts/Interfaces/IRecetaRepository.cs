using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Dominio.Entities;

namespace System.Contracts.Interfaces
{
    public interface IRecetaRepository
    {
        ///CRUD
        void AddReceta(Receta receta);
        Receta? GetRecetaByID(Guid id);
        public IEnumerable<Receta> GetAllReceta();
        void UpdateReceta(Receta receta);
        void DeleteReceta(Receta receta);
    }
}

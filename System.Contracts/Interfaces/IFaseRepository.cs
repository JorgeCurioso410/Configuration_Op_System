using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Dominio.Entities;

namespace System.Contracts
{
    public interface IFaseRepository
    {
        ///CRUD
        void AddFase(Fase fase);
        Fase? GetFaseByID(Guid id);
        public IEnumerable<Fase> GetAllFase();
        void UpdateFase(Fase fase);
        void DeleteFase(Fase fase);
    }
}

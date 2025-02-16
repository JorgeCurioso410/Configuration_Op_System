using System.DataAccess.Context;
using System.DataAccess.Repos.Common;
using System.Dominio.Entities;
using System.Contracts;

namespace System.DataAccess.Repos.RepoEntities
{
    ///Implementacion de los CRUD
    public class FaseRepository : RepositoryBase, IFaseRepository
    {
        public FaseRepository(ApplicationContext context) : base(context)
            { }
        public void AddFase(Fase fase)
        {
            _context.FaseList.Add(fase);
        }
        public void DeleteFase(Fase fase)
        {
            _context.FaseList.Remove(fase);
        }
        public IEnumerable<Fase> GetAllFase()
        {
            return _context.FaseList.ToList();
        }
        public Fase? GetFaseByID(Guid id)
        {
            return _context.FaseList.FirstOrDefault(x => x.Id == id);
        }
        public void UpdateFase(Fase fase)
        {
            _context.FaseList.Update(fase);
        }
    }
}


using System.DataAccess.Context;
using System.DataAccess.Repos.Common;
using System.Dominio.Entities;
using System.Contracts.Interfaces;

namespace System.DataAccess.Repos.RepoEntities
{
    ///Implementacion de los CRUD
    public class RecetaRepository : RepositoryBase, IRecetaRepository
    {
        public RecetaRepository(ApplicationContext context) : base(context) { }
        public void AddReceta(Receta receta)
        {
            _context.RecetaList.Add(receta);    
        }
        public void DeleteReceta(Receta receta)
        {
            _context.RecetaList.Remove(receta);
        }
        public IEnumerable<Receta> GetAllReceta()
        {
            return _context.RecetaList.ToList();
        }
        public Receta? GetRecetaByID(Guid id)
        {
            return _context.RecetaList.FirstOrDefault(x => x.Id == id);
        }
        public void UpdateReceta(Receta receta)
        {
            _context.RecetaList.Update(receta);
        }
    }
}


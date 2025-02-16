
using System.DataAccess.Context;
using System.DataAccess.Repos.Common;
using System.Dominio.Entities;
using System.Contracts.Interfaces;



namespace System.DataAccess.Repos.RepoEntities
{
    ///Implementacion de los CRUD
    public class OperacionRepository : RepositoryBase, IOperacionRepository
    {
        public OperacionRepository(ApplicationContext context) : base(context)
            { }
        public void AddOperacion(Operacion operacion)
        {
            _context.OperacionList.Add(operacion);
        }
        public void DeleteOperacion(Operacion operacion)
        {
            _context.OperacionList.Remove(operacion);
        }
        public IEnumerable<Operacion> GetAllOperaciones()
        {
            return _context.OperacionList.ToList();
        }
        public Operacion? GetOperacionByID(Guid id)
        {
            return _context.OperacionList.FirstOrDefault(x => x.Id == id);
        }
        public void UpdateOperacion(Operacion operacion)
        {
            _context.OperacionList.Update(operacion);
        }

    }
}

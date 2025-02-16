using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Dominio.Entities;

namespace System.Contracts.Interfaces
{
    public interface IOperacionRepository
    {
        ///CRUD
        void AddOperacion(Operacion operacion);
        Operacion? GetOperacionByID(Guid id);
        public IEnumerable<Operacion> GetAllOperaciones();
        void UpdateOperacion(Operacion operacion);
        void DeleteOperacion(Operacion operacion );
    }
}

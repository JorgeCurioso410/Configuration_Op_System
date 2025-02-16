
using System.Dominio.Common;

namespace System.Dominio.Entities
{
    public class Receta : Entity
    {
        public string Nombre { get; set; }
        public string Code { get; set; }
        public string Descripcion { get; set; }
        public string CodigoUnidad { get; set; }

        public List<Fase> FaseList { get; set; }
        public List<Operacion> OperacionList { get; set; }

        protected Receta() { }

        public Receta(Guid id, string r_nombre, string r_code, string r_descripcion, string codigoUnidad) : base(id)
        {
            Nombre = r_nombre;
            Code = r_code;
            Descripcion = r_descripcion;
            CodigoUnidad = codigoUnidad;
            OperacionList = new List<Operacion>();
            FaseList = new List<Fase>();
        }

    }
}

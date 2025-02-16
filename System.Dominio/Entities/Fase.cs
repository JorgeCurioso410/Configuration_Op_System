using System.Dominio.Common;

namespace System.Dominio.Entities
{
    public class Fase : Entity
    {
        public string Code;
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public List<Receta> RecetaList { get; set; }
        public List<Operacion> OperacionList { get; set; }

        protected Fase() { }
        public Fase(Guid id,string nombre, string code, string descripcion) : base(id)
        {
            Nombre = nombre;
            Code = code;
            Descripcion = descripcion;
            RecetaList = new List<Receta>();
            OperacionList = new List<Operacion>();
        }

    }
}


using System.Dominio.Common;


namespace System.Dominio.Entities
{
    public class Operacion : Entity
    {
        public string Nombre { get; set; }
        public string Code { get; set; }
        public string Descripcion { get; set; }
        public string CodigoUnidad { get; set; }
        public List<Receta> RecetaList { get; set; }
        public List<Fase> FaseList { get; set; }

        protected Operacion() { }
        public Operacion(Guid id, string o_nombre, string o_code, string o_descripcion, string codigoUnidad) : base(id)
        {
            Nombre = o_nombre;
            Code = o_code;
            Descripcion = o_descripcion;
            CodigoUnidad = codigoUnidad;
            RecetaList = new List<Receta>();
            FaseList = new List<Fase>();
        }

    }
}

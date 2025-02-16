using Microsoft.EntityFrameworkCore;
using System.DataAccess.Context;


namespace System.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /// Creando un Contexto para interactuar con la Base de Datos
            ApplicationContext appContext = new ApplicationContext("Data Source= SystemDB.sqlite");
            /// Verificando si la BD no existe
            if (!appContext.Database.CanConnect())
            {
                ///Migrando base de datos. Genera la BD con las tablas confiuguradas en su migracion.
                appContext.Database.Migrate();
            }
        }
    }
}


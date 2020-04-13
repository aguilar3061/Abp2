using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.BD
{
    public static class ORM
    {
        public static chrysallis_grupo3Entities4 bd = new chrysallis_grupo3Entities4();

        public static String mensaje(SqlException ex)
        {
            String mensaje;
            switch (ex.Number)
            {
                case -1:
                    mensaje = ex.Number + "Error de conexión con el servidor";
                    break;
                case 547:
                    mensaje = ex.Number + "Tiene datos relacionados";
                    break;
                case 2601:
                    mensaje = ex.Number + "Datos duplicados";
                    break;
                case 2627:
                    mensaje = ex.Number + "Datos duplicados";
                    break;
                case 4060:
                    mensaje = ex.Number + "No se encuentra la Base de datos";
                    break;
                case 18456:
                    mensaje = ex.Number + "Usuario o contraseña incorrecto";
                    break;
                default:
                    mensaje = ex.Number + ", " + ex.Message;
                    break;
            }

            return mensaje;

        }
        public static void RejectChanges()
        {
            foreach (DbEntityEntry entry in bd.ChangeTracker.Entries())
            {
                switch (entry.State)
                {
                    case EntityState.Modified:
                        entry.State = EntityState.Unchanged;
                        break;
                    case EntityState.Added:
                        entry.State = EntityState.Detached;
                        break;
                    case EntityState.Deleted:
                        entry.Reload();
                        break;
                    default: break;
                }
            }
        }
    }
}

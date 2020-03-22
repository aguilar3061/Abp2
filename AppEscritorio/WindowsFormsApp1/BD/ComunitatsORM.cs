using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.BD
{
    public static class ComunitatsORM
    {
        public static List<Comunitat> SelectAllComunitats()
        {
            List<Comunitat> comunitats =
                (
                from p in ORM.bd.Comunitat
                select p
                ).ToList();
            return comunitats;
        }
    }
}

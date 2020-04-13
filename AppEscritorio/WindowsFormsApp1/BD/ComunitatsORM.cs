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


        //public static int BuscarRelacionSocio(Socis socio)
        //{


        //    //int id_comunidad =
        //    //    (
      

        //    //    );


        //    //from tablaSoci in ORM.bd.Socis
        //    //join tablaComun in ORM.bd.Comunitat
        //    //on tablaSoci.id = tablaComun.id_Soci
        //    //                     select tablaSoci

        //    //SELECT id_Comunitat
        //    //FROM Socis
        //    //RIGHT JOIN Comunitat_Soci
        //    //ON Socis.id = Comunitat_Soci.id_Soci;

        //    return id_comunidad;
        //}









    }




}

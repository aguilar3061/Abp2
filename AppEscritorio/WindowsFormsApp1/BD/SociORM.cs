using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.Entity.Infrastructure;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.BD
{
    public static class SociORM
    {



        public static String InsertSoci(Boolean activo, Boolean administrador,String Correu, String Nom, String Cognoms, String Telefon, String DNI, Comunitat comunidad)
        {

            String mensaje = "";
            String contrasenya = "1234";

            //Hash hash = new Hash();
            //SHA512.Create(contrasenya);
            //hash.Sha512(contrasenya);


            Socis soci = new Socis();

            soci.actiu = activo;
            soci.administrador= administrador;
            soci.mail = Correu;
            soci.nom = Nom;
            soci.cognoms = Cognoms;
            soci.contrasenya = null;
            soci.telefon = Telefon;
            soci.DNI = DNI;


            





            if (administrador != true)
            {
                soci.id_comunitat_admin = null;
            }
            else
            {
                soci.id_comunitat_admin = comunidad.id;
                soci.contrasenya = "1234";
            }
            

            



            ORM.bd.Socis.Add(soci);






            try
            {
                ORM.bd.SaveChanges();
            }
            catch (DbUpdateException ex)
            {
                ORM.RejectChanges();
                SqlException sqlEx = (SqlException)ex.InnerException.InnerException;
                mensaje = ORM.mensaje(sqlEx);

            }

            return mensaje;

        }





        public static List<Socis> SelectunSoci(int idSoci)
        {
            

            List<Socis> socio =
            (
                from p in ORM.bd.Socis
                where p.id == idSoci
                select p

            ).ToList();

            return socio;
        }
        public static List<Socis> SelectAllSocis()
        {

            List<Socis> socio =
            (
                from p in ORM.bd.Socis
                select p

            ).ToList();

            return socio;

        }



        public static String UpdateSocio(Socis socioM)
        {
            String mensaje = "";
            try
            {

                ORM.bd.SaveChanges();

            }
            catch (DbUpdateException ex)
            {
                ORM.RejectChanges();
                SqlException sqlEx = (SqlException)ex.InnerException.InnerException;
                mensaje = ORM.mensaje(sqlEx);

            }
            return mensaje;
        }






    }
}

using OC.Core.Crypto;
using System;
using System.Collections.Generic;
using System.Data.Entity.Infrastructure;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.BD
{
    public static class SociORM
    {



        public static String InsertSoci(Boolean administrador,String Correu, String Nom, String Cognoms, String Telefon, String DNI, int idComunitatAdmin)
        {
            String mensaje = "";

            String contrasenya = "1234";

            //Hash hash = new Hash();
            //SHA512.Create(contrasenya);
            //hash.Sha512(contrasenya);
            Socis soci = new Socis();

            soci.actiu = true;
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
                soci.id_comunitat_admin = idComunitatAdmin;
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


        public static List<Socis> SelectAllsocis()
        {

            List<Socis> socis =
            (
                from p in ORM.bd.Socis
                select p

            ).ToList();

            return socis;

        }


    }
}

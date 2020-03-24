using System;
using System.Collections.Generic;
using System.Data.Entity.Infrastructure;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.BD
{
    public static class EventoORM
    {


        public static String UpdateHotel(Esdeveniment hotelM)
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








        public static List<Esdeveniment> SelectAllEventos()
        {

            List<Esdeveniment> hotels =
            (
                from p in ORM.bd.Esdeveniment
                select p

            ).ToList();

            return hotels;

        }

        public static List<Esdeveniment> SelectAllEventosPorComunidad(int idComunitat)
        {

            List<Esdeveniment> listEventos =
            (
                from p in ORM.bd.Esdeveniment
                where p.id_Comunitat == idComunitat
                select p

            ).ToList();

            return listEventos;

        }
        public static String DeleteEvento(Esdeveniment esdevenimentEliminar)
        {
            String mensaje="";
             ORM.bd.Esdeveniment.Remove(esdevenimentEliminar);
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
        public static String InsertEvento(DateTime dataInici, DateTime horaInici, int idComunitat, DateTime fechaFin, DateTime horaFinal, String Direccion, String NombreEvento )
        {
            String mensaje = "";

            Esdeveniment esdeveniment = new Esdeveniment();
            
            esdeveniment.fechaInicio = dataInici;
            esdeveniment.horaInicio = horaInici.TimeOfDay;
            esdeveniment.id_Comunitat = idComunitat;
            esdeveniment.fechaFin = fechaFin;
            esdeveniment.horaFin = horaFinal.TimeOfDay;
            esdeveniment.NombreEvento = Direccion;
            esdeveniment.Direccio = NombreEvento;



            ORM.bd.Esdeveniment.Add(esdeveniment);

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

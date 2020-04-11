using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.BD
{
    public static class AssistirORM
    {

        public static List<Assistir> SelectAllAssitir(int idEsdeveniment)
        {
            List<Assistir> assistir =
                (
                from p in ORM.bd.Assistir where p.id_Esdeveiment == idEsdeveniment
                select p
                ).ToList();
            return assistir;
        }
    }
}

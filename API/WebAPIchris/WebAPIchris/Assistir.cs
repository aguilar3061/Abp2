//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WebAPIchris
{
    using System;
    using System.Collections.Generic;
    
    public partial class Assistir
    {
        public int id_Soci { get; set; }
        public int id_Esdeveiment { get; set; }
        public Nullable<int> valoracio { get; set; }
        public string comentari { get; set; }
        public Nullable<bool> aiste { get; set; }
    
        public virtual Esdeveniment Esdeveniment { get; set; }
        public virtual Soci Soci { get; set; }
    }
}

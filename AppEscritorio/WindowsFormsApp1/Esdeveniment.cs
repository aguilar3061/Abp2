//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WindowsFormsApp1
{
    using System;
    using System.Collections.Generic;
    
    public partial class Esdeveniment
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Esdeveniment()
        {
            this.Assistir = new HashSet<Assistir>();
            this.Documents = new HashSet<Documents>();
            this.Notificacions = new HashSet<Notificacions>();
        }
    
        public int id { get; set; }
        public System.DateTime fechaInicio { get; set; }
        public System.TimeSpan horaInicio { get; set; }
        public string NombreEvento { get; set; }
        public string Direccio { get; set; }
        public int id_Comunitat { get; set; }
        public System.DateTime fechaFin { get; set; }
        public Nullable<System.TimeSpan> horaFin { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Assistir> Assistir { get; set; }
        public virtual Comunitat Comunitat { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Documents> Documents { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Notificacions> Notificacions { get; set; }
    }
}
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
    
    public partial class Socis
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Socis()
        {
            this.Assistir = new HashSet<Assistir>();
            this.Comunitat1 = new HashSet<Comunitat>();
        }
    
        public int id { get; set; }
        public string telefon { get; set; }
        public string mail { get; set; }
        public string nom { get; set; }
        public string cognoms { get; set; }
        public string contrasenya { get; set; }
        public bool actiu { get; set; }
        public bool administrador { get; set; }
        public Nullable<int> id_comunitat_admin { get; set; }
        public string DNI { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Assistir> Assistir { get; set; }
        public virtual Comunitat Comunitat { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Comunitat> Comunitat1 { get; set; }
    }
}

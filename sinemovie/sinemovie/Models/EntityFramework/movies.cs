//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace sinemovie.Models.EntityFramework
{
    using System;
    using System.Collections.Generic;
    
    public partial class movies
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public movies()
        {
            this.actors = new HashSet<actors>();
            this.comments = new HashSet<comments>();
        }
    
        public int id { get; set; }
        public string name { get; set; }
        public string release_date { get; set; }
        public string time { get; set; }
        public string genre { get; set; }
        public string director { get; set; }
        public string summary { get; set; }
        public string poster { get; set; }
        public string fragman { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<actors> actors { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<comments> comments { get; set; }
    }
}

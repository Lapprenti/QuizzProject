//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace QuizzMotorsport.DAL
{
    using System;
    using System.Collections.Generic;
    
    public partial class quizz
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public quizz()
        {
            this.questions = new HashSet<question>();
        }
    
        public short idquizz { get; set; }
        public short idjoueur { get; set; }
        public Nullable<decimal> resultat { get; set; }
    
        public virtual joueur joueur { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<question> questions { get; set; }
    }
}

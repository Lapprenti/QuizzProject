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
    
    public partial class question
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public question()
        {
            this.responses = new HashSet<response>();
        }
    
        public short idquestion { get; set; }
        public string intitule { get; set; }
        public string image { get; set; }
        public Nullable<System.TimeSpan> temps { get; set; }
        public Nullable<short> idquizz { get; set; }
    
        public virtual quizz quizz { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<response> responses { get; set; }
    }
}

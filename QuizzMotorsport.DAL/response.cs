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
    
    public partial class response
    {
        public short idréponse { get; set; }
        public short idquestion { get; set; }
        public string libelle { get; set; }
        public Nullable<bool> juste { get; set; }
    
        public virtual question question { get; set; }
    }
}

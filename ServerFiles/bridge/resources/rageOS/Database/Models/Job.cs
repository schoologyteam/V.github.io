//------------------------------------------------------------------------------
// <auto-generated>
//    Dieser Code wurde aus einer Vorlage generiert.
//
//    Manuelle Änderungen an dieser Datei führen möglicherweise zu unerwartetem Verhalten Ihrer Anwendung.
//    Manuelle Änderungen an dieser Datei werden überschrieben, wenn der Code neu generiert wird.
// </auto-generated>
//------------------------------------------------------------------------------

namespace RageOS.Database.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Job
    {
        public int Id { get; set; }
        public int CharacterId { get; set; }
        public Nullable<JobTypes> JobType { get; set; }
        public int JobLevel { get; set; }
        public int EXPToNextLevel { get; set; }
        public int EXPInThisLevel { get; set; }
        public int CompaniesId { get; set; }
    
        public virtual Character characters { get; set; }
        public virtual Company companies { get; set; }
    }
}

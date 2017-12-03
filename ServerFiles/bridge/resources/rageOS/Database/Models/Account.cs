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
    
    public partial class Account
    {
        public Account()
        {
            this.characters = new HashSet<Character>();
        }
    
        public int Id { get; set; }
        public string EMail { get; set; }
        public string Password { get; set; }
        public CopLevel CopLevel { get; set; }
        public JustizLevel JustizLevel { get; set; }
        public AdminLevel AdminLevel { get; set; }
        public MedicLevel MedicLevel { get; set; }
        public bool IsOnline { get; set; }
        public bool IsBanned { get; set; }
        public Nullable<System.DateTime> BanTime { get; set; }
        public string BanReason { get; set; }
    
        public virtual HashSet<Character> characters { get; set; }
    }
}

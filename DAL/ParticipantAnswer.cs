//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DAL
{
    using System;
    using System.Collections.Generic;
    
    public partial class ParticipantAnswer
    {
        public System.Guid participant_id { get; set; }
        public string phoneNumber { get; set; }
        public Nullable<System.DateTime> Date { get; set; }
        public string answer { get; set; }
        public string score { get; set; }
    
        public virtual Participant Participant { get; set; }
    }
}

//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace JumpersForGoalposts.Data
{
    using System;
    using System.Collections.Generic;
    
    public partial class Event
    {
        public Event()
        {
            this.Members = new HashSet<Member>();
            this.Users = new HashSet<User>();
        }
    
        public int EventId { get; set; }
        public Nullable<int> EventGroupId { get; set; }
        public System.DateTime Start { get; set; }
        public System.DateTime Finish { get; set; }
    
        public virtual EventGroup EventGroup { get; set; }
        public virtual ICollection<Member> Members { get; set; }
        public virtual ICollection<User> Users { get; set; }
    }
}

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
    
    public partial class Member
    {
        public Member()
        {
            this.Events = new HashSet<Event>();
        }
    
        public int MemberId { get; set; }
        public string Name { get; set; }
    
        public virtual ICollection<Event> Events { get; set; }
    }
}
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MeetingRoom
{
    using System;
    using System.Collections.Generic;
    
    public partial class Meetings
    {
        public int MeetingID { get; set; }
        public System.DateTime Date { get; set; }
        public int Hour { get; set; }
        public int CompanyID { get; set; }
        public int MeetingRoomID { get; set; }
        public string Description { get; set; }
    
        public virtual Companies Companies { get; set; }
        public virtual MeetingRooms MeetingRooms { get; set; }
    }
}

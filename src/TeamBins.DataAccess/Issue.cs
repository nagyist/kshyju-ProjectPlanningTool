//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace TeamBins.DataAccess
{
    using System;
    using System.Collections.Generic;
    
    public partial class Issue
    {
        public Issue()
        {
            this.Comments = new HashSet<Comment>();
            this.IssueMembers = new HashSet<IssueMember>();
            this.Documents = new HashSet<Document>();
        }
    
        public int ID { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public Nullable<System.DateTime> DueDate { get; set; }
        public Nullable<int> PriorityID { get; set; }
        public int CategoryID { get; set; }
        public int StatusID { get; set; }
        public int ProjectID { get; set; }
        public System.DateTime CreatedDate { get; set; }
        public int CreatedByID { get; set; }
        public Nullable<System.DateTime> ModifiedDate { get; set; }
        public Nullable<int> ModifiedByID { get; set; }
        public string Location { get; set; }
        public int TeamID { get; set; }
        public bool Active { get; set; }
    
        public virtual Category Category { get; set; }
        public virtual Priority Priority { get; set; }
        public virtual Status Status { get; set; }
        public virtual Project Project { get; set; }
        public virtual ICollection<Comment> Comments { get; set; }
        public virtual ICollection<IssueMember> IssueMembers { get; set; }
        public virtual ICollection<Document> Documents { get; set; }
        public virtual User CreatedBy { get; set; }
        public virtual User ModifiedBy { get; set; }
        public virtual Team Team { get; set; }
    }
}

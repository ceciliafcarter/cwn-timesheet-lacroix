//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace NM.Web.WebApplication.Timesheets.United.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class tblMasterUser
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tblMasterUser()
        {
            this.tblIndividuals = new HashSet<tblIndividual>();
            this.tblIndividuals1 = new HashSet<tblIndividual>();
            this.tblMasterUser1 = new HashSet<tblMasterUser>();
            this.tblMasterUser11 = new HashSet<tblMasterUser>();
            this.tblMasterUserRoles = new HashSet<tblMasterUserRole>();
            this.tblRoles = new HashSet<tblRole>();
            this.tblRoles1 = new HashSet<tblRole>();
            this.tblTSEmployeeInfoes = new HashSet<tblTSEmployeeInfo>();
        }
    
        public int MasterUserID { get; set; }
        public string UserName { get; set; }
        public string DomainName { get; set; }
        public string MRIUserID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public Nullable<bool> AcceptedUPDirect { get; set; }
        public int Version { get; set; }
        public Nullable<int> ModifiedByMasterUserID { get; set; }
        public Nullable<System.DateTime> ModifiedDatetime { get; set; }
        public int CreatedByMasterUserID { get; set; }
        public System.DateTime CreatedDatetime { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblIndividual> tblIndividuals { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblIndividual> tblIndividuals1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblMasterUser> tblMasterUser1 { get; set; }
        public virtual tblMasterUser tblMasterUser2 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblMasterUser> tblMasterUser11 { get; set; }
        public virtual tblMasterUser tblMasterUser3 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblMasterUserRole> tblMasterUserRoles { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblRole> tblRoles { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblRole> tblRoles1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblTSEmployeeInfo> tblTSEmployeeInfoes { get; set; }
    }
}

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SchoolManagement.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class SchoolDetail
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public SchoolDetail()
        {
            this.ManagerDetails = new HashSet<ManagerDetail>();
        }
    
        public int SchoolDetailID { get; set; }
        public string SchoolCity { get; set; }
        public int SchoolCounty { get; set; }
        public decimal SchoolUnitPrice { get; set; }
        public string SchoolAddress { get; set; }
        public string Region { get; set; }
        public int SchoolID { get; set; }
    
        public virtual School School { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ManagerDetail> ManagerDetails { get; set; }
    }
}
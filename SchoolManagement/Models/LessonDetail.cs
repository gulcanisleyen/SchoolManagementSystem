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
    
    public partial class LessonDetail
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public LessonDetail()
        {
            this.ExamDetails = new HashSet<ExamDetail>();
            this.Scores = new HashSet<Score>();
            this.Scores1 = new HashSet<Score>();
            this.ClassroomDetails = new HashSet<ClassroomDetail>();
        }
    
        public int LessonDetailID { get; set; }
        public System.DateTime LessonTime { get; set; }
        public string LessonPlace { get; set; }
        public string LessonQuota { get; set; }
        public int LessonID { get; set; }
        public int BranchDetailID { get; set; }
        public Nullable<int> Lesson_LessonID { get; set; }
        public Nullable<int> BranchDetail_BranchDetailID { get; set; }
    
        public virtual BranchDetail BranchDetail { get; set; }
        public virtual BranchDetail BranchDetail1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ExamDetail> ExamDetails { get; set; }
        public virtual Lesson Lesson { get; set; }
        public virtual Lesson Lesson1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Score> Scores { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Score> Scores1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ClassroomDetail> ClassroomDetails { get; set; }
    }
}
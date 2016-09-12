﻿namespace akcetDB
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Werkbrief")]
    public partial class Werkbrief
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Werkbrief()
        {
            WerkbriefHours = new HashSet<WerkbriefHours>();
        }

        [Key]
        public int WerkbriefID { get; set; }

        public int? CompanyID { get; set; }

        [Display(Name = "Date created")]
        public string WerkbriefDate { get; set; }

        [Display(Name = "Payment end date")]
        public string WerkbriefEndDate { get; set; }

        [Display(Name = "Period")]
        public string Period { get; set; }

        public string TotalHours { get; set; }

        public DateTime? DateCreated { get; set; }

        public DateTime? DateModified { get; set; }

        [StringLength(500)]
        public string UserName { get; set; }

        public string WerkbriefHTML { get; set; }
        [StringLength(128)]
        public string UserId { get; set; }

        public virtual Company Company { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<WerkbriefHours> WerkbriefHours { get; set; }
    }
}

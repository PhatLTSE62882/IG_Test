//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace IG_Test_Data
{
    using System;
    using System.Collections.Generic;
    
    public partial class IG_Service
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public IG_Service()
        {
            this.IG_Login_Service = new HashSet<IG_Login_Service>();
            this.IG_Rating_Login_Service = new HashSet<IG_Rating_Login_Service>();
        }
    
        public string serviceCode { get; set; }
        public string serviceName { get; set; }
        public string servicePasscode { get; set; }
        public string serviceImage { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<IG_Login_Service> IG_Login_Service { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<IG_Rating_Login_Service> IG_Rating_Login_Service { get; set; }
    }
}

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DbAccess
{
    using System;
    using System.Collections.Generic;
    
    public partial class Product
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Product()
        {
            this.OrderItems = new HashSet<OrderItem>();
        }
    
        public int Id { get; set; }
        public string ProductName { get; set; }
        public int SupplierId { get; set; }
        public Nullable<decimal> UnitPrice { get; set; }
        public string Package { get; set; }
        public bool IsDiscontinued { get; set; }
        public string moreColumn1 { get; set; }
        public string moreColumn2 { get; set; }
        public string moreColumn3 { get; set; }
        public string moreColumn4 { get; set; }
        public string moreColumn5 { get; set; }
        public string moreColumn6 { get; set; }
        public string moreColumn7 { get; set; }
        public string moreColumn8 { get; set; }
        public string moreColumn9 { get; set; }
        public string moreColumn10 { get; set; }
        public string moreColumn11 { get; set; }
        public string moreColumn12 { get; set; }
        public string moreColumn13 { get; set; }
        public string moreColumn14 { get; set; }
        public string moreColumn15 { get; set; }
        public string moreColumn16 { get; set; }
        public string moreColumn17 { get; set; }
        public string moreColumn18 { get; set; }
        public string moreColumn19 { get; set; }
        public string moreColumn20 { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<OrderItem> OrderItems { get; set; }
        public virtual Supplier Supplier { get; set; }
    }
}

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Rustics_Inventory
{
    using System;
    using System.Collections.Generic;
    
    public partial class Material
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Material()
        {
            this.ProductMaterials = new HashSet<ProductMaterial>();
        }
    
        public int MatID { get; set; }
        public string MaterialName { get; set; }
        public string Description { get; set; }
        public string Color { get; set; }
        public Nullable<decimal> Price { get; set; }
        public Nullable<int> SupplierID { get; set; }
        public Nullable<int> AmountAvailable { get; set; }
    
        public virtual Supplier Supplier { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ProductMaterial> ProductMaterials { get; set; }
    }
}

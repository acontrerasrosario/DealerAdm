//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DealerADMProject
{
    using System;
    using System.Collections.Generic;
    
    public partial class Vehiculo
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Vehiculo()
        {
            this.Detalle_Factura = new HashSet<Detalle_Factura>();
            this.Detalle_Factura1 = new HashSet<Detalle_Factura>();
            this.Ventas = new HashSet<Venta>();
        }
    
        public int ID { get; set; }
        public int CategoriaID { get; set; }
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public string Chasis { get; set; }
        public string Color { get; set; }
        public int CantPuertas { get; set; }
        public int CantCilindros { get; set; }
        public int KmActual { get; set; }
        public System.DateTime FechaRegistro { get; set; }
        public System.DateTime FechaAquisicion { get; set; }
        public string Detalles { get; set; }
        public decimal PrecioAdquirido { get; set; }
        public Nullable<decimal> PrecioVenta { get; set; }
    
        public virtual Categoria Categoria { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Detalle_Factura> Detalle_Factura { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Detalle_Factura> Detalle_Factura1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Venta> Ventas { get; set; }
    }
}

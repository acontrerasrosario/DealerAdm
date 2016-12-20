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
    
    public partial class Venta
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Venta()
        {
            this.Facturas = new HashSet<Factura>();
        }
    
        public int ID { get; set; }
        public int ClienteID { get; set; }
        public int VehiculoID { get; set; }
        public System.DateTime FechaVenta { get; set; }
        public Nullable<System.DateTime> FechaPago { get; set; }
        public Nullable<decimal> PagoMensual { get; set; }
        public decimal PrevioVenta { get; set; }
        public decimal PrecioAcordado { get; set; }
        public string DetalleVenta { get; set; }
    
        public virtual Cliente Cliente { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Factura> Facturas { get; set; }
        public virtual Vehiculo Vehiculo { get; set; }
    }
}

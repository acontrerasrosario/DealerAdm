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
    
    public partial class Pago
    {
        public int ID { get; set; }
        public int FacturaID { get; set; }
        public string Status { get; set; }
        public System.DateTime Fecha { get; set; }
        public decimal TotalPagado { get; set; }
    
        public virtual Factura Factura { get; set; }
    }
}
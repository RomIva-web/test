//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WindowsFormsApp2
{
    using System;
    using System.Collections.Generic;
    
    public partial class ORDERS
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public ORDERS()
        {
            this.ORDERHASTOVAR = new HashSet<ORDERHASTOVAR>();
        }
    
        public int IDORDERS { get; set; }
        public Nullable<System.DateTime> DATEORDER { get; set; }
        public Nullable<System.DateTime> DATEDELIVERY { get; set; }
        public string IDPOINTDELIVERY { get; set; }
        public Nullable<int> IDUSERS { get; set; }
        public Nullable<int> CODEFORGET { get; set; }
        public Nullable<int> IDSTATUSORDER { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ORDERHASTOVAR> ORDERHASTOVAR { get; set; }
        public virtual POINTDELIVERY POINTDELIVERY { get; set; }
        public virtual STATUSORDER STATUSORDER { get; set; }
        public virtual USERS USERS { get; set; }
    }
}
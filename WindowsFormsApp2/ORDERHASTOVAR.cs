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
    
    public partial class ORDERHASTOVAR
    {
        public int IDORDERS { get; set; }
        public string IDTOVARS { get; set; }
        public Nullable<int> AMOUNT { get; set; }
    
        public virtual ORDERS ORDERS { get; set; }
        public virtual TOVARS TOVARS { get; set; }
    }
}

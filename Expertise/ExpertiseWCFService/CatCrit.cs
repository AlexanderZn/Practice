//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ExpertiseWCFService
{
    using System;
    using System.Collections.Generic;
    
    public partial class CatCrit
    {
        public int id_cat_crit { get; set; }
        public int id_cat { get; set; }
        public int id_crit { get; set; }
    
        public virtual Categories Categories { get; set; }
        public virtual Criterions Criterions { get; set; }
    }
}
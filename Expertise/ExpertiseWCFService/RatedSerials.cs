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
    
    public partial class RatedSerials
    {
        public int id_watch_ser { get; set; }
        public int user_id { get; set; }
        public int ser_id { get; set; }
        public int user_rate_ser { get; set; }
    
        public virtual Serials Serials { get; set; }
        public virtual Users Users { get; set; }
    }
}

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
    
    public partial class RatedFilms
    {
        public int id_watch { get; set; }
        public int user_id { get; set; }
        public int film_id { get; set; }
        public int user_rate_film { get; set; }
    
        public virtual Filmes Filmes { get; set; }
        public virtual Users Users { get; set; }
    }
}

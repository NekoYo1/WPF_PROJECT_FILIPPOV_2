//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WPF_PROJECT_FILIPPOV_2
{
    using System;
    using System.Collections.Generic;
    
    public partial class Tovar
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Tovar()
        {
            this.Proizvoditel = new HashSet<Proizvoditel>();
        }
    
        public int IDTovar { get; set; }
        public string NameTovar { get; set; }
        public Nullable<int> KolichestvoTovara { get; set; }
        public Nullable<System.DateTime> Date { get; set; }
        public int IDPostavchik { get; set; }
    
        public virtual Postavchik Postavchik { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Proizvoditel> Proizvoditel { get; set; }
    }
}

namespace serwis_komputerowy
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("serwis_komputerowy.KatSprzetu")]
    public partial class KatSprzetu
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public KatSprzetu()
        {
            Sprzet = new HashSet<Sprzet>();
        }

        [Key]
        public int idKatSprzetu { get; set; }

        [Required]
        [StringLength(45)]
        public string NazwaKatSprzetu { get; set; }

        [Required]
        [StringLength(45)]
        public string Uwagi { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Sprzet> Sprzet { get; set; }
    }
}

namespace serwis_komputerowy.entity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("serwis_komputerowy.KatCzynnosci")]
    public partial class KatCzynnosci
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public KatCzynnosci()
        {
            Czynnosc = new HashSet<Czynnosc>();
        }

        [Key]
        public int IDKatCzynnosci { get; set; }

        [Required]
        [StringLength(45)]
        public string NazwaKatCzynnosci { get; set; }

        [Required]
        [StringLength(45)]
        public string Informacje { get; set; }

        [Required]
        [StringLength(45)]
        public string Uwagi { get; set; }

        public int Cennik { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Czynnosc> Czynnosc { get; set; }
    }
}

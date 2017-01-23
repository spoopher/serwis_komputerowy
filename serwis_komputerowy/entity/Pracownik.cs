namespace serwis_komputerowy.entity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("serwis_komputerowy.Pracownik")]
    public partial class Pracownik
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Pracownik()
        {
            Czynnosc = new HashSet<Czynnosc>();
        }

        [Key]
        public int IDPracownika { get; set; }

        [Required]
        [StringLength(45)]
        public string Imie { get; set; }

        [Required]
        [StringLength(45)]
        public string Nazwisko { get; set; }

        [Required]
        [StringLength(45)]
        public string Login { get; set; }

        [Required]
        [StringLength(45)]
        public string Haslo { get; set; }

        [Required]
        [StringLength(45)]
        public string Uprawnienia { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Czynnosc> Czynnosc { get; set; }
    }
}

namespace serwis_komputerowy.entity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("serwis_komputerowy.Zlecenie")]
    public partial class Zlecenie
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Zlecenie()
        {
            Czynnosc = new HashSet<Czynnosc>();
        }

        [Key]
        public int IDZlecenia { get; set; }

        public int IDKlienta { get; set; }

        public int IDSprzetu { get; set; }

        [Required]
        [StringLength(45)]
        public string Status { get; set; }

        [Required]
        [StringLength(45)]
        public string UwagiKlienta { get; set; }

        [Required]
        [StringLength(45)]
        public string UwagiSerwisu { get; set; }

        public int Kod { get; set; }

        public int Klient_IDKlienta { get; set; }

        public int Sprzet_IDSprzetu { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Czynnosc> Czynnosc { get; set; }

        public virtual Klient Klient { get; set; }

        public virtual Sprzet Sprzet { get; set; }
    }
}

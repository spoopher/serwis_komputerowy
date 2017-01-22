namespace serwis_komputerowy
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("serwis_komputerowy.Klient")]
    public partial class Klient
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Klient()
        {
            Sprzet = new HashSet<Sprzet>();
            Zlecenie = new HashSet<Zlecenie>();
        }

        [Key]
        public int IDKlienta { get; set; }

        [Required]
        [StringLength(45)]
        public string Imie { get; set; }

        [Required]
        [StringLength(45)]
        public string Nazwisko { get; set; }

        [Required]
        [StringLength(45)]
        public string Adres { get; set; }

        public int Telefon { get; set; }

        [Required]
        [StringLength(45)]
        public string Mail { get; set; }

        public int Kod { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Sprzet> Sprzet { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Zlecenie> Zlecenie { get; set; }
    }
}

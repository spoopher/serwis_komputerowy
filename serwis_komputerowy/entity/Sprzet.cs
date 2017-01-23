namespace serwis_komputerowy.entity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("serwis_komputerowy.Sprzet")]
    public partial class Sprzet
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Sprzet()
        {
            Zlecenie = new HashSet<Zlecenie>();
        }

        [Key]
        public int IDSprzetu { get; set; }

        public int IDKatSprzetu { get; set; }

        public int IDKlienta { get; set; }

        [Required]
        [StringLength(45)]
        public string Producent { get; set; }

        [Required]
        [StringLength(45)]
        public string Model { get; set; }

        public int NrSeryjny { get; set; }

        [Required]
        [StringLength(45)]
        public string CzySprawny { get; set; }

        [Required]
        [StringLength(45)]
        public string Uwagi { get; set; }

        public int Kod { get; set; }

        public int KatSprzetu_idKatSprzetu { get; set; }

        public int Klient_IDKlienta { get; set; }

        public virtual KatSprzetu KatSprzetu { get; set; }

        public virtual Klient Klient { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Zlecenie> Zlecenie { get; set; }
    }
}

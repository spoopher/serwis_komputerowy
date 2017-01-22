namespace serwis_komputerowy
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("serwis_komputerowy.Czynnosc")]
    public partial class Czynnosc
    {
        [Key]
        public int IDCzynnosci { get; set; }

        [Required]
        [StringLength(45)]
        public string IDZlecenia { get; set; }

        [Required]
        [StringLength(45)]
        public string IDPracownika { get; set; }

        [Required]
        [StringLength(45)]
        public string IDKatCzynnosci { get; set; }

        [Required]
        [StringLength(45)]
        public string Data { get; set; }

        [Required]
        [StringLength(45)]
        public string Godzina { get; set; }

        [Required]
        [StringLength(45)]
        public string Miejsce { get; set; }

        [Required]
        [StringLength(45)]
        public string NazwaCzynnosci { get; set; }

        [Required]
        [StringLength(45)]
        public string OpisCzynnosci { get; set; }

        [Required]
        [StringLength(45)]
        public string Uwagi { get; set; }

        public int Zlecenie_IDZlecenia { get; set; }

        public int Pracownik_IDPracownika { get; set; }

        public int KatCzynnosci_IDKatCzynnosci { get; set; }

        public virtual KatCzynnosci KatCzynnosci { get; set; }

        public virtual Pracownik Pracownik { get; set; }

        public virtual Zlecenie Zlecenie { get; set; }
    }
}

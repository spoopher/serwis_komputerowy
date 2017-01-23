namespace serwis_komputerowy.entity
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class Baza : DbContext
    {
        public Baza()
            : base("name=Baza")
        {
        }

        public virtual DbSet<Czynnosc> Czynnosc { get; set; }
        public virtual DbSet<KatCzynnosci> KatCzynnosci { get; set; }
        public virtual DbSet<KatSprzetu> KatSprzetu { get; set; }
        public virtual DbSet<Klient> Klient { get; set; }
        public virtual DbSet<Pracownik> Pracownik { get; set; }
        public virtual DbSet<Sprzet> Sprzet { get; set; }
        public virtual DbSet<Zlecenie> Zlecenie { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Czynnosc>()
                .Property(e => e.Data)
                .IsUnicode(false);

            modelBuilder.Entity<Czynnosc>()
                .Property(e => e.Godzina)
                .IsUnicode(false);

            modelBuilder.Entity<Czynnosc>()
                .Property(e => e.Miejsce)
                .IsUnicode(false);

            modelBuilder.Entity<Czynnosc>()
                .Property(e => e.NazwaCzynnosci)
                .IsUnicode(false);

            modelBuilder.Entity<Czynnosc>()
                .Property(e => e.OpisCzynnosci)
                .IsUnicode(false);

            modelBuilder.Entity<Czynnosc>()
                .Property(e => e.Uwagi)
                .IsUnicode(false);

            modelBuilder.Entity<KatCzynnosci>()
                .Property(e => e.NazwaKatCzynnosci)
                .IsUnicode(false);

            modelBuilder.Entity<KatCzynnosci>()
                .Property(e => e.Informacje)
                .IsUnicode(false);

            modelBuilder.Entity<KatCzynnosci>()
                .Property(e => e.Uwagi)
                .IsUnicode(false);

            modelBuilder.Entity<KatCzynnosci>()
                .HasMany(e => e.Czynnosc)
                .WithRequired(e => e.KatCzynnosci)
                .HasForeignKey(e => e.KatCzynnosci_IDKatCzynnosci)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<KatSprzetu>()
                .Property(e => e.NazwaKatSprzetu)
                .IsUnicode(false);

            modelBuilder.Entity<KatSprzetu>()
                .Property(e => e.Uwagi)
                .IsUnicode(false);

            modelBuilder.Entity<KatSprzetu>()
                .HasMany(e => e.Sprzet)
                .WithRequired(e => e.KatSprzetu)
                .HasForeignKey(e => e.KatSprzetu_idKatSprzetu)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Klient>()
                .Property(e => e.Imie)
                .IsUnicode(false);

            modelBuilder.Entity<Klient>()
                .Property(e => e.Nazwisko)
                .IsUnicode(false);

            modelBuilder.Entity<Klient>()
                .Property(e => e.Adres)
                .IsUnicode(false);

            modelBuilder.Entity<Klient>()
                .Property(e => e.Mail)
                .IsUnicode(false);

            modelBuilder.Entity<Klient>()
                .HasMany(e => e.Sprzet)
                .WithRequired(e => e.Klient)
                .HasForeignKey(e => e.Klient_IDKlienta)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Klient>()
                .HasMany(e => e.Zlecenie)
                .WithRequired(e => e.Klient)
                .HasForeignKey(e => e.Klient_IDKlienta)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Pracownik>()
                .Property(e => e.Imie)
                .IsUnicode(false);

            modelBuilder.Entity<Pracownik>()
                .Property(e => e.Nazwisko)
                .IsUnicode(false);

            modelBuilder.Entity<Pracownik>()
                .Property(e => e.Login)
                .IsUnicode(false);

            modelBuilder.Entity<Pracownik>()
                .Property(e => e.Haslo)
                .IsUnicode(false);

            modelBuilder.Entity<Pracownik>()
                .Property(e => e.Uprawnienia)
                .IsUnicode(false);

            modelBuilder.Entity<Pracownik>()
                .HasMany(e => e.Czynnosc)
                .WithRequired(e => e.Pracownik)
                .HasForeignKey(e => e.Pracownik_IDPracownika)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Sprzet>()
                .Property(e => e.Producent)
                .IsUnicode(false);

            modelBuilder.Entity<Sprzet>()
                .Property(e => e.Model)
                .IsUnicode(false);

            modelBuilder.Entity<Sprzet>()
                .Property(e => e.CzySprawny)
                .IsUnicode(false);

            modelBuilder.Entity<Sprzet>()
                .Property(e => e.Uwagi)
                .IsUnicode(false);

            modelBuilder.Entity<Sprzet>()
                .HasMany(e => e.Zlecenie)
                .WithRequired(e => e.Sprzet)
                .HasForeignKey(e => e.Sprzet_IDSprzetu)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Zlecenie>()
                .Property(e => e.Status)
                .IsUnicode(false);

            modelBuilder.Entity<Zlecenie>()
                .Property(e => e.UwagiKlienta)
                .IsUnicode(false);

            modelBuilder.Entity<Zlecenie>()
                .Property(e => e.UwagiSerwisu)
                .IsUnicode(false);

            modelBuilder.Entity<Zlecenie>()
                .HasMany(e => e.Czynnosc)
                .WithRequired(e => e.Zlecenie)
                .HasForeignKey(e => e.Zlecenie_IDZlecenia)
                .WillCascadeOnDelete(false);
        }
    }
}

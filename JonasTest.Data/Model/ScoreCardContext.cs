using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace JonasTest.Data.Model
{
    public partial class ScoreCardContext : DbContext
    {
        public ScoreCardContext()
        {
        }

        public ScoreCardContext(DbContextOptions<ScoreCardContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Academics> Academics { get; set; }
        public virtual DbSet<Admissions> Admissions { get; set; }
        public virtual DbSet<Completion> Completion { get; set; }
        public virtual DbSet<Cost> Cost { get; set; }
        public virtual DbSet<Earnings> Earnings { get; set; }
        public virtual DbSet<Repayment> Repayment { get; set; }
        public virtual DbSet<Root> Root { get; set; }
        public virtual DbSet<School> School { get; set; }
        public virtual DbSet<Student> Student { get; set; }
        public virtual DbSet<TitleIv> TitleIv { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Data Source=(localdb)\\v12.0;Initial Catalog=ScoreCard;Integrated Security=True;User ID=cscUser;Password=cscUser;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("ProductVersion", "2.2.3-servicing-35854");

            modelBuilder.Entity<Academics>(entity =>
            {
                entity.HasKey(e => e.Unitid)
                    .HasName("PK_Academics_UNITID");

                entity.ToTable("Academics", "cscData");

                entity.Property(e => e.Unitid)
                    .HasColumnName("UNITID")
                    .ValueGeneratedNever();

                entity.Property(e => e.Cip01assoc).HasColumnName("CIP01ASSOC");

                entity.Property(e => e.Cip01bachl).HasColumnName("CIP01BACHL");

                entity.Property(e => e.Cip01cert1).HasColumnName("CIP01CERT1");

                entity.Property(e => e.Cip01cert2).HasColumnName("CIP01CERT2");

                entity.Property(e => e.Cip01cert4).HasColumnName("CIP01CERT4");

                entity.Property(e => e.Cip03assoc).HasColumnName("CIP03ASSOC");

                entity.Property(e => e.Cip03bachl).HasColumnName("CIP03BACHL");

                entity.Property(e => e.Cip03cert1).HasColumnName("CIP03CERT1");

                entity.Property(e => e.Cip03cert2).HasColumnName("CIP03CERT2");

                entity.Property(e => e.Cip03cert4).HasColumnName("CIP03CERT4");

                entity.Property(e => e.Cip04assoc).HasColumnName("CIP04ASSOC");

                entity.Property(e => e.Cip04bachl).HasColumnName("CIP04BACHL");

                entity.Property(e => e.Cip04cert1).HasColumnName("CIP04CERT1");

                entity.Property(e => e.Cip04cert2).HasColumnName("CIP04CERT2");

                entity.Property(e => e.Cip04cert4).HasColumnName("CIP04CERT4");

                entity.Property(e => e.Cip05assoc).HasColumnName("CIP05ASSOC");

                entity.Property(e => e.Cip05bachl).HasColumnName("CIP05BACHL");

                entity.Property(e => e.Cip05cert1).HasColumnName("CIP05CERT1");

                entity.Property(e => e.Cip05cert2).HasColumnName("CIP05CERT2");

                entity.Property(e => e.Cip05cert4).HasColumnName("CIP05CERT4");

                entity.Property(e => e.Cip09assoc).HasColumnName("CIP09ASSOC");

                entity.Property(e => e.Cip09bachl).HasColumnName("CIP09BACHL");

                entity.Property(e => e.Cip09cert1).HasColumnName("CIP09CERT1");

                entity.Property(e => e.Cip09cert2).HasColumnName("CIP09CERT2");

                entity.Property(e => e.Cip09cert4).HasColumnName("CIP09CERT4");

                entity.Property(e => e.Cip10assoc).HasColumnName("CIP10ASSOC");

                entity.Property(e => e.Cip10bachl).HasColumnName("CIP10BACHL");

                entity.Property(e => e.Cip10cert1).HasColumnName("CIP10CERT1");

                entity.Property(e => e.Cip10cert2).HasColumnName("CIP10CERT2");

                entity.Property(e => e.Cip10cert4).HasColumnName("CIP10CERT4");

                entity.Property(e => e.Cip11assoc).HasColumnName("CIP11ASSOC");

                entity.Property(e => e.Cip11bachl).HasColumnName("CIP11BACHL");

                entity.Property(e => e.Cip11cert1).HasColumnName("CIP11CERT1");

                entity.Property(e => e.Cip11cert2).HasColumnName("CIP11CERT2");

                entity.Property(e => e.Cip11cert4).HasColumnName("CIP11CERT4");

                entity.Property(e => e.Cip12assoc).HasColumnName("CIP12ASSOC");

                entity.Property(e => e.Cip12bachl).HasColumnName("CIP12BACHL");

                entity.Property(e => e.Cip12cert1).HasColumnName("CIP12CERT1");

                entity.Property(e => e.Cip12cert2).HasColumnName("CIP12CERT2");

                entity.Property(e => e.Cip12cert4).HasColumnName("CIP12CERT4");

                entity.Property(e => e.Cip13assoc).HasColumnName("CIP13ASSOC");

                entity.Property(e => e.Cip13bachl).HasColumnName("CIP13BACHL");

                entity.Property(e => e.Cip13cert1).HasColumnName("CIP13CERT1");

                entity.Property(e => e.Cip13cert2).HasColumnName("CIP13CERT2");

                entity.Property(e => e.Cip13cert4).HasColumnName("CIP13CERT4");

                entity.Property(e => e.Cip14assoc).HasColumnName("CIP14ASSOC");

                entity.Property(e => e.Cip14bachl).HasColumnName("CIP14BACHL");

                entity.Property(e => e.Cip14cert1).HasColumnName("CIP14CERT1");

                entity.Property(e => e.Cip14cert2).HasColumnName("CIP14CERT2");

                entity.Property(e => e.Cip14cert4).HasColumnName("CIP14CERT4");

                entity.Property(e => e.Cip15assoc).HasColumnName("CIP15ASSOC");

                entity.Property(e => e.Cip15bachl).HasColumnName("CIP15BACHL");

                entity.Property(e => e.Cip15cert1).HasColumnName("CIP15CERT1");

                entity.Property(e => e.Cip15cert2).HasColumnName("CIP15CERT2");

                entity.Property(e => e.Cip15cert4).HasColumnName("CIP15CERT4");

                entity.Property(e => e.Cip16assoc).HasColumnName("CIP16ASSOC");

                entity.Property(e => e.Cip16bachl).HasColumnName("CIP16BACHL");

                entity.Property(e => e.Cip16cert1).HasColumnName("CIP16CERT1");

                entity.Property(e => e.Cip16cert2).HasColumnName("CIP16CERT2");

                entity.Property(e => e.Cip16cert4).HasColumnName("CIP16CERT4");

                entity.Property(e => e.Cip19assoc).HasColumnName("CIP19ASSOC");

                entity.Property(e => e.Cip19bachl).HasColumnName("CIP19BACHL");

                entity.Property(e => e.Cip19cert1).HasColumnName("CIP19CERT1");

                entity.Property(e => e.Cip19cert2).HasColumnName("CIP19CERT2");

                entity.Property(e => e.Cip19cert4).HasColumnName("CIP19CERT4");

                entity.Property(e => e.Cip22assoc).HasColumnName("CIP22ASSOC");

                entity.Property(e => e.Cip22bachl).HasColumnName("CIP22BACHL");

                entity.Property(e => e.Cip22cert1).HasColumnName("CIP22CERT1");

                entity.Property(e => e.Cip22cert2).HasColumnName("CIP22CERT2");

                entity.Property(e => e.Cip22cert4).HasColumnName("CIP22CERT4");

                entity.Property(e => e.Cip23assoc).HasColumnName("CIP23ASSOC");

                entity.Property(e => e.Cip23bachl).HasColumnName("CIP23BACHL");

                entity.Property(e => e.Cip23cert1).HasColumnName("CIP23CERT1");

                entity.Property(e => e.Cip23cert2).HasColumnName("CIP23CERT2");

                entity.Property(e => e.Cip23cert4).HasColumnName("CIP23CERT4");

                entity.Property(e => e.Cip24assoc).HasColumnName("CIP24ASSOC");

                entity.Property(e => e.Cip24bachl).HasColumnName("CIP24BACHL");

                entity.Property(e => e.Cip24cert1).HasColumnName("CIP24CERT1");

                entity.Property(e => e.Cip24cert2).HasColumnName("CIP24CERT2");

                entity.Property(e => e.Cip24cert4).HasColumnName("CIP24CERT4");

                entity.Property(e => e.Cip25assoc).HasColumnName("CIP25ASSOC");

                entity.Property(e => e.Cip25bachl).HasColumnName("CIP25BACHL");

                entity.Property(e => e.Cip25cert1).HasColumnName("CIP25CERT1");

                entity.Property(e => e.Cip25cert2).HasColumnName("CIP25CERT2");

                entity.Property(e => e.Cip25cert4).HasColumnName("CIP25CERT4");

                entity.Property(e => e.Cip26assoc).HasColumnName("CIP26ASSOC");

                entity.Property(e => e.Cip26bachl).HasColumnName("CIP26BACHL");

                entity.Property(e => e.Cip26cert1).HasColumnName("CIP26CERT1");

                entity.Property(e => e.Cip26cert2).HasColumnName("CIP26CERT2");

                entity.Property(e => e.Cip26cert4).HasColumnName("CIP26CERT4");

                entity.Property(e => e.Cip27assoc).HasColumnName("CIP27ASSOC");

                entity.Property(e => e.Cip27bachl).HasColumnName("CIP27BACHL");

                entity.Property(e => e.Cip27cert1).HasColumnName("CIP27CERT1");

                entity.Property(e => e.Cip27cert2).HasColumnName("CIP27CERT2");

                entity.Property(e => e.Cip27cert4).HasColumnName("CIP27CERT4");

                entity.Property(e => e.Cip29assoc).HasColumnName("CIP29ASSOC");

                entity.Property(e => e.Cip29bachl).HasColumnName("CIP29BACHL");

                entity.Property(e => e.Cip29cert1).HasColumnName("CIP29CERT1");

                entity.Property(e => e.Cip29cert2).HasColumnName("CIP29CERT2");

                entity.Property(e => e.Cip29cert4).HasColumnName("CIP29CERT4");

                entity.Property(e => e.Cip30assoc).HasColumnName("CIP30ASSOC");

                entity.Property(e => e.Cip30bachl).HasColumnName("CIP30BACHL");

                entity.Property(e => e.Cip30cert1).HasColumnName("CIP30CERT1");

                entity.Property(e => e.Cip30cert2).HasColumnName("CIP30CERT2");

                entity.Property(e => e.Cip30cert4).HasColumnName("CIP30CERT4");

                entity.Property(e => e.Cip31assoc).HasColumnName("CIP31ASSOC");

                entity.Property(e => e.Cip31bachl).HasColumnName("CIP31BACHL");

                entity.Property(e => e.Cip31cert1).HasColumnName("CIP31CERT1");

                entity.Property(e => e.Cip31cert2).HasColumnName("CIP31CERT2");

                entity.Property(e => e.Cip31cert4).HasColumnName("CIP31CERT4");

                entity.Property(e => e.Cip38assoc).HasColumnName("CIP38ASSOC");

                entity.Property(e => e.Cip38bachl).HasColumnName("CIP38BACHL");

                entity.Property(e => e.Cip38cert1).HasColumnName("CIP38CERT1");

                entity.Property(e => e.Cip38cert2).HasColumnName("CIP38CERT2");

                entity.Property(e => e.Cip38cert4).HasColumnName("CIP38CERT4");

                entity.Property(e => e.Cip39assoc).HasColumnName("CIP39ASSOC");

                entity.Property(e => e.Cip39bachl).HasColumnName("CIP39BACHL");

                entity.Property(e => e.Cip39cert1).HasColumnName("CIP39CERT1");

                entity.Property(e => e.Cip39cert2).HasColumnName("CIP39CERT2");

                entity.Property(e => e.Cip39cert4).HasColumnName("CIP39CERT4");

                entity.Property(e => e.Cip40assoc).HasColumnName("CIP40ASSOC");

                entity.Property(e => e.Cip40bachl).HasColumnName("CIP40BACHL");

                entity.Property(e => e.Cip40cert1).HasColumnName("CIP40CERT1");

                entity.Property(e => e.Cip40cert2).HasColumnName("CIP40CERT2");

                entity.Property(e => e.Cip40cert4).HasColumnName("CIP40CERT4");

                entity.Property(e => e.Cip41assoc).HasColumnName("CIP41ASSOC");

                entity.Property(e => e.Cip41bachl).HasColumnName("CIP41BACHL");

                entity.Property(e => e.Cip41cert1).HasColumnName("CIP41CERT1");

                entity.Property(e => e.Cip41cert2).HasColumnName("CIP41CERT2");

                entity.Property(e => e.Cip41cert4).HasColumnName("CIP41CERT4");

                entity.Property(e => e.Cip42assoc).HasColumnName("CIP42ASSOC");

                entity.Property(e => e.Cip42bachl).HasColumnName("CIP42BACHL");

                entity.Property(e => e.Cip42cert1).HasColumnName("CIP42CERT1");

                entity.Property(e => e.Cip42cert2).HasColumnName("CIP42CERT2");

                entity.Property(e => e.Cip42cert4).HasColumnName("CIP42CERT4");

                entity.Property(e => e.Cip43assoc).HasColumnName("CIP43ASSOC");

                entity.Property(e => e.Cip43bachl).HasColumnName("CIP43BACHL");

                entity.Property(e => e.Cip43cert1).HasColumnName("CIP43CERT1");

                entity.Property(e => e.Cip43cert2).HasColumnName("CIP43CERT2");

                entity.Property(e => e.Cip43cert4).HasColumnName("CIP43CERT4");

                entity.Property(e => e.Cip44assoc).HasColumnName("CIP44ASSOC");

                entity.Property(e => e.Cip44bachl).HasColumnName("CIP44BACHL");

                entity.Property(e => e.Cip44cert1).HasColumnName("CIP44CERT1");

                entity.Property(e => e.Cip44cert2).HasColumnName("CIP44CERT2");

                entity.Property(e => e.Cip44cert4).HasColumnName("CIP44CERT4");

                entity.Property(e => e.Cip45assoc).HasColumnName("CIP45ASSOC");

                entity.Property(e => e.Cip45bachl).HasColumnName("CIP45BACHL");

                entity.Property(e => e.Cip45cert1).HasColumnName("CIP45CERT1");

                entity.Property(e => e.Cip45cert2).HasColumnName("CIP45CERT2");

                entity.Property(e => e.Cip45cert4).HasColumnName("CIP45CERT4");

                entity.Property(e => e.Cip46assoc).HasColumnName("CIP46ASSOC");

                entity.Property(e => e.Cip46bachl).HasColumnName("CIP46BACHL");

                entity.Property(e => e.Cip46cert1).HasColumnName("CIP46CERT1");

                entity.Property(e => e.Cip46cert2).HasColumnName("CIP46CERT2");

                entity.Property(e => e.Cip46cert4).HasColumnName("CIP46CERT4");

                entity.Property(e => e.Cip47assoc).HasColumnName("CIP47ASSOC");

                entity.Property(e => e.Cip47bachl).HasColumnName("CIP47BACHL");

                entity.Property(e => e.Cip47cert1).HasColumnName("CIP47CERT1");

                entity.Property(e => e.Cip47cert2).HasColumnName("CIP47CERT2");

                entity.Property(e => e.Cip47cert4).HasColumnName("CIP47CERT4");

                entity.Property(e => e.Cip48assoc).HasColumnName("CIP48ASSOC");

                entity.Property(e => e.Cip48bachl).HasColumnName("CIP48BACHL");

                entity.Property(e => e.Cip48cert1).HasColumnName("CIP48CERT1");

                entity.Property(e => e.Cip48cert2).HasColumnName("CIP48CERT2");

                entity.Property(e => e.Cip48cert4).HasColumnName("CIP48CERT4");

                entity.Property(e => e.Cip49assoc).HasColumnName("CIP49ASSOC");

                entity.Property(e => e.Cip49bachl).HasColumnName("CIP49BACHL");

                entity.Property(e => e.Cip49cert1).HasColumnName("CIP49CERT1");

                entity.Property(e => e.Cip49cert2).HasColumnName("CIP49CERT2");

                entity.Property(e => e.Cip49cert4).HasColumnName("CIP49CERT4");

                entity.Property(e => e.Cip50assoc).HasColumnName("CIP50ASSOC");

                entity.Property(e => e.Cip50bachl).HasColumnName("CIP50BACHL");

                entity.Property(e => e.Cip50cert1).HasColumnName("CIP50CERT1");

                entity.Property(e => e.Cip50cert2).HasColumnName("CIP50CERT2");

                entity.Property(e => e.Cip50cert4).HasColumnName("CIP50CERT4");

                entity.Property(e => e.Cip51assoc).HasColumnName("CIP51ASSOC");

                entity.Property(e => e.Cip51bachl).HasColumnName("CIP51BACHL");

                entity.Property(e => e.Cip51cert1).HasColumnName("CIP51CERT1");

                entity.Property(e => e.Cip51cert2).HasColumnName("CIP51CERT2");

                entity.Property(e => e.Cip51cert4).HasColumnName("CIP51CERT4");

                entity.Property(e => e.Cip52assoc).HasColumnName("CIP52ASSOC");

                entity.Property(e => e.Cip52bachl).HasColumnName("CIP52BACHL");

                entity.Property(e => e.Cip52cert1).HasColumnName("CIP52CERT1");

                entity.Property(e => e.Cip52cert2).HasColumnName("CIP52CERT2");

                entity.Property(e => e.Cip52cert4).HasColumnName("CIP52CERT4");

                entity.Property(e => e.Cip54assoc).HasColumnName("CIP54ASSOC");

                entity.Property(e => e.Cip54bachl).HasColumnName("CIP54BACHL");

                entity.Property(e => e.Cip54cert1).HasColumnName("CIP54CERT1");

                entity.Property(e => e.Cip54cert2).HasColumnName("CIP54CERT2");

                entity.Property(e => e.Cip54cert4).HasColumnName("CIP54CERT4");

                entity.Property(e => e.Pcip01)
                    .HasColumnName("PCIP01")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.Pcip03)
                    .HasColumnName("PCIP03")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.Pcip04)
                    .HasColumnName("PCIP04")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.Pcip05)
                    .HasColumnName("PCIP05")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.Pcip09)
                    .HasColumnName("PCIP09")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.Pcip10)
                    .HasColumnName("PCIP10")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.Pcip11)
                    .HasColumnName("PCIP11")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.Pcip12)
                    .HasColumnName("PCIP12")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.Pcip13)
                    .HasColumnName("PCIP13")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.Pcip14)
                    .HasColumnName("PCIP14")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.Pcip15)
                    .HasColumnName("PCIP15")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.Pcip16)
                    .HasColumnName("PCIP16")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.Pcip19)
                    .HasColumnName("PCIP19")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.Pcip22)
                    .HasColumnName("PCIP22")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.Pcip23)
                    .HasColumnName("PCIP23")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.Pcip24)
                    .HasColumnName("PCIP24")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.Pcip25)
                    .HasColumnName("PCIP25")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.Pcip26)
                    .HasColumnName("PCIP26")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.Pcip27)
                    .HasColumnName("PCIP27")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.Pcip29)
                    .HasColumnName("PCIP29")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.Pcip30)
                    .HasColumnName("PCIP30")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.Pcip31)
                    .HasColumnName("PCIP31")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.Pcip38)
                    .HasColumnName("PCIP38")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.Pcip39)
                    .HasColumnName("PCIP39")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.Pcip40)
                    .HasColumnName("PCIP40")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.Pcip41)
                    .HasColumnName("PCIP41")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.Pcip42)
                    .HasColumnName("PCIP42")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.Pcip43)
                    .HasColumnName("PCIP43")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.Pcip44)
                    .HasColumnName("PCIP44")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.Pcip45)
                    .HasColumnName("PCIP45")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.Pcip46)
                    .HasColumnName("PCIP46")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.Pcip47)
                    .HasColumnName("PCIP47")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.Pcip48)
                    .HasColumnName("PCIP48")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.Pcip49)
                    .HasColumnName("PCIP49")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.Pcip50)
                    .HasColumnName("PCIP50")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.Pcip51)
                    .HasColumnName("PCIP51")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.Pcip52)
                    .HasColumnName("PCIP52")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.Pcip54)
                    .HasColumnName("PCIP54")
                    .HasColumnType("decimal(5, 2)");

                entity.HasOne(d => d.Unit)
                    .WithOne(p => p.Academics)
                    .HasForeignKey<Academics>(d => d.Unitid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_UNITID");
            });

            modelBuilder.Entity<Admissions>(entity =>
            {
                entity.HasKey(e => e.Unitid)
                    .HasName("PK_Admissions_UNITID");

                entity.ToTable("Admissions", "cscData");

                entity.Property(e => e.Unitid)
                    .HasColumnName("UNITID")
                    .ValueGeneratedNever();

                entity.Property(e => e.Actcm25)
                    .HasColumnName("ACTCM25")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.Actcm75)
                    .HasColumnName("ACTCM75")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.Actcmmid)
                    .HasColumnName("ACTCMMID")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.Acten25)
                    .HasColumnName("ACTEN25")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.Acten75)
                    .HasColumnName("ACTEN75")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.Actenmid)
                    .HasColumnName("ACTENMID")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.Actmt25)
                    .HasColumnName("ACTMT25")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.Actmt75)
                    .HasColumnName("ACTMT75")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.Actmtmid)
                    .HasColumnName("ACTMTMID")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.Actwr25)
                    .HasColumnName("ACTWR25")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.Actwr75)
                    .HasColumnName("ACTWR75")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.Actwrmid)
                    .HasColumnName("ACTWRMID")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.AdmRate)
                    .HasColumnName("ADM_RATE")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.AdmRateAll)
                    .HasColumnName("ADM_RATE_ALL")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.SatAvg)
                    .HasColumnName("SAT_AVG")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.SatAvgAll)
                    .HasColumnName("SAT_AVG_ALL")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.Satmt25)
                    .HasColumnName("SATMT25")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.Satmt75)
                    .HasColumnName("SATMT75")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.Satmtmid)
                    .HasColumnName("SATMTMID")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.Satvr25)
                    .HasColumnName("SATVR25")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.Satvr75)
                    .HasColumnName("SATVR75")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.Satvrmid)
                    .HasColumnName("SATVRMID")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.Satwr25)
                    .HasColumnName("SATWR25")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.Satwr75)
                    .HasColumnName("SATWR75")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.Satwrmid)
                    .HasColumnName("SATWRMID")
                    .HasColumnType("decimal(5, 2)");

                entity.HasOne(d => d.Unit)
                    .WithOne(p => p.Admissions)
                    .HasForeignKey<Admissions>(d => d.Unitid)
                    .OnDelete(DeleteBehavior.ClientSetNull);
            });

            modelBuilder.Entity<Completion>(entity =>
            {
                entity.HasKey(e => e.Unitid)
                    .HasName("PK_Completion_UNITID");

                entity.ToTable("Completion", "cscData");

                entity.Property(e => e.Unitid)
                    .HasColumnName("UNITID")
                    .ValueGeneratedNever();

                entity.Property(e => e.C1004)
                    .HasColumnName("C100_4")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.C1004Pooled)
                    .HasColumnName("C100_4_POOLED")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.C1004PooledSupp)
                    .HasColumnName("C100_4_POOLED_SUPP")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.C100L4)
                    .HasColumnName("C100_L4")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.C100L4Pooled)
                    .HasColumnName("C100_L4_POOLED")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.C100L4PooledSupp)
                    .HasColumnName("C100_L4_POOLED_SUPP")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.C1504)
                    .HasColumnName("C150_4")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.C15042mor)
                    .HasColumnName("C150_4_2MOR")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.C1504Aian)
                    .HasColumnName("C150_4_AIAN")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.C1504Aianold)
                    .HasColumnName("C150_4_AIANOLD")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.C1504Api)
                    .HasColumnName("C150_4_API")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.C1504Asian)
                    .HasColumnName("C150_4_ASIAN")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.C1504Black)
                    .HasColumnName("C150_4_BLACK")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.C1504Blacknh)
                    .HasColumnName("C150_4_BLACKNH")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.C1504Hisp)
                    .HasColumnName("C150_4_HISP")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.C1504Hispold)
                    .HasColumnName("C150_4_HISPOLD")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.C1504Loannopell)
                    .HasColumnName("C150_4_LOANNOPELL")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.C1504Nhpi)
                    .HasColumnName("C150_4_NHPI")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.C1504Noloannopell)
                    .HasColumnName("C150_4_NOLOANNOPELL")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.C1504Nra)
                    .HasColumnName("C150_4_NRA")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.C1504Pell)
                    .HasColumnName("C150_4_PELL")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.C1504Pooled)
                    .HasColumnName("C150_4_POOLED")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.C1504PooledSupp)
                    .HasColumnName("C150_4_POOLED_SUPP")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.C1504Unkn)
                    .HasColumnName("C150_4_UNKN")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.C1504White)
                    .HasColumnName("C150_4_WHITE")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.C1504Whitenh)
                    .HasColumnName("C150_4_WHITENH")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.C150L4)
                    .HasColumnName("C150_L4")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.C150L42mor)
                    .HasColumnName("C150_L4_2MOR")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.C150L4Aian)
                    .HasColumnName("C150_L4_AIAN")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.C150L4Aianold)
                    .HasColumnName("C150_L4_AIANOLD")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.C150L4Api)
                    .HasColumnName("C150_L4_API")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.C150L4Asian)
                    .HasColumnName("C150_L4_ASIAN")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.C150L4Black)
                    .HasColumnName("C150_L4_BLACK")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.C150L4Blacknh)
                    .HasColumnName("C150_L4_BLACKNH")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.C150L4Hisp)
                    .HasColumnName("C150_L4_HISP")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.C150L4Hispold)
                    .HasColumnName("C150_L4_HISPOLD")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.C150L4Loannopell)
                    .HasColumnName("C150_L4_LOANNOPELL")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.C150L4Nhpi)
                    .HasColumnName("C150_L4_NHPI")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.C150L4Noloannopell)
                    .HasColumnName("C150_L4_NOLOANNOPELL")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.C150L4Nra)
                    .HasColumnName("C150_L4_NRA")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.C150L4Pell)
                    .HasColumnName("C150_L4_PELL")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.C150L4Pooled)
                    .HasColumnName("C150_L4_POOLED")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.C150L4PooledSupp)
                    .HasColumnName("C150_L4_POOLED_SUPP")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.C150L4Unkn)
                    .HasColumnName("C150_L4_UNKN")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.C150L4White)
                    .HasColumnName("C150_L4_WHITE")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.C150L4Whitenh)
                    .HasColumnName("C150_L4_WHITENH")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.C2004)
                    .HasColumnName("C200_4")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.C2004Pooled)
                    .HasColumnName("C200_4_POOLED")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.C2004PooledSupp)
                    .HasColumnName("C200_4_POOLED_SUPP")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.C200L4)
                    .HasColumnName("C200_L4")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.C200L4Pooled)
                    .HasColumnName("C200_L4_POOLED")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.C200L4PooledSupp)
                    .HasColumnName("C200_L4_POOLED_SUPP")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.D1004).HasColumnName("D100_4");

                entity.Property(e => e.D1004Pooled).HasColumnName("D100_4_POOLED");

                entity.Property(e => e.D100L4).HasColumnName("D100_L4");

                entity.Property(e => e.D100L4Pooled).HasColumnName("D100_L4_POOLED");

                entity.Property(e => e.D1504).HasColumnName("D150_4");

                entity.Property(e => e.D15042mor).HasColumnName("D150_4_2MOR");

                entity.Property(e => e.D1504Aian).HasColumnName("D150_4_AIAN");

                entity.Property(e => e.D1504Aianold).HasColumnName("D150_4_AIANOld");

                entity.Property(e => e.D1504Api).HasColumnName("D150_4_API");

                entity.Property(e => e.D1504Asian).HasColumnName("D150_4_ASIAN");

                entity.Property(e => e.D1504Black).HasColumnName("D150_4_BLACK");

                entity.Property(e => e.D1504Blacknh).HasColumnName("D150_4_BLACKNH");

                entity.Property(e => e.D1504Hisp).HasColumnName("D150_4_HISP");

                entity.Property(e => e.D1504Hispold).HasColumnName("D150_4_HISPOld");

                entity.Property(e => e.D1504Loannopell).HasColumnName("D150_4_LOANNOPELL");

                entity.Property(e => e.D1504Nhpi).HasColumnName("D150_4_NHPI");

                entity.Property(e => e.D1504Noloannopell).HasColumnName("D150_4_NOLOANNOPELL");

                entity.Property(e => e.D1504Nra).HasColumnName("D150_4_NRA");

                entity.Property(e => e.D1504Pell).HasColumnName("D150_4_PELL");

                entity.Property(e => e.D1504Pooled).HasColumnName("D150_4_POOLED");

                entity.Property(e => e.D1504Unkn).HasColumnName("D150_4_UNKN");

                entity.Property(e => e.D1504White).HasColumnName("D150_4_WHITE");

                entity.Property(e => e.D1504Whitenh).HasColumnName("D150_4_WHITENH");

                entity.Property(e => e.D150L4).HasColumnName("D150_L4");

                entity.Property(e => e.D150L42mor).HasColumnName("D150_L4_2MOR");

                entity.Property(e => e.D150L4Aian).HasColumnName("D150_L4_AIAN");

                entity.Property(e => e.D150L4Aianold).HasColumnName("D150_L4_AIANOld");

                entity.Property(e => e.D150L4Api).HasColumnName("D150_L4_API");

                entity.Property(e => e.D150L4Asian).HasColumnName("D150_L4_ASIAN");

                entity.Property(e => e.D150L4Black).HasColumnName("D150_L4_BLACK");

                entity.Property(e => e.D150L4Blacknh).HasColumnName("D150_L4_BLACKNH");

                entity.Property(e => e.D150L4Hisp).HasColumnName("D150_L4_HISP");

                entity.Property(e => e.D150L4Hispold).HasColumnName("D150_L4_HISPOld");

                entity.Property(e => e.D150L4Loannopell).HasColumnName("D150_L4_LOANNOPELL");

                entity.Property(e => e.D150L4Nhpi).HasColumnName("D150_L4_NHPI");

                entity.Property(e => e.D150L4Noloannopell).HasColumnName("D150_L4_NOLOANNOPELL");

                entity.Property(e => e.D150L4Nra).HasColumnName("D150_L4_NRA");

                entity.Property(e => e.D150L4Pell).HasColumnName("D150_L4_PELL");

                entity.Property(e => e.D150L4Pooled).HasColumnName("D150_L4_POOLED");

                entity.Property(e => e.D150L4Unkn).HasColumnName("D150_L4_UNKN");

                entity.Property(e => e.D150L4White).HasColumnName("D150_L4_WHITE");

                entity.Property(e => e.D150L4Whitenh).HasColumnName("D150_L4_WHITENH");

                entity.Property(e => e.D2004)
                    .HasColumnName("D200_4")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.D2004Pooled)
                    .HasColumnName("D200_4_POOLED")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.D200L4)
                    .HasColumnName("D200_L4")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.D200L4Pooled)
                    .HasColumnName("D200_L4_POOLED")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.DepYr2N).HasColumnName("DEP_YR2_N");

                entity.Property(e => e.DepYr3N).HasColumnName("DEP_YR3_N");

                entity.Property(e => e.DepYr4N).HasColumnName("DEP_YR4_N");

                entity.Property(e => e.DepYr6N).HasColumnName("DEP_YR6_N");

                entity.Property(e => e.DepYr8N).HasColumnName("DEP_YR8_N");

                entity.Property(e => e.Dtrans4).HasColumnName("DTRANS_4");

                entity.Property(e => e.Dtrans4Pooled).HasColumnName("DTRANS_4_POOLED");

                entity.Property(e => e.DtransL4).HasColumnName("DTRANS_L4");

                entity.Property(e => e.DtransL4Pooled).HasColumnName("DTRANS_L4_POOLED");

                entity.Property(e => e.FemaleYr2N).HasColumnName("FEMALE_YR2_N");

                entity.Property(e => e.FemaleYr3N).HasColumnName("FEMALE_YR3_N");

                entity.Property(e => e.FemaleYr4N).HasColumnName("FEMALE_YR4_N");

                entity.Property(e => e.FemaleYr6N).HasColumnName("FEMALE_YR6_N");

                entity.Property(e => e.FemaleYr8N).HasColumnName("FEMALE_YR8_N");

                entity.Property(e => e.FirstgenYr2N).HasColumnName("FIRSTGEN_YR2_N");

                entity.Property(e => e.FirstgenYr3N).HasColumnName("FIRSTGEN_YR3_N");

                entity.Property(e => e.FirstgenYr4N).HasColumnName("FIRSTGEN_YR4_N");

                entity.Property(e => e.FirstgenYr6N).HasColumnName("FIRSTGEN_YR6_N");

                entity.Property(e => e.FirstgenYr8N).HasColumnName("FIRSTGEN_YR8_N");

                entity.Property(e => e.HiIncYr2N).HasColumnName("HI_INC_YR2_N");

                entity.Property(e => e.HiIncYr3N).HasColumnName("HI_INC_YR3_N");

                entity.Property(e => e.HiIncYr4N).HasColumnName("HI_INC_YR4_N");

                entity.Property(e => e.HiIncYr6N).HasColumnName("HI_INC_YR6_N");

                entity.Property(e => e.HiIncYr8N).HasColumnName("HI_INC_YR8_N");

                entity.Property(e => e.IndYr2N).HasColumnName("IND_YR2_N");

                entity.Property(e => e.IndYr3N).HasColumnName("IND_YR3_N");

                entity.Property(e => e.IndYr4N).HasColumnName("IND_YR4_N");

                entity.Property(e => e.IndYr6N).HasColumnName("IND_YR6_N");

                entity.Property(e => e.IndYr8N).HasColumnName("IND_YR8_N");

                entity.Property(e => e.LoIncYr2N).HasColumnName("LO_INC_YR2_N");

                entity.Property(e => e.LoIncYr3N).HasColumnName("LO_INC_YR3_N");

                entity.Property(e => e.LoIncYr4N).HasColumnName("LO_INC_YR4_N");

                entity.Property(e => e.LoIncYr6N).HasColumnName("LO_INC_YR6_N");

                entity.Property(e => e.LoIncYr8N).HasColumnName("LO_INC_YR8_N");

                entity.Property(e => e.LoanYr2N).HasColumnName("LOAN_YR2_N");

                entity.Property(e => e.LoanYr3N).HasColumnName("LOAN_YR3_N");

                entity.Property(e => e.LoanYr4N).HasColumnName("LOAN_YR4_N");

                entity.Property(e => e.LoanYr6N).HasColumnName("LOAN_YR6_N");

                entity.Property(e => e.LoanYr8N).HasColumnName("LOAN_YR8_N");

                entity.Property(e => e.MaleYr2N).HasColumnName("MALE_YR2_N");

                entity.Property(e => e.MaleYr3N).HasColumnName("MALE_YR3_N");

                entity.Property(e => e.MaleYr4N).HasColumnName("MALE_YR4_N");

                entity.Property(e => e.MaleYr6N).HasColumnName("MALE_YR6_N");

                entity.Property(e => e.MaleYr8N).HasColumnName("MALE_YR8_N");

                entity.Property(e => e.MdIncYr2N).HasColumnName("MD_INC_YR2_N");

                entity.Property(e => e.MdIncYr3N).HasColumnName("MD_INC_YR3_N");

                entity.Property(e => e.MdIncYr4N).HasColumnName("MD_INC_YR4_N");

                entity.Property(e => e.MdIncYr6N).HasColumnName("MD_INC_YR6_N");

                entity.Property(e => e.MdIncYr8N).HasColumnName("MD_INC_YR8_N");

                entity.Property(e => e.NoloanYr2N).HasColumnName("NOLOAN_YR2_N");

                entity.Property(e => e.NoloanYr3N).HasColumnName("NOLOAN_YR3_N");

                entity.Property(e => e.NoloanYr4N).HasColumnName("NOLOAN_YR4_N");

                entity.Property(e => e.NoloanYr6N).HasColumnName("NOLOAN_YR6_N");

                entity.Property(e => e.NoloanYr8N).HasColumnName("NOLOAN_YR8_N");

                entity.Property(e => e.NopellYr2N).HasColumnName("NOPELL_YR2_N");

                entity.Property(e => e.NopellYr3N).HasColumnName("NOPELL_YR3_N");

                entity.Property(e => e.NopellYr4N).HasColumnName("NOPELL_YR4_N");

                entity.Property(e => e.NopellYr6N).HasColumnName("NOPELL_YR6_N");

                entity.Property(e => e.NopellYr8N).HasColumnName("NOPELL_YR8_N");

                entity.Property(e => e.Not1stgenYr2N).HasColumnName("NOT1STGEN_YR2_N");

                entity.Property(e => e.Not1stgenYr3N).HasColumnName("NOT1STGEN_YR3_N");

                entity.Property(e => e.Not1stgenYr4N).HasColumnName("NOT1STGEN_YR4_N");

                entity.Property(e => e.Not1stgenYr6N).HasColumnName("NOT1STGEN_YR6_N");

                entity.Property(e => e.Not1stgenYr8N).HasColumnName("NOT1STGEN_YR8_N");

                entity.Property(e => e.Omacht6Ftft).HasColumnName("OMACHT6_FTFT");

                entity.Property(e => e.Omacht6FtftPooled).HasColumnName("OMACHT6_FTFT_POOLED");

                entity.Property(e => e.Omacht6Ftnft).HasColumnName("OMACHT6_FTNFT");

                entity.Property(e => e.Omacht6FtnftPooled).HasColumnName("OMACHT6_FTNFT_POOLED");

                entity.Property(e => e.Omacht6Ptft).HasColumnName("OMACHT6_PTFT");

                entity.Property(e => e.Omacht6PtftPooled).HasColumnName("OMACHT6_PTFT_POOLED");

                entity.Property(e => e.Omacht6Ptnft).HasColumnName("OMACHT6_PTNFT");

                entity.Property(e => e.Omacht6PtnftPooled).HasColumnName("OMACHT6_PTNFT_POOLED");

                entity.Property(e => e.Omacht8Ftft).HasColumnName("OMACHT8_FTFT");

                entity.Property(e => e.Omacht8FtftPooled).HasColumnName("OMACHT8_FTFT_POOLED");

                entity.Property(e => e.Omacht8Ftnft).HasColumnName("OMACHT8_FTNFT");

                entity.Property(e => e.Omacht8FtnftPooled).HasColumnName("OMACHT8_FTNFT_POOLED");

                entity.Property(e => e.Omacht8Ptft).HasColumnName("OMACHT8_PTFT");

                entity.Property(e => e.Omacht8PtftPooled).HasColumnName("OMACHT8_PTFT_POOLED");

                entity.Property(e => e.Omacht8Ptnft).HasColumnName("OMACHT8_PTNFT");

                entity.Property(e => e.Omacht8PtnftPooled).HasColumnName("OMACHT8_PTNFT_POOLED");

                entity.Property(e => e.Omawdp6Ftft)
                    .HasColumnName("OMAWDP6_FTFT")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.Omawdp6FtftPooled)
                    .HasColumnName("OMAWDP6_FTFT_POOLED")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.Omawdp6FtftPooledSupp)
                    .HasColumnName("OMAWDP6_FTFT_POOLED_SUPP")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.Omawdp6Ftnft)
                    .HasColumnName("OMAWDP6_FTNFT")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.Omawdp6FtnftPooled)
                    .HasColumnName("OMAWDP6_FTNFT_POOLED")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.Omawdp6FtnftPooledSupp)
                    .HasColumnName("OMAWDP6_FTNFT_POOLED_SUPP")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.Omawdp6Ptft)
                    .HasColumnName("OMAWDP6_PTFT")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.Omawdp6PtftPooled)
                    .HasColumnName("OMAWDP6_PTFT_POOLED")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.Omawdp6PtftPooledSupp)
                    .HasColumnName("OMAWDP6_PTFT_POOLED_SUPP")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.Omawdp6Ptnft)
                    .HasColumnName("OMAWDP6_PTNFT")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.Omawdp6PtnftPooled)
                    .HasColumnName("OMAWDP6_PTNFT_POOLED")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.Omawdp6PtnftPooledSupp)
                    .HasColumnName("OMAWDP6_PTNFT_POOLED_SUPP")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.Omawdp8Ftft)
                    .HasColumnName("OMAWDP8_FTFT")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.Omawdp8FtftPooled)
                    .HasColumnName("OMAWDP8_FTFT_POOLED")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.Omawdp8FtftPooledSupp)
                    .HasColumnName("OMAWDP8_FTFT_POOLED_SUPP")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.Omawdp8Ftnft)
                    .HasColumnName("OMAWDP8_FTNFT")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.Omawdp8FtnftPooled)
                    .HasColumnName("OMAWDP8_FTNFT_POOLED")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.Omawdp8FtnftPooledSupp)
                    .HasColumnName("OMAWDP8_FTNFT_POOLED_SUPP")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.Omawdp8Ptft)
                    .HasColumnName("OMAWDP8_PTFT")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.Omawdp8PtftPooled)
                    .HasColumnName("OMAWDP8_PTFT_POOLED")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.Omawdp8PtftPooledSupp)
                    .HasColumnName("OMAWDP8_PTFT_POOLED_SUPP")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.Omawdp8Ptnft)
                    .HasColumnName("OMAWDP8_PTNFT")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.Omawdp8PtnftPooled)
                    .HasColumnName("OMAWDP8_PTNFT_POOLED")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.Omawdp8PtnftPooledSupp)
                    .HasColumnName("OMAWDP8_PTNFT_POOLED_SUPP")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.Omenrap8Ftft)
                    .HasColumnName("OMENRAP8_FTFT")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.Omenrap8FtftPooled)
                    .HasColumnName("OMENRAP8_FTFT_POOLED")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.Omenrap8FtftPooledSupp)
                    .HasColumnName("OMENRAP8_FTFT_POOLED_SUPP")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.Omenrap8Ftnft)
                    .HasColumnName("OMENRAP8_FTNFT")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.Omenrap8FtnftPooled)
                    .HasColumnName("OMENRAP8_FTNFT_POOLED")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.Omenrap8FtnftPooledSupp)
                    .HasColumnName("OMENRAP8_FTNFT_POOLED_SUPP")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.Omenrap8Ptft)
                    .HasColumnName("OMENRAP8_PTFT")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.Omenrap8PtftPooled)
                    .HasColumnName("OMENRAP8_PTFT_POOLED")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.Omenrap8PtftPooledSupp)
                    .HasColumnName("OMENRAP8_PTFT_POOLED_SUPP")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.Omenrap8Ptnft)
                    .HasColumnName("OMENRAP8_PTNFT")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.Omenrap8PtnftPooled)
                    .HasColumnName("OMENRAP8_PTNFT_POOLED")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.Omenrap8PtnftPooledSupp)
                    .HasColumnName("OMENRAP8_PTNFT_POOLED_SUPP")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.Omenrup8Ftft)
                    .HasColumnName("OMENRUP8_FTFT")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.Omenrup8FtftPooled)
                    .HasColumnName("OMENRUP8_FTFT_POOLED")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.Omenrup8FtftPooledSupp)
                    .HasColumnName("OMENRUP8_FTFT_POOLED_SUPP")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.Omenrup8Ftnft)
                    .HasColumnName("OMENRUP8_FTNFT")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.Omenrup8FtnftPooled)
                    .HasColumnName("OMENRUP8_FTNFT_POOLED")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.Omenrup8FtnftPooledSupp)
                    .HasColumnName("OMENRUP8_FTNFT_POOLED_SUPP")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.Omenrup8Ptft)
                    .HasColumnName("OMENRUP8_PTFT")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.Omenrup8PtftPooled)
                    .HasColumnName("OMENRUP8_PTFT_POOLED")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.Omenrup8PtftPooledSupp)
                    .HasColumnName("OMENRUP8_PTFT_POOLED_SUPP")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.Omenrup8Ptnft)
                    .HasColumnName("OMENRUP8_PTNFT")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.Omenrup8PtnftPooled)
                    .HasColumnName("OMENRUP8_PTNFT_POOLED")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.Omenrup8PtnftPooledSupp)
                    .HasColumnName("OMENRUP8_PTNFT_POOLED_SUPP")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.Omenryp8Ftft)
                    .HasColumnName("OMENRYP8_FTFT")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.Omenryp8FtftPooled)
                    .HasColumnName("OMENRYP8_FTFT_POOLED")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.Omenryp8FtftPooledSupp)
                    .HasColumnName("OMENRYP8_FTFT_POOLED_SUPP")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.Omenryp8Ftnft)
                    .HasColumnName("OMENRYP8_FTNFT")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.Omenryp8FtnftPooled)
                    .HasColumnName("OMENRYP8_FTNFT_POOLED")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.Omenryp8FtnftPooledSupp)
                    .HasColumnName("OMENRYP8_FTNFT_POOLED_SUPP")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.Omenryp8Ptft)
                    .HasColumnName("OMENRYP8_PTFT")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.Omenryp8PtftPooled)
                    .HasColumnName("OMENRYP8_PTFT_POOLED")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.Omenryp8PtftPooledSupp)
                    .HasColumnName("OMENRYP8_PTFT_POOLED_SUPP")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.Omenryp8Ptnft)
                    .HasColumnName("OMENRYP8_PTNFT")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.Omenryp8PtnftPooled)
                    .HasColumnName("OMENRYP8_PTNFT_POOLED")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.Omenryp8PtnftPooledSupp)
                    .HasColumnName("OMENRYP8_PTNFT_POOLED_SUPP")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.OverallYr2N).HasColumnName("OVERALL_YR2_N");

                entity.Property(e => e.OverallYr3N).HasColumnName("OVERALL_YR3_N");

                entity.Property(e => e.OverallYr4N).HasColumnName("OVERALL_YR4_N");

                entity.Property(e => e.OverallYr6N).HasColumnName("OVERALL_YR6_N");

                entity.Property(e => e.OverallYr8N).HasColumnName("OVERALL_YR8_N");

                entity.Property(e => e.PellYr2N).HasColumnName("PELL_YR2_N");

                entity.Property(e => e.PellYr3N).HasColumnName("PELL_YR3_N");

                entity.Property(e => e.PellYr4N).HasColumnName("PELL_YR4_N");

                entity.Property(e => e.PellYr6N).HasColumnName("PELL_YR6_N");

                entity.Property(e => e.PellYr8N).HasColumnName("PELL_YR8_N");

                entity.Property(e => e.Poolyrs).HasColumnName("POOLYRS");

                entity.Property(e => e.Poolyrs100).HasColumnName("POOLYRS100");

                entity.Property(e => e.Poolyrs200).HasColumnName("POOLYRS200");

                entity.Property(e => e.PoolyrsOmFtft).HasColumnName("poolyrsOM_FTFT");

                entity.Property(e => e.PoolyrsOmFtnft).HasColumnName("poolyrsOM_FTNFT");

                entity.Property(e => e.PoolyrsOmPtft).HasColumnName("poolyrsOM_PTFT");

                entity.Property(e => e.PoolyrsOmPtnft).HasColumnName("poolyrsOM_PTNFT");

                entity.Property(e => e.SeparDtMdn)
                    .HasColumnName("SEPAR_DT_MDN")
                    .HasMaxLength(20);

                entity.Property(e => e.SeparDtN).HasColumnName("SEPAR_DT_N");

                entity.Property(e => e.Trans4)
                    .HasColumnName("TRANS_4")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.Trans4Pooled)
                    .HasColumnName("TRANS_4_POOLED")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.Trans4PooledSupp)
                    .HasColumnName("TRANS_4_POOLED_SUPP")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.TransL4)
                    .HasColumnName("TRANS_L4")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.TransL4Pooled)
                    .HasColumnName("TRANS_L4_POOLED")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.TransL4PooledSupp)
                    .HasColumnName("TRANS_L4_POOLED_SUPP")
                    .HasColumnType("decimal(5, 2)");

                entity.HasOne(d => d.Unit)
                    .WithOne(p => p.Completion)
                    .HasForeignKey<Completion>(d => d.Unitid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("PK_Completion_Root_UNITID");
            });

            modelBuilder.Entity<Cost>(entity =>
            {
                entity.HasKey(e => e.Unitid)
                    .HasName("PK_Cost_UNITID");

                entity.ToTable("Cost", "cscData");

                entity.Property(e => e.Unitid)
                    .HasColumnName("UNITID")
                    .ValueGeneratedNever();

                entity.Property(e => e.Costt4A).HasColumnName("COSTT4_A");

                entity.Property(e => e.Costt4P).HasColumnName("COSTT4_P");

                entity.Property(e => e.Npt4048Other).HasColumnName("NPT4_048_OTHER");

                entity.Property(e => e.Npt4048Priv).HasColumnName("NPT4_048_PRIV");

                entity.Property(e => e.Npt4048Prog).HasColumnName("NPT4_048_PROG");

                entity.Property(e => e.Npt4048Pub).HasColumnName("NPT4_048_PUB");

                entity.Property(e => e.Npt41Other).HasColumnName("NPT41_OTHER");

                entity.Property(e => e.Npt41Priv).HasColumnName("NPT41_PRIV");

                entity.Property(e => e.Npt41Prog).HasColumnName("NPT41_PROG");

                entity.Property(e => e.Npt41Pub).HasColumnName("NPT41_PUB");

                entity.Property(e => e.Npt42Other).HasColumnName("NPT42_OTHER");

                entity.Property(e => e.Npt42Priv).HasColumnName("NPT42_PRIV");

                entity.Property(e => e.Npt42Prog).HasColumnName("NPT42_PROG");

                entity.Property(e => e.Npt42Pub).HasColumnName("NPT42_PUB");

                entity.Property(e => e.Npt43075Other).HasColumnName("NPT4_3075_OTHER");

                entity.Property(e => e.Npt43075Priv).HasColumnName("NPT4_3075_PRIV");

                entity.Property(e => e.Npt43075Prog).HasColumnName("NPT4_3075_PROG");

                entity.Property(e => e.Npt43075Pub).HasColumnName("NPT4_3075_PUB");

                entity.Property(e => e.Npt43Other).HasColumnName("NPT43_OTHER");

                entity.Property(e => e.Npt43Priv).HasColumnName("NPT43_PRIV");

                entity.Property(e => e.Npt43Prog).HasColumnName("NPT43_PROG");

                entity.Property(e => e.Npt43Pub).HasColumnName("NPT43_PUB");

                entity.Property(e => e.Npt44Other).HasColumnName("NPT44_OTHER");

                entity.Property(e => e.Npt44Priv).HasColumnName("NPT44_PRIV");

                entity.Property(e => e.Npt44Prog).HasColumnName("NPT44_PROG");

                entity.Property(e => e.Npt44Pub).HasColumnName("NPT44_PUB");

                entity.Property(e => e.Npt45Other).HasColumnName("NPT45_OTHER");

                entity.Property(e => e.Npt45Priv).HasColumnName("NPT45_PRIV");

                entity.Property(e => e.Npt45Prog).HasColumnName("NPT45_PROG");

                entity.Property(e => e.Npt45Pub).HasColumnName("NPT45_PUB");

                entity.Property(e => e.Npt475upOther).HasColumnName("NPT4_75UP_OTHER");

                entity.Property(e => e.Npt475upPriv).HasColumnName("NPT4_75UP_PRIV");

                entity.Property(e => e.Npt475upProg).HasColumnName("NPT4_75UP_PROG");

                entity.Property(e => e.Npt475upPub).HasColumnName("NPT4_75UP_PUB");

                entity.Property(e => e.Npt4Other).HasColumnName("NPT4_OTHER");

                entity.Property(e => e.Npt4Priv).HasColumnName("NPT4_PRIV");

                entity.Property(e => e.Npt4Prog).HasColumnName("NPT4_PROG");

                entity.Property(e => e.Npt4Pub).HasColumnName("NPT4_PUB");

                entity.Property(e => e.Num41Other).HasColumnName("NUM41_OTHER");

                entity.Property(e => e.Num41Priv).HasColumnName("NUM41_PRIV");

                entity.Property(e => e.Num41Prog).HasColumnName("NUM41_PROG");

                entity.Property(e => e.Num41Pub).HasColumnName("NUM41_PUB");

                entity.Property(e => e.Num42Other).HasColumnName("NUM42_OTHER");

                entity.Property(e => e.Num42Priv).HasColumnName("NUM42_PRIV");

                entity.Property(e => e.Num42Prog).HasColumnName("NUM42_PROG");

                entity.Property(e => e.Num42Pub).HasColumnName("NUM42_PUB");

                entity.Property(e => e.Num43Other).HasColumnName("NUM43_OTHER");

                entity.Property(e => e.Num43Priv).HasColumnName("NUM43_PRIV");

                entity.Property(e => e.Num43Prog).HasColumnName("NUM43_PROG");

                entity.Property(e => e.Num43Pub).HasColumnName("NUM43_PUB");

                entity.Property(e => e.Num44Other).HasColumnName("NUM44_OTHER");

                entity.Property(e => e.Num44Priv).HasColumnName("NUM44_PRIV");

                entity.Property(e => e.Num44Prog).HasColumnName("NUM44_PROG");

                entity.Property(e => e.Num44Pub).HasColumnName("NUM44_PUB");

                entity.Property(e => e.Num45Other).HasColumnName("NUM45_OTHER");

                entity.Property(e => e.Num45Priv).HasColumnName("NUM45_PRIV");

                entity.Property(e => e.Num45Prog).HasColumnName("NUM45_PROG");

                entity.Property(e => e.Num45Pub).HasColumnName("NUM45_PUB");

                entity.Property(e => e.Num4Other).HasColumnName("NUM4_OTHER");

                entity.Property(e => e.Num4Priv).HasColumnName("NUM4_PRIV");

                entity.Property(e => e.Num4Prog).HasColumnName("NUM4_PROG");

                entity.Property(e => e.Num4Pub).HasColumnName("NUM4_PUB");

                entity.Property(e => e.TuitionfeeIn).HasColumnName("TUITIONFEE_IN");

                entity.Property(e => e.TuitionfeeOut).HasColumnName("TUITIONFEE_OUT");

                entity.Property(e => e.TuitionfeeProg).HasColumnName("TUITIONFEE_PROG");

                entity.HasOne(d => d.Unit)
                    .WithOne(p => p.Cost)
                    .HasForeignKey<Cost>(d => d.Unitid)
                    .OnDelete(DeleteBehavior.ClientSetNull);
            });

            modelBuilder.Entity<Earnings>(entity =>
            {
                entity.HasKey(e => e.Unitid)
                    .HasName("PK_Earning_UNITID");

                entity.ToTable("Earnings", "cscData");

                entity.Property(e => e.Unitid)
                    .HasColumnName("UNITID")
                    .ValueGeneratedNever();

                entity.Property(e => e.CountEd).HasColumnName("COUNT_ED");

                entity.Property(e => e.CountNwneP10).HasColumnName("COUNT_NWNE_P10");

                entity.Property(e => e.CountNwneP6).HasColumnName("COUNT_NWNE_P6");

                entity.Property(e => e.CountNwneP7)
                    .HasColumnName("COUNT_NWNE_P7")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.CountNwneP8).HasColumnName("COUNT_NWNE_P8");

                entity.Property(e => e.CountNwneP9).HasColumnName("COUNT_NWNE_P9");

                entity.Property(e => e.CountWneInc1P10).HasColumnName("COUNT_WNE_INC1_P10");

                entity.Property(e => e.CountWneInc1P6).HasColumnName("COUNT_WNE_INC1_P6");

                entity.Property(e => e.CountWneInc2P10).HasColumnName("COUNT_WNE_INC2_P10");

                entity.Property(e => e.CountWneInc2P6).HasColumnName("COUNT_WNE_INC2_P6");

                entity.Property(e => e.CountWneInc3P10).HasColumnName("COUNT_WNE_INC3_P10");

                entity.Property(e => e.CountWneInc3P6).HasColumnName("COUNT_WNE_INC3_P6");

                entity.Property(e => e.CountWneIndep0Inc1P10).HasColumnName("COUNT_WNE_INDEP0_INC1_P10");

                entity.Property(e => e.CountWneIndep0Inc1P6).HasColumnName("COUNT_WNE_INDEP0_INC1_P6");

                entity.Property(e => e.CountWneIndep0P10).HasColumnName("COUNT_WNE_INDEP0_P10");

                entity.Property(e => e.CountWneIndep0P6).HasColumnName("COUNT_WNE_INDEP0_P6");

                entity.Property(e => e.CountWneIndep1P10).HasColumnName("COUNT_WNE_INDEP1_P10");

                entity.Property(e => e.CountWneIndep1P6).HasColumnName("COUNT_WNE_INDEP1_P6");

                entity.Property(e => e.CountWneMale0P10).HasColumnName("COUNT_WNE_MALE0_P10");

                entity.Property(e => e.CountWneMale0P6).HasColumnName("COUNT_WNE_MALE0_P6");

                entity.Property(e => e.CountWneMale1P10).HasColumnName("COUNT_WNE_MALE1_P10");

                entity.Property(e => e.CountWneMale1P6).HasColumnName("COUNT_WNE_MALE1_P6");

                entity.Property(e => e.CountWneP10).HasColumnName("COUNT_WNE_P10");

                entity.Property(e => e.CountWneP6).HasColumnName("COUNT_WNE_P6");

                entity.Property(e => e.CountWneP7).HasColumnName("COUNT_WNE_P7");

                entity.Property(e => e.CountWneP8).HasColumnName("COUNT_WNE_P8");

                entity.Property(e => e.CountWneP9).HasColumnName("COUNT_WNE_P9");

                entity.Property(e => e.Gt25kP10)
                    .HasColumnName("GT_25K_P10")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.Gt25kP6)
                    .HasColumnName("GT_25K_P6")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.Gt25kP7)
                    .HasColumnName("GT_25K_P7")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.Gt25kP8)
                    .HasColumnName("GT_25K_P8")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.Gt25kP9)
                    .HasColumnName("GT_25K_P9")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.Gt28kP10)
                    .HasColumnName("GT_28K_P10")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.Gt28kP6)
                    .HasColumnName("GT_28K_P6")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.Gt28kP8)
                    .HasColumnName("GT_28K_P8")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.MdEarnWneP10).HasColumnName("MD_EARN_WNE_P10");

                entity.Property(e => e.MdEarnWneP6).HasColumnName("MD_EARN_WNE_P6");

                entity.Property(e => e.MdEarnWneP8)
                    .HasColumnName("MD_EARN_WNE_P8")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.MnEarnWneInc1P10).HasColumnName("MN_EARN_WNE_INC1_P10");

                entity.Property(e => e.MnEarnWneInc1P6)
                    .HasColumnName("MN_EARN_WNE_INC1_P6")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.MnEarnWneInc2P10).HasColumnName("MN_EARN_WNE_INC2_P10");

                entity.Property(e => e.MnEarnWneInc2P6)
                    .HasColumnName("MN_EARN_WNE_INC2_P6")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.MnEarnWneInc3P10).HasColumnName("MN_EARN_WNE_INC3_P10");

                entity.Property(e => e.MnEarnWneInc3P6)
                    .HasColumnName("MN_EARN_WNE_INC3_P6")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.MnEarnWneIndep0Inc1P10).HasColumnName("MN_EARN_WNE_INDEP0_INC1_P10");

                entity.Property(e => e.MnEarnWneIndep0Inc1P6)
                    .HasColumnName("MN_EARN_WNE_INDEP0_INC1_P6")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.MnEarnWneIndep0P10).HasColumnName("MN_EARN_WNE_INDEP0_P10");

                entity.Property(e => e.MnEarnWneIndep0P6)
                    .HasColumnName("MN_EARN_WNE_INDEP0_P6")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.MnEarnWneIndep1P10).HasColumnName("MN_EARN_WNE_INDEP1_P10");

                entity.Property(e => e.MnEarnWneIndep1P6)
                    .HasColumnName("MN_EARN_WNE_INDEP1_P6")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.MnEarnWneMale0P10).HasColumnName("MN_EARN_WNE_MALE0_P10");

                entity.Property(e => e.MnEarnWneMale0P6)
                    .HasColumnName("MN_EARN_WNE_MALE0_P6")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.MnEarnWneMale1P10).HasColumnName("MN_EARN_WNE_MALE1_P10");

                entity.Property(e => e.MnEarnWneMale1P6)
                    .HasColumnName("MN_EARN_WNE_MALE1_P6")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.MnEarnWneP10).HasColumnName("MN_EARN_WNE_P10");

                entity.Property(e => e.MnEarnWneP6).HasColumnName("MN_EARN_WNE_P6");

                entity.Property(e => e.MnEarnWneP7)
                    .HasColumnName("MN_EARN_WNE_P7")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.MnEarnWneP8)
                    .HasColumnName("MN_EARN_WNE_P8")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.MnEarnWneP9)
                    .HasColumnName("MN_EARN_WNE_P9")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.Pct10EarnWneP10).HasColumnName("PCT10_EARN_WNE_P10");

                entity.Property(e => e.Pct10EarnWneP6).HasColumnName("PCT10_EARN_WNE_P6");

                entity.Property(e => e.Pct10EarnWneP8).HasColumnName("PCT10_EARN_WNE_P8");

                entity.Property(e => e.Pct25EarnWneP10).HasColumnName("PCT25_EARN_WNE_P10");

                entity.Property(e => e.Pct25EarnWneP6).HasColumnName("PCT25_EARN_WNE_P6");

                entity.Property(e => e.Pct25EarnWneP8).HasColumnName("PCT25_EARN_WNE_P8");

                entity.Property(e => e.Pct75EarnWneP10).HasColumnName("PCT75_EARN_WNE_P10");

                entity.Property(e => e.Pct75EarnWneP6).HasColumnName("PCT75_EARN_WNE_P6");

                entity.Property(e => e.Pct75EarnWneP8).HasColumnName("PCT75_EARN_WNE_P8");

                entity.Property(e => e.Pct90EarnWneP10).HasColumnName("PCT90_EARN_WNE_P10");

                entity.Property(e => e.Pct90EarnWneP6).HasColumnName("PCT90_EARN_WNE_P6");

                entity.Property(e => e.Pct90EarnWneP8).HasColumnName("PCT90_EARN_WNE_P8");

                entity.Property(e => e.SdEarnWneP10).HasColumnName("SD_EARN_WNE_P10");

                entity.Property(e => e.SdEarnWneP6).HasColumnName("SD_EARN_WNE_P6");

                entity.Property(e => e.SdEarnWneP7)
                    .HasColumnName("SD_EARN_WNE_P7")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.SdEarnWneP8)
                    .HasColumnName("SD_EARN_WNE_P8")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.SdEarnWneP9)
                    .HasColumnName("SD_EARN_WNE_P9")
                    .HasColumnType("decimal(5, 2)");

                entity.HasOne(d => d.Unit)
                    .WithOne(p => p.Earnings)
                    .HasForeignKey<Earnings>(d => d.Unitid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Earning_Root_UNITID");
            });

            modelBuilder.Entity<Repayment>(entity =>
            {
                entity.HasKey(e => e.Unitid)
                    .HasName("PK_Repayment_UNITID");

                entity.ToTable("Repayment", "cscData");

                entity.Property(e => e.Unitid)
                    .HasColumnName("UNITID")
                    .ValueGeneratedNever();

                entity.Property(e => e.Cdr2)
                    .HasColumnName("CDR2")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.Cdr2Denom).HasColumnName("CDR2_DENOM");

                entity.Property(e => e.Cdr3)
                    .HasColumnName("CDR3")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.Cdr3Denom).HasColumnName("CDR3_DENOM");

                entity.Property(e => e.ComplRpy1yrN).HasColumnName("COMPL_RPY_1YR_N");

                entity.Property(e => e.ComplRpy1yrRt)
                    .HasColumnName("COMPL_RPY_1YR_RT")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.ComplRpy3yrN).HasColumnName("COMPL_RPY_3YR_N");

                entity.Property(e => e.ComplRpy3yrRt)
                    .HasColumnName("COMPL_RPY_3YR_RT")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.ComplRpy3yrRtSupp)
                    .HasColumnName("COMPL_RPY_3YR_RT_SUPP")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.ComplRpy5yrN).HasColumnName("COMPL_RPY_5YR_N");

                entity.Property(e => e.ComplRpy5yrRt)
                    .HasColumnName("COMPL_RPY_5YR_RT")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.ComplRpy7yrN).HasColumnName("COMPL_RPY_7YR_N");

                entity.Property(e => e.ComplRpy7yrRt)
                    .HasColumnName("COMPL_RPY_7YR_RT")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.DepRpy1yrN).HasColumnName("DEP_RPY_1YR_N");

                entity.Property(e => e.DepRpy1yrRt)
                    .HasColumnName("DEP_RPY_1YR_RT")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.DepRpy3yrN).HasColumnName("DEP_RPY_3YR_N");

                entity.Property(e => e.DepRpy3yrRt)
                    .HasColumnName("DEP_RPY_3YR_RT")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.DepRpy3yrRtSupp)
                    .HasColumnName("DEP_RPY_3YR_RT_SUPP")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.DepRpy5yrN).HasColumnName("DEP_RPY_5YR_N");

                entity.Property(e => e.DepRpy5yrRt)
                    .HasColumnName("DEP_RPY_5YR_RT")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.DepRpy7yrN).HasColumnName("DEP_RPY_7YR_N");

                entity.Property(e => e.DepRpy7yrRt)
                    .HasColumnName("DEP_RPY_7YR_RT")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.FemaleRpy1yrN).HasColumnName("FEMALE_RPY_1YR_N");

                entity.Property(e => e.FemaleRpy1yrRt)
                    .HasColumnName("FEMALE_RPY_1YR_RT")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.FemaleRpy3yrN).HasColumnName("FEMALE_RPY_3YR_N");

                entity.Property(e => e.FemaleRpy3yrRt)
                    .HasColumnName("FEMALE_RPY_3YR_RT")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.FemaleRpy3yrRtSupp)
                    .HasColumnName("FEMALE_RPY_3YR_RT_SUPP")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.FemaleRpy5yrN).HasColumnName("FEMALE_RPY_5YR_N");

                entity.Property(e => e.FemaleRpy5yrRt)
                    .HasColumnName("FEMALE_RPY_5YR_RT")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.FemaleRpy7yrN).HasColumnName("FEMALE_RPY_7YR_N");

                entity.Property(e => e.FemaleRpy7yrRt)
                    .HasColumnName("FEMALE_RPY_7YR_RT")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.FirstgenRpy1yrN).HasColumnName("FIRSTGEN_RPY_1YR_N");

                entity.Property(e => e.FirstgenRpy1yrRt)
                    .HasColumnName("FIRSTGEN_RPY_1YR_RT")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.FirstgenRpy3yrN).HasColumnName("FIRSTGEN_RPY_3YR_N");

                entity.Property(e => e.FirstgenRpy3yrRt)
                    .HasColumnName("FIRSTGEN_RPY_3YR_RT")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.FirstgenRpy3yrRtSupp)
                    .HasColumnName("FIRSTGEN_RPY_3YR_RT_SUPP")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.FirstgenRpy5yrN).HasColumnName("FIRSTGEN_RPY_5YR_N");

                entity.Property(e => e.FirstgenRpy5yrRt)
                    .HasColumnName("FIRSTGEN_RPY_5YR_RT")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.FirstgenRpy7yrN).HasColumnName("FIRSTGEN_RPY_7YR_N");

                entity.Property(e => e.FirstgenRpy7yrRt)
                    .HasColumnName("FIRSTGEN_RPY_7YR_RT")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.HiIncRpy1yrN).HasColumnName("HI_INC_RPY_1YR_N");

                entity.Property(e => e.HiIncRpy1yrRt)
                    .HasColumnName("HI_INC_RPY_1YR_RT")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.HiIncRpy3yrN).HasColumnName("HI_INC_RPY_3YR_N");

                entity.Property(e => e.HiIncRpy3yrRt)
                    .HasColumnName("HI_INC_RPY_3YR_RT")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.HiIncRpy3yrRtSupp)
                    .HasColumnName("HI_INC_RPY_3YR_RT_SUPP")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.HiIncRpy5yrN).HasColumnName("HI_INC_RPY_5YR_N");

                entity.Property(e => e.HiIncRpy5yrRt)
                    .HasColumnName("HI_INC_RPY_5YR_RT")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.HiIncRpy7yrN).HasColumnName("HI_INC_RPY_7YR_N");

                entity.Property(e => e.HiIncRpy7yrRt)
                    .HasColumnName("HI_INC_RPY_7YR_RT")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.IndRpy1yrN).HasColumnName("IND_RPY_1YR_N");

                entity.Property(e => e.IndRpy1yrRt)
                    .HasColumnName("IND_RPY_1YR_RT")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.IndRpy3yrN).HasColumnName("IND_RPY_3YR_N");

                entity.Property(e => e.IndRpy3yrRt)
                    .HasColumnName("IND_RPY_3YR_RT")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.IndRpy3yrRtSupp)
                    .HasColumnName("IND_RPY_3YR_RT_SUPP")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.IndRpy5yrN).HasColumnName("IND_RPY_5YR_N");

                entity.Property(e => e.IndRpy5yrRt)
                    .HasColumnName("IND_RPY_5YR_RT")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.IndRpy7yrN).HasColumnName("IND_RPY_7YR_N");

                entity.Property(e => e.IndRpy7yrRt)
                    .HasColumnName("IND_RPY_7YR_RT")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.LoIncRpy1yrN).HasColumnName("LO_INC_RPY_1YR_N");

                entity.Property(e => e.LoIncRpy1yrRt)
                    .HasColumnName("LO_INC_RPY_1YR_RT")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.LoIncRpy3yrN).HasColumnName("LO_INC_RPY_3YR_N");

                entity.Property(e => e.LoIncRpy3yrRt)
                    .HasColumnName("LO_INC_RPY_3YR_RT")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.LoIncRpy3yrRtSupp)
                    .HasColumnName("LO_INC_RPY_3YR_RT_SUPP")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.LoIncRpy5yrN).HasColumnName("LO_INC_RPY_5YR_N");

                entity.Property(e => e.LoIncRpy5yrRt)
                    .HasColumnName("LO_INC_RPY_5YR_RT")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.LoIncRpy7yrN).HasColumnName("LO_INC_RPY_7YR_N");

                entity.Property(e => e.LoIncRpy7yrRt)
                    .HasColumnName("LO_INC_RPY_7YR_RT")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.MaleRpy1yrN).HasColumnName("MALE_RPY_1YR_N");

                entity.Property(e => e.MaleRpy1yrRt)
                    .HasColumnName("MALE_RPY_1YR_RT")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.MaleRpy3yrN).HasColumnName("MALE_RPY_3YR_N");

                entity.Property(e => e.MaleRpy3yrRt)
                    .HasColumnName("MALE_RPY_3YR_RT")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.MaleRpy3yrRtSupp)
                    .HasColumnName("MALE_RPY_3YR_RT_SUPP")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.MaleRpy5yrN).HasColumnName("MALE_RPY_5YR_N");

                entity.Property(e => e.MaleRpy5yrRt)
                    .HasColumnName("MALE_RPY_5YR_RT")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.MaleRpy7yrN).HasColumnName("MALE_RPY_7YR_N");

                entity.Property(e => e.MaleRpy7yrRt)
                    .HasColumnName("MALE_RPY_7YR_RT")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.MdIncRpy1yrN).HasColumnName("MD_INC_RPY_1YR_N");

                entity.Property(e => e.MdIncRpy1yrRt)
                    .HasColumnName("MD_INC_RPY_1YR_RT")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.MdIncRpy3yrN).HasColumnName("MD_INC_RPY_3YR_N");

                entity.Property(e => e.MdIncRpy3yrRt)
                    .HasColumnName("MD_INC_RPY_3YR_RT")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.MdIncRpy3yrRtSupp)
                    .HasColumnName("MD_INC_RPY_3YR_RT_SUPP")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.MdIncRpy5yrN).HasColumnName("MD_INC_RPY_5YR_N");

                entity.Property(e => e.MdIncRpy5yrRt)
                    .HasColumnName("MD_INC_RPY_5YR_RT")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.MdIncRpy7yrN).HasColumnName("MD_INC_RPY_7YR_N");

                entity.Property(e => e.MdIncRpy7yrRt)
                    .HasColumnName("MD_INC_RPY_7YR_RT")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.NoncomRpy1yrN).HasColumnName("NONCOM_RPY_1YR_N");

                entity.Property(e => e.NoncomRpy1yrRt)
                    .HasColumnName("NONCOM_RPY_1YR_RT")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.NoncomRpy3yrN).HasColumnName("NONCOM_RPY_3YR_N");

                entity.Property(e => e.NoncomRpy3yrRt)
                    .HasColumnName("NONCOM_RPY_3YR_RT")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.NoncomRpy3yrRtSupp)
                    .HasColumnName("NONCOM_RPY_3YR_RT_SUPP")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.NoncomRpy5yrN).HasColumnName("NONCOM_RPY_5YR_N");

                entity.Property(e => e.NoncomRpy5yrRt)
                    .HasColumnName("NONCOM_RPY_5YR_RT")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.NoncomRpy7yrN).HasColumnName("NONCOM_RPY_7YR_N");

                entity.Property(e => e.NoncomRpy7yrRt)
                    .HasColumnName("NONCOM_RPY_7YR_RT")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.NopellRpy1yrN).HasColumnName("NOPELL_RPY_1YR_N");

                entity.Property(e => e.NopellRpy1yrRt)
                    .HasColumnName("NOPELL_RPY_1YR_RT")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.NopellRpy3yrN).HasColumnName("NOPELL_RPY_3YR_N");

                entity.Property(e => e.NopellRpy3yrRt)
                    .HasColumnName("NOPELL_RPY_3YR_RT")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.NopellRpy3yrRtSupp)
                    .HasColumnName("NOPELL_RPY_3YR_RT_SUPP")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.NopellRpy5yrN).HasColumnName("NOPELL_RPY_5YR_N");

                entity.Property(e => e.NopellRpy5yrRt)
                    .HasColumnName("NOPELL_RPY_5YR_RT")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.NopellRpy7yrN).HasColumnName("NOPELL_RPY_7YR_N");

                entity.Property(e => e.NopellRpy7yrRt)
                    .HasColumnName("NOPELL_RPY_7YR_RT")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.NotfirstgenRpy1yrN).HasColumnName("NOTFIRSTGEN_RPY_1YR_N");

                entity.Property(e => e.NotfirstgenRpy1yrRt)
                    .HasColumnName("NOTFIRSTGEN_RPY_1YR_RT")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.NotfirstgenRpy3yrN).HasColumnName("NOTFIRSTGEN_RPY_3YR_N");

                entity.Property(e => e.NotfirstgenRpy3yrRt)
                    .HasColumnName("NOTFIRSTGEN_RPY_3YR_RT")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.NotfirstgenRpy3yrRtSupp)
                    .HasColumnName("NOTFIRSTGEN_RPY_3YR_RT_SUPP")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.NotfirstgenRpy5yrN).HasColumnName("NOTFIRSTGEN_RPY_5YR_N");

                entity.Property(e => e.NotfirstgenRpy5yrRt)
                    .HasColumnName("NOTFIRSTGEN_RPY_5YR_RT")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.NotfirstgenRpy7yrN).HasColumnName("NOTFIRSTGEN_RPY_7YR_N");

                entity.Property(e => e.NotfirstgenRpy7yrRt)
                    .HasColumnName("NOTFIRSTGEN_RPY_7YR_RT")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.PellRpy1yrN).HasColumnName("PELL_RPY_1YR_N");

                entity.Property(e => e.PellRpy1yrRt)
                    .HasColumnName("PELL_RPY_1YR_RT")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.PellRpy3yrN).HasColumnName("PELL_RPY_3YR_N");

                entity.Property(e => e.PellRpy3yrRt)
                    .HasColumnName("PELL_RPY_3YR_RT")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.PellRpy3yrRtSupp)
                    .HasColumnName("PELL_RPY_3YR_RT_SUPP")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.PellRpy5yrN).HasColumnName("PELL_RPY_5YR_N");

                entity.Property(e => e.PellRpy5yrRt)
                    .HasColumnName("PELL_RPY_5YR_RT")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.PellRpy7yrN).HasColumnName("PELL_RPY_7YR_N");

                entity.Property(e => e.PellRpy7yrRt)
                    .HasColumnName("PELL_RPY_7YR_RT")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.RepayDtMdn)
                    .HasColumnName("REPAY_DT_MDN")
                    .HasMaxLength(20);

                entity.Property(e => e.RepayDtN).HasColumnName("REPAY_DT_N");

                entity.Property(e => e.Rpy1yrN).HasColumnName("RPY_1YR_N");

                entity.Property(e => e.Rpy1yrRt)
                    .HasColumnName("RPY_1YR_RT")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.Rpy3yrN).HasColumnName("RPY_3YR_N");

                entity.Property(e => e.Rpy3yrRt)
                    .HasColumnName("RPY_3YR_RT")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.Rpy3yrRtSupp)
                    .HasColumnName("RPY_3YR_RT_SUPP")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.Rpy5yrN).HasColumnName("RPY_5YR_N");

                entity.Property(e => e.Rpy5yrRt)
                    .HasColumnName("RPY_5YR_RT")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.Rpy7yrN).HasColumnName("RPY_7YR_N");

                entity.Property(e => e.Rpy7yrRt)
                    .HasColumnName("RPY_7YR_RT")
                    .HasColumnType("decimal(5, 2)");

                entity.HasOne(d => d.Unit)
                    .WithOne(p => p.Repayment)
                    .HasForeignKey<Repayment>(d => d.Unitid)
                    .OnDelete(DeleteBehavior.ClientSetNull);
            });

            modelBuilder.Entity<Root>(entity =>
            {
                entity.HasKey(e => e.Unitid)
                    .HasName("PK_Root_UNITID");

                entity.ToTable("Root", "cscData");

                entity.Property(e => e.Unitid)
                    .HasColumnName("UNITID")
                    .ValueGeneratedNever();

                entity.Property(e => e.Latitude)
                    .HasColumnName("LATITUDE")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.Longitude)
                    .HasColumnName("LONGITUDE")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.Opeid).HasColumnName("OPEID");

                entity.Property(e => e.Opeid6).HasColumnName("OPEID6");
            });

            modelBuilder.Entity<School>(entity =>
            {
                entity.HasKey(e => e.Unitid)
                    .HasName("PK_School_UNITID");

                entity.ToTable("School", "cscData");

                entity.Property(e => e.Unitid)
                    .HasColumnName("UNITID")
                    .ValueGeneratedNever();

                entity.Property(e => e.Aanapii).HasColumnName("AANAPII");

                entity.Property(e => e.Accredagency)
                    .HasColumnName("ACCREDAGENCY")
                    .HasMaxLength(20);

                entity.Property(e => e.Accredcode)
                    .HasColumnName("ACCREDCODE")
                    .HasMaxLength(20);

                entity.Property(e => e.Alias)
                    .HasColumnName("ALIAS")
                    .HasMaxLength(20);

                entity.Property(e => e.Annhi).HasColumnName("ANNHI");

                entity.Property(e => e.Avgfacsal).HasColumnName("AVGFACSAL");

                entity.Property(e => e.Ccbasic).HasColumnName("CCBASIC");

                entity.Property(e => e.Ccsizset).HasColumnName("CCSIZSET");

                entity.Property(e => e.Ccugprof).HasColumnName("CCUGPROF");

                entity.Property(e => e.City)
                    .HasColumnName("CITY")
                    .HasMaxLength(20);

                entity.Property(e => e.Control).HasColumnName("CONTROL");

                entity.Property(e => e.Curroper).HasColumnName("CURROPER");

                entity.Property(e => e.Distanceonly).HasColumnName("DISTANCEONLY");

                entity.Property(e => e.Hbcu).HasColumnName("HBCU");

                entity.Property(e => e.Hcm2).HasColumnName("HCM2");

                entity.Property(e => e.Highdeg).HasColumnName("HIGHDEG");

                entity.Property(e => e.Hsi).HasColumnName("HSI");

                entity.Property(e => e.Iclevel).HasColumnName("ICLEVEL");

                entity.Property(e => e.Inexpfte).HasColumnName("INEXPFTE");

                entity.Property(e => e.Instnm)
                    .HasColumnName("INSTNM")
                    .HasMaxLength(20);

                entity.Property(e => e.Insturl)
                    .HasColumnName("INSTURL")
                    .HasMaxLength(20);

                entity.Property(e => e.Locale).HasColumnName("LOCALE");

                entity.Property(e => e.Locale2).HasColumnName("LOCALE2");

                entity.Property(e => e.Main).HasColumnName("MAIN");

                entity.Property(e => e.Menonly).HasColumnName("MENONLY");

                entity.Property(e => e.Nanti).HasColumnName("NANTI");

                entity.Property(e => e.Npcurl)
                    .HasColumnName("NPCURL")
                    .HasMaxLength(20);

                entity.Property(e => e.Numbranch).HasColumnName("NUMBRANCH");

                entity.Property(e => e.Openadmp).HasColumnName("OPENADMP");

                entity.Property(e => e.Pbi).HasColumnName("PBI");

                entity.Property(e => e.Pftfac)
                    .HasColumnName("PFTFAC")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.Preddeg).HasColumnName("PREDDEG");

                entity.Property(e => e.Region).HasColumnName("REGION");

                entity.Property(e => e.Relaffil).HasColumnName("RELAFFIL");

                entity.Property(e => e.SchDeg).HasColumnName("SCH_DEG");

                entity.Property(e => e.StFips).HasColumnName("ST_FIPS");

                entity.Property(e => e.Stabbr)
                    .HasColumnName("STABBR")
                    .HasMaxLength(20);

                entity.Property(e => e.T4approvaldate)
                    .HasColumnName("T4APPROVALDATE")
                    .HasMaxLength(20);

                entity.Property(e => e.Tribal).HasColumnName("TRIBAL");

                entity.Property(e => e.Tuitfte).HasColumnName("TUITFTE");

                entity.Property(e => e.Womenonly).HasColumnName("WOMENONLY");

                entity.Property(e => e.Zip)
                    .HasColumnName("ZIP")
                    .HasMaxLength(20);

                entity.HasOne(d => d.Unit)
                    .WithOne(p => p.School)
                    .HasForeignKey<School>(d => d.Unitid)
                    .OnDelete(DeleteBehavior.ClientSetNull);
            });

            modelBuilder.Entity<Student>(entity =>
            {
                entity.HasKey(e => e.Unitid)
                    .HasName("PK_Student_UNITID");

                entity.ToTable("Student", "cscData");

                entity.Property(e => e.Unitid)
                    .HasColumnName("UNITID")
                    .ValueGeneratedNever();

                entity.Property(e => e.AgeEntry)
                    .HasColumnName("AGE_ENTRY")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.AgeEntrySq).HasColumnName("AGE_ENTRY_SQ");

                entity.Property(e => e.Agege24)
                    .HasColumnName("AGEGE24")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.ApplSchN).HasColumnName("APPL_SCH_N");

                entity.Property(e => e.ApplSchPctGe2)
                    .HasColumnName("APPL_SCH_PCT_GE2")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.ApplSchPctGe3)
                    .HasColumnName("APPL_SCH_PCT_GE3")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.ApplSchPctGe4)
                    .HasColumnName("APPL_SCH_PCT_GE4")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.ApplSchPctGe5)
                    .HasColumnName("APPL_SCH_PCT_GE5")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.DPctpellPctfloan).HasColumnName("D_PCTPELL_PCTFLOAN");

                entity.Property(e => e.DepIncAvg)
                    .HasColumnName("DEP_INC_AVG")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.DepIncN).HasColumnName("DEP_INC_N");

                entity.Property(e => e.DepIncPctH1)
                    .HasColumnName("DEP_INC_PCT_H1")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.DepIncPctH2)
                    .HasColumnName("DEP_INC_PCT_H2")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.DepIncPctLo)
                    .HasColumnName("DEP_INC_PCT_LO")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.DepIncPctM1)
                    .HasColumnName("DEP_INC_PCT_M1")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.DepIncPctM2)
                    .HasColumnName("DEP_INC_PCT_M2")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.DepStatN).HasColumnName("DEP_STAT_N");

                entity.Property(e => e.DepStatPctInd)
                    .HasColumnName("DEP_STAT_PCT_IND")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.Dependent)
                    .HasColumnName("DEPENDENT")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.Faminc)
                    .HasColumnName("FAMINC")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.FamincInd)
                    .HasColumnName("FAMINC_IND")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.Female)
                    .HasColumnName("FEMALE")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.FirstGen)
                    .HasColumnName("FIRST_GEN")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.Fsend1)
                    .HasColumnName("FSEND_1")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.Fsend2)
                    .HasColumnName("FSEND_2")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.Fsend3)
                    .HasColumnName("FSEND_3")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.Fsend4)
                    .HasColumnName("FSEND_4")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.Fsend5)
                    .HasColumnName("FSEND_5")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.FsendCount).HasColumnName("FSEND_COUNT");

                entity.Property(e => e.Grads).HasColumnName("GRADS");

                entity.Property(e => e.IncN).HasColumnName("INC_N");

                entity.Property(e => e.IncPctH1)
                    .HasColumnName("INC_PCT_H1")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.IncPctH2)
                    .HasColumnName("INC_PCT_H2")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.IncPctLo)
                    .HasColumnName("INC_PCT_LO")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.IncPctM1)
                    .HasColumnName("INC_PCT_M1")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.IncPctM2)
                    .HasColumnName("INC_PCT_M2")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.IndIncAvg)
                    .HasColumnName("IND_INC_AVG")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.IndIncN).HasColumnName("IND_INC_N");

                entity.Property(e => e.IndIncPctH1)
                    .HasColumnName("IND_INC_PCT_H1")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.IndIncPctH2)
                    .HasColumnName("IND_INC_PCT_H2")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.IndIncPctLo)
                    .HasColumnName("IND_INC_PCT_LO")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.IndIncPctM1)
                    .HasColumnName("IND_INC_PCT_M1")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.IndIncPctM2)
                    .HasColumnName("IND_INC_PCT_M2")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.LnMedianHhInc).HasColumnName("LN_MEDIAN_HH_INC");

                entity.Property(e => e.Lnfaminc).HasColumnName("LNFAMINC");

                entity.Property(e => e.LnfamincInd).HasColumnName("LNFAMINC_IND");

                entity.Property(e => e.Married)
                    .HasColumnName("MARRIED")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.MdFaminc)
                    .HasColumnName("MD_FAMINC")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.MedianHhInc).HasColumnName("MEDIAN_HH_INC");

                entity.Property(e => e.ParEdN).HasColumnName("PAR_ED_N");

                entity.Property(e => e.ParEdPct1stgen)
                    .HasColumnName("PAR_ED_PCT_1STGEN")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.ParEdPctHs)
                    .HasColumnName("PAR_ED_PCT_HS")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.ParEdPctMs)
                    .HasColumnName("PAR_ED_PCT_MS")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.ParEdPctPs)
                    .HasColumnName("PAR_ED_PCT_PS")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.PctAsian)
                    .HasColumnName("PCT_ASIAN")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.PctBa)
                    .HasColumnName("PCT_BA")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.PctBlack)
                    .HasColumnName("PCT_BLACK")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.PctBornUs)
                    .HasColumnName("PCT_BORN_US")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.PctGradProf)
                    .HasColumnName("PCT_GRAD_PROF")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.PctHispanic)
                    .HasColumnName("PCT_HISPANIC")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.PctWhite)
                    .HasColumnName("PCT_WHITE")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.PellEver)
                    .HasColumnName("PELL_EVER")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.Pftftug1Ef)
                    .HasColumnName("PFTFTUG1_EF")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.PoolyrsretFt).HasColumnName("POOLYRSRET_FT");

                entity.Property(e => e.PoolyrsretPt).HasColumnName("POOLYRSRET_PT");

                entity.Property(e => e.PovertyRate)
                    .HasColumnName("POVERTY_RATE")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.PptugEf)
                    .HasColumnName("PPTUG_EF")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.PptugEf2)
                    .HasColumnName("PPTUG_EF2")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.RetFt4)
                    .HasColumnName("RET_FT4")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.RetFt4Pooled)
                    .HasColumnName("RET_FT4_POOLED")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.RetFt4PooledSupp)
                    .HasColumnName("RET_FT4_POOLED_SUPP")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.RetFtDen4Pooled)
                    .HasColumnName("RET_FT_DEN4_POOLED")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.RetFtDenl4Pooled)
                    .HasColumnName("RET_FT_DENL4_POOLED")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.RetFtl4)
                    .HasColumnName("RET_FTL4")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.RetFtl4Pooled)
                    .HasColumnName("RET_FTL4_POOLED")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.RetFtl4PooledSupp)
                    .HasColumnName("RET_FTL4_POOLED_SUPP")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.RetPt4)
                    .HasColumnName("RET_PT4")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.RetPt4Pooled)
                    .HasColumnName("RET_PT4_POOLED")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.RetPt4PooledSupp)
                    .HasColumnName("RET_PT4_POOLED_SUPP")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.RetPtDen4Pooled)
                    .HasColumnName("RET_PT_DEN4_POOLED")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.RetPtDenl4Pooled)
                    .HasColumnName("RET_PT_DENL4_POOLED")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.RetPtl4)
                    .HasColumnName("RET_PTL4")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.RetPtl4Pooled)
                    .HasColumnName("RET_PTL4_POOLED")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.RetPtl4PooledSupp)
                    .HasColumnName("RET_PTL4_POOLED_SUPP")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.Ug).HasColumnName("UG");

                entity.Property(e => e.Ug25abv)
                    .HasColumnName("UG25ABV")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.UgAianold)
                    .HasColumnName("UG_AIANOLD")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.UgApi)
                    .HasColumnName("UG_API")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.UgBlacknh)
                    .HasColumnName("UG_BLACKNH")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.UgHispold)
                    .HasColumnName("UG_HISPOLD")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.UgNra)
                    .HasColumnName("UG_NRA")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.UgUnkn)
                    .HasColumnName("UG_UNKN")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.UgWhitenh)
                    .HasColumnName("UG_WHITENH")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.Ugds).HasColumnName("UGDS");

                entity.Property(e => e.Ugds2mor)
                    .HasColumnName("UGDS_2MOR")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.UgdsAian)
                    .HasColumnName("UGDS_AIAN")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.UgdsAianold)
                    .HasColumnName("UGDS_AIANOLD")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.UgdsApi)
                    .HasColumnName("UGDS_API")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.UgdsAsian)
                    .HasColumnName("UGDS_ASIAN")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.UgdsBlack)
                    .HasColumnName("UGDS_BLACK")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.UgdsBlacknh)
                    .HasColumnName("UGDS_BLACKNH")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.UgdsHisp)
                    .HasColumnName("UGDS_HISP")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.UgdsHispold)
                    .HasColumnName("UGDS_HISPOLD")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.UgdsMen)
                    .HasColumnName("UGDS_MEN")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.UgdsNhpi)
                    .HasColumnName("UGDS_NHPI")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.UgdsNra)
                    .HasColumnName("UGDS_NRA")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.UgdsUnkn)
                    .HasColumnName("UGDS_UNKN")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.UgdsWhite)
                    .HasColumnName("UGDS_WHITE")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.UgdsWhitenh)
                    .HasColumnName("UGDS_WHITENH")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.UgdsWomen)
                    .HasColumnName("UGDS_WOMEN")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.Ugnonds).HasColumnName("UGNONDS");

                entity.Property(e => e.UnempRate)
                    .HasColumnName("UNEMP_RATE")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.Veteran)
                    .HasColumnName("VETERAN")
                    .HasColumnType("decimal(5, 2)");

                entity.HasOne(d => d.Unit)
                    .WithOne(p => p.Student)
                    .HasForeignKey<Student>(d => d.Unitid)
                    .OnDelete(DeleteBehavior.ClientSetNull);
            });

            modelBuilder.Entity<TitleIv>(entity =>
            {
                entity.HasKey(e => e.Unitid)
                    .HasName("PK_Completion_TitleIV_UNITID");

                entity.ToTable("TitleIV", "cscData");

                entity.Property(e => e.Unitid)
                    .HasColumnName("UNITID")
                    .ValueGeneratedNever();

                entity.Property(e => e.Comp2yrTransYr2Rt)
                    .HasColumnName("COMP_2YR_TRANS_YR2_RT")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.Comp2yrTransYr3Rt)
                    .HasColumnName("COMP_2YR_TRANS_YR3_RT")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.Comp2yrTransYr4Rt)
                    .HasColumnName("COMP_2YR_TRANS_YR4_RT")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.Comp2yrTransYr6Rt)
                    .HasColumnName("COMP_2YR_TRANS_YR6_RT")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.Comp2yrTransYr8Rt)
                    .HasColumnName("COMP_2YR_TRANS_YR8_RT")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.Comp4yrTransYr2Rt)
                    .HasColumnName("COMP_4YR_TRANS_YR2_RT")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.Comp4yrTransYr3Rt)
                    .HasColumnName("COMP_4YR_TRANS_YR3_RT")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.Comp4yrTransYr4Rt)
                    .HasColumnName("COMP_4YR_TRANS_YR4_RT")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.Comp4yrTransYr6Rt)
                    .HasColumnName("COMP_4YR_TRANS_YR6_RT")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.Comp4yrTransYr8Rt)
                    .HasColumnName("COMP_4YR_TRANS_YR8_RT")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.CompOrigYr2Rt)
                    .HasColumnName("COMP_ORIG_YR2_RT")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.CompOrigYr3Rt)
                    .HasColumnName("COMP_ORIG_YR3_RT")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.CompOrigYr4Rt)
                    .HasColumnName("COMP_ORIG_YR4_RT")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.CompOrigYr6Rt)
                    .HasColumnName("COMP_ORIG_YR6_RT")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.CompOrigYr8Rt)
                    .HasColumnName("COMP_ORIG_YR8_RT")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.DeathYr2Rt)
                    .HasColumnName("DEATH_YR2_RT")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.DeathYr3Rt)
                    .HasColumnName("DEATH_YR3_RT")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.DeathYr4Rt)
                    .HasColumnName("DEATH_YR4_RT")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.DeathYr6Rt)
                    .HasColumnName("DEATH_YR6_RT")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.DeathYr8Rt)
                    .HasColumnName("DEATH_YR8_RT")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.DepComp2yrTransYr2Rt)
                    .HasColumnName("DEP_COMP_2YR_TRANS_YR2_RT")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.DepComp2yrTransYr3Rt)
                    .HasColumnName("DEP_COMP_2YR_TRANS_YR3_RT")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.DepComp2yrTransYr4Rt)
                    .HasColumnName("DEP_COMP_2YR_TRANS_YR4_RT")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.DepComp2yrTransYr6Rt)
                    .HasColumnName("DEP_COMP_2YR_TRANS_YR6_RT")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.DepComp2yrTransYr8Rt)
                    .HasColumnName("DEP_COMP_2YR_TRANS_YR8_RT")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.DepComp4yrTransYr2Rt)
                    .HasColumnName("DEP_COMP_4YR_TRANS_YR2_RT")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.DepComp4yrTransYr3Rt)
                    .HasColumnName("DEP_COMP_4YR_TRANS_YR3_RT")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.DepComp4yrTransYr4Rt)
                    .HasColumnName("DEP_COMP_4YR_TRANS_YR4_RT")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.DepComp4yrTransYr6Rt)
                    .HasColumnName("DEP_COMP_4YR_TRANS_YR6_RT")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.DepComp4yrTransYr8Rt)
                    .HasColumnName("DEP_COMP_4YR_TRANS_YR8_RT")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.DepCompOrigYr2Rt)
                    .HasColumnName("DEP_COMP_ORIG_YR2_RT")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.DepCompOrigYr3Rt)
                    .HasColumnName("DEP_COMP_ORIG_YR3_RT")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.DepCompOrigYr4Rt)
                    .HasColumnName("DEP_COMP_ORIG_YR4_RT")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.DepCompOrigYr6Rt)
                    .HasColumnName("DEP_COMP_ORIG_YR6_RT")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.DepCompOrigYr8Rt)
                    .HasColumnName("DEP_COMP_ORIG_YR8_RT")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.DepDeathYr2Rt)
                    .HasColumnName("DEP_DEATH_YR2_RT")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.DepDeathYr3Rt)
                    .HasColumnName("DEP_DEATH_YR3_RT")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.DepDeathYr4Rt)
                    .HasColumnName("DEP_DEATH_YR4_RT")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.DepDeathYr6Rt)
                    .HasColumnName("DEP_DEATH_YR6_RT")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.DepDeathYr8Rt)
                    .HasColumnName("DEP_DEATH_YR8_RT")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.DepEnrl2yrTransYr2Rt)
                    .HasColumnName("DEP_ENRL_2YR_TRANS_YR2_RT")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.DepEnrl2yrTransYr3Rt)
                    .HasColumnName("DEP_ENRL_2YR_TRANS_YR3_RT")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.DepEnrl2yrTransYr4Rt)
                    .HasColumnName("DEP_ENRL_2YR_TRANS_YR4_RT")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.DepEnrl2yrTransYr6Rt)
                    .HasColumnName("DEP_ENRL_2YR_TRANS_YR6_RT")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.DepEnrl2yrTransYr8Rt)
                    .HasColumnName("DEP_ENRL_2YR_TRANS_YR8_RT")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.DepEnrl4yrTransYr2Rt)
                    .HasColumnName("DEP_ENRL_4YR_TRANS_YR2_RT")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.DepEnrl4yrTransYr3Rt)
                    .HasColumnName("DEP_ENRL_4YR_TRANS_YR3_RT")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.DepEnrl4yrTransYr4Rt)
                    .HasColumnName("DEP_ENRL_4YR_TRANS_YR4_RT")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.DepEnrl4yrTransYr6Rt)
                    .HasColumnName("DEP_ENRL_4YR_TRANS_YR6_RT")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.DepEnrl4yrTransYr8Rt)
                    .HasColumnName("DEP_ENRL_4YR_TRANS_YR8_RT")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.DepEnrlOrigYr2Rt)
                    .HasColumnName("DEP_ENRL_ORIG_YR2_RT")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.DepEnrlOrigYr3Rt)
                    .HasColumnName("DEP_ENRL_ORIG_YR3_RT")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.DepEnrlOrigYr4Rt)
                    .HasColumnName("DEP_ENRL_ORIG_YR4_RT")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.DepEnrlOrigYr6Rt)
                    .HasColumnName("DEP_ENRL_ORIG_YR6_RT")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.DepEnrlOrigYr8Rt)
                    .HasColumnName("DEP_ENRL_ORIG_YR8_RT")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.DepUnkn2yrTransYr2Rt)
                    .HasColumnName("DEP_UNKN_2YR_TRANS_YR2_RT")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.DepUnkn2yrTransYr3Rt)
                    .HasColumnName("DEP_UNKN_2YR_TRANS_YR3_RT")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.DepUnkn2yrTransYr4Rt)
                    .HasColumnName("DEP_UNKN_2YR_TRANS_YR4_RT")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.DepUnkn2yrTransYr6Rt)
                    .HasColumnName("DEP_UNKN_2YR_TRANS_YR6_RT")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.DepUnkn2yrTransYr8Rt)
                    .HasColumnName("DEP_UNKN_2YR_TRANS_YR8_RT")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.DepUnkn4yrTransYr2Rt)
                    .HasColumnName("DEP_UNKN_4YR_TRANS_YR2_RT")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.DepUnkn4yrTransYr3Rt)
                    .HasColumnName("DEP_UNKN_4YR_TRANS_YR3_RT")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.DepUnkn4yrTransYr4Rt)
                    .HasColumnName("DEP_UNKN_4YR_TRANS_YR4_RT")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.DepUnkn4yrTransYr6Rt)
                    .HasColumnName("DEP_UNKN_4YR_TRANS_YR6_RT")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.DepUnkn4yrTransYr8Rt)
                    .HasColumnName("DEP_UNKN_4YR_TRANS_YR8_RT")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.DepUnknOrigYr2Rt)
                    .HasColumnName("DEP_UNKN_ORIG_YR2_RT")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.DepUnknOrigYr3Rt)
                    .HasColumnName("DEP_UNKN_ORIG_YR3_RT")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.DepUnknOrigYr4Rt)
                    .HasColumnName("DEP_UNKN_ORIG_YR4_RT")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.DepUnknOrigYr6Rt)
                    .HasColumnName("DEP_UNKN_ORIG_YR6_RT")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.DepUnknOrigYr8Rt)
                    .HasColumnName("DEP_UNKN_ORIG_YR8_RT")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.DepWdraw2yrTransYr2Rt)
                    .HasColumnName("DEP_WDRAW_2YR_TRANS_YR2_RT")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.DepWdraw2yrTransYr3Rt)
                    .HasColumnName("DEP_WDRAW_2YR_TRANS_YR3_RT")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.DepWdraw2yrTransYr4Rt)
                    .HasColumnName("DEP_WDRAW_2YR_TRANS_YR4_RT")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.DepWdraw2yrTransYr6Rt)
                    .HasColumnName("DEP_WDRAW_2YR_TRANS_YR6_RT")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.DepWdraw2yrTransYr8Rt)
                    .HasColumnName("DEP_WDRAW_2YR_TRANS_YR8_RT")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.DepWdraw4yrTransYr2Rt)
                    .HasColumnName("DEP_WDRAW_4YR_TRANS_YR2_RT")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.DepWdraw4yrTransYr3Rt)
                    .HasColumnName("DEP_WDRAW_4YR_TRANS_YR3_RT")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.DepWdraw4yrTransYr4Rt)
                    .HasColumnName("DEP_WDRAW_4YR_TRANS_YR4_RT")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.DepWdraw4yrTransYr6Rt)
                    .HasColumnName("DEP_WDRAW_4YR_TRANS_YR6_RT")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.DepWdraw4yrTransYr8Rt)
                    .HasColumnName("DEP_WDRAW_4YR_TRANS_YR8_RT")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.DepWdrawOrigYr2Rt)
                    .HasColumnName("DEP_WDRAW_ORIG_YR2_RT")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.DepWdrawOrigYr3Rt)
                    .HasColumnName("DEP_WDRAW_ORIG_YR3_RT")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.DepWdrawOrigYr4Rt)
                    .HasColumnName("DEP_WDRAW_ORIG_YR4_RT")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.DepWdrawOrigYr6Rt)
                    .HasColumnName("DEP_WDRAW_ORIG_YR6_RT")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.DepWdrawOrigYr8Rt)
                    .HasColumnName("DEP_WDRAW_ORIG_YR8_RT")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.Enrl2yrTransYr2Rt)
                    .HasColumnName("ENRL_2YR_TRANS_YR2_RT")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.Enrl2yrTransYr3Rt)
                    .HasColumnName("ENRL_2YR_TRANS_YR3_RT")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.Enrl2yrTransYr4Rt)
                    .HasColumnName("ENRL_2YR_TRANS_YR4_RT")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.Enrl2yrTransYr6Rt)
                    .HasColumnName("ENRL_2YR_TRANS_YR6_RT")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.Enrl2yrTransYr8Rt)
                    .HasColumnName("ENRL_2YR_TRANS_YR8_RT")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.Enrl4yrTransYr2Rt)
                    .HasColumnName("ENRL_4YR_TRANS_YR2_RT")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.Enrl4yrTransYr3Rt)
                    .HasColumnName("ENRL_4YR_TRANS_YR3_RT")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.Enrl4yrTransYr4Rt)
                    .HasColumnName("ENRL_4YR_TRANS_YR4_RT")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.Enrl4yrTransYr6Rt)
                    .HasColumnName("ENRL_4YR_TRANS_YR6_RT")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.Enrl4yrTransYr8Rt)
                    .HasColumnName("ENRL_4YR_TRANS_YR8_RT")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.EnrlOrigYr2Rt)
                    .HasColumnName("ENRL_ORIG_YR2_RT")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.EnrlOrigYr3Rt)
                    .HasColumnName("ENRL_ORIG_YR3_RT")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.EnrlOrigYr4Rt)
                    .HasColumnName("ENRL_ORIG_YR4_RT")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.EnrlOrigYr6Rt)
                    .HasColumnName("ENRL_ORIG_YR6_RT")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.EnrlOrigYr8Rt)
                    .HasColumnName("ENRL_ORIG_YR8_RT")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.FemaleComp2yrTransYr2Rt)
                    .HasColumnName("FEMALE_COMP_2YR_TRANS_YR2_RT")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.FemaleComp2yrTransYr3Rt)
                    .HasColumnName("FEMALE_COMP_2YR_TRANS_YR3_RT")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.FemaleComp2yrTransYr4Rt)
                    .HasColumnName("FEMALE_COMP_2YR_TRANS_YR4_RT")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.FemaleComp2yrTransYr6Rt)
                    .HasColumnName("FEMALE_COMP_2YR_TRANS_YR6_RT")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.FemaleComp2yrTransYr8Rt)
                    .HasColumnName("FEMALE_COMP_2YR_TRANS_YR8_RT")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.FemaleComp4yrTransYr2Rt)
                    .HasColumnName("FEMALE_COMP_4YR_TRANS_YR2_RT")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.FemaleComp4yrTransYr3Rt)
                    .HasColumnName("FEMALE_COMP_4YR_TRANS_YR3_RT")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.FemaleComp4yrTransYr4Rt)
                    .HasColumnName("FEMALE_COMP_4YR_TRANS_YR4_RT")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.FemaleComp4yrTransYr6Rt)
                    .HasColumnName("FEMALE_COMP_4YR_TRANS_YR6_RT")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.FemaleComp4yrTransYr8Rt)
                    .HasColumnName("FEMALE_COMP_4YR_TRANS_YR8_RT")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.FemaleCompOrigYr2Rt)
                    .HasColumnName("FEMALE_COMP_ORIG_YR2_RT")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.FemaleCompOrigYr3Rt)
                    .HasColumnName("FEMALE_COMP_ORIG_YR3_RT")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.FemaleCompOrigYr4Rt)
                    .HasColumnName("FEMALE_COMP_ORIG_YR4_RT")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.FemaleCompOrigYr6Rt)
                    .HasColumnName("FEMALE_COMP_ORIG_YR6_RT")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.FemaleCompOrigYr8Rt)
                    .HasColumnName("FEMALE_COMP_ORIG_YR8_RT")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.FemaleDeathYr2Rt)
                    .HasColumnName("FEMALE_DEATH_YR2_RT")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.FemaleDeathYr3Rt)
                    .HasColumnName("FEMALE_DEATH_YR3_RT")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.FemaleDeathYr4Rt)
                    .HasColumnName("FEMALE_DEATH_YR4_RT")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.FemaleDeathYr6Rt)
                    .HasColumnName("FEMALE_DEATH_YR6_RT")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.FemaleDeathYr8Rt)
                    .HasColumnName("FEMALE_DEATH_YR8_RT")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.FemaleEnrl2yrTransYr2Rt)
                    .HasColumnName("FEMALE_ENRL_2YR_TRANS_YR2_RT")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.FemaleEnrl2yrTransYr3Rt)
                    .HasColumnName("FEMALE_ENRL_2YR_TRANS_YR3_RT")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.FemaleEnrl2yrTransYr4Rt)
                    .HasColumnName("FEMALE_ENRL_2YR_TRANS_YR4_RT")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.FemaleEnrl2yrTransYr6Rt)
                    .HasColumnName("FEMALE_ENRL_2YR_TRANS_YR6_RT")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.FemaleEnrl2yrTransYr8Rt)
                    .HasColumnName("FEMALE_ENRL_2YR_TRANS_YR8_RT")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.FemaleEnrl4yrTransYr2Rt)
                    .HasColumnName("FEMALE_ENRL_4YR_TRANS_YR2_RT")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.FemaleEnrl4yrTransYr3Rt)
                    .HasColumnName("FEMALE_ENRL_4YR_TRANS_YR3_RT")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.FemaleEnrl4yrTransYr4Rt)
                    .HasColumnName("FEMALE_ENRL_4YR_TRANS_YR4_RT")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.FemaleEnrl4yrTransYr6Rt)
                    .HasColumnName("FEMALE_ENRL_4YR_TRANS_YR6_RT")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.FemaleEnrl4yrTransYr8Rt)
                    .HasColumnName("FEMALE_ENRL_4YR_TRANS_YR8_RT")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.FemaleEnrlOrigYr2Rt)
                    .HasColumnName("FEMALE_ENRL_ORIG_YR2_RT")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.FemaleEnrlOrigYr3Rt)
                    .HasColumnName("FEMALE_ENRL_ORIG_YR3_RT")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.FemaleEnrlOrigYr4Rt)
                    .HasColumnName("FEMALE_ENRL_ORIG_YR4_RT")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.FemaleEnrlOrigYr6Rt)
                    .HasColumnName("FEMALE_ENRL_ORIG_YR6_RT")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.FemaleEnrlOrigYr8Rt)
                    .HasColumnName("FEMALE_ENRL_ORIG_YR8_RT")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.FemaleUnkn2yrTransYr2Rt)
                    .HasColumnName("FEMALE_UNKN_2YR_TRANS_YR2_RT")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.FemaleUnkn2yrTransYr3Rt)
                    .HasColumnName("FEMALE_UNKN_2YR_TRANS_YR3_RT")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.FemaleUnkn2yrTransYr4Rt)
                    .HasColumnName("FEMALE_UNKN_2YR_TRANS_YR4_RT")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.FemaleUnkn2yrTransYr6Rt)
                    .HasColumnName("FEMALE_UNKN_2YR_TRANS_YR6_RT")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.FemaleUnkn2yrTransYr8Rt)
                    .HasColumnName("FEMALE_UNKN_2YR_TRANS_YR8_RT")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.FemaleUnkn4yrTransYr2Rt)
                    .HasColumnName("FEMALE_UNKN_4YR_TRANS_YR2_RT")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.FemaleUnkn4yrTransYr3Rt)
                    .HasColumnName("FEMALE_UNKN_4YR_TRANS_YR3_RT")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.FemaleUnkn4yrTransYr4Rt)
                    .HasColumnName("FEMALE_UNKN_4YR_TRANS_YR4_RT")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.FemaleUnkn4yrTransYr6Rt)
                    .HasColumnName("FEMALE_UNKN_4YR_TRANS_YR6_RT")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.FemaleUnkn4yrTransYr8Rt)
                    .HasColumnName("FEMALE_UNKN_4YR_TRANS_YR8_RT")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.FemaleUnknOrigYr2Rt)
                    .HasColumnName("FEMALE_UNKN_ORIG_YR2_RT")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.FemaleUnknOrigYr3Rt)
                    .HasColumnName("FEMALE_UNKN_ORIG_YR3_RT")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.FemaleUnknOrigYr4Rt)
                    .HasColumnName("FEMALE_UNKN_ORIG_YR4_RT")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.FemaleUnknOrigYr6Rt)
                    .HasColumnName("FEMALE_UNKN_ORIG_YR6_RT")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.FemaleUnknOrigYr8Rt)
                    .HasColumnName("FEMALE_UNKN_ORIG_YR8_RT")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.FemaleWdraw2yrTransYr2Rt)
                    .HasColumnName("FEMALE_WDRAW_2YR_TRANS_YR2_RT")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.FemaleWdraw2yrTransYr3Rt)
                    .HasColumnName("FEMALE_WDRAW_2YR_TRANS_YR3_RT")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.FemaleWdraw2yrTransYr4Rt)
                    .HasColumnName("FEMALE_WDRAW_2YR_TRANS_YR4_RT")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.FemaleWdraw2yrTransYr6Rt)
                    .HasColumnName("FEMALE_WDRAW_2YR_TRANS_YR6_RT")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.FemaleWdraw2yrTransYr8Rt)
                    .HasColumnName("FEMALE_WDRAW_2YR_TRANS_YR8_RT")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.FemaleWdraw4yrTransYr2Rt)
                    .HasColumnName("FEMALE_WDRAW_4YR_TRANS_YR2_RT")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.FemaleWdraw4yrTransYr3Rt)
                    .HasColumnName("FEMALE_WDRAW_4YR_TRANS_YR3_RT")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.FemaleWdraw4yrTransYr4Rt)
                    .HasColumnName("FEMALE_WDRAW_4YR_TRANS_YR4_RT")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.FemaleWdraw4yrTransYr6Rt)
                    .HasColumnName("FEMALE_WDRAW_4YR_TRANS_YR6_RT")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.FemaleWdraw4yrTransYr8Rt)
                    .HasColumnName("FEMALE_WDRAW_4YR_TRANS_YR8_RT")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.FemaleWdrawOrigYr2Rt)
                    .HasColumnName("FEMALE_WDRAW_ORIG_YR2_RT")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.FemaleWdrawOrigYr3Rt)
                    .HasColumnName("FEMALE_WDRAW_ORIG_YR3_RT")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.FemaleWdrawOrigYr4Rt)
                    .HasColumnName("FEMALE_WDRAW_ORIG_YR4_RT")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.FemaleWdrawOrigYr6Rt)
                    .HasColumnName("FEMALE_WDRAW_ORIG_YR6_RT")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.FemaleWdrawOrigYr8Rt)
                    .HasColumnName("FEMALE_WDRAW_ORIG_YR8_RT")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.FirstgenComp2yrTransYr2Rt)
                    .HasColumnName("FIRSTGEN_COMP_2YR_TRANS_YR2_RT")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.FirstgenComp2yrTransYr3Rt)
                    .HasColumnName("FIRSTGEN_COMP_2YR_TRANS_YR3_RT")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.FirstgenComp2yrTransYr4Rt)
                    .HasColumnName("FIRSTGEN_COMP_2YR_TRANS_YR4_RT")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.FirstgenComp2yrTransYr6Rt)
                    .HasColumnName("FIRSTGEN_COMP_2YR_TRANS_YR6_RT")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.FirstgenComp2yrTransYr8Rt)
                    .HasColumnName("FIRSTGEN_COMP_2YR_TRANS_YR8_RT")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.FirstgenComp4yrTransYr2Rt)
                    .HasColumnName("FIRSTGEN_COMP_4YR_TRANS_YR2_RT")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.FirstgenComp4yrTransYr3Rt)
                    .HasColumnName("FIRSTGEN_COMP_4YR_TRANS_YR3_RT")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.FirstgenComp4yrTransYr4Rt)
                    .HasColumnName("FIRSTGEN_COMP_4YR_TRANS_YR4_RT")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.FirstgenComp4yrTransYr6Rt)
                    .HasColumnName("FIRSTGEN_COMP_4YR_TRANS_YR6_RT")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.FirstgenComp4yrTransYr8Rt)
                    .HasColumnName("FIRSTGEN_COMP_4YR_TRANS_YR8_RT")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.FirstgenCompOrigYr2Rt)
                    .HasColumnName("FIRSTGEN_COMP_ORIG_YR2_RT")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.FirstgenCompOrigYr3Rt)
                    .HasColumnName("FIRSTGEN_COMP_ORIG_YR3_RT")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.FirstgenCompOrigYr4Rt)
                    .HasColumnName("FIRSTGEN_COMP_ORIG_YR4_RT")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.FirstgenCompOrigYr6Rt)
                    .HasColumnName("FIRSTGEN_COMP_ORIG_YR6_RT")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.FirstgenCompOrigYr8Rt)
                    .HasColumnName("FIRSTGEN_COMP_ORIG_YR8_RT")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.FirstgenDeathYr2Rt)
                    .HasColumnName("FIRSTGEN_DEATH_YR2_RT")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.FirstgenDeathYr3Rt)
                    .HasColumnName("FIRSTGEN_DEATH_YR3_RT")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.FirstgenDeathYr4Rt)
                    .HasColumnName("FIRSTGEN_DEATH_YR4_RT")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.FirstgenDeathYr6Rt)
                    .HasColumnName("FIRSTGEN_DEATH_YR6_RT")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.FirstgenDeathYr8Rt)
                    .HasColumnName("FIRSTGEN_DEATH_YR8_RT")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.FirstgenEnrl2yrTransYr2Rt)
                    .HasColumnName("FIRSTGEN_ENRL_2YR_TRANS_YR2_RT")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.FirstgenEnrl2yrTransYr3Rt)
                    .HasColumnName("FIRSTGEN_ENRL_2YR_TRANS_YR3_RT")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.FirstgenEnrl2yrTransYr4Rt)
                    .HasColumnName("FIRSTGEN_ENRL_2YR_TRANS_YR4_RT")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.FirstgenEnrl2yrTransYr6Rt)
                    .HasColumnName("FIRSTGEN_ENRL_2YR_TRANS_YR6_RT")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.FirstgenEnrl2yrTransYr8Rt)
                    .HasColumnName("FIRSTGEN_ENRL_2YR_TRANS_YR8_RT")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.FirstgenEnrl4yrTransYr2Rt)
                    .HasColumnName("FIRSTGEN_ENRL_4YR_TRANS_YR2_RT")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.FirstgenEnrl4yrTransYr3Rt)
                    .HasColumnName("FIRSTGEN_ENRL_4YR_TRANS_YR3_RT")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.FirstgenEnrl4yrTransYr4Rt)
                    .HasColumnName("FIRSTGEN_ENRL_4YR_TRANS_YR4_RT")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.FirstgenEnrl4yrTransYr6Rt)
                    .HasColumnName("FIRSTGEN_ENRL_4YR_TRANS_YR6_RT")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.FirstgenEnrl4yrTransYr8Rt)
                    .HasColumnName("FIRSTGEN_ENRL_4YR_TRANS_YR8_RT")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.FirstgenEnrlOrigYr2Rt)
                    .HasColumnName("FIRSTGEN_ENRL_ORIG_YR2_RT")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.FirstgenEnrlOrigYr3Rt)
                    .HasColumnName("FIRSTGEN_ENRL_ORIG_YR3_RT")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.FirstgenEnrlOrigYr4Rt)
                    .HasColumnName("FIRSTGEN_ENRL_ORIG_YR4_RT")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.FirstgenEnrlOrigYr6Rt)
                    .HasColumnName("FIRSTGEN_ENRL_ORIG_YR6_RT")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.FirstgenEnrlOrigYr8Rt)
                    .HasColumnName("FIRSTGEN_ENRL_ORIG_YR8_RT")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.FirstgenUnkn2yrTransYr2Rt)
                    .HasColumnName("FIRSTGEN_UNKN_2YR_TRANS_YR2_RT")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.FirstgenUnkn2yrTransYr3Rt)
                    .HasColumnName("FIRSTGEN_UNKN_2YR_TRANS_YR3_RT")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.FirstgenUnkn2yrTransYr4Rt)
                    .HasColumnName("FIRSTGEN_UNKN_2YR_TRANS_YR4_RT")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.FirstgenUnkn2yrTransYr6Rt)
                    .HasColumnName("FIRSTGEN_UNKN_2YR_TRANS_YR6_RT")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.FirstgenUnkn2yrTransYr8Rt)
                    .HasColumnName("FIRSTGEN_UNKN_2YR_TRANS_YR8_RT")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.FirstgenUnkn4yrTransYr2Rt)
                    .HasColumnName("FIRSTGEN_UNKN_4YR_TRANS_YR2_RT")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.FirstgenUnkn4yrTransYr3Rt)
                    .HasColumnName("FIRSTGEN_UNKN_4YR_TRANS_YR3_RT")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.FirstgenUnkn4yrTransYr4Rt)
                    .HasColumnName("FIRSTGEN_UNKN_4YR_TRANS_YR4_RT")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.FirstgenUnkn4yrTransYr6Rt)
                    .HasColumnName("FIRSTGEN_UNKN_4YR_TRANS_YR6_RT")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.FirstgenUnkn4yrTransYr8Rt)
                    .HasColumnName("FIRSTGEN_UNKN_4YR_TRANS_YR8_RT")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.FirstgenUnknOrigYr2Rt)
                    .HasColumnName("FIRSTGEN_UNKN_ORIG_YR2_RT")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.FirstgenUnknOrigYr3Rt)
                    .HasColumnName("FIRSTGEN_UNKN_ORIG_YR3_RT")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.FirstgenUnknOrigYr4Rt)
                    .HasColumnName("FIRSTGEN_UNKN_ORIG_YR4_RT")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.FirstgenUnknOrigYr6Rt)
                    .HasColumnName("FIRSTGEN_UNKN_ORIG_YR6_RT")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.FirstgenUnknOrigYr8Rt)
                    .HasColumnName("FIRSTGEN_UNKN_ORIG_YR8_RT")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.FirstgenWdraw2yrTransYr2Rt)
                    .HasColumnName("FIRSTGEN_WDRAW_2YR_TRANS_YR2_RT")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.FirstgenWdraw2yrTransYr3Rt)
                    .HasColumnName("FIRSTGEN_WDRAW_2YR_TRANS_YR3_RT")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.FirstgenWdraw2yrTransYr4Rt)
                    .HasColumnName("FIRSTGEN_WDRAW_2YR_TRANS_YR4_RT")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.FirstgenWdraw2yrTransYr6Rt)
                    .HasColumnName("FIRSTGEN_WDRAW_2YR_TRANS_YR6_RT")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.FirstgenWdraw2yrTransYr8Rt)
                    .HasColumnName("FIRSTGEN_WDRAW_2YR_TRANS_YR8_RT")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.FirstgenWdraw4yrTransYr2Rt)
                    .HasColumnName("FIRSTGEN_WDRAW_4YR_TRANS_YR2_RT")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.FirstgenWdraw4yrTransYr3Rt)
                    .HasColumnName("FIRSTGEN_WDRAW_4YR_TRANS_YR3_RT")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.FirstgenWdraw4yrTransYr4Rt)
                    .HasColumnName("FIRSTGEN_WDRAW_4YR_TRANS_YR4_RT")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.FirstgenWdraw4yrTransYr6Rt)
                    .HasColumnName("FIRSTGEN_WDRAW_4YR_TRANS_YR6_RT")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.FirstgenWdraw4yrTransYr8Rt)
                    .HasColumnName("FIRSTGEN_WDRAW_4YR_TRANS_YR8_RT")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.FirstgenWdrawOrigYr2Rt)
                    .HasColumnName("FIRSTGEN_WDRAW_ORIG_YR2_RT")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.FirstgenWdrawOrigYr3Rt)
                    .HasColumnName("FIRSTGEN_WDRAW_ORIG_YR3_RT")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.FirstgenWdrawOrigYr4Rt)
                    .HasColumnName("FIRSTGEN_WDRAW_ORIG_YR4_RT")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.FirstgenWdrawOrigYr6Rt)
                    .HasColumnName("FIRSTGEN_WDRAW_ORIG_YR6_RT")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.FirstgenWdrawOrigYr8Rt)
                    .HasColumnName("FIRSTGEN_WDRAW_ORIG_YR8_RT")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.HiIncComp2yrTransYr2Rt)
                    .HasColumnName("HI_INC_COMP_2YR_TRANS_YR2_RT")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.HiIncComp2yrTransYr3Rt)
                    .HasColumnName("HI_INC_COMP_2YR_TRANS_YR3_RT")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.HiIncComp2yrTransYr4Rt)
                    .HasColumnName("HI_INC_COMP_2YR_TRANS_YR4_RT")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.HiIncComp2yrTransYr6Rt)
                    .HasColumnName("HI_INC_COMP_2YR_TRANS_YR6_RT")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.HiIncComp2yrTransYr8Rt)
                    .HasColumnName("HI_INC_COMP_2YR_TRANS_YR8_RT")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.HiIncComp4yrTransYr2Rt)
                    .HasColumnName("HI_INC_COMP_4YR_TRANS_YR2_RT")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.HiIncComp4yrTransYr3Rt)
                    .HasColumnName("HI_INC_COMP_4YR_TRANS_YR3_RT")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.HiIncComp4yrTransYr4Rt)
                    .HasColumnName("HI_INC_COMP_4YR_TRANS_YR4_RT")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.HiIncComp4yrTransYr6Rt)
                    .HasColumnName("HI_INC_COMP_4YR_TRANS_YR6_RT")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.HiIncComp4yrTransYr8Rt)
                    .HasColumnName("HI_INC_COMP_4YR_TRANS_YR8_RT")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.HiIncCompOrigYr2Rt)
                    .HasColumnName("HI_INC_COMP_ORIG_YR2_RT")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.HiIncCompOrigYr3Rt)
                    .HasColumnName("HI_INC_COMP_ORIG_YR3_RT")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.HiIncCompOrigYr4Rt)
                    .HasColumnName("HI_INC_COMP_ORIG_YR4_RT")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.HiIncCompOrigYr6Rt)
                    .HasColumnName("HI_INC_COMP_ORIG_YR6_RT")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.HiIncCompOrigYr8Rt)
                    .HasColumnName("HI_INC_COMP_ORIG_YR8_RT")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.HiIncDeathYr2Rt)
                    .HasColumnName("HI_INC_DEATH_YR2_RT")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.HiIncDeathYr3Rt)
                    .HasColumnName("HI_INC_DEATH_YR3_RT")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.HiIncDeathYr4Rt)
                    .HasColumnName("HI_INC_DEATH_YR4_RT")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.HiIncDeathYr6Rt)
                    .HasColumnName("HI_INC_DEATH_YR6_RT")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.HiIncDeathYr8Rt)
                    .HasColumnName("HI_INC_DEATH_YR8_RT")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.HiIncEnrl2yrTransYr2Rt)
                    .HasColumnName("HI_INC_ENRL_2YR_TRANS_YR2_RT")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.HiIncEnrl2yrTransYr3Rt)
                    .HasColumnName("HI_INC_ENRL_2YR_TRANS_YR3_RT")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.HiIncEnrl2yrTransYr4Rt)
                    .HasColumnName("HI_INC_ENRL_2YR_TRANS_YR4_RT")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.HiIncEnrl2yrTransYr6Rt)
                    .HasColumnName("HI_INC_ENRL_2YR_TRANS_YR6_RT")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.HiIncEnrl2yrTransYr8Rt)
                    .HasColumnName("HI_INC_ENRL_2YR_TRANS_YR8_RT")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.HiIncEnrl4yrTransYr2Rt)
                    .HasColumnName("HI_INC_ENRL_4YR_TRANS_YR2_RT")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.HiIncEnrl4yrTransYr3Rt)
                    .HasColumnName("HI_INC_ENRL_4YR_TRANS_YR3_RT")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.HiIncEnrl4yrTransYr4Rt)
                    .HasColumnName("HI_INC_ENRL_4YR_TRANS_YR4_RT")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.HiIncEnrl4yrTransYr6Rt)
                    .HasColumnName("HI_INC_ENRL_4YR_TRANS_YR6_RT")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.HiIncEnrl4yrTransYr8Rt)
                    .HasColumnName("HI_INC_ENRL_4YR_TRANS_YR8_RT")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.HiIncEnrlOrigYr2Rt)
                    .HasColumnName("HI_INC_ENRL_ORIG_YR2_RT")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.HiIncEnrlOrigYr3Rt)
                    .HasColumnName("HI_INC_ENRL_ORIG_YR3_RT")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.HiIncEnrlOrigYr4Rt)
                    .HasColumnName("HI_INC_ENRL_ORIG_YR4_RT")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.HiIncEnrlOrigYr6Rt)
                    .HasColumnName("HI_INC_ENRL_ORIG_YR6_RT")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.HiIncEnrlOrigYr8Rt)
                    .HasColumnName("HI_INC_ENRL_ORIG_YR8_RT")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.HiIncUnkn2yrTransYr2Rt)
                    .HasColumnName("HI_INC_UNKN_2YR_TRANS_YR2_RT")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.HiIncUnkn2yrTransYr3Rt)
                    .HasColumnName("HI_INC_UNKN_2YR_TRANS_YR3_RT")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.HiIncUnkn2yrTransYr4Rt)
                    .HasColumnName("HI_INC_UNKN_2YR_TRANS_YR4_RT")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.HiIncUnkn2yrTransYr6Rt)
                    .HasColumnName("HI_INC_UNKN_2YR_TRANS_YR6_RT")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.HiIncUnkn2yrTransYr8Rt)
                    .HasColumnName("HI_INC_UNKN_2YR_TRANS_YR8_RT")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.HiIncUnkn4yrTransYr2Rt)
                    .HasColumnName("HI_INC_UNKN_4YR_TRANS_YR2_RT")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.HiIncUnkn4yrTransYr3Rt)
                    .HasColumnName("HI_INC_UNKN_4YR_TRANS_YR3_RT")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.HiIncUnkn4yrTransYr4Rt)
                    .HasColumnName("HI_INC_UNKN_4YR_TRANS_YR4_RT")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.HiIncUnkn4yrTransYr6Rt)
                    .HasColumnName("HI_INC_UNKN_4YR_TRANS_YR6_RT")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.HiIncUnkn4yrTransYr8Rt)
                    .HasColumnName("HI_INC_UNKN_4YR_TRANS_YR8_RT")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.HiIncUnknOrigYr2Rt)
                    .HasColumnName("HI_INC_UNKN_ORIG_YR2_RT")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.HiIncUnknOrigYr3Rt)
                    .HasColumnName("HI_INC_UNKN_ORIG_YR3_RT")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.HiIncUnknOrigYr4Rt)
                    .HasColumnName("HI_INC_UNKN_ORIG_YR4_RT")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.HiIncUnknOrigYr6Rt)
                    .HasColumnName("HI_INC_UNKN_ORIG_YR6_RT")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.HiIncUnknOrigYr8Rt)
                    .HasColumnName("HI_INC_UNKN_ORIG_YR8_RT")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.HiIncWdraw2yrTransYr2Rt)
                    .HasColumnName("HI_INC_WDRAW_2YR_TRANS_YR2_RT")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.HiIncWdraw2yrTransYr3Rt)
                    .HasColumnName("HI_INC_WDRAW_2YR_TRANS_YR3_RT")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.HiIncWdraw2yrTransYr4Rt)
                    .HasColumnName("HI_INC_WDRAW_2YR_TRANS_YR4_RT")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.HiIncWdraw2yrTransYr6Rt)
                    .HasColumnName("HI_INC_WDRAW_2YR_TRANS_YR6_RT")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.HiIncWdraw2yrTransYr8Rt)
                    .HasColumnName("HI_INC_WDRAW_2YR_TRANS_YR8_RT")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.HiIncWdraw4yrTransYr2Rt)
                    .HasColumnName("HI_INC_WDRAW_4YR_TRANS_YR2_RT")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.HiIncWdraw4yrTransYr3Rt)
                    .HasColumnName("HI_INC_WDRAW_4YR_TRANS_YR3_RT")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.HiIncWdraw4yrTransYr4Rt)
                    .HasColumnName("HI_INC_WDRAW_4YR_TRANS_YR4_RT")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.HiIncWdraw4yrTransYr6Rt)
                    .HasColumnName("HI_INC_WDRAW_4YR_TRANS_YR6_RT")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.HiIncWdraw4yrTransYr8Rt)
                    .HasColumnName("HI_INC_WDRAW_4YR_TRANS_YR8_RT")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.HiIncWdrawOrigYr2Rt)
                    .HasColumnName("HI_INC_WDRAW_ORIG_YR2_RT")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.HiIncWdrawOrigYr3Rt)
                    .HasColumnName("HI_INC_WDRAW_ORIG_YR3_RT")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.HiIncWdrawOrigYr4Rt)
                    .HasColumnName("HI_INC_WDRAW_ORIG_YR4_RT")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.HiIncWdrawOrigYr6Rt)
                    .HasColumnName("HI_INC_WDRAW_ORIG_YR6_RT")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.HiIncWdrawOrigYr8Rt)
                    .HasColumnName("HI_INC_WDRAW_ORIG_YR8_RT")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.IndComp2yrTransYr2Rt)
                    .HasColumnName("IND_COMP_2YR_TRANS_YR2_RT")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.IndComp2yrTransYr3Rt)
                    .HasColumnName("IND_COMP_2YR_TRANS_YR3_RT")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.IndComp2yrTransYr4Rt)
                    .HasColumnName("IND_COMP_2YR_TRANS_YR4_RT")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.IndComp2yrTransYr6Rt)
                    .HasColumnName("IND_COMP_2YR_TRANS_YR6_RT")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.IndComp2yrTransYr8Rt)
                    .HasColumnName("IND_COMP_2YR_TRANS_YR8_RT")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.IndComp4yrTransYr2Rt)
                    .HasColumnName("IND_COMP_4YR_TRANS_YR2_RT")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.IndComp4yrTransYr3Rt)
                    .HasColumnName("IND_COMP_4YR_TRANS_YR3_RT")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.IndComp4yrTransYr4Rt)
                    .HasColumnName("IND_COMP_4YR_TRANS_YR4_RT")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.IndComp4yrTransYr6Rt)
                    .HasColumnName("IND_COMP_4YR_TRANS_YR6_RT")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.IndComp4yrTransYr8Rt)
                    .HasColumnName("IND_COMP_4YR_TRANS_YR8_RT")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.IndCompOrigYr2Rt)
                    .HasColumnName("IND_COMP_ORIG_YR2_RT")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.IndCompOrigYr3Rt)
                    .HasColumnName("IND_COMP_ORIG_YR3_RT")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.IndCompOrigYr4Rt)
                    .HasColumnName("IND_COMP_ORIG_YR4_RT")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.IndCompOrigYr6Rt)
                    .HasColumnName("IND_COMP_ORIG_YR6_RT")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.IndCompOrigYr8Rt)
                    .HasColumnName("IND_COMP_ORIG_YR8_RT")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.IndDeathYr2Rt)
                    .HasColumnName("IND_DEATH_YR2_RT")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.IndDeathYr3Rt)
                    .HasColumnName("IND_DEATH_YR3_RT")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.IndDeathYr4Rt)
                    .HasColumnName("IND_DEATH_YR4_RT")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.IndDeathYr6Rt)
                    .HasColumnName("IND_DEATH_YR6_RT")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.IndDeathYr8Rt)
                    .HasColumnName("IND_DEATH_YR8_RT")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.IndEnrl2yrTransYr2Rt)
                    .HasColumnName("IND_ENRL_2YR_TRANS_YR2_RT")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.IndEnrl2yrTransYr3Rt)
                    .HasColumnName("IND_ENRL_2YR_TRANS_YR3_RT")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.IndEnrl2yrTransYr4Rt)
                    .HasColumnName("IND_ENRL_2YR_TRANS_YR4_RT")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.IndEnrl2yrTransYr6Rt)
                    .HasColumnName("IND_ENRL_2YR_TRANS_YR6_RT")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.IndEnrl2yrTransYr8Rt)
                    .HasColumnName("IND_ENRL_2YR_TRANS_YR8_RT")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.IndEnrl4yrTransYr2Rt)
                    .HasColumnName("IND_ENRL_4YR_TRANS_YR2_RT")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.IndEnrl4yrTransYr3Rt)
                    .HasColumnName("IND_ENRL_4YR_TRANS_YR3_RT")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.IndEnrl4yrTransYr4Rt)
                    .HasColumnName("IND_ENRL_4YR_TRANS_YR4_RT")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.IndEnrl4yrTransYr6Rt)
                    .HasColumnName("IND_ENRL_4YR_TRANS_YR6_RT")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.IndEnrl4yrTransYr8Rt)
                    .HasColumnName("IND_ENRL_4YR_TRANS_YR8_RT")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.IndEnrlOrigYr2Rt)
                    .HasColumnName("IND_ENRL_ORIG_YR2_RT")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.IndEnrlOrigYr3Rt)
                    .HasColumnName("IND_ENRL_ORIG_YR3_RT")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.IndEnrlOrigYr4Rt)
                    .HasColumnName("IND_ENRL_ORIG_YR4_RT")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.IndEnrlOrigYr6Rt)
                    .HasColumnName("IND_ENRL_ORIG_YR6_RT")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.IndEnrlOrigYr8Rt)
                    .HasColumnName("IND_ENRL_ORIG_YR8_RT")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.IndUnkn2yrTransYr2Rt)
                    .HasColumnName("IND_UNKN_2YR_TRANS_YR2_RT")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.IndUnkn2yrTransYr3Rt)
                    .HasColumnName("IND_UNKN_2YR_TRANS_YR3_RT")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.IndUnkn2yrTransYr4Rt)
                    .HasColumnName("IND_UNKN_2YR_TRANS_YR4_RT")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.IndUnkn2yrTransYr6Rt)
                    .HasColumnName("IND_UNKN_2YR_TRANS_YR6_RT")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.IndUnkn2yrTransYr8Rt)
                    .HasColumnName("IND_UNKN_2YR_TRANS_YR8_RT")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.IndUnkn4yrTransYr2Rt)
                    .HasColumnName("IND_UNKN_4YR_TRANS_YR2_RT")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.IndUnkn4yrTransYr3Rt)
                    .HasColumnName("IND_UNKN_4YR_TRANS_YR3_RT")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.IndUnkn4yrTransYr4Rt)
                    .HasColumnName("IND_UNKN_4YR_TRANS_YR4_RT")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.IndUnkn4yrTransYr6Rt)
                    .HasColumnName("IND_UNKN_4YR_TRANS_YR6_RT")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.IndUnkn4yrTransYr8Rt)
                    .HasColumnName("IND_UNKN_4YR_TRANS_YR8_RT")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.IndUnknOrigYr2Rt)
                    .HasColumnName("IND_UNKN_ORIG_YR2_RT")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.IndUnknOrigYr3Rt)
                    .HasColumnName("IND_UNKN_ORIG_YR3_RT")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.IndUnknOrigYr4Rt)
                    .HasColumnName("IND_UNKN_ORIG_YR4_RT")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.IndUnknOrigYr6Rt)
                    .HasColumnName("IND_UNKN_ORIG_YR6_RT")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.IndUnknOrigYr8Rt)
                    .HasColumnName("IND_UNKN_ORIG_YR8_RT")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.IndWdraw2yrTransYr2Rt)
                    .HasColumnName("IND_WDRAW_2YR_TRANS_YR2_RT")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.IndWdraw2yrTransYr3Rt)
                    .HasColumnName("IND_WDRAW_2YR_TRANS_YR3_RT")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.IndWdraw2yrTransYr4Rt)
                    .HasColumnName("IND_WDRAW_2YR_TRANS_YR4_RT")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.IndWdraw2yrTransYr6Rt)
                    .HasColumnName("IND_WDRAW_2YR_TRANS_YR6_RT")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.IndWdraw2yrTransYr8Rt)
                    .HasColumnName("IND_WDRAW_2YR_TRANS_YR8_RT")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.IndWdraw4yrTransYr2Rt)
                    .HasColumnName("IND_WDRAW_4YR_TRANS_YR2_RT")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.IndWdraw4yrTransYr3Rt)
                    .HasColumnName("IND_WDRAW_4YR_TRANS_YR3_RT")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.IndWdraw4yrTransYr4Rt)
                    .HasColumnName("IND_WDRAW_4YR_TRANS_YR4_RT")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.IndWdraw4yrTransYr6Rt)
                    .HasColumnName("IND_WDRAW_4YR_TRANS_YR6_RT")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.IndWdraw4yrTransYr8Rt)
                    .HasColumnName("IND_WDRAW_4YR_TRANS_YR8_RT")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.IndWdrawOrigYr2Rt)
                    .HasColumnName("IND_WDRAW_ORIG_YR2_RT")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.IndWdrawOrigYr3Rt)
                    .HasColumnName("IND_WDRAW_ORIG_YR3_RT")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.IndWdrawOrigYr4Rt)
                    .HasColumnName("IND_WDRAW_ORIG_YR4_RT")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.IndWdrawOrigYr6Rt)
                    .HasColumnName("IND_WDRAW_ORIG_YR6_RT")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.IndWdrawOrigYr8Rt)
                    .HasColumnName("IND_WDRAW_ORIG_YR8_RT")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.LoIncComp2yrTransYr2Rt)
                    .HasColumnName("LO_INC_COMP_2YR_TRANS_YR2_RT")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.LoIncComp2yrTransYr3Rt)
                    .HasColumnName("LO_INC_COMP_2YR_TRANS_YR3_RT")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.LoIncComp2yrTransYr4Rt)
                    .HasColumnName("LO_INC_COMP_2YR_TRANS_YR4_RT")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.LoIncComp2yrTransYr6Rt)
                    .HasColumnName("LO_INC_COMP_2YR_TRANS_YR6_RT")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.LoIncComp2yrTransYr8Rt)
                    .HasColumnName("LO_INC_COMP_2YR_TRANS_YR8_RT")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.LoIncComp4yrTransYr2Rt)
                    .HasColumnName("LO_INC_COMP_4YR_TRANS_YR2_RT")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.LoIncComp4yrTransYr3Rt)
                    .HasColumnName("LO_INC_COMP_4YR_TRANS_YR3_RT")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.LoIncComp4yrTransYr4Rt)
                    .HasColumnName("LO_INC_COMP_4YR_TRANS_YR4_RT")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.LoIncComp4yrTransYr6Rt)
                    .HasColumnName("LO_INC_COMP_4YR_TRANS_YR6_RT")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.LoIncComp4yrTransYr8Rt)
                    .HasColumnName("LO_INC_COMP_4YR_TRANS_YR8_RT")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.LoIncCompOrigYr2Rt)
                    .HasColumnName("LO_INC_COMP_ORIG_YR2_RT")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.LoIncCompOrigYr3Rt)
                    .HasColumnName("LO_INC_COMP_ORIG_YR3_RT")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.LoIncCompOrigYr4Rt)
                    .HasColumnName("LO_INC_COMP_ORIG_YR4_RT")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.LoIncCompOrigYr6Rt)
                    .HasColumnName("LO_INC_COMP_ORIG_YR6_RT")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.LoIncCompOrigYr8Rt)
                    .HasColumnName("LO_INC_COMP_ORIG_YR8_RT")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.LoIncDeathYr2Rt)
                    .HasColumnName("LO_INC_DEATH_YR2_RT")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.LoIncDeathYr3Rt)
                    .HasColumnName("LO_INC_DEATH_YR3_RT")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.LoIncDeathYr4Rt)
                    .HasColumnName("LO_INC_DEATH_YR4_RT")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.LoIncDeathYr6Rt)
                    .HasColumnName("LO_INC_DEATH_YR6_RT")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.LoIncDeathYr8Rt)
                    .HasColumnName("LO_INC_DEATH_YR8_RT")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.LoIncEnrl2yrTransYr2Rt)
                    .HasColumnName("LO_INC_ENRL_2YR_TRANS_YR2_RT")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.LoIncEnrl2yrTransYr3Rt)
                    .HasColumnName("LO_INC_ENRL_2YR_TRANS_YR3_RT")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.LoIncEnrl2yrTransYr4Rt)
                    .HasColumnName("LO_INC_ENRL_2YR_TRANS_YR4_RT")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.LoIncEnrl2yrTransYr6Rt)
                    .HasColumnName("LO_INC_ENRL_2YR_TRANS_YR6_RT")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.LoIncEnrl2yrTransYr8Rt)
                    .HasColumnName("LO_INC_ENRL_2YR_TRANS_YR8_RT")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.LoIncEnrl4yrTransYr2Rt)
                    .HasColumnName("LO_INC_ENRL_4YR_TRANS_YR2_RT")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.LoIncEnrl4yrTransYr3Rt)
                    .HasColumnName("LO_INC_ENRL_4YR_TRANS_YR3_RT")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.LoIncEnrl4yrTransYr4Rt)
                    .HasColumnName("LO_INC_ENRL_4YR_TRANS_YR4_RT")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.LoIncEnrl4yrTransYr6Rt)
                    .HasColumnName("LO_INC_ENRL_4YR_TRANS_YR6_RT")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.LoIncEnrl4yrTransYr8Rt)
                    .HasColumnName("LO_INC_ENRL_4YR_TRANS_YR8_RT")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.LoIncEnrlOrigYr2Rt)
                    .HasColumnName("LO_INC_ENRL_ORIG_YR2_RT")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.LoIncEnrlOrigYr3Rt)
                    .HasColumnName("LO_INC_ENRL_ORIG_YR3_RT")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.LoIncEnrlOrigYr4Rt)
                    .HasColumnName("LO_INC_ENRL_ORIG_YR4_RT")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.LoIncEnrlOrigYr6Rt)
                    .HasColumnName("LO_INC_ENRL_ORIG_YR6_RT")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.LoIncEnrlOrigYr8Rt)
                    .HasColumnName("LO_INC_ENRL_ORIG_YR8_RT")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.LoIncUnkn2yrTransYr2Rt)
                    .HasColumnName("LO_INC_UNKN_2YR_TRANS_YR2_RT")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.LoIncUnkn2yrTransYr3Rt)
                    .HasColumnName("LO_INC_UNKN_2YR_TRANS_YR3_RT")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.LoIncUnkn2yrTransYr4Rt)
                    .HasColumnName("LO_INC_UNKN_2YR_TRANS_YR4_RT")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.LoIncUnkn2yrTransYr6Rt)
                    .HasColumnName("LO_INC_UNKN_2YR_TRANS_YR6_RT")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.LoIncUnkn2yrTransYr8Rt)
                    .HasColumnName("LO_INC_UNKN_2YR_TRANS_YR8_RT")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.LoIncUnkn4yrTransYr2Rt)
                    .HasColumnName("LO_INC_UNKN_4YR_TRANS_YR2_RT")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.LoIncUnkn4yrTransYr3Rt)
                    .HasColumnName("LO_INC_UNKN_4YR_TRANS_YR3_RT")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.LoIncUnkn4yrTransYr4Rt)
                    .HasColumnName("LO_INC_UNKN_4YR_TRANS_YR4_RT")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.LoIncUnkn4yrTransYr6Rt)
                    .HasColumnName("LO_INC_UNKN_4YR_TRANS_YR6_RT")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.LoIncUnkn4yrTransYr8Rt)
                    .HasColumnName("LO_INC_UNKN_4YR_TRANS_YR8_RT")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.LoIncUnknOrigYr2Rt)
                    .HasColumnName("LO_INC_UNKN_ORIG_YR2_RT")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.LoIncUnknOrigYr3Rt)
                    .HasColumnName("LO_INC_UNKN_ORIG_YR3_RT")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.LoIncUnknOrigYr4Rt)
                    .HasColumnName("LO_INC_UNKN_ORIG_YR4_RT")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.LoIncUnknOrigYr6Rt)
                    .HasColumnName("LO_INC_UNKN_ORIG_YR6_RT")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.LoIncUnknOrigYr8Rt)
                    .HasColumnName("LO_INC_UNKN_ORIG_YR8_RT")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.LoIncWdraw2yrTransYr2Rt)
                    .HasColumnName("LO_INC_WDRAW_2YR_TRANS_YR2_RT")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.LoIncWdraw2yrTransYr3Rt)
                    .HasColumnName("LO_INC_WDRAW_2YR_TRANS_YR3_RT")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.LoIncWdraw2yrTransYr4Rt)
                    .HasColumnName("LO_INC_WDRAW_2YR_TRANS_YR4_RT")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.LoIncWdraw2yrTransYr6Rt)
                    .HasColumnName("LO_INC_WDRAW_2YR_TRANS_YR6_RT")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.LoIncWdraw2yrTransYr8Rt)
                    .HasColumnName("LO_INC_WDRAW_2YR_TRANS_YR8_RT")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.LoIncWdraw4yrTransYr2Rt)
                    .HasColumnName("LO_INC_WDRAW_4YR_TRANS_YR2_RT")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.LoIncWdraw4yrTransYr3Rt)
                    .HasColumnName("LO_INC_WDRAW_4YR_TRANS_YR3_RT")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.LoIncWdraw4yrTransYr4Rt)
                    .HasColumnName("LO_INC_WDRAW_4YR_TRANS_YR4_RT")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.LoIncWdraw4yrTransYr6Rt)
                    .HasColumnName("LO_INC_WDRAW_4YR_TRANS_YR6_RT")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.LoIncWdraw4yrTransYr8Rt)
                    .HasColumnName("LO_INC_WDRAW_4YR_TRANS_YR8_RT")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.LoIncWdrawOrigYr2Rt)
                    .HasColumnName("LO_INC_WDRAW_ORIG_YR2_RT")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.LoIncWdrawOrigYr3Rt)
                    .HasColumnName("LO_INC_WDRAW_ORIG_YR3_RT")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.LoIncWdrawOrigYr4Rt)
                    .HasColumnName("LO_INC_WDRAW_ORIG_YR4_RT")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.LoIncWdrawOrigYr6Rt)
                    .HasColumnName("LO_INC_WDRAW_ORIG_YR6_RT")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.LoIncWdrawOrigYr8Rt)
                    .HasColumnName("LO_INC_WDRAW_ORIG_YR8_RT")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.LoanComp2yrTransYr2Rt)
                    .HasColumnName("LOAN_COMP_2YR_TRANS_YR2_RT")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.LoanComp2yrTransYr3Rt)
                    .HasColumnName("LOAN_COMP_2YR_TRANS_YR3_RT")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.LoanComp2yrTransYr4Rt)
                    .HasColumnName("LOAN_COMP_2YR_TRANS_YR4_RT")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.LoanComp2yrTransYr6Rt)
                    .HasColumnName("LOAN_COMP_2YR_TRANS_YR6_RT")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.LoanComp2yrTransYr8Rt)
                    .HasColumnName("LOAN_COMP_2YR_TRANS_YR8_RT")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.LoanComp4yrTransYr2Rt)
                    .HasColumnName("LOAN_COMP_4YR_TRANS_YR2_RT")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.LoanComp4yrTransYr3Rt)
                    .HasColumnName("LOAN_COMP_4YR_TRANS_YR3_RT")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.LoanComp4yrTransYr4Rt)
                    .HasColumnName("LOAN_COMP_4YR_TRANS_YR4_RT")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.LoanComp4yrTransYr6Rt)
                    .HasColumnName("LOAN_COMP_4YR_TRANS_YR6_RT")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.LoanComp4yrTransYr8Rt)
                    .HasColumnName("LOAN_COMP_4YR_TRANS_YR8_RT")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.LoanCompOrigYr2Rt)
                    .HasColumnName("LOAN_COMP_ORIG_YR2_RT")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.LoanCompOrigYr3Rt)
                    .HasColumnName("LOAN_COMP_ORIG_YR3_RT")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.LoanCompOrigYr4Rt)
                    .HasColumnName("LOAN_COMP_ORIG_YR4_RT")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.LoanCompOrigYr6Rt)
                    .HasColumnName("LOAN_COMP_ORIG_YR6_RT")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.LoanCompOrigYr8Rt)
                    .HasColumnName("LOAN_COMP_ORIG_YR8_RT")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.LoanDeathYr2Rt)
                    .HasColumnName("LOAN_DEATH_YR2_RT")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.LoanDeathYr3Rt)
                    .HasColumnName("LOAN_DEATH_YR3_RT")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.LoanDeathYr4Rt)
                    .HasColumnName("LOAN_DEATH_YR4_RT")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.LoanDeathYr6Rt)
                    .HasColumnName("LOAN_DEATH_YR6_RT")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.LoanDeathYr8Rt)
                    .HasColumnName("LOAN_DEATH_YR8_RT")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.LoanEnrl2yrTransYr2Rt)
                    .HasColumnName("LOAN_ENRL_2YR_TRANS_YR2_RT")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.LoanEnrl2yrTransYr3Rt)
                    .HasColumnName("LOAN_ENRL_2YR_TRANS_YR3_RT")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.LoanEnrl2yrTransYr4Rt)
                    .HasColumnName("LOAN_ENRL_2YR_TRANS_YR4_RT")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.LoanEnrl2yrTransYr6Rt)
                    .HasColumnName("LOAN_ENRL_2YR_TRANS_YR6_RT")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.LoanEnrl2yrTransYr8Rt)
                    .HasColumnName("LOAN_ENRL_2YR_TRANS_YR8_RT")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.LoanEnrl4yrTransYr2Rt)
                    .HasColumnName("LOAN_ENRL_4YR_TRANS_YR2_RT")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.LoanEnrl4yrTransYr3Rt)
                    .HasColumnName("LOAN_ENRL_4YR_TRANS_YR3_RT")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.LoanEnrl4yrTransYr4Rt)
                    .HasColumnName("LOAN_ENRL_4YR_TRANS_YR4_RT")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.LoanEnrl4yrTransYr6Rt)
                    .HasColumnName("LOAN_ENRL_4YR_TRANS_YR6_RT")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.LoanEnrl4yrTransYr8Rt)
                    .HasColumnName("LOAN_ENRL_4YR_TRANS_YR8_RT")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.LoanEnrlOrigYr2Rt)
                    .HasColumnName("LOAN_ENRL_ORIG_YR2_RT")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.LoanEnrlOrigYr3Rt)
                    .HasColumnName("LOAN_ENRL_ORIG_YR3_RT")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.LoanEnrlOrigYr4Rt)
                    .HasColumnName("LOAN_ENRL_ORIG_YR4_RT")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.LoanEnrlOrigYr6Rt)
                    .HasColumnName("LOAN_ENRL_ORIG_YR6_RT")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.LoanEnrlOrigYr8Rt)
                    .HasColumnName("LOAN_ENRL_ORIG_YR8_RT")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.LoanUnkn2yrTransYr2Rt)
                    .HasColumnName("LOAN_UNKN_2YR_TRANS_YR2_RT")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.LoanUnkn2yrTransYr3Rt)
                    .HasColumnName("LOAN_UNKN_2YR_TRANS_YR3_RT")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.LoanUnkn2yrTransYr4Rt)
                    .HasColumnName("LOAN_UNKN_2YR_TRANS_YR4_RT")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.LoanUnkn2yrTransYr6Rt)
                    .HasColumnName("LOAN_UNKN_2YR_TRANS_YR6_RT")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.LoanUnkn2yrTransYr8Rt)
                    .HasColumnName("LOAN_UNKN_2YR_TRANS_YR8_RT")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.LoanUnkn4yrTransYr2Rt)
                    .HasColumnName("LOAN_UNKN_4YR_TRANS_YR2_RT")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.LoanUnkn4yrTransYr3Rt)
                    .HasColumnName("LOAN_UNKN_4YR_TRANS_YR3_RT")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.LoanUnkn4yrTransYr4Rt)
                    .HasColumnName("LOAN_UNKN_4YR_TRANS_YR4_RT")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.LoanUnkn4yrTransYr6Rt)
                    .HasColumnName("LOAN_UNKN_4YR_TRANS_YR6_RT")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.LoanUnkn4yrTransYr8Rt)
                    .HasColumnName("LOAN_UNKN_4YR_TRANS_YR8_RT")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.LoanUnknOrigYr2Rt)
                    .HasColumnName("LOAN_UNKN_ORIG_YR2_RT")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.LoanUnknOrigYr3Rt)
                    .HasColumnName("LOAN_UNKN_ORIG_YR3_RT")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.LoanUnknOrigYr4Rt)
                    .HasColumnName("LOAN_UNKN_ORIG_YR4_RT")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.LoanUnknOrigYr6Rt)
                    .HasColumnName("LOAN_UNKN_ORIG_YR6_RT")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.LoanUnknOrigYr8Rt)
                    .HasColumnName("LOAN_UNKN_ORIG_YR8_RT")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.LoanWdraw2yrTransYr2Rt)
                    .HasColumnName("LOAN_WDRAW_2YR_TRANS_YR2_RT")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.LoanWdraw2yrTransYr3Rt)
                    .HasColumnName("LOAN_WDRAW_2YR_TRANS_YR3_RT")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.LoanWdraw2yrTransYr4Rt)
                    .HasColumnName("LOAN_WDRAW_2YR_TRANS_YR4_RT")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.LoanWdraw2yrTransYr6Rt)
                    .HasColumnName("LOAN_WDRAW_2YR_TRANS_YR6_RT")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.LoanWdraw2yrTransYr8Rt)
                    .HasColumnName("LOAN_WDRAW_2YR_TRANS_YR8_RT")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.LoanWdraw4yrTransYr2Rt)
                    .HasColumnName("LOAN_WDRAW_4YR_TRANS_YR2_RT")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.LoanWdraw4yrTransYr3Rt)
                    .HasColumnName("LOAN_WDRAW_4YR_TRANS_YR3_RT")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.LoanWdraw4yrTransYr4Rt)
                    .HasColumnName("LOAN_WDRAW_4YR_TRANS_YR4_RT")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.LoanWdraw4yrTransYr6Rt)
                    .HasColumnName("LOAN_WDRAW_4YR_TRANS_YR6_RT")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.LoanWdraw4yrTransYr8Rt)
                    .HasColumnName("LOAN_WDRAW_4YR_TRANS_YR8_RT")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.LoanWdrawOrigYr2Rt)
                    .HasColumnName("LOAN_WDRAW_ORIG_YR2_RT")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.LoanWdrawOrigYr3Rt)
                    .HasColumnName("LOAN_WDRAW_ORIG_YR3_RT")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.LoanWdrawOrigYr4Rt)
                    .HasColumnName("LOAN_WDRAW_ORIG_YR4_RT")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.LoanWdrawOrigYr6Rt)
                    .HasColumnName("LOAN_WDRAW_ORIG_YR6_RT")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.LoanWdrawOrigYr8Rt)
                    .HasColumnName("LOAN_WDRAW_ORIG_YR8_RT")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.MaleComp2yrTransYr2Rt)
                    .HasColumnName("MALE_COMP_2YR_TRANS_YR2_RT")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.MaleComp2yrTransYr3Rt)
                    .HasColumnName("MALE_COMP_2YR_TRANS_YR3_RT")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.MaleComp2yrTransYr4Rt)
                    .HasColumnName("MALE_COMP_2YR_TRANS_YR4_RT")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.MaleComp2yrTransYr6Rt)
                    .HasColumnName("MALE_COMP_2YR_TRANS_YR6_RT")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.MaleComp2yrTransYr8Rt)
                    .HasColumnName("MALE_COMP_2YR_TRANS_YR8_RT")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.MaleComp4yrTransYr2Rt)
                    .HasColumnName("MALE_COMP_4YR_TRANS_YR2_RT")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.MaleComp4yrTransYr3Rt)
                    .HasColumnName("MALE_COMP_4YR_TRANS_YR3_RT")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.MaleComp4yrTransYr4Rt)
                    .HasColumnName("MALE_COMP_4YR_TRANS_YR4_RT")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.MaleComp4yrTransYr6Rt)
                    .HasColumnName("MALE_COMP_4YR_TRANS_YR6_RT")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.MaleComp4yrTransYr8Rt)
                    .HasColumnName("MALE_COMP_4YR_TRANS_YR8_RT")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.MaleCompOrigYr2Rt)
                    .HasColumnName("MALE_COMP_ORIG_YR2_RT")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.MaleCompOrigYr3Rt)
                    .HasColumnName("MALE_COMP_ORIG_YR3_RT")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.MaleCompOrigYr4Rt)
                    .HasColumnName("MALE_COMP_ORIG_YR4_RT")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.MaleCompOrigYr6Rt)
                    .HasColumnName("MALE_COMP_ORIG_YR6_RT")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.MaleCompOrigYr8Rt)
                    .HasColumnName("MALE_COMP_ORIG_YR8_RT")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.MaleDeathYr2Rt)
                    .HasColumnName("MALE_DEATH_YR2_RT")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.MaleDeathYr3Rt)
                    .HasColumnName("MALE_DEATH_YR3_RT")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.MaleDeathYr4Rt)
                    .HasColumnName("MALE_DEATH_YR4_RT")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.MaleDeathYr6Rt)
                    .HasColumnName("MALE_DEATH_YR6_RT")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.MaleDeathYr8Rt)
                    .HasColumnName("MALE_DEATH_YR8_RT")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.MaleEnrl2yrTransYr2Rt)
                    .HasColumnName("MALE_ENRL_2YR_TRANS_YR2_RT")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.MaleEnrl2yrTransYr3Rt)
                    .HasColumnName("MALE_ENRL_2YR_TRANS_YR3_RT")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.MaleEnrl2yrTransYr4Rt)
                    .HasColumnName("MALE_ENRL_2YR_TRANS_YR4_RT")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.MaleEnrl2yrTransYr6Rt)
                    .HasColumnName("MALE_ENRL_2YR_TRANS_YR6_RT")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.MaleEnrl2yrTransYr8Rt)
                    .HasColumnName("MALE_ENRL_2YR_TRANS_YR8_RT")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.MaleEnrl4yrTransYr2Rt)
                    .HasColumnName("MALE_ENRL_4YR_TRANS_YR2_RT")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.MaleEnrl4yrTransYr3Rt)
                    .HasColumnName("MALE_ENRL_4YR_TRANS_YR3_RT")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.MaleEnrl4yrTransYr4Rt)
                    .HasColumnName("MALE_ENRL_4YR_TRANS_YR4_RT")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.MaleEnrl4yrTransYr6Rt)
                    .HasColumnName("MALE_ENRL_4YR_TRANS_YR6_RT")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.MaleEnrl4yrTransYr8Rt)
                    .HasColumnName("MALE_ENRL_4YR_TRANS_YR8_RT")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.MaleEnrlOrigYr2Rt)
                    .HasColumnName("MALE_ENRL_ORIG_YR2_RT")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.MaleEnrlOrigYr3Rt)
                    .HasColumnName("MALE_ENRL_ORIG_YR3_RT")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.MaleEnrlOrigYr4Rt)
                    .HasColumnName("MALE_ENRL_ORIG_YR4_RT")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.MaleEnrlOrigYr6Rt)
                    .HasColumnName("MALE_ENRL_ORIG_YR6_RT")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.MaleEnrlOrigYr8Rt)
                    .HasColumnName("MALE_ENRL_ORIG_YR8_RT")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.MaleUnkn2yrTransYr2Rt)
                    .HasColumnName("MALE_UNKN_2YR_TRANS_YR2_RT")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.MaleUnkn2yrTransYr3Rt)
                    .HasColumnName("MALE_UNKN_2YR_TRANS_YR3_RT")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.MaleUnkn2yrTransYr4Rt)
                    .HasColumnName("MALE_UNKN_2YR_TRANS_YR4_RT")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.MaleUnkn2yrTransYr6Rt)
                    .HasColumnName("MALE_UNKN_2YR_TRANS_YR6_RT")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.MaleUnkn2yrTransYr8Rt)
                    .HasColumnName("MALE_UNKN_2YR_TRANS_YR8_RT")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.MaleUnkn4yrTransYr2Rt)
                    .HasColumnName("MALE_UNKN_4YR_TRANS_YR2_RT")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.MaleUnkn4yrTransYr3Rt)
                    .HasColumnName("MALE_UNKN_4YR_TRANS_YR3_RT")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.MaleUnkn4yrTransYr4Rt)
                    .HasColumnName("MALE_UNKN_4YR_TRANS_YR4_RT")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.MaleUnkn4yrTransYr6Rt)
                    .HasColumnName("MALE_UNKN_4YR_TRANS_YR6_RT")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.MaleUnkn4yrTransYr8Rt)
                    .HasColumnName("MALE_UNKN_4YR_TRANS_YR8_RT")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.MaleUnknOrigYr2Rt)
                    .HasColumnName("MALE_UNKN_ORIG_YR2_RT")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.MaleUnknOrigYr3Rt)
                    .HasColumnName("MALE_UNKN_ORIG_YR3_RT")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.MaleUnknOrigYr4Rt)
                    .HasColumnName("MALE_UNKN_ORIG_YR4_RT")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.MaleUnknOrigYr6Rt)
                    .HasColumnName("MALE_UNKN_ORIG_YR6_RT")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.MaleUnknOrigYr8Rt)
                    .HasColumnName("MALE_UNKN_ORIG_YR8_RT")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.MaleWdraw2yrTransYr2Rt)
                    .HasColumnName("MALE_WDRAW_2YR_TRANS_YR2_RT")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.MaleWdraw2yrTransYr3Rt)
                    .HasColumnName("MALE_WDRAW_2YR_TRANS_YR3_RT")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.MaleWdraw2yrTransYr4Rt)
                    .HasColumnName("MALE_WDRAW_2YR_TRANS_YR4_RT")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.MaleWdraw2yrTransYr6Rt)
                    .HasColumnName("MALE_WDRAW_2YR_TRANS_YR6_RT")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.MaleWdraw2yrTransYr8Rt)
                    .HasColumnName("MALE_WDRAW_2YR_TRANS_YR8_RT")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.MaleWdraw4yrTransYr2Rt)
                    .HasColumnName("MALE_WDRAW_4YR_TRANS_YR2_RT")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.MaleWdraw4yrTransYr3Rt)
                    .HasColumnName("MALE_WDRAW_4YR_TRANS_YR3_RT")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.MaleWdraw4yrTransYr4Rt)
                    .HasColumnName("MALE_WDRAW_4YR_TRANS_YR4_RT")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.MaleWdraw4yrTransYr6Rt)
                    .HasColumnName("MALE_WDRAW_4YR_TRANS_YR6_RT")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.MaleWdraw4yrTransYr8Rt)
                    .HasColumnName("MALE_WDRAW_4YR_TRANS_YR8_RT")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.MaleWdrawOrigYr2Rt)
                    .HasColumnName("MALE_WDRAW_ORIG_YR2_RT")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.MaleWdrawOrigYr3Rt)
                    .HasColumnName("MALE_WDRAW_ORIG_YR3_RT")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.MaleWdrawOrigYr4Rt)
                    .HasColumnName("MALE_WDRAW_ORIG_YR4_RT")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.MaleWdrawOrigYr6Rt)
                    .HasColumnName("MALE_WDRAW_ORIG_YR6_RT")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.MaleWdrawOrigYr8Rt)
                    .HasColumnName("MALE_WDRAW_ORIG_YR8_RT")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.MdIncComp2yrTransYr2Rt)
                    .HasColumnName("MD_INC_COMP_2YR_TRANS_YR2_RT")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.MdIncComp2yrTransYr3Rt)
                    .HasColumnName("MD_INC_COMP_2YR_TRANS_YR3_RT")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.MdIncComp2yrTransYr4Rt)
                    .HasColumnName("MD_INC_COMP_2YR_TRANS_YR4_RT")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.MdIncComp2yrTransYr6Rt)
                    .HasColumnName("MD_INC_COMP_2YR_TRANS_YR6_RT")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.MdIncComp2yrTransYr8Rt)
                    .HasColumnName("MD_INC_COMP_2YR_TRANS_YR8_RT")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.MdIncComp4yrTransYr2Rt)
                    .HasColumnName("MD_INC_COMP_4YR_TRANS_YR2_RT")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.MdIncComp4yrTransYr3Rt)
                    .HasColumnName("MD_INC_COMP_4YR_TRANS_YR3_RT")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.MdIncComp4yrTransYr4Rt)
                    .HasColumnName("MD_INC_COMP_4YR_TRANS_YR4_RT")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.MdIncComp4yrTransYr6Rt)
                    .HasColumnName("MD_INC_COMP_4YR_TRANS_YR6_RT")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.MdIncComp4yrTransYr8Rt)
                    .HasColumnName("MD_INC_COMP_4YR_TRANS_YR8_RT")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.MdIncCompOrigYr2Rt)
                    .HasColumnName("MD_INC_COMP_ORIG_YR2_RT")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.MdIncCompOrigYr3Rt)
                    .HasColumnName("MD_INC_COMP_ORIG_YR3_RT")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.MdIncCompOrigYr4Rt)
                    .HasColumnName("MD_INC_COMP_ORIG_YR4_RT")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.MdIncCompOrigYr6Rt)
                    .HasColumnName("MD_INC_COMP_ORIG_YR6_RT")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.MdIncCompOrigYr8Rt)
                    .HasColumnName("MD_INC_COMP_ORIG_YR8_RT")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.MdIncDeathYr2Rt)
                    .HasColumnName("MD_INC_DEATH_YR2_RT")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.MdIncDeathYr3Rt)
                    .HasColumnName("MD_INC_DEATH_YR3_RT")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.MdIncDeathYr4Rt)
                    .HasColumnName("MD_INC_DEATH_YR4_RT")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.MdIncDeathYr6Rt)
                    .HasColumnName("MD_INC_DEATH_YR6_RT")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.MdIncDeathYr8Rt)
                    .HasColumnName("MD_INC_DEATH_YR8_RT")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.MdIncEnrl2yrTransYr2Rt)
                    .HasColumnName("MD_INC_ENRL_2YR_TRANS_YR2_RT")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.MdIncEnrl2yrTransYr3Rt)
                    .HasColumnName("MD_INC_ENRL_2YR_TRANS_YR3_RT")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.MdIncEnrl2yrTransYr4Rt)
                    .HasColumnName("MD_INC_ENRL_2YR_TRANS_YR4_RT")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.MdIncEnrl2yrTransYr6Rt)
                    .HasColumnName("MD_INC_ENRL_2YR_TRANS_YR6_RT")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.MdIncEnrl2yrTransYr8Rt)
                    .HasColumnName("MD_INC_ENRL_2YR_TRANS_YR8_RT")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.MdIncEnrl4yrTransYr2Rt)
                    .HasColumnName("MD_INC_ENRL_4YR_TRANS_YR2_RT")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.MdIncEnrl4yrTransYr3Rt)
                    .HasColumnName("MD_INC_ENRL_4YR_TRANS_YR3_RT")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.MdIncEnrl4yrTransYr4Rt)
                    .HasColumnName("MD_INC_ENRL_4YR_TRANS_YR4_RT")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.MdIncEnrl4yrTransYr6Rt)
                    .HasColumnName("MD_INC_ENRL_4YR_TRANS_YR6_RT")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.MdIncEnrl4yrTransYr8Rt)
                    .HasColumnName("MD_INC_ENRL_4YR_TRANS_YR8_RT")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.MdIncEnrlOrigYr2Rt)
                    .HasColumnName("MD_INC_ENRL_ORIG_YR2_RT")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.MdIncEnrlOrigYr3Rt)
                    .HasColumnName("MD_INC_ENRL_ORIG_YR3_RT")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.MdIncEnrlOrigYr4Rt)
                    .HasColumnName("MD_INC_ENRL_ORIG_YR4_RT")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.MdIncEnrlOrigYr6Rt)
                    .HasColumnName("MD_INC_ENRL_ORIG_YR6_RT")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.MdIncEnrlOrigYr8Rt)
                    .HasColumnName("MD_INC_ENRL_ORIG_YR8_RT")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.MdIncUnkn2yrTransYr2Rt)
                    .HasColumnName("MD_INC_UNKN_2YR_TRANS_YR2_RT")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.MdIncUnkn2yrTransYr3Rt)
                    .HasColumnName("MD_INC_UNKN_2YR_TRANS_YR3_RT")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.MdIncUnkn2yrTransYr4Rt)
                    .HasColumnName("MD_INC_UNKN_2YR_TRANS_YR4_RT")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.MdIncUnkn2yrTransYr6Rt)
                    .HasColumnName("MD_INC_UNKN_2YR_TRANS_YR6_RT")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.MdIncUnkn2yrTransYr8Rt)
                    .HasColumnName("MD_INC_UNKN_2YR_TRANS_YR8_RT")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.MdIncUnkn4yrTransYr2Rt)
                    .HasColumnName("MD_INC_UNKN_4YR_TRANS_YR2_RT")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.MdIncUnkn4yrTransYr3Rt)
                    .HasColumnName("MD_INC_UNKN_4YR_TRANS_YR3_RT")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.MdIncUnkn4yrTransYr4Rt)
                    .HasColumnName("MD_INC_UNKN_4YR_TRANS_YR4_RT")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.MdIncUnkn4yrTransYr6Rt)
                    .HasColumnName("MD_INC_UNKN_4YR_TRANS_YR6_RT")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.MdIncUnkn4yrTransYr8Rt)
                    .HasColumnName("MD_INC_UNKN_4YR_TRANS_YR8_RT")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.MdIncUnknOrigYr2Rt)
                    .HasColumnName("MD_INC_UNKN_ORIG_YR2_RT")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.MdIncUnknOrigYr3Rt)
                    .HasColumnName("MD_INC_UNKN_ORIG_YR3_RT")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.MdIncUnknOrigYr4Rt)
                    .HasColumnName("MD_INC_UNKN_ORIG_YR4_RT")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.MdIncUnknOrigYr6Rt)
                    .HasColumnName("MD_INC_UNKN_ORIG_YR6_RT")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.MdIncUnknOrigYr8Rt)
                    .HasColumnName("MD_INC_UNKN_ORIG_YR8_RT")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.MdIncWdraw2yrTransYr2Rt)
                    .HasColumnName("MD_INC_WDRAW_2YR_TRANS_YR2_RT")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.MdIncWdraw2yrTransYr3Rt)
                    .HasColumnName("MD_INC_WDRAW_2YR_TRANS_YR3_RT")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.MdIncWdraw2yrTransYr4Rt)
                    .HasColumnName("MD_INC_WDRAW_2YR_TRANS_YR4_RT")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.MdIncWdraw2yrTransYr6Rt)
                    .HasColumnName("MD_INC_WDRAW_2YR_TRANS_YR6_RT")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.MdIncWdraw2yrTransYr8Rt)
                    .HasColumnName("MD_INC_WDRAW_2YR_TRANS_YR8_RT")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.MdIncWdraw4yrTransYr2Rt)
                    .HasColumnName("MD_INC_WDRAW_4YR_TRANS_YR2_RT")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.MdIncWdraw4yrTransYr3Rt)
                    .HasColumnName("MD_INC_WDRAW_4YR_TRANS_YR3_RT")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.MdIncWdraw4yrTransYr4Rt)
                    .HasColumnName("MD_INC_WDRAW_4YR_TRANS_YR4_RT")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.MdIncWdraw4yrTransYr6Rt)
                    .HasColumnName("MD_INC_WDRAW_4YR_TRANS_YR6_RT")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.MdIncWdraw4yrTransYr8Rt)
                    .HasColumnName("MD_INC_WDRAW_4YR_TRANS_YR8_RT")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.MdIncWdrawOrigYr2Rt)
                    .HasColumnName("MD_INC_WDRAW_ORIG_YR2_RT")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.MdIncWdrawOrigYr3Rt)
                    .HasColumnName("MD_INC_WDRAW_ORIG_YR3_RT")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.MdIncWdrawOrigYr4Rt)
                    .HasColumnName("MD_INC_WDRAW_ORIG_YR4_RT")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.MdIncWdrawOrigYr6Rt)
                    .HasColumnName("MD_INC_WDRAW_ORIG_YR6_RT")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.MdIncWdrawOrigYr8Rt)
                    .HasColumnName("MD_INC_WDRAW_ORIG_YR8_RT")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.NoloanComp2yrTransYr2Rt)
                    .HasColumnName("NOLOAN_COMP_2YR_TRANS_YR2_RT")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.NoloanComp2yrTransYr3Rt)
                    .HasColumnName("NOLOAN_COMP_2YR_TRANS_YR3_RT")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.NoloanComp2yrTransYr4Rt)
                    .HasColumnName("NOLOAN_COMP_2YR_TRANS_YR4_RT")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.NoloanComp2yrTransYr6Rt)
                    .HasColumnName("NOLOAN_COMP_2YR_TRANS_YR6_RT")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.NoloanComp2yrTransYr8Rt)
                    .HasColumnName("NOLOAN_COMP_2YR_TRANS_YR8_RT")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.NoloanComp4yrTransYr2Rt)
                    .HasColumnName("NOLOAN_COMP_4YR_TRANS_YR2_RT")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.NoloanComp4yrTransYr3Rt)
                    .HasColumnName("NOLOAN_COMP_4YR_TRANS_YR3_RT")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.NoloanComp4yrTransYr4Rt)
                    .HasColumnName("NOLOAN_COMP_4YR_TRANS_YR4_RT")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.NoloanComp4yrTransYr6Rt)
                    .HasColumnName("NOLOAN_COMP_4YR_TRANS_YR6_RT")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.NoloanComp4yrTransYr8Rt)
                    .HasColumnName("NOLOAN_COMP_4YR_TRANS_YR8_RT")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.NoloanCompOrigYr2Rt)
                    .HasColumnName("NOLOAN_COMP_ORIG_YR2_RT")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.NoloanCompOrigYr3Rt)
                    .HasColumnName("NOLOAN_COMP_ORIG_YR3_RT")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.NoloanCompOrigYr4Rt)
                    .HasColumnName("NOLOAN_COMP_ORIG_YR4_RT")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.NoloanCompOrigYr6Rt)
                    .HasColumnName("NOLOAN_COMP_ORIG_YR6_RT")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.NoloanCompOrigYr8Rt)
                    .HasColumnName("NOLOAN_COMP_ORIG_YR8_RT")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.NoloanDeathYr2Rt)
                    .HasColumnName("NOLOAN_DEATH_YR2_RT")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.NoloanDeathYr3Rt)
                    .HasColumnName("NOLOAN_DEATH_YR3_RT")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.NoloanDeathYr4Rt)
                    .HasColumnName("NOLOAN_DEATH_YR4_RT")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.NoloanDeathYr6Rt)
                    .HasColumnName("NOLOAN_DEATH_YR6_RT")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.NoloanDeathYr8Rt)
                    .HasColumnName("NOLOAN_DEATH_YR8_RT")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.NoloanEnrl2yrTransYr2Rt)
                    .HasColumnName("NOLOAN_ENRL_2YR_TRANS_YR2_RT")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.NoloanEnrl2yrTransYr3Rt)
                    .HasColumnName("NOLOAN_ENRL_2YR_TRANS_YR3_RT")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.NoloanEnrl2yrTransYr4Rt)
                    .HasColumnName("NOLOAN_ENRL_2YR_TRANS_YR4_RT")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.NoloanEnrl2yrTransYr6Rt)
                    .HasColumnName("NOLOAN_ENRL_2YR_TRANS_YR6_RT")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.NoloanEnrl2yrTransYr8Rt)
                    .HasColumnName("NOLOAN_ENRL_2YR_TRANS_YR8_RT")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.NoloanEnrl4yrTransYr2Rt)
                    .HasColumnName("NOLOAN_ENRL_4YR_TRANS_YR2_RT")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.NoloanEnrl4yrTransYr3Rt)
                    .HasColumnName("NOLOAN_ENRL_4YR_TRANS_YR3_RT")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.NoloanEnrl4yrTransYr4Rt)
                    .HasColumnName("NOLOAN_ENRL_4YR_TRANS_YR4_RT")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.NoloanEnrl4yrTransYr6Rt)
                    .HasColumnName("NOLOAN_ENRL_4YR_TRANS_YR6_RT")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.NoloanEnrl4yrTransYr8Rt)
                    .HasColumnName("NOLOAN_ENRL_4YR_TRANS_YR8_RT")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.NoloanEnrlOrigYr2Rt)
                    .HasColumnName("NOLOAN_ENRL_ORIG_YR2_RT")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.NoloanEnrlOrigYr3Rt)
                    .HasColumnName("NOLOAN_ENRL_ORIG_YR3_RT")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.NoloanEnrlOrigYr4Rt)
                    .HasColumnName("NOLOAN_ENRL_ORIG_YR4_RT")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.NoloanEnrlOrigYr6Rt)
                    .HasColumnName("NOLOAN_ENRL_ORIG_YR6_RT")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.NoloanEnrlOrigYr8Rt)
                    .HasColumnName("NOLOAN_ENRL_ORIG_YR8_RT")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.NoloanUnkn2yrTransYr2Rt)
                    .HasColumnName("NOLOAN_UNKN_2YR_TRANS_YR2_RT")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.NoloanUnkn2yrTransYr3Rt)
                    .HasColumnName("NOLOAN_UNKN_2YR_TRANS_YR3_RT")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.NoloanUnkn2yrTransYr4Rt)
                    .HasColumnName("NOLOAN_UNKN_2YR_TRANS_YR4_RT")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.NoloanUnkn2yrTransYr6Rt)
                    .HasColumnName("NOLOAN_UNKN_2YR_TRANS_YR6_RT")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.NoloanUnkn2yrTransYr8Rt)
                    .HasColumnName("NOLOAN_UNKN_2YR_TRANS_YR8_RT")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.NoloanUnkn4yrTransYr2Rt)
                    .HasColumnName("NOLOAN_UNKN_4YR_TRANS_YR2_RT")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.NoloanUnkn4yrTransYr3Rt)
                    .HasColumnName("NOLOAN_UNKN_4YR_TRANS_YR3_RT")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.NoloanUnkn4yrTransYr4Rt)
                    .HasColumnName("NOLOAN_UNKN_4YR_TRANS_YR4_RT")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.NoloanUnkn4yrTransYr6Rt)
                    .HasColumnName("NOLOAN_UNKN_4YR_TRANS_YR6_RT")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.NoloanUnkn4yrTransYr8Rt)
                    .HasColumnName("NOLOAN_UNKN_4YR_TRANS_YR8_RT")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.NoloanUnknOrigYr2Rt)
                    .HasColumnName("NOLOAN_UNKN_ORIG_YR2_RT")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.NoloanUnknOrigYr3Rt)
                    .HasColumnName("NOLOAN_UNKN_ORIG_YR3_RT")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.NoloanUnknOrigYr4Rt)
                    .HasColumnName("NOLOAN_UNKN_ORIG_YR4_RT")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.NoloanUnknOrigYr6Rt)
                    .HasColumnName("NOLOAN_UNKN_ORIG_YR6_RT")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.NoloanUnknOrigYr8Rt)
                    .HasColumnName("NOLOAN_UNKN_ORIG_YR8_RT")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.NoloanWdraw2yrTransYr2Rt)
                    .HasColumnName("NOLOAN_WDRAW_2YR_TRANS_YR2_RT")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.NoloanWdraw2yrTransYr3Rt)
                    .HasColumnName("NOLOAN_WDRAW_2YR_TRANS_YR3_RT")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.NoloanWdraw2yrTransYr4Rt)
                    .HasColumnName("NOLOAN_WDRAW_2YR_TRANS_YR4_RT")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.NoloanWdraw2yrTransYr6Rt)
                    .HasColumnName("NOLOAN_WDRAW_2YR_TRANS_YR6_RT")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.NoloanWdraw2yrTransYr8Rt)
                    .HasColumnName("NOLOAN_WDRAW_2YR_TRANS_YR8_RT")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.NoloanWdraw4yrTransYr2Rt)
                    .HasColumnName("NOLOAN_WDRAW_4YR_TRANS_YR2_RT")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.NoloanWdraw4yrTransYr3Rt)
                    .HasColumnName("NOLOAN_WDRAW_4YR_TRANS_YR3_RT")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.NoloanWdraw4yrTransYr4Rt)
                    .HasColumnName("NOLOAN_WDRAW_4YR_TRANS_YR4_RT")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.NoloanWdraw4yrTransYr6Rt)
                    .HasColumnName("NOLOAN_WDRAW_4YR_TRANS_YR6_RT")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.NoloanWdraw4yrTransYr8Rt)
                    .HasColumnName("NOLOAN_WDRAW_4YR_TRANS_YR8_RT")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.NoloanWdrawOrigYr2Rt)
                    .HasColumnName("NOLOAN_WDRAW_ORIG_YR2_RT")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.NoloanWdrawOrigYr3Rt)
                    .HasColumnName("NOLOAN_WDRAW_ORIG_YR3_RT")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.NoloanWdrawOrigYr4Rt)
                    .HasColumnName("NOLOAN_WDRAW_ORIG_YR4_RT")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.NoloanWdrawOrigYr6Rt)
                    .HasColumnName("NOLOAN_WDRAW_ORIG_YR6_RT")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.NoloanWdrawOrigYr8Rt)
                    .HasColumnName("NOLOAN_WDRAW_ORIG_YR8_RT")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.NopellComp2yrTransYr2Rt)
                    .HasColumnName("NOPELL_COMP_2YR_TRANS_YR2_RT")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.NopellComp2yrTransYr3Rt)
                    .HasColumnName("NOPELL_COMP_2YR_TRANS_YR3_RT")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.NopellComp2yrTransYr4Rt)
                    .HasColumnName("NOPELL_COMP_2YR_TRANS_YR4_RT")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.NopellComp2yrTransYr6Rt)
                    .HasColumnName("NOPELL_COMP_2YR_TRANS_YR6_RT")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.NopellComp2yrTransYr8Rt)
                    .HasColumnName("NOPELL_COMP_2YR_TRANS_YR8_RT")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.NopellComp4yrTransYr2Rt)
                    .HasColumnName("NOPELL_COMP_4YR_TRANS_YR2_RT")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.NopellComp4yrTransYr3Rt)
                    .HasColumnName("NOPELL_COMP_4YR_TRANS_YR3_RT")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.NopellComp4yrTransYr4Rt)
                    .HasColumnName("NOPELL_COMP_4YR_TRANS_YR4_RT")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.NopellComp4yrTransYr6Rt)
                    .HasColumnName("NOPELL_COMP_4YR_TRANS_YR6_RT")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.NopellComp4yrTransYr8Rt)
                    .HasColumnName("NOPELL_COMP_4YR_TRANS_YR8_RT")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.NopellCompOrigYr2Rt)
                    .HasColumnName("NOPELL_COMP_ORIG_YR2_RT")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.NopellCompOrigYr3Rt)
                    .HasColumnName("NOPELL_COMP_ORIG_YR3_RT")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.NopellCompOrigYr4Rt)
                    .HasColumnName("NOPELL_COMP_ORIG_YR4_RT")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.NopellCompOrigYr6Rt)
                    .HasColumnName("NOPELL_COMP_ORIG_YR6_RT")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.NopellCompOrigYr8Rt)
                    .HasColumnName("NOPELL_COMP_ORIG_YR8_RT")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.NopellDeathYr2Rt)
                    .HasColumnName("NOPELL_DEATH_YR2_RT")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.NopellDeathYr3Rt)
                    .HasColumnName("NOPELL_DEATH_YR3_RT")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.NopellDeathYr4Rt)
                    .HasColumnName("NOPELL_DEATH_YR4_RT")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.NopellDeathYr6Rt)
                    .HasColumnName("NOPELL_DEATH_YR6_RT")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.NopellDeathYr8Rt)
                    .HasColumnName("NOPELL_DEATH_YR8_RT")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.NopellEnrl2yrTransYr2Rt)
                    .HasColumnName("NOPELL_ENRL_2YR_TRANS_YR2_RT")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.NopellEnrl2yrTransYr3Rt)
                    .HasColumnName("NOPELL_ENRL_2YR_TRANS_YR3_RT")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.NopellEnrl2yrTransYr4Rt)
                    .HasColumnName("NOPELL_ENRL_2YR_TRANS_YR4_RT")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.NopellEnrl2yrTransYr6Rt)
                    .HasColumnName("NOPELL_ENRL_2YR_TRANS_YR6_RT")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.NopellEnrl2yrTransYr8Rt)
                    .HasColumnName("NOPELL_ENRL_2YR_TRANS_YR8_RT")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.NopellEnrl4yrTransYr2Rt)
                    .HasColumnName("NOPELL_ENRL_4YR_TRANS_YR2_RT")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.NopellEnrl4yrTransYr3Rt)
                    .HasColumnName("NOPELL_ENRL_4YR_TRANS_YR3_RT")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.NopellEnrl4yrTransYr4Rt)
                    .HasColumnName("NOPELL_ENRL_4YR_TRANS_YR4_RT")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.NopellEnrl4yrTransYr6Rt)
                    .HasColumnName("NOPELL_ENRL_4YR_TRANS_YR6_RT")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.NopellEnrl4yrTransYr8Rt)
                    .HasColumnName("NOPELL_ENRL_4YR_TRANS_YR8_RT")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.NopellEnrlOrigYr2Rt)
                    .HasColumnName("NOPELL_ENRL_ORIG_YR2_RT")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.NopellEnrlOrigYr3Rt)
                    .HasColumnName("NOPELL_ENRL_ORIG_YR3_RT")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.NopellEnrlOrigYr4Rt)
                    .HasColumnName("NOPELL_ENRL_ORIG_YR4_RT")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.NopellEnrlOrigYr6Rt)
                    .HasColumnName("NOPELL_ENRL_ORIG_YR6_RT")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.NopellEnrlOrigYr8Rt)
                    .HasColumnName("NOPELL_ENRL_ORIG_YR8_RT")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.NopellUnkn2yrTransYr2Rt)
                    .HasColumnName("NOPELL_UNKN_2YR_TRANS_YR2_RT")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.NopellUnkn2yrTransYr3Rt)
                    .HasColumnName("NOPELL_UNKN_2YR_TRANS_YR3_RT")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.NopellUnkn2yrTransYr4Rt)
                    .HasColumnName("NOPELL_UNKN_2YR_TRANS_YR4_RT")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.NopellUnkn2yrTransYr6Rt)
                    .HasColumnName("NOPELL_UNKN_2YR_TRANS_YR6_RT")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.NopellUnkn2yrTransYr8Rt)
                    .HasColumnName("NOPELL_UNKN_2YR_TRANS_YR8_RT")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.NopellUnkn4yrTransYr2Rt)
                    .HasColumnName("NOPELL_UNKN_4YR_TRANS_YR2_RT")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.NopellUnkn4yrTransYr3Rt)
                    .HasColumnName("NOPELL_UNKN_4YR_TRANS_YR3_RT")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.NopellUnkn4yrTransYr4Rt)
                    .HasColumnName("NOPELL_UNKN_4YR_TRANS_YR4_RT")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.NopellUnkn4yrTransYr6Rt)
                    .HasColumnName("NOPELL_UNKN_4YR_TRANS_YR6_RT")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.NopellUnkn4yrTransYr8Rt)
                    .HasColumnName("NOPELL_UNKN_4YR_TRANS_YR8_RT")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.NopellUnknOrigYr2Rt)
                    .HasColumnName("NOPELL_UNKN_ORIG_YR2_RT")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.NopellUnknOrigYr3Rt)
                    .HasColumnName("NOPELL_UNKN_ORIG_YR3_RT")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.NopellUnknOrigYr4Rt)
                    .HasColumnName("NOPELL_UNKN_ORIG_YR4_RT")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.NopellUnknOrigYr6Rt)
                    .HasColumnName("NOPELL_UNKN_ORIG_YR6_RT")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.NopellUnknOrigYr8Rt)
                    .HasColumnName("NOPELL_UNKN_ORIG_YR8_RT")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.NopellWdraw2yrTransYr2Rt)
                    .HasColumnName("NOPELL_WDRAW_2YR_TRANS_YR2_RT")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.NopellWdraw2yrTransYr3Rt)
                    .HasColumnName("NOPELL_WDRAW_2YR_TRANS_YR3_RT")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.NopellWdraw2yrTransYr4Rt)
                    .HasColumnName("NOPELL_WDRAW_2YR_TRANS_YR4_RT")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.NopellWdraw2yrTransYr6Rt)
                    .HasColumnName("NOPELL_WDRAW_2YR_TRANS_YR6_RT")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.NopellWdraw2yrTransYr8Rt)
                    .HasColumnName("NOPELL_WDRAW_2YR_TRANS_YR8_RT")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.NopellWdraw4yrTransYr2Rt)
                    .HasColumnName("NOPELL_WDRAW_4YR_TRANS_YR2_RT")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.NopellWdraw4yrTransYr3Rt)
                    .HasColumnName("NOPELL_WDRAW_4YR_TRANS_YR3_RT")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.NopellWdraw4yrTransYr4Rt)
                    .HasColumnName("NOPELL_WDRAW_4YR_TRANS_YR4_RT")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.NopellWdraw4yrTransYr6Rt)
                    .HasColumnName("NOPELL_WDRAW_4YR_TRANS_YR6_RT")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.NopellWdraw4yrTransYr8Rt)
                    .HasColumnName("NOPELL_WDRAW_4YR_TRANS_YR8_RT")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.NopellWdrawOrigYr2Rt)
                    .HasColumnName("NOPELL_WDRAW_ORIG_YR2_RT")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.NopellWdrawOrigYr3Rt)
                    .HasColumnName("NOPELL_WDRAW_ORIG_YR3_RT")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.NopellWdrawOrigYr4Rt)
                    .HasColumnName("NOPELL_WDRAW_ORIG_YR4_RT")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.NopellWdrawOrigYr6Rt)
                    .HasColumnName("NOPELL_WDRAW_ORIG_YR6_RT")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.NopellWdrawOrigYr8Rt)
                    .HasColumnName("NOPELL_WDRAW_ORIG_YR8_RT")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.Not1stgenComp2yrTransYr2Rt)
                    .HasColumnName("NOT1STGEN_COMP_2YR_TRANS_YR2_RT")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.Not1stgenComp2yrTransYr3Rt)
                    .HasColumnName("NOT1STGEN_COMP_2YR_TRANS_YR3_RT")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.Not1stgenComp2yrTransYr4Rt)
                    .HasColumnName("NOT1STGEN_COMP_2YR_TRANS_YR4_RT")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.Not1stgenComp2yrTransYr6Rt)
                    .HasColumnName("NOT1STGEN_COMP_2YR_TRANS_YR6_RT")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.Not1stgenComp2yrTransYr8Rt)
                    .HasColumnName("NOT1STGEN_COMP_2YR_TRANS_YR8_RT")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.Not1stgenComp4yrTransYr2Rt)
                    .HasColumnName("NOT1STGEN_COMP_4YR_TRANS_YR2_RT")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.Not1stgenComp4yrTransYr3Rt)
                    .HasColumnName("NOT1STGEN_COMP_4YR_TRANS_YR3_RT")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.Not1stgenComp4yrTransYr4Rt)
                    .HasColumnName("NOT1STGEN_COMP_4YR_TRANS_YR4_RT")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.Not1stgenComp4yrTransYr6Rt)
                    .HasColumnName("NOT1STGEN_COMP_4YR_TRANS_YR6_RT")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.Not1stgenComp4yrTransYr8Rt)
                    .HasColumnName("NOT1STGEN_COMP_4YR_TRANS_YR8_RT")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.Not1stgenCompOrigYr2Rt)
                    .HasColumnName("NOT1STGEN_COMP_ORIG_YR2_RT")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.Not1stgenCompOrigYr3Rt)
                    .HasColumnName("NOT1STGEN_COMP_ORIG_YR3_RT")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.Not1stgenCompOrigYr4Rt)
                    .HasColumnName("NOT1STGEN_COMP_ORIG_YR4_RT")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.Not1stgenCompOrigYr6Rt)
                    .HasColumnName("NOT1STGEN_COMP_ORIG_YR6_RT")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.Not1stgenCompOrigYr8Rt)
                    .HasColumnName("NOT1STGEN_COMP_ORIG_YR8_RT")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.Not1stgenDeathYr2Rt)
                    .HasColumnName("NOT1STGEN_DEATH_YR2_RT")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.Not1stgenDeathYr3Rt)
                    .HasColumnName("NOT1STGEN_DEATH_YR3_RT")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.Not1stgenDeathYr4Rt)
                    .HasColumnName("NOT1STGEN_DEATH_YR4_RT")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.Not1stgenDeathYr6Rt)
                    .HasColumnName("NOT1STGEN_DEATH_YR6_RT")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.Not1stgenDeathYr8Rt)
                    .HasColumnName("NOT1STGEN_DEATH_YR8_RT")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.Not1stgenEnrl2yrTransYr2Rt)
                    .HasColumnName("NOT1STGEN_ENRL_2YR_TRANS_YR2_RT")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.Not1stgenEnrl2yrTransYr3Rt)
                    .HasColumnName("NOT1STGEN_ENRL_2YR_TRANS_YR3_RT")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.Not1stgenEnrl2yrTransYr4Rt)
                    .HasColumnName("NOT1STGEN_ENRL_2YR_TRANS_YR4_RT")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.Not1stgenEnrl2yrTransYr6Rt)
                    .HasColumnName("NOT1STGEN_ENRL_2YR_TRANS_YR6_RT")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.Not1stgenEnrl2yrTransYr8Rt)
                    .HasColumnName("NOT1STGEN_ENRL_2YR_TRANS_YR8_RT")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.Not1stgenEnrl4yrTransYr2Rt)
                    .HasColumnName("NOT1STGEN_ENRL_4YR_TRANS_YR2_RT")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.Not1stgenEnrl4yrTransYr3Rt)
                    .HasColumnName("NOT1STGEN_ENRL_4YR_TRANS_YR3_RT")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.Not1stgenEnrl4yrTransYr4Rt)
                    .HasColumnName("NOT1STGEN_ENRL_4YR_TRANS_YR4_RT")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.Not1stgenEnrl4yrTransYr6Rt)
                    .HasColumnName("NOT1STGEN_ENRL_4YR_TRANS_YR6_RT")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.Not1stgenEnrl4yrTransYr8Rt)
                    .HasColumnName("NOT1STGEN_ENRL_4YR_TRANS_YR8_RT")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.Not1stgenEnrlOrigYr2Rt)
                    .HasColumnName("NOT1STGEN_ENRL_ORIG_YR2_RT")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.Not1stgenEnrlOrigYr3Rt)
                    .HasColumnName("NOT1STGEN_ENRL_ORIG_YR3_RT")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.Not1stgenEnrlOrigYr4Rt)
                    .HasColumnName("NOT1STGEN_ENRL_ORIG_YR4_RT")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.Not1stgenEnrlOrigYr6Rt)
                    .HasColumnName("NOT1STGEN_ENRL_ORIG_YR6_RT")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.Not1stgenEnrlOrigYr8Rt)
                    .HasColumnName("NOT1STGEN_ENRL_ORIG_YR8_RT")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.Not1stgenUnkn2yrTransYr2Rt)
                    .HasColumnName("NOT1STGEN_UNKN_2YR_TRANS_YR2_RT")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.Not1stgenUnkn2yrTransYr3Rt)
                    .HasColumnName("NOT1STGEN_UNKN_2YR_TRANS_YR3_RT")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.Not1stgenUnkn2yrTransYr4Rt)
                    .HasColumnName("NOT1STGEN_UNKN_2YR_TRANS_YR4_RT")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.Not1stgenUnkn2yrTransYr6Rt)
                    .HasColumnName("NOT1STGEN_UNKN_2YR_TRANS_YR6_RT")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.Not1stgenUnkn2yrTransYr8Rt)
                    .HasColumnName("NOT1STGEN_UNKN_2YR_TRANS_YR8_RT")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.Not1stgenUnkn4yrTransYr2Rt)
                    .HasColumnName("NOT1STGEN_UNKN_4YR_TRANS_YR2_RT")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.Not1stgenUnkn4yrTransYr3Rt)
                    .HasColumnName("NOT1STGEN_UNKN_4YR_TRANS_YR3_RT")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.Not1stgenUnkn4yrTransYr4Rt)
                    .HasColumnName("NOT1STGEN_UNKN_4YR_TRANS_YR4_RT")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.Not1stgenUnkn4yrTransYr6Rt)
                    .HasColumnName("NOT1STGEN_UNKN_4YR_TRANS_YR6_RT")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.Not1stgenUnkn4yrTransYr8Rt)
                    .HasColumnName("NOT1STGEN_UNKN_4YR_TRANS_YR8_RT")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.Not1stgenUnknOrigYr2Rt)
                    .HasColumnName("NOT1STGEN_UNKN_ORIG_YR2_RT")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.Not1stgenUnknOrigYr3Rt)
                    .HasColumnName("NOT1STGEN_UNKN_ORIG_YR3_RT")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.Not1stgenUnknOrigYr4Rt)
                    .HasColumnName("NOT1STGEN_UNKN_ORIG_YR4_RT")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.Not1stgenUnknOrigYr6Rt)
                    .HasColumnName("NOT1STGEN_UNKN_ORIG_YR6_RT")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.Not1stgenUnknOrigYr8Rt)
                    .HasColumnName("NOT1STGEN_UNKN_ORIG_YR8_RT")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.Not1stgenWdraw2yrTransYr2Rt)
                    .HasColumnName("NOT1STGEN_WDRAW_2YR_TRANS_YR2_RT")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.Not1stgenWdraw2yrTransYr3Rt)
                    .HasColumnName("NOT1STGEN_WDRAW_2YR_TRANS_YR3_RT")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.Not1stgenWdraw2yrTransYr4Rt)
                    .HasColumnName("NOT1STGEN_WDRAW_2YR_TRANS_YR4_RT")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.Not1stgenWdraw2yrTransYr6Rt)
                    .HasColumnName("NOT1STGEN_WDRAW_2YR_TRANS_YR6_RT")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.Not1stgenWdraw2yrTransYr8Rt)
                    .HasColumnName("NOT1STGEN_WDRAW_2YR_TRANS_YR8_RT")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.Not1stgenWdraw4yrTransYr2Rt)
                    .HasColumnName("NOT1STGEN_WDRAW_4YR_TRANS_YR2_RT")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.Not1stgenWdraw4yrTransYr3Rt)
                    .HasColumnName("NOT1STGEN_WDRAW_4YR_TRANS_YR3_RT")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.Not1stgenWdraw4yrTransYr4Rt)
                    .HasColumnName("NOT1STGEN_WDRAW_4YR_TRANS_YR4_RT")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.Not1stgenWdraw4yrTransYr6Rt)
                    .HasColumnName("NOT1STGEN_WDRAW_4YR_TRANS_YR6_RT")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.Not1stgenWdraw4yrTransYr8Rt)
                    .HasColumnName("NOT1STGEN_WDRAW_4YR_TRANS_YR8_RT")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.Not1stgenWdrawOrigYr2Rt)
                    .HasColumnName("NOT1STGEN_WDRAW_ORIG_YR2_RT")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.Not1stgenWdrawOrigYr3Rt)
                    .HasColumnName("NOT1STGEN_WDRAW_ORIG_YR3_RT")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.Not1stgenWdrawOrigYr4Rt)
                    .HasColumnName("NOT1STGEN_WDRAW_ORIG_YR4_RT")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.Not1stgenWdrawOrigYr6Rt)
                    .HasColumnName("NOT1STGEN_WDRAW_ORIG_YR6_RT")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.Not1stgenWdrawOrigYr8Rt)
                    .HasColumnName("NOT1STGEN_WDRAW_ORIG_YR8_RT")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.PellComp2yrTransYr2Rt)
                    .HasColumnName("PELL_COMP_2YR_TRANS_YR2_RT")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.PellComp2yrTransYr3Rt)
                    .HasColumnName("PELL_COMP_2YR_TRANS_YR3_RT")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.PellComp2yrTransYr4Rt)
                    .HasColumnName("PELL_COMP_2YR_TRANS_YR4_RT")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.PellComp2yrTransYr6Rt)
                    .HasColumnName("PELL_COMP_2YR_TRANS_YR6_RT")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.PellComp2yrTransYr8Rt)
                    .HasColumnName("PELL_COMP_2YR_TRANS_YR8_RT")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.PellComp4yrTransYr2Rt)
                    .HasColumnName("PELL_COMP_4YR_TRANS_YR2_RT")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.PellComp4yrTransYr3Rt)
                    .HasColumnName("PELL_COMP_4YR_TRANS_YR3_RT")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.PellComp4yrTransYr4Rt)
                    .HasColumnName("PELL_COMP_4YR_TRANS_YR4_RT")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.PellComp4yrTransYr6Rt)
                    .HasColumnName("PELL_COMP_4YR_TRANS_YR6_RT")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.PellComp4yrTransYr8Rt)
                    .HasColumnName("PELL_COMP_4YR_TRANS_YR8_RT")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.PellCompOrigYr2Rt)
                    .HasColumnName("PELL_COMP_ORIG_YR2_RT")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.PellCompOrigYr3Rt)
                    .HasColumnName("PELL_COMP_ORIG_YR3_RT")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.PellCompOrigYr4Rt)
                    .HasColumnName("PELL_COMP_ORIG_YR4_RT")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.PellCompOrigYr6Rt)
                    .HasColumnName("PELL_COMP_ORIG_YR6_RT")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.PellCompOrigYr8Rt)
                    .HasColumnName("PELL_COMP_ORIG_YR8_RT")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.PellDeathYr2Rt)
                    .HasColumnName("PELL_DEATH_YR2_RT")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.PellDeathYr3Rt)
                    .HasColumnName("PELL_DEATH_YR3_RT")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.PellDeathYr4Rt)
                    .HasColumnName("PELL_DEATH_YR4_RT")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.PellDeathYr6Rt)
                    .HasColumnName("PELL_DEATH_YR6_RT")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.PellDeathYr8Rt)
                    .HasColumnName("PELL_DEATH_YR8_RT")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.PellEnrl2yrTransYr2Rt)
                    .HasColumnName("PELL_ENRL_2YR_TRANS_YR2_RT")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.PellEnrl2yrTransYr3Rt)
                    .HasColumnName("PELL_ENRL_2YR_TRANS_YR3_RT")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.PellEnrl2yrTransYr4Rt)
                    .HasColumnName("PELL_ENRL_2YR_TRANS_YR4_RT")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.PellEnrl2yrTransYr6Rt)
                    .HasColumnName("PELL_ENRL_2YR_TRANS_YR6_RT")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.PellEnrl2yrTransYr8Rt)
                    .HasColumnName("PELL_ENRL_2YR_TRANS_YR8_RT")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.PellEnrl4yrTransYr2Rt)
                    .HasColumnName("PELL_ENRL_4YR_TRANS_YR2_RT")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.PellEnrl4yrTransYr3Rt)
                    .HasColumnName("PELL_ENRL_4YR_TRANS_YR3_RT")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.PellEnrl4yrTransYr4Rt)
                    .HasColumnName("PELL_ENRL_4YR_TRANS_YR4_RT")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.PellEnrl4yrTransYr6Rt)
                    .HasColumnName("PELL_ENRL_4YR_TRANS_YR6_RT")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.PellEnrl4yrTransYr8Rt)
                    .HasColumnName("PELL_ENRL_4YR_TRANS_YR8_RT")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.PellEnrlOrigYr2Rt)
                    .HasColumnName("PELL_ENRL_ORIG_YR2_RT")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.PellEnrlOrigYr3Rt)
                    .HasColumnName("PELL_ENRL_ORIG_YR3_RT")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.PellEnrlOrigYr4Rt)
                    .HasColumnName("PELL_ENRL_ORIG_YR4_RT")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.PellEnrlOrigYr6Rt)
                    .HasColumnName("PELL_ENRL_ORIG_YR6_RT")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.PellEnrlOrigYr8Rt)
                    .HasColumnName("PELL_ENRL_ORIG_YR8_RT")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.PellUnkn2yrTransYr2Rt)
                    .HasColumnName("PELL_UNKN_2YR_TRANS_YR2_RT")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.PellUnkn2yrTransYr3Rt)
                    .HasColumnName("PELL_UNKN_2YR_TRANS_YR3_RT")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.PellUnkn2yrTransYr4Rt)
                    .HasColumnName("PELL_UNKN_2YR_TRANS_YR4_RT")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.PellUnkn2yrTransYr6Rt)
                    .HasColumnName("PELL_UNKN_2YR_TRANS_YR6_RT")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.PellUnkn2yrTransYr8Rt)
                    .HasColumnName("PELL_UNKN_2YR_TRANS_YR8_RT")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.PellUnkn4yrTransYr2Rt)
                    .HasColumnName("PELL_UNKN_4YR_TRANS_YR2_RT")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.PellUnkn4yrTransYr3Rt)
                    .HasColumnName("PELL_UNKN_4YR_TRANS_YR3_RT")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.PellUnkn4yrTransYr4Rt)
                    .HasColumnName("PELL_UNKN_4YR_TRANS_YR4_RT")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.PellUnkn4yrTransYr6Rt)
                    .HasColumnName("PELL_UNKN_4YR_TRANS_YR6_RT")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.PellUnkn4yrTransYr8Rt)
                    .HasColumnName("PELL_UNKN_4YR_TRANS_YR8_RT")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.PellUnknOrigYr2Rt)
                    .HasColumnName("PELL_UNKN_ORIG_YR2_RT")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.PellUnknOrigYr3Rt)
                    .HasColumnName("PELL_UNKN_ORIG_YR3_RT")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.PellUnknOrigYr4Rt)
                    .HasColumnName("PELL_UNKN_ORIG_YR4_RT")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.PellUnknOrigYr6Rt)
                    .HasColumnName("PELL_UNKN_ORIG_YR6_RT")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.PellUnknOrigYr8Rt)
                    .HasColumnName("PELL_UNKN_ORIG_YR8_RT")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.PellWdraw2yrTransYr2Rt)
                    .HasColumnName("PELL_WDRAW_2YR_TRANS_YR2_RT")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.PellWdraw2yrTransYr3Rt)
                    .HasColumnName("PELL_WDRAW_2YR_TRANS_YR3_RT")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.PellWdraw2yrTransYr4Rt)
                    .HasColumnName("PELL_WDRAW_2YR_TRANS_YR4_RT")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.PellWdraw2yrTransYr6Rt)
                    .HasColumnName("PELL_WDRAW_2YR_TRANS_YR6_RT")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.PellWdraw2yrTransYr8Rt)
                    .HasColumnName("PELL_WDRAW_2YR_TRANS_YR8_RT")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.PellWdraw4yrTransYr2Rt)
                    .HasColumnName("PELL_WDRAW_4YR_TRANS_YR2_RT")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.PellWdraw4yrTransYr3Rt)
                    .HasColumnName("PELL_WDRAW_4YR_TRANS_YR3_RT")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.PellWdraw4yrTransYr4Rt)
                    .HasColumnName("PELL_WDRAW_4YR_TRANS_YR4_RT")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.PellWdraw4yrTransYr6Rt)
                    .HasColumnName("PELL_WDRAW_4YR_TRANS_YR6_RT")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.PellWdraw4yrTransYr8Rt)
                    .HasColumnName("PELL_WDRAW_4YR_TRANS_YR8_RT")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.PellWdrawOrigYr2Rt)
                    .HasColumnName("PELL_WDRAW_ORIG_YR2_RT")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.PellWdrawOrigYr3Rt)
                    .HasColumnName("PELL_WDRAW_ORIG_YR3_RT")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.PellWdrawOrigYr4Rt)
                    .HasColumnName("PELL_WDRAW_ORIG_YR4_RT")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.PellWdrawOrigYr6Rt)
                    .HasColumnName("PELL_WDRAW_ORIG_YR6_RT")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.PellWdrawOrigYr8Rt)
                    .HasColumnName("PELL_WDRAW_ORIG_YR8_RT")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.Unkn2yrTransYr2Rt)
                    .HasColumnName("UNKN_2YR_TRANS_YR2_RT")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.Unkn2yrTransYr3Rt)
                    .HasColumnName("UNKN_2YR_TRANS_YR3_RT")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.Unkn2yrTransYr4Rt)
                    .HasColumnName("UNKN_2YR_TRANS_YR4_RT")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.Unkn2yrTransYr6Rt)
                    .HasColumnName("UNKN_2YR_TRANS_YR6_RT")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.Unkn2yrTransYr8Rt)
                    .HasColumnName("UNKN_2YR_TRANS_YR8_RT")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.Unkn4yrTransYr2Rt)
                    .HasColumnName("UNKN_4YR_TRANS_YR2_RT")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.Unkn4yrTransYr3Rt)
                    .HasColumnName("UNKN_4YR_TRANS_YR3_RT")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.Unkn4yrTransYr4Rt)
                    .HasColumnName("UNKN_4YR_TRANS_YR4_RT")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.Unkn4yrTransYr6Rt)
                    .HasColumnName("UNKN_4YR_TRANS_YR6_RT")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.Unkn4yrTransYr8Rt)
                    .HasColumnName("UNKN_4YR_TRANS_YR8_RT")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.UnknOrigYr2Rt)
                    .HasColumnName("UNKN_ORIG_YR2_RT")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.UnknOrigYr3Rt)
                    .HasColumnName("UNKN_ORIG_YR3_RT")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.UnknOrigYr4Rt)
                    .HasColumnName("UNKN_ORIG_YR4_RT")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.UnknOrigYr6Rt)
                    .HasColumnName("UNKN_ORIG_YR6_RT")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.UnknOrigYr8Rt)
                    .HasColumnName("UNKN_ORIG_YR8_RT")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.Wdraw2yrTransYr2Rt)
                    .HasColumnName("WDRAW_2YR_TRANS_YR2_RT")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.Wdraw2yrTransYr3Rt)
                    .HasColumnName("WDRAW_2YR_TRANS_YR3_RT")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.Wdraw2yrTransYr4Rt)
                    .HasColumnName("WDRAW_2YR_TRANS_YR4_RT")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.Wdraw2yrTransYr6Rt)
                    .HasColumnName("WDRAW_2YR_TRANS_YR6_RT")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.Wdraw2yrTransYr8Rt)
                    .HasColumnName("WDRAW_2YR_TRANS_YR8_RT")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.Wdraw4yrTransYr2Rt)
                    .HasColumnName("WDRAW_4YR_TRANS_YR2_RT")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.Wdraw4yrTransYr3Rt)
                    .HasColumnName("WDRAW_4YR_TRANS_YR3_RT")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.Wdraw4yrTransYr4Rt)
                    .HasColumnName("WDRAW_4YR_TRANS_YR4_RT")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.Wdraw4yrTransYr6Rt)
                    .HasColumnName("WDRAW_4YR_TRANS_YR6_RT")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.Wdraw4yrTransYr8Rt)
                    .HasColumnName("WDRAW_4YR_TRANS_YR8_RT")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.WdrawOrigYr2Rt)
                    .HasColumnName("WDRAW_ORIG_YR2_RT")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.WdrawOrigYr3Rt)
                    .HasColumnName("WDRAW_ORIG_YR3_RT")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.WdrawOrigYr4Rt)
                    .HasColumnName("WDRAW_ORIG_YR4_RT")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.WdrawOrigYr6Rt)
                    .HasColumnName("WDRAW_ORIG_YR6_RT")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.WdrawOrigYr8Rt)
                    .HasColumnName("WDRAW_ORIG_YR8_RT")
                    .HasColumnType("decimal(5, 2)");

                entity.HasOne(d => d.Unit)
                    .WithOne(p => p.TitleIv)
                    .HasForeignKey<TitleIv>(d => d.Unitid)
                    .OnDelete(DeleteBehavior.ClientSetNull);
            });
        }
    }
}

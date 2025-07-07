using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace TSL.Data.Models.CDN_KNF_Konfiguracja;

public partial class CDN_KNF_KonfiguracjaContext : DbContext
{
    public CDN_KNF_KonfiguracjaContext(DbContextOptions<CDN_KNF_KonfiguracjaContext> options)
        : base(options)
    {
    }

    public virtual DbSet<AktualizacjeBaza> AktualizacjeBazas { get; set; }

    public virtual DbSet<AktualizacjeLog> AktualizacjeLogs { get; set; }

    public virtual DbSet<AktualizacjeProgram> AktualizacjePrograms { get; set; }

    public virtual DbSet<AktualizacjeStanowiska> AktualizacjeStanowiskas { get; set; }

    public virtual DbSet<Analizy> Analizies { get; set; }

    public virtual DbSet<AnlPodlaczenium> AnlPodlaczenia { get; set; }

    public virtual DbSet<AnlUlubione> AnlUlubiones { get; set; }

    public virtual DbSet<AnlWstawki> AnlWstawkis { get; set; }

    public virtual DbSet<AnlZakazy> AnlZakazies { get; set; }

    public virtual DbSet<BackupIbard> BackupIbards { get; set; }

    public virtual DbSet<BazModulyOperatora> BazModulyOperatoras { get; set; }

    public virtual DbSet<BazPrzypomnienium> BazPrzypomnienia { get; set; }

    public virtual DbSet<BazZakazy> BazZakazies { get; set; }

    public virtual DbSet<Bazy> Bazies { get; set; }

    public virtual DbSet<BnkNazwyImport> BnkNazwyImports { get; set; }

    public virtual DbSet<CfgDzialy> CfgDzialies { get; set; }

    public virtual DbSet<CfgKlucze> CfgKluczes { get; set; }

    public virtual DbSet<CfgWartosci> CfgWartoscis { get; set; }

    public virtual DbSet<CrmAutomatyWind> CrmAutomatyWinds { get; set; }

    public virtual DbSet<DaneBinarne> DaneBinarnes { get; set; }

    public virtual DbSet<DeklaracjeDefinicje> DeklaracjeDefinicjes { get; set; }

    public virtual DbSet<DetalFunkcjePrac> DetalFunkcjePracs { get; set; }

    public virtual DbSet<DietyRyczalty> DietyRyczalties { get; set; }

    public virtual DbSet<DokDefinicje> DokDefinicjes { get; set; }

    public virtual DbSet<DokNag> DokNags { get; set; }

    public virtual DbSet<DokNagEtapy> DokNagEtapies { get; set; }

    public virtual DbSet<DokNagEtapyHistorium> DokNagEtapyHistoria { get; set; }

    public virtual DbSet<DokNagEtapyKolejne> DokNagEtapyKolejnes { get; set; }

    public virtual DbSet<DokNagPliki> DokNagPlikis { get; set; }

    public virtual DbSet<DokNagProcesEtapy> DokNagProcesEtapies { get; set; }

    public virtual DbSet<DokPodmioty> DokPodmioties { get; set; }

    public virtual DbSet<DokRelacje> DokRelacjes { get; set; }

    public virtual DbSet<Eteczki> Eteczkis { get; set; }

    public virtual DbSet<EteczkiCertyfikaty> EteczkiCertyfikaties { get; set; }

    public virtual DbSet<Filtry> Filtries { get; set; }

    public virtual DbSet<Grupy> Grupies { get; set; }

    public virtual DbSet<HistoriaPobieraniaWskaznikow> HistoriaPobieraniaWskaznikows { get; set; }

    public virtual DbSet<Informacje> Informacjes { get; set; }

    public virtual DbSet<KatalogZakazy> KatalogZakazies { get; set; }

    public virtual DbSet<Katalogi> Katalogis { get; set; }

    public virtual DbSet<Katrybuty> Katrybuties { get; set; }

    public virtual DbSet<KatrybutyGrupy> KatrybutyGrupies { get; set; }

    public virtual DbSet<KatrybutyKlasy> KatrybutyKlasies { get; set; }

    public virtual DbSet<KatrybutyKlasyElem> KatrybutyKlasyElems { get; set; }

    public virtual DbSet<KatrybutyKlasyZakaz> KatrybutyKlasyZakazs { get; set; }

    public virtual DbSet<KatrybutyKolumny> KatrybutyKolumnies { get; set; }

    public virtual DbSet<Kfpiw> Kfpiws { get; set; }

    public virtual DbSet<Konfig> Konfigs { get; set; }

    public virtual DbSet<KonfigCdn> KonfigCdns { get; set; }

    public virtual DbSet<KonfigText> KonfigTexts { get; set; }

    public virtual DbSet<Kraje> Krajes { get; set; }

    public virtual DbSet<Krst> Krsts { get; set; }

    public virtual DbSet<Kzi> Kzis { get; set; }

    public virtual DbSet<MailFoldery> MailFolderies { get; set; }

    public virtual DbSet<MailIdentyfikatory> MailIdentyfikatories { get; set; }

    public virtual DbSet<MailKontaCertyfikaty> MailKontaCertyfikaties { get; set; }

    public virtual DbSet<MailKontaEmail> MailKontaEmails { get; set; }

    public virtual DbSet<MailPodpisy> MailPodpisies { get; set; }

    public virtual DbSet<MailSzablony> MailSzablonies { get; set; }

    public virtual DbSet<MailSzablonyDomyslne> MailSzablonyDomyslnes { get; set; }

    public virtual DbSet<MailSzablonyPodlaczenium> MailSzablonyPodlaczenia { get; set; }

    public virtual DbSet<MailUzytkownicyKont> MailUzytkownicyKonts { get; set; }

    public virtual DbSet<MailWatek> MailWateks { get; set; }

    public virtual DbSet<MailWiadomosci> MailWiadomoscis { get; set; }

    public virtual DbSet<MailWiadomosciHistorium> MailWiadomosciHistoria { get; set; }

    public virtual DbSet<MailWiadomosciPrzeczytane> MailWiadomosciPrzeczytanes { get; set; }

    public virtual DbSet<Miastum> Miasta { get; set; }

    public virtual DbSet<OfertyFrag> OfertyFrags { get; set; }

    public virtual DbSet<OfertySzablony> OfertySzablonies { get; set; }

    public virtual DbSet<OfertySzablonyDomyslne> OfertySzablonyDomyslnes { get; set; }

    public virtual DbSet<OpMailKontaEmail> OpMailKontaEmails { get; set; }

    public virtual DbSet<OpMailUzytkownicyKont> OpMailUzytkownicyKonts { get; set; }

    public virtual DbSet<OpSyncStatus> OpSyncStatuses { get; set; }

    public virtual DbSet<OpeInfoBaza> OpeInfoBazas { get; set; }

    public virtual DbSet<OpeInformacje> OpeInformacjes { get; set; }

    public virtual DbSet<OpeListaZadan> OpeListaZadans { get; set; }

    public virtual DbSet<OpeListaZadanGenerator> OpeListaZadanGenerators { get; set; }

    public virtual DbSet<OpeListaZadanSzablony> OpeListaZadanSzablonies { get; set; }

    public virtual DbSet<OpeListaZadanSzablonyBazy> OpeListaZadanSzablonyBazies { get; set; }

    public virtual DbSet<OpeListaZadanSzablonyElem> OpeListaZadanSzablonyElems { get; set; }

    public virtual DbSet<OpeUstawienium> OpeUstawienia { get; set; }

    public virtual DbSet<Operatorzy> Operatorzies { get; set; }

    public virtual DbSet<OrganizacjePp> OrganizacjePps { get; set; }

    public virtual DbSet<PodpisCertyfikat> PodpisCertyfikats { get; set; }

    public virtual DbSet<ProZakazy> ProZakazies { get; set; }

    public virtual DbSet<Rckategorie> Rckategories { get; set; }

    public virtual DbSet<Rcsesje> Rcsesjes { get; set; }

    public virtual DbSet<RejestrOperacji> RejestrOperacjis { get; set; }

    public virtual DbSet<RejestrOperacjiTypyObiektow> RejestrOperacjiTypyObiektows { get; set; }

    public virtual DbSet<RejestrOperacjiTypyOperacji> RejestrOperacjiTypyOperacjis { get; set; }

    public virtual DbSet<SekEtapOperatorzy> SekEtapOperatorzies { get; set; }

    public virtual DbSet<SekEtapy> SekEtapies { get; set; }

    public virtual DbSet<SekSchemEtapy> SekSchemEtapies { get; set; }

    public virtual DbSet<SekSchemEtapyKolejne> SekSchemEtapyKolejnes { get; set; }

    public virtual DbSet<SekSchematy> SekSchematies { get; set; }

    public virtual DbSet<SerwerBackup> SerwerBackups { get; set; }

    public virtual DbSet<Sm> Sms { get; set; }

    public virtual DbSet<SoaLog> SoaLogs { get; set; }

    public virtual DbSet<StanowiskaKomp> StanowiskaKomps { get; set; }

    public virtual DbSet<Statystyki> Statystykis { get; set; }

    public virtual DbSet<Sync> Syncs { get; set; }

    public virtual DbSet<Terminy> Terminies { get; set; }

    public virtual DbSet<Teryt> Teryts { get; set; }

    public virtual DbSet<UrzRachunkiImport> UrzRachunkiImports { get; set; }

    public virtual DbSet<UrzedyImport> UrzedyImports { get; set; }

    public virtual DbSet<UstawieniaCustomizacji> UstawieniaCustomizacjis { get; set; }

    public virtual DbSet<UstawieniaGlobalne> UstawieniaGlobalnes { get; set; }

    public virtual DbSet<UstawieniaWidoku> UstawieniaWidokus { get; set; }

    public virtual DbSet<UstawieniaWidokuSzczegoly> UstawieniaWidokuSzczegolies { get; set; }

    public virtual DbSet<Uwdkonfig> Uwdkonfigs { get; set; }

    public virtual DbSet<WalElemView> WalElemViews { get; set; }

    public virtual DbSet<WalKursy> WalKursies { get; set; }

    public virtual DbSet<WalNagView> WalNagViews { get; set; }

    public virtual DbSet<WalNazwy> WalNazwies { get; set; }

    public virtual DbSet<WalNotowanium> WalNotowania { get; set; }

    public virtual DbSet<WdrAuto> WdrAutos { get; set; }

    public virtual DbSet<WdrDomyslne> WdrDomyslnes { get; set; }

    public virtual DbSet<WdrPodlaczeniaWydrukow> WdrPodlaczeniaWydrukows { get; set; }

    public virtual DbSet<WdrPodlaczeniaZestawow> WdrPodlaczeniaZestawows { get; set; }

    public virtual DbSet<WdrZakazyDoWydrukow> WdrZakazyDoWydrukows { get; set; }

    public virtual DbSet<WdrZakazyDoZestawow> WdrZakazyDoZestawows { get; set; }

    public virtual DbSet<WdrZestawy> WdrZestawies { get; set; }

    public virtual DbSet<WebSubtask> WebSubtasks { get; set; }

    public virtual DbSet<WebSubtasksLog> WebSubtasksLogs { get; set; }

    public virtual DbSet<WebTask> WebTasks { get; set; }

    public virtual DbSet<WebViewSetting> WebViewSettings { get; set; }

    public virtual DbSet<WidokiKolumny> WidokiKolumnies { get; set; }

    public virtual DbSet<WidokiNazwy> WidokiNazwies { get; set; }

    public virtual DbSet<Wydruki> Wydrukis { get; set; }

    public virtual DbSet<ZadaniaWtle> ZadaniaWtles { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<AktualizacjeBaza>(entity =>
        {
            entity.HasKey(e => new { e.AktBHash, e.AktBWersja })
                .HasName("AktB_Primary")
                .HasFillFactor(100);

            entity.ToTable("AktualizacjeBaza", "CDN");

            entity.Property(e => e.AktBHash)
                .HasMaxLength(64)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("AktB_Hash");
            entity.Property(e => e.AktBWersja)
                .HasMaxLength(50)
                .HasDefaultValue("")
                .HasColumnName("AktB_Wersja");
            entity.Property(e => e.AktBKolejnosc).HasColumnName("AktB_Kolejnosc");
            entity.Property(e => e.AktBKonfig).HasColumnName("AktB_Konfig");
            entity.Property(e => e.AktBKrytyczna).HasColumnName("AktB_Krytyczna");
            entity.Property(e => e.AktBOpis)
                .HasMaxLength(1000)
                .HasColumnName("AktB_Opis");
            entity.Property(e => e.AktBPlik)
                .HasColumnType("image")
                .HasColumnName("AktB_Plik");
            entity.Property(e => e.AktBSciezka)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("AktB_Sciezka");
            entity.Property(e => e.AktBTytul)
                .HasMaxLength(200)
                .HasColumnName("AktB_Tytul");
            entity.Property(e => e.AktBZainstalowano).HasColumnName("AktB_Zainstalowano");
        });

        modelBuilder.Entity<AktualizacjeLog>(entity =>
        {
            entity.HasKey(e => e.AktLId)
                .HasName("AktL_Primary")
                .HasFillFactor(100);

            entity.ToTable("AktualizacjeLog", "CDN");

            entity.Property(e => e.AktLId).HasColumnName("AktL_ID");
            entity.Property(e => e.AktLData)
                .HasColumnType("datetime")
                .HasColumnName("AktL_Data");
            entity.Property(e => e.AktLHash)
                .HasMaxLength(64)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("AktL_Hash");
            entity.Property(e => e.AktLLog)
                .IsUnicode(false)
                .HasColumnName("AktL_Log");
            entity.Property(e => e.AktLOpis)
                .HasMaxLength(1000)
                .HasColumnName("AktL_Opis");
            entity.Property(e => e.AktLStatus).HasColumnName("AktL_Status");
            entity.Property(e => e.AktLTytul)
                .HasMaxLength(200)
                .HasColumnName("AktL_Tytul");
            entity.Property(e => e.AktLUzytkownik)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("AktL_Uzytkownik");
        });

        modelBuilder.Entity<AktualizacjeProgram>(entity =>
        {
            entity.HasKey(e => new { e.AktPHash, e.AktPWersja })
                .HasName("AktP_Primary")
                .HasFillFactor(100);

            entity.ToTable("AktualizacjeProgram", "CDN");

            entity.Property(e => e.AktPHash)
                .HasMaxLength(64)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("AktP_Hash");
            entity.Property(e => e.AktPWersja)
                .HasMaxLength(50)
                .HasDefaultValue("")
                .HasColumnName("AktP_Wersja");
            entity.Property(e => e.AktPGkonfig).HasColumnName("AktP_GKonfig");
            entity.Property(e => e.AktPGrupa).HasColumnName("AktP_Grupa");
            entity.Property(e => e.AktPKolejnosc).HasColumnName("AktP_Kolejnosc");
            entity.Property(e => e.AktPKrytyczna).HasColumnName("AktP_Krytyczna");
            entity.Property(e => e.AktPOpis)
                .HasMaxLength(1000)
                .HasColumnName("AktP_Opis");
            entity.Property(e => e.AktPPlik)
                .HasColumnType("image")
                .HasColumnName("AktP_Plik");
            entity.Property(e => e.AktPSciezka)
                .HasMaxLength(1000)
                .IsUnicode(false)
                .HasColumnName("AktP_Sciezka");
            entity.Property(e => e.AktPTytul)
                .HasMaxLength(200)
                .HasColumnName("AktP_Tytul");
            entity.Property(e => e.AktPZainstalowano).HasColumnName("AktP_Zainstalowano");
        });

        modelBuilder.Entity<AktualizacjeStanowiska>(entity =>
        {
            entity.HasKey(e => e.AktSId)
                .HasName("AktS_Primary")
                .HasFillFactor(100);

            entity.ToTable("AktualizacjeStanowiska", "CDN");

            entity.Property(e => e.AktSId).HasColumnName("AktS_ID");
            entity.Property(e => e.AktSData)
                .HasColumnType("datetime")
                .HasColumnName("AktS_Data");
            entity.Property(e => e.AktSHash)
                .HasMaxLength(64)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("AktS_Hash");
            entity.Property(e => e.AktSOperator)
                .HasMaxLength(200)
                .HasColumnName("AktS_Operator");
            entity.Property(e => e.AktSStanowisko)
                .HasMaxLength(200)
                .HasColumnName("AktS_Stanowisko");
        });

        modelBuilder.Entity<Analizy>(entity =>
        {
            entity.HasKey(e => new { e.AnlStandardowa, e.AnlId })
                .HasName("Anl_Primary")
                .HasFillFactor(100);

            entity.ToTable("Analizy", "CDN", tb => tb.HasTrigger("Analizy_Delete_Trigger"));

            entity.HasIndex(e => new { e.AnlStandardowa, e.AnlNazwa }, "AnlWgNazwy").HasFillFactor(100);

            entity.Property(e => e.AnlStandardowa).HasColumnName("Anl_Standardowa");
            entity.Property(e => e.AnlId).HasColumnName("Anl_ID");
            entity.Property(e => e.AnlAutor)
                .HasMaxLength(32)
                .IsUnicode(false)
                .HasColumnName("Anl_Autor");
            entity.Property(e => e.AnlDefinicjaPrezentacji)
                .HasColumnType("text")
                .HasColumnName("Anl_DefinicjaPrezentacji");
            entity.Property(e => e.AnlDefinicjaPrezentacjiWizard)
                .HasColumnType("text")
                .HasColumnName("Anl_DefinicjaPrezentacjiWizard");
            entity.Property(e => e.AnlEdycja)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("Anl_Edycja");
            entity.Property(e => e.AnlHaslo)
                .HasMaxLength(64)
                .HasColumnName("Anl_Haslo");
            entity.Property(e => e.AnlHasloChk)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("Anl_Haslo_chk");
            entity.Property(e => e.AnlLayout)
                .HasColumnType("text")
                .HasColumnName("Anl_Layout");
            entity.Property(e => e.AnlNazwa)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Anl_Nazwa");
            entity.Property(e => e.AnlOpeModId).HasColumnName("Anl_OpeModId");
            entity.Property(e => e.AnlOpeModKod)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("Anl_OpeModKod");
            entity.Property(e => e.AnlOpeModNazwisko)
                .HasMaxLength(50)
                .HasDefaultValue("")
                .HasColumnName("Anl_OpeModNazwisko");
            entity.Property(e => e.AnlOpeZalId).HasColumnName("Anl_OpeZalId");
            entity.Property(e => e.AnlOpeZalKod)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("Anl_OpeZalKod");
            entity.Property(e => e.AnlOpeZalNazwisko)
                .HasMaxLength(50)
                .HasDefaultValue("")
                .HasColumnName("Anl_OpeZalNazwisko");
            entity.Property(e => e.AnlOpis)
                .HasMaxLength(1024)
                .IsUnicode(false)
                .HasColumnName("Anl_Opis");
            entity.Property(e => e.AnlTimeout).HasColumnName("Anl_Timeout");
            entity.Property(e => e.AnlTsMod)
                .HasColumnType("datetime")
                .HasColumnName("Anl_TS_Mod");
            entity.Property(e => e.AnlTsZal)
                .HasColumnType("datetime")
                .HasColumnName("Anl_TS_Zal");
            entity.Property(e => e.AnlTyp).HasColumnName("Anl_Typ");
            entity.Property(e => e.AnlTypObslugiZaznaczen).HasColumnName("Anl_TypObslugiZaznaczen");
            entity.Property(e => e.AnlTypPrezentacji).HasColumnName("Anl_TypPrezentacji");
            entity.Property(e => e.AnlWarunek)
                .HasMaxLength(4096)
                .IsUnicode(false)
                .HasColumnName("Anl_Warunek");
            entity.Property(e => e.AnlWarunekAuto)
                .HasMaxLength(1024)
                .IsUnicode(false)
                .HasColumnName("Anl_WarunekAuto");
            entity.Property(e => e.AnlWersja)
                .HasMaxLength(16)
                .IsUnicode(false)
                .HasColumnName("Anl_Wersja");
            entity.Property(e => e.AnlZapytanie)
                .HasColumnType("text")
                .HasColumnName("Anl_Zapytanie");
        });

        modelBuilder.Entity<AnlPodlaczenium>(entity =>
        {
            entity.HasKey(e => new { e.AnPProcId, e.AnPKontId, e.AnPStandardowa, e.AnPNadAnlId, e.AnPAnlId })
                .HasName("AnP_Primary")
                .HasFillFactor(100);

            entity.ToTable("AnlPodlaczenia", "CDN");

            entity.HasIndex(e => new { e.AnPStandardowa, e.AnPProcId, e.AnPKontId, e.AnPNadAnlId, e.AnPLp, e.AnPAnlId }, "AnPLp")
                .IsUnique()
                .HasFillFactor(100);

            entity.Property(e => e.AnPProcId).HasColumnName("AnP_ProcID");
            entity.Property(e => e.AnPKontId).HasColumnName("AnP_KontID");
            entity.Property(e => e.AnPStandardowa).HasColumnName("AnP_Standardowa");
            entity.Property(e => e.AnPNadAnlId).HasColumnName("AnP_NadAnlID");
            entity.Property(e => e.AnPAnlId).HasColumnName("AnP_AnlID");
            entity.Property(e => e.AnPDomyslna).HasColumnName("AnP_Domyslna");
            entity.Property(e => e.AnPEdycja)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("AnP_Edycja");
            entity.Property(e => e.AnPLp).HasColumnName("AnP_Lp");
            entity.Property(e => e.AnPWarunek)
                .HasMaxLength(4096)
                .IsUnicode(false)
                .HasColumnName("AnP_Warunek");
        });

        modelBuilder.Entity<AnlUlubione>(entity =>
        {
            entity.HasKey(e => new { e.AnUStandardowa, e.AnUId })
                .HasName("AnU_Primary")
                .HasFillFactor(100);

            entity.ToTable("AnlUlubione", "CDN");

            entity.HasIndex(e => new { e.AnUOpeId, e.AnUStandardowa, e.AnUAnlId }, "AnUWgOperatora")
                .IsUnique()
                .HasFillFactor(100);

            entity.Property(e => e.AnUStandardowa).HasColumnName("AnU_Standardowa");
            entity.Property(e => e.AnUId)
                .ValueGeneratedOnAdd()
                .HasColumnName("AnU_ID");
            entity.Property(e => e.AnUAnlId).HasColumnName("AnU_AnlID");
            entity.Property(e => e.AnUOpeId).HasColumnName("AnU_OpeID");
        });

        modelBuilder.Entity<AnlWstawki>(entity =>
        {
            entity.HasKey(e => new { e.AnWStandardowa, e.AnWId })
                .HasName("AnW_Primary")
                .HasFillFactor(100);

            entity.ToTable("AnlWstawki", "CDN");

            entity.HasIndex(e => new { e.AnWStandardowa, e.AnWNazwa }, "AnWWgNazwy")
                .IsUnique()
                .HasFillFactor(100);

            entity.Property(e => e.AnWStandardowa).HasColumnName("AnW_Standardowa");
            entity.Property(e => e.AnWId).HasColumnName("AnW_ID");
            entity.Property(e => e.AnWAutor)
                .HasMaxLength(32)
                .IsUnicode(false)
                .HasColumnName("AnW_Autor");
            entity.Property(e => e.AnWEdycja)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("AnW_Edycja");
            entity.Property(e => e.AnWHaslo)
                .HasMaxLength(64)
                .HasColumnName("AnW_Haslo");
            entity.Property(e => e.AnWHasloChk)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("AnW_Haslo_chk");
            entity.Property(e => e.AnWNazwa)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("AnW_Nazwa");
            entity.Property(e => e.AnWOpeModId).HasColumnName("AnW_OpeModId");
            entity.Property(e => e.AnWOpeModKod)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("AnW_OpeModKod");
            entity.Property(e => e.AnWOpeModNazwisko)
                .HasMaxLength(50)
                .HasDefaultValue("")
                .HasColumnName("AnW_OpeModNazwisko");
            entity.Property(e => e.AnWOpeZalId).HasColumnName("AnW_OpeZalId");
            entity.Property(e => e.AnWOpeZalKod)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("AnW_OpeZalKod");
            entity.Property(e => e.AnWOpeZalNazwisko)
                .HasMaxLength(50)
                .HasDefaultValue("")
                .HasColumnName("AnW_OpeZalNazwisko");
            entity.Property(e => e.AnWTekst)
                .HasColumnType("text")
                .HasColumnName("AnW_Tekst");
            entity.Property(e => e.AnWTsMod)
                .HasColumnType("datetime")
                .HasColumnName("AnW_TS_Mod");
            entity.Property(e => e.AnWTsZal)
                .HasColumnType("datetime")
                .HasColumnName("AnW_TS_Zal");
            entity.Property(e => e.AnWWersja)
                .HasMaxLength(16)
                .IsUnicode(false)
                .HasColumnName("AnW_Wersja");
        });

        modelBuilder.Entity<AnlZakazy>(entity =>
        {
            entity.HasKey(e => e.AnZAnZid)
                .HasName("AnZ_Primary")
                .HasFillFactor(100);

            entity.ToTable("AnlZakazy", "CDN");

            entity.HasIndex(e => new { e.AnZStandardowa, e.AnZAnlId, e.AnZOpeId }, "AnZWgAnalizy")
                .IsUnique()
                .HasFillFactor(100);

            entity.HasIndex(e => new { e.AnZOpeId, e.AnZStandardowa, e.AnZAnlId }, "AnZWgOperatora")
                .IsUnique()
                .HasFillFactor(100);

            entity.Property(e => e.AnZAnZid).HasColumnName("AnZ_AnZID");
            entity.Property(e => e.AnZAnlId).HasColumnName("AnZ_AnlID");
            entity.Property(e => e.AnZOpeId).HasColumnName("AnZ_OpeID");
            entity.Property(e => e.AnZStandardowa).HasColumnName("AnZ_Standardowa");
        });

        modelBuilder.Entity<BackupIbard>(entity =>
        {
            entity.HasKey(e => e.BibBibid)
                .HasName("BIB_Primary")
                .HasFillFactor(100);

            entity.ToTable("BackupIBard", "CDN");

            entity.HasIndex(e => e.BibConnectionString, "UN_BIB_ConnectionString")
                .IsUnique()
                .HasFillFactor(100);

            entity.HasIndex(e => e.BibSerwer, "UN_BIB_Serwer")
                .IsUnique()
                .HasFillFactor(100);

            entity.Property(e => e.BibBibid).HasColumnName("BIB_BIBId");
            entity.Property(e => e.BibConnectionString)
                .HasMaxLength(256)
                .HasColumnName("BIB_ConnectionString");
            entity.Property(e => e.BibSerwer)
                .HasMaxLength(256)
                .HasColumnName("BIB_Serwer");
            entity.Property(e => e.BibToken)
                .HasMaxLength(256)
                .HasColumnName("BIB_Token");
        });

        modelBuilder.Entity<BazModulyOperatora>(entity =>
        {
            entity.HasKey(e => e.BmoBmoId)
                .HasName("BMO_Primary")
                .HasFillFactor(100);

            entity.ToTable("BazModulyOperatora", "CDN");

            entity.Property(e => e.BmoBmoId).HasColumnName("BMO_BmoId");
            entity.Property(e => e.BmoBazId).HasColumnName("BMO_BazID");
            entity.Property(e => e.BmoModulAnl).HasColumnName("BMO_ModulANL");
            entity.Property(e => e.BmoModulAnlp).HasColumnName("BMO_ModulANLP");
            entity.Property(e => e.BmoModulCrm).HasColumnName("BMO_ModulCRM");
            entity.Property(e => e.BmoModulCrmp).HasColumnName("BMO_ModulCRMP");
            entity.Property(e => e.BmoModulFa).HasColumnName("BMO_ModulFA");
            entity.Property(e => e.BmoModulHa).HasColumnName("BMO_ModulHA");
            entity.Property(e => e.BmoModulHap).HasColumnName("BMO_ModulHAP");
            entity.Property(e => e.BmoModulKb).HasColumnName("BMO_ModulKB");
            entity.Property(e => e.BmoModulKbp).HasColumnName("BMO_ModulKBP");
            entity.Property(e => e.BmoModulKh).HasColumnName("BMO_ModulKH");
            entity.Property(e => e.BmoModulKhp).HasColumnName("BMO_ModulKHP");
            entity.Property(e => e.BmoModulKp).HasColumnName("BMO_ModulKP");
            entity.Property(e => e.BmoModulObd).HasColumnName("BMO_ModulOBD");
            entity.Property(e => e.BmoModulPk).HasColumnName("BMO_ModulPK");
            entity.Property(e => e.BmoModulPkp).HasColumnName("BMO_ModulPKP");
            entity.Property(e => e.BmoModulSrw).HasColumnName("BMO_ModulSRW");
            entity.Property(e => e.BmoModulSt).HasColumnName("BMO_ModulST");
            entity.Property(e => e.BmoOpeId).HasColumnName("BMO_OpeID");
            entity.Property(e => e.BmoSerwerKlucza)
                .HasMaxLength(255)
                .HasColumnName("BMO_SerwerKlucza");
            entity.Property(e => e.BmoUstawieniaOgolne)
                .HasComputedColumnSql("(case when (((((((((((((((([BMO_ModulKP]+[BMO_ModulKH])+[BMO_ModulST])+[BMO_ModulFA])+[BMO_ModulHA])+[BMO_ModulPK])+[BMO_ModulPKP])+[BMO_ModulANL])+[BMO_ModulANLP])+[BMO_ModulCRM])+[BMO_ModulCRMP])+[BMO_ModulKHP])+[BMO_ModulSRW])+[BMO_ModulOBD])+[BMO_ModulKB])+[BMO_ModulKBP])+[BMO_ModulHAP])>(0) then (0) else (1) end)", false)
                .HasColumnName("BMO_UstawieniaOgolne");

            entity.HasOne(d => d.BmoBaz).WithMany(p => p.BazModulyOperatoras)
                .HasForeignKey(d => d.BmoBazId)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK_BMOBaza");

            entity.HasOne(d => d.BmoOpe).WithMany(p => p.BazModulyOperatoras)
                .HasForeignKey(d => d.BmoOpeId)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK_BMOOperator");
        });

        modelBuilder.Entity<BazPrzypomnienium>(entity =>
        {
            entity.HasKey(e => e.BprBprId)
                .HasName("BPr_Primary")
                .HasFillFactor(100);

            entity.ToTable("BazPrzypomnienia", "CDN");

            entity.HasIndex(e => new { e.BprBazId, e.BprOpeId }, "BPrBaza")
                .IsUnique()
                .HasFillFactor(100);

            entity.HasIndex(e => new { e.BprOpeId, e.BprBazId }, "BPrOperator")
                .IsUnique()
                .HasFillFactor(100);

            entity.Property(e => e.BprBprId).HasColumnName("BPr_BPrID");
            entity.Property(e => e.BprBazId).HasColumnName("BPr_BazID");
            entity.Property(e => e.BprOpeId).HasColumnName("BPr_OpeID");

            entity.HasOne(d => d.BprBaz).WithMany(p => p.BazPrzypomnienia)
                .HasForeignKey(d => d.BprBazId)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK_BPrBaza");

            entity.HasOne(d => d.BprOpe).WithMany(p => p.BazPrzypomnienia)
                .HasForeignKey(d => d.BprOpeId)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK_BPrOperator");
        });

        modelBuilder.Entity<BazZakazy>(entity =>
        {
            entity.HasKey(e => e.BzaBzaId)
                .HasName("BZa_Primary")
                .HasFillFactor(100);

            entity.ToTable("BazZakazy", "CDN", tb =>
                {
                    tb.HasTrigger("BazZakazy_Delete_Trigger");
                    tb.HasTrigger("BazZakazy_InsertUpdateHandler");
                    tb.HasTrigger("BazZakazy_InsertUpdate_Trigger");
                });

            entity.HasIndex(e => new { e.BzaBazId, e.BzaOpeId }, "BZaBaza")
                .IsUnique()
                .HasFillFactor(100);

            entity.HasIndex(e => new { e.BzaOpeId, e.BzaBazId }, "BZaOperator")
                .IsUnique()
                .HasFillFactor(100);

            entity.Property(e => e.BzaBzaId).HasColumnName("BZa_BZaID");
            entity.Property(e => e.BzaBazId).HasColumnName("BZa_BazID");
            entity.Property(e => e.BzaOpeId).HasColumnName("BZa_OpeID");

            entity.HasOne(d => d.BzaOpe).WithMany(p => p.BazZakazies)
                .HasForeignKey(d => d.BzaOpeId)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK_BZaOperator");
        });

        modelBuilder.Entity<Bazy>(entity =>
        {
            entity.HasKey(e => e.BazBazId)
                .HasName("Baz_Primary")
                .HasFillFactor(100);

            entity.ToTable("Bazy", "CDN", tb =>
                {
                    tb.HasTrigger("Bazy_AfterInsert_Trigger");
                    tb.HasTrigger("Bazy_DeleteHandler");
                    tb.HasTrigger("Bazy_Delete_Trigger");
                    tb.HasTrigger("Bazy_Insert_Trigger");
                    tb.HasTrigger("Bazy_Update_Trigger");
                });

            entity.HasIndex(e => new { e.BazNieaktywna, e.BazNazwa }, "BazNazwa")
                .IsUnique()
                .HasFillFactor(100);

            entity.Property(e => e.BazBazId).HasColumnName("Baz_BazID");
            entity.Property(e => e.BazAutomatycznyBackup).HasColumnName("Baz_AutomatycznyBackup");
            entity.Property(e => e.BazCzasArchiwacji).HasColumnName("Baz_CzasArchiwacji");
            entity.Property(e => e.BazDostep)
                .HasMaxLength(254)
                .IsUnicode(false)
                .HasColumnName("Baz_Dostep");
            entity.Property(e => e.BazDostepnaWbip).HasColumnName("Baz_DostepnaWBIP");
            entity.Property(e => e.BazDostepnaWpm).HasColumnName("Baz_DostepnaWPM");
            entity.Property(e => e.BazDostepnaWppk)
                .HasDefaultValue((byte)1)
                .HasColumnName("Baz_DostepnaWPPK");
            entity.Property(e => e.BazGuid)
                .HasDefaultValueSql("(newid())")
                .HasColumnName("Baz_GUID");
            entity.Property(e => e.BazNazwa)
                .HasMaxLength(120)
                .IsUnicode(false)
                .HasColumnName("Baz_Nazwa");
            entity.Property(e => e.BazNazwaArchiwum)
                .HasMaxLength(511)
                .IsUnicode(false)
                .HasColumnName("Baz_NazwaArchiwum");
            entity.Property(e => e.BazNazwaBazy)
                .HasMaxLength(254)
                .IsUnicode(false)
                .HasComputedColumnSql("(substring([Baz_Dostep],charindex(':',[Baz_Dostep])+(1),(charindex(',',[Baz_Dostep],charindex(':',[Baz_Dostep]))-charindex(':',[Baz_Dostep]))-(1)))", false)
                .HasColumnName("Baz_NazwaBazy");
            entity.Property(e => e.BazNazwaSerwera)
                .HasMaxLength(254)
                .IsUnicode(false)
                .HasComputedColumnSql("(substring([Baz_Dostep],charindex(',',[Baz_Dostep])+(1),(charindex(',',[Baz_Dostep],charindex(',',[Baz_Dostep])+(1))-charindex(',',[Baz_Dostep]))-(1)))", false)
                .HasColumnName("Baz_NazwaSerwera");
            entity.Property(e => e.BazNieaktywna).HasColumnName("Baz_Nieaktywna");
            entity.Property(e => e.BazNip)
                .HasMaxLength(24)
                .IsUnicode(false)
                .HasColumnName("Baz_NIP");
            entity.Property(e => e.BazOkresArchiwacji).HasColumnName("Baz_OkresArchiwacji");
            entity.Property(e => e.BazOpis)
                .HasMaxLength(254)
                .HasColumnName("Baz_Opis");
            entity.Property(e => e.BazRozmiarBazy)
                .HasColumnType("decimal(8, 2)")
                .HasColumnName("Baz_RozmiarBazy");
            entity.Property(e => e.BazRozmiarDanychBin)
                .HasColumnType("decimal(8, 2)")
                .HasColumnName("Baz_RozmiarDanychBin");
            entity.Property(e => e.BazTsArch)
                .HasColumnType("datetime")
                .HasColumnName("Baz_TS_Arch");
        });

        modelBuilder.Entity<BnkNazwyImport>(entity =>
        {
            entity.HasKey(e => e.BnaIBnaId)
                .HasName("BNaI_Primary")
                .HasFillFactor(100);

            entity.ToTable("BnkNazwyImport", "CDN");

            entity.HasIndex(e => e.BnaINumer, "BNaI_IX_Numer").HasFillFactor(100);

            entity.Property(e => e.BnaIBnaId).HasColumnName("BNaI_BNaId");
            entity.Property(e => e.BnaIAkronim)
                .HasMaxLength(20)
                .HasColumnName("BNaI_Akronim");
            entity.Property(e => e.BnaICentrala)
                .HasMaxLength(3)
                .HasColumnName("BNaI_Centrala");
            entity.Property(e => e.BnaIKodPocztowy)
                .HasMaxLength(10)
                .HasColumnName("BNaI_KodPocztowy");
            entity.Property(e => e.BnaIMiasto)
                .HasMaxLength(40)
                .HasColumnName("BNaI_Miasto");
            entity.Property(e => e.BnaINazwa1)
                .HasMaxLength(50)
                .HasColumnName("BNaI_Nazwa1");
            entity.Property(e => e.BnaINazwa2)
                .HasMaxLength(50)
                .HasColumnName("BNaI_Nazwa2");
            entity.Property(e => e.BnaINrDomu)
                .HasMaxLength(10)
                .HasColumnName("BNaI_NrDomu");
            entity.Property(e => e.BnaINrLokalu)
                .HasMaxLength(10)
                .HasColumnName("BNaI_NrLokalu");
            entity.Property(e => e.BnaINumer)
                .HasMaxLength(10)
                .HasColumnName("BNaI_Numer");
            entity.Property(e => e.BnaISwift)
                .HasMaxLength(20)
                .HasColumnName("BNaI_Swift");
            entity.Property(e => e.BnaIUlica)
                .HasMaxLength(40)
                .HasColumnName("BNaI_Ulica");
        });

        modelBuilder.Entity<CfgDzialy>(entity =>
        {
            entity.HasKey(e => e.CdzCdzId)
                .HasName("CDz_Primary")
                .HasFillFactor(100);

            entity.ToTable("CfgDzialy", "CDN");

            entity.HasIndex(e => e.CdzNumer, "GDzNumer")
                .IsUnique()
                .HasFillFactor(100);

            entity.Property(e => e.CdzCdzId).HasColumnName("CDz_CDzID");
            entity.Property(e => e.CdzFlaga).HasColumnName("CDz_Flaga");
            entity.Property(e => e.CdzNazwa)
                .HasMaxLength(50)
                .HasColumnName("CDz_Nazwa");
            entity.Property(e => e.CdzNumer).HasColumnName("CDz_Numer");
            entity.Property(e => e.CdzStawka)
                .HasColumnType("decimal(7, 2)")
                .HasColumnName("CDz_Stawka");
            entity.Property(e => e.CdzZrodlowa)
                .HasColumnType("decimal(7, 2)")
                .HasColumnName("CDz_Zrodlowa");
        });

        modelBuilder.Entity<CfgKlucze>(entity =>
        {
            entity.HasKey(e => e.CfkCfkId)
                .HasName("CFK_Primary")
                .HasFillFactor(100);

            entity.ToTable("CfgKlucze", "CDN", tb => tb.HasTrigger("CfgKlucze_Update_Trigger"));

            entity.HasIndex(e => new { e.CfkParentId, e.CfkNazwa, e.CfkOkresOd }, "CFKParent")
                .IsUnique()
                .HasFillFactor(100);

            entity.Property(e => e.CfkCfkId).HasColumnName("CFK_CfkId");
            entity.Property(e => e.CfkNazwa)
                .HasMaxLength(32)
                .IsUnicode(false)
                .HasColumnName("CFK_Nazwa");
            entity.Property(e => e.CfkOkresDo)
                .HasColumnType("datetime")
                .HasColumnName("CFK_OkresDo");
            entity.Property(e => e.CfkOkresOd)
                .HasColumnType("datetime")
                .HasColumnName("CFK_OkresOd");
            entity.Property(e => e.CfkOpeModId).HasColumnName("CFK_OpeModId");
            entity.Property(e => e.CfkOpeModKod)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("CFK_OpeModKod");
            entity.Property(e => e.CfkOpeModNazwisko)
                .HasMaxLength(50)
                .HasDefaultValue("")
                .HasColumnName("CFK_OpeModNazwisko");
            entity.Property(e => e.CfkOpeZalId).HasColumnName("CFK_OpeZalId");
            entity.Property(e => e.CfkOpeZalKod)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("CFK_OpeZalKod");
            entity.Property(e => e.CfkOpeZalNazwisko)
                .HasMaxLength(50)
                .HasDefaultValue("")
                .HasColumnName("CFK_OpeZalNazwisko");
            entity.Property(e => e.CfkParentId).HasColumnName("CFK_ParentId");
            entity.Property(e => e.CfkStaModId).HasColumnName("CFK_StaModId");
            entity.Property(e => e.CfkStaZalId).HasColumnName("CFK_StaZalId");
            entity.Property(e => e.CfkTsMod)
                .HasColumnType("datetime")
                .HasColumnName("CFK_TS_Mod");
            entity.Property(e => e.CfkTsZal)
                .HasColumnType("datetime")
                .HasColumnName("CFK_TS_Zal");

            entity.HasOne(d => d.CfkParent).WithMany(p => p.InverseCfkParent)
                .HasForeignKey(d => d.CfkParentId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_CFK_Parent");
        });

        modelBuilder.Entity<CfgWartosci>(entity =>
        {
            entity.HasKey(e => e.CfwCfwId)
                .HasName("CFW_Primary")
                .HasFillFactor(100);

            entity.ToTable("CfgWartosci", "CDN");

            entity.HasIndex(e => new { e.CfwCfkId, e.CfwNazwa }, "CFWCfkLink")
                .IsUnique()
                .HasFillFactor(100);

            entity.Property(e => e.CfwCfwId).HasColumnName("CFW_CfwId");
            entity.Property(e => e.CfwCfkId).HasColumnName("CFW_CfkId");
            entity.Property(e => e.CfwNazwa)
                .HasMaxLength(32)
                .IsUnicode(false)
                .HasColumnName("CFW_Nazwa");
            entity.Property(e => e.CfwOpeModId).HasColumnName("CFW_OpeModId");
            entity.Property(e => e.CfwOpeModKod)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("CFW_OpeModKod");
            entity.Property(e => e.CfwOpeModNazwisko)
                .HasMaxLength(50)
                .HasDefaultValue("")
                .HasColumnName("CFW_OpeModNazwisko");
            entity.Property(e => e.CfwOpeZalId).HasColumnName("CFW_OpeZalId");
            entity.Property(e => e.CfwOpeZalKod)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("CFW_OpeZalKod");
            entity.Property(e => e.CfwOpeZalNazwisko)
                .HasMaxLength(50)
                .HasDefaultValue("")
                .HasColumnName("CFW_OpeZalNazwisko");
            entity.Property(e => e.CfwStaModId).HasColumnName("CFW_StaModId");
            entity.Property(e => e.CfwStaZalId).HasColumnName("CFW_StaZalId");
            entity.Property(e => e.CfwTsMod)
                .HasColumnType("datetime")
                .HasColumnName("CFW_TS_Mod");
            entity.Property(e => e.CfwTsZal)
                .HasColumnType("datetime")
                .HasColumnName("CFW_TS_Zal");
            entity.Property(e => e.CfwTyp).HasColumnName("CFW_Typ");
            entity.Property(e => e.CfwWartosc)
                .HasMaxLength(4000)
                .HasColumnName("CFW_Wartosc");

            entity.HasOne(d => d.CfwCfk).WithMany(p => p.CfgWartoscis)
                .HasForeignKey(d => d.CfwCfkId)
                .HasConstraintName("FK_CFWCfkLink");
        });

        modelBuilder.Entity<CrmAutomatyWind>(entity =>
        {
            entity.HasKey(e => e.CrAkCrakId)
                .HasName("CrAK_Primary")
                .HasFillFactor(100);

            entity.ToTable("CrmAutomatyWind", "CDN");

            entity.HasIndex(e => new { e.CrAkBazId, e.CrAkTypAutomatu }, "OneAutomatForDatabase")
                .IsUnique()
                .HasFillFactor(100);

            entity.Property(e => e.CrAkCrakId).HasColumnName("CrAK_CrakID");
            entity.Property(e => e.CrAkAktywny).HasColumnName("CrAK_Aktywny");
            entity.Property(e => e.CrAkBazId).HasColumnName("CrAK_BazId");
            entity.Property(e => e.CrAkBlokadaSprGodzinaAkcji)
                .HasColumnType("datetime")
                .HasColumnName("CrAK_BlokadaSprGodzinaAkcji");
            entity.Property(e => e.CrAkBlokadaSprKwotaMin)
                .HasColumnType("decimal(15, 2)")
                .HasColumnName("CrAK_BlokadaSprKwotaMin");
            entity.Property(e => e.CrAkBlokadaSprzedazy).HasColumnName("CrAK_BlokadaSprzedazy");
            entity.Property(e => e.CrAkCrkOpeMail).HasColumnName("CrAK_CrkOpeMail");
            entity.Property(e => e.CrAkCrkOpeMailSzablonId).HasColumnName("CrAK_CrkOpeMailSzablonId");
            entity.Property(e => e.CrAkCrkOpePobierajUstawieniaDomyslne).HasColumnName("CrAK_CrkOpePobierajUstawieniaDomyslne");
            entity.Property(e => e.CrAkCrkOpePrzypomnieniaMailCzasPrzypomnienia).HasColumnName("CrAK_CrkOpePrzypomnieniaMailCzasPrzypomnienia");
            entity.Property(e => e.CrAkCrkOpePrzypomnieniaSmsCzasPrzypomnienia).HasColumnName("CrAK_CrkOpePrzypomnieniaSmsCzasPrzypomnienia");
            entity.Property(e => e.CrAkCrkOpeSms).HasColumnName("CrAK_CrkOpeSms");
            entity.Property(e => e.CrAkCrkOpeSmsSzablonId).HasColumnName("CrAK_CrkOpeSmsSzablonId");
            entity.Property(e => e.CrAkCrkPobierajUstawieniaDomyslne).HasColumnName("CrAK_CrkPobierajUstawieniaDomyslne");
            entity.Property(e => e.CrAkCrkPrzypomnieniaGodzinaAkcji)
                .HasColumnType("datetime")
                .HasColumnName("CrAK_CrkPrzypomnieniaGodzinaAkcji");
            entity.Property(e => e.CrAkCrkPrzypomnieniaMailCzasPrzypomnienia).HasColumnName("CrAK_CrkPrzypomnieniaMailCzasPrzypomnienia");
            entity.Property(e => e.CrAkCrkPrzypomnieniaSmsCzasPrzypomnienia).HasColumnName("CrAK_CrkPrzypomnieniaSmsCzasPrzypomnienia");
            entity.Property(e => e.CrAkCrm).HasColumnName("CrAK_Crm");
            entity.Property(e => e.CrAkCrmGodzinaAkcji)
                .HasColumnType("datetime")
                .HasColumnName("CrAK_CrmGodzinaAkcji");
            entity.Property(e => e.CrAkCrmOpiekunId).HasColumnName("CrAK_CrmOpiekunId");
            entity.Property(e => e.CrAkCrmOpiekunMode).HasColumnName("CrAK_CrmOpiekunMode");
            entity.Property(e => e.CrAkCrmOpiekunTyp).HasColumnName("CrAK_CrmOpiekunTyp");
            entity.Property(e => e.CrAkCrmZadanieCzasPrzypomnienia).HasColumnName("CrAK_CrmZadanieCzasPrzypomnienia");
            entity.Property(e => e.CrAkCrmZadaniePrzypomnienie).HasColumnName("CrAK_CrmZadaniePrzypomnienie");
            entity.Property(e => e.CrAkCrmZadanieTerminCo).HasColumnName("CrAK_CrmZadanieTerminCo");
            entity.Property(e => e.CrAkCrmzadanieGodzinaDo)
                .HasColumnType("datetime")
                .HasColumnName("CrAK_CRMZadanieGodzinaDo");
            entity.Property(e => e.CrAkCrmzadanieGodzinaOd)
                .HasColumnType("datetime")
                .HasColumnName("CrAK_CRMZadanieGodzinaOd");
            entity.Property(e => e.CrAkDniPrzedTerminem).HasColumnName("CrAK_DniPrzedTerminem");
            entity.Property(e => e.CrAkFaCyklGenDok).HasColumnName("CrAK_FaCyklGenDok");
            entity.Property(e => e.CrAkFaCyklGenDokGodzinaAkcji)
                .HasDefaultValueSql("((0))")
                .HasColumnType("datetime")
                .HasColumnName("CrAK_FaCyklGenDokGodzinaAkcji");
            entity.Property(e => e.CrAkIwdEksport).HasColumnName("CrAK_IwdEksport");
            entity.Property(e => e.CrAkIwdEksportCo).HasColumnName("CrAK_IwdEksport_Co");
            entity.Property(e => e.CrAkIwdEksportDo)
                .HasColumnType("datetime")
                .HasColumnName("CrAK_IwdEksport_Do");
            entity.Property(e => e.CrAkIwdEksportKiedy).HasColumnName("CrAK_IwdEksport_Kiedy");
            entity.Property(e => e.CrAkIwdEksportOd)
                .HasColumnType("datetime")
                .HasColumnName("CrAK_IwdEksport_Od");
            entity.Property(e => e.CrAkIwdEksportRodzajeDok)
                .HasMaxLength(1024)
                .IsUnicode(false)
                .HasColumnName("CrAK_IwdEksport_RodzajeDok");
            entity.Property(e => e.CrAkIwdEksportZaOkres).HasColumnName("CrAK_IwdEksport_ZaOkres");
            entity.Property(e => e.CrAkIwdImport).HasColumnName("CrAK_IwdImport");
            entity.Property(e => e.CrAkIwdImportCo).HasColumnName("CrAK_IwdImport_Co");
            entity.Property(e => e.CrAkIwdImportDo)
                .HasColumnType("datetime")
                .HasColumnName("CrAK_IwdImport_Do");
            entity.Property(e => e.CrAkIwdImportOd)
                .HasColumnType("datetime")
                .HasColumnName("CrAK_IwdImport_Od");
            entity.Property(e => e.CrAkIwdImportUsuwanieRaportowCo).HasColumnName("CrAK_IwdImport_UsuwanieRaportow_Co");
            entity.Property(e => e.CrAkKwotaMin)
                .HasColumnType("decimal(15, 2)")
                .HasColumnName("CrAK_KwotaMin");
            entity.Property(e => e.CrAkMail).HasColumnName("CrAK_Mail");
            entity.Property(e => e.CrAkMailGodzinaAkcji)
                .HasColumnType("datetime")
                .HasColumnName("CrAK_MailGodzinaAkcji");
            entity.Property(e => e.CrAkMailKontoId).HasColumnName("CrAK_MailKontoId");
            entity.Property(e => e.CrAkMailSzablonId).HasColumnName("CrAK_MailSzablonId");
            entity.Property(e => e.CrAkMailWysylka).HasColumnName("CrAK_MailWysylka");
            entity.Property(e => e.CrAkOpeId).HasColumnName("CrAK_OpeId");
            entity.Property(e => e.CrAkOpeModId).HasColumnName("CrAK_OpeModId");
            entity.Property(e => e.CrAkOpeModKod)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("CrAK_OpeModKod");
            entity.Property(e => e.CrAkOpeModNazwisko)
                .HasMaxLength(50)
                .HasDefaultValue("")
                .HasColumnName("CrAK_OpeModNazwisko");
            entity.Property(e => e.CrAkOpeParams)
                .HasMaxLength(512)
                .HasColumnName("CrAK_OpeParams");
            entity.Property(e => e.CrAkOpeZalId).HasColumnName("CrAK_OpeZalId");
            entity.Property(e => e.CrAkOpeZalKod)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("CrAK_OpeZalKod");
            entity.Property(e => e.CrAkOpeZalNazwisko)
                .HasMaxLength(50)
                .HasDefaultValue("")
                .HasColumnName("CrAK_OpeZalNazwisko");
            entity.Property(e => e.CrAkPonZapGodzinaAkcji)
                .HasColumnType("datetime")
                .HasColumnName("CrAK_PonZapGodzinaAkcji");
            entity.Property(e => e.CrAkPonZapOdsetkiFormaPlatnosciId).HasColumnName("CrAK_PonZapOdsetkiFormaPlatnosciId");
            entity.Property(e => e.CrAkPonZapOdsetkiGenerujPlatnosc).HasColumnName("CrAK_PonZapOdsetkiGenerujPlatnosc");
            entity.Property(e => e.CrAkPonZapOdsetkiPodatkoweProg)
                .HasColumnType("decimal(15, 2)")
                .HasColumnName("CrAK_PonZapOdsetkiPodatkoweProg");
            entity.Property(e => e.CrAkPonZapOdsetkiStopa)
                .HasColumnType("decimal(7, 2)")
                .HasColumnName("CrAK_PonZapOdsetkiStopa");
            entity.Property(e => e.CrAkPonZapOdsetkiTerminPlatDni).HasColumnName("CrAK_PonZapOdsetkiTerminPlatDni");
            entity.Property(e => e.CrAkPonZapOdsetkiTyp).HasColumnName("CrAK_PonZapOdsetkiTyp");
            entity.Property(e => e.CrAkPonaglenieZaplaty).HasColumnName("CrAK_PonaglenieZaplaty");
            entity.Property(e => e.CrAkSms).HasColumnName("CrAK_Sms");
            entity.Property(e => e.CrAkSmsGodzinaAkcji)
                .HasDefaultValueSql("((0))")
                .HasColumnType("datetime")
                .HasColumnName("CrAK_SmsGodzinaAkcji");
            entity.Property(e => e.CrAkSmsSzablonId).HasColumnName("CrAK_SmsSzablonId");
            entity.Property(e => e.CrAkSmsWysylka).HasColumnName("CrAK_SmsWysylka");
            entity.Property(e => e.CrAkStaModId).HasColumnName("CrAK_StaModId");
            entity.Property(e => e.CrAkStaZalId).HasColumnName("CrAK_StaZalId");
            entity.Property(e => e.CrAkTerminPlatnosciTyp).HasColumnName("CrAK_TerminPlatnosciTyp");
            entity.Property(e => e.CrAkTsMod)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("CrAK_TS_Mod");
            entity.Property(e => e.CrAkTsZal)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("CrAK_TS_Zal");
            entity.Property(e => e.CrAkTypAutomatu).HasColumnName("CrAK_TypAutomatu");
            entity.Property(e => e.CrAkWydrukFaId).HasColumnName("CrAK_WydrukFaId");
            entity.Property(e => e.CrAkWydrukFaTyp).HasColumnName("CrAK_WydrukFaTyp");
            entity.Property(e => e.CrAkWydrukFaWalId).HasColumnName("CrAK_WydrukFaWalId");
            entity.Property(e => e.CrAkWydrukFaWalTyp).HasColumnName("CrAK_WydrukFaWalTyp");
            entity.Property(e => e.CrAkZleceniaCyklGenDokGodzinaAkcji)
                .HasColumnType("datetime")
                .HasColumnName("CrAK_ZleceniaCyklGenDokGodzinaAkcji");

            entity.HasOne(d => d.CrAkBaz).WithMany(p => p.CrmAutomatyWinds)
                .HasForeignKey(d => d.CrAkBazId)
                .HasConstraintName("FK_CrAKSyncBaza");
        });

        modelBuilder.Entity<DaneBinarne>(entity =>
        {
            entity.HasKey(e => e.DabDabid)
                .HasName("DAB_Primary")
                .HasFillFactor(100);

            entity.ToTable("DaneBinarne", "CDN");

            entity.HasIndex(e => e.DabTwAid, "AtBTwrAtrybut").HasFillFactor(100);

            entity.HasIndex(e => new { e.DabNazwa, e.DabDabid }, "DABKeyNazwa").HasFillFactor(100);

            entity.Property(e => e.DabDabid).HasColumnName("DAB_DABID");
            entity.Property(e => e.DabFlaga).HasColumnName("DAB_Flaga");
            entity.Property(e => e.DabGuid).HasColumnName("DAB_GUID");
            entity.Property(e => e.DabIbard24Id).HasColumnName("DAB_IBard24Id");
            entity.Property(e => e.DabIbard24LinkPrywatny)
                .HasMaxLength(512)
                .HasColumnName("DAB_IBard24LinkPrywatny");
            entity.Property(e => e.DabMagazynDanych)
                .HasDefaultValue((byte)1)
                .HasColumnName("DAB_MagazynDanych");
            entity.Property(e => e.DabMagazynDanychId)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("DAB_MagazynDanychId");
            entity.Property(e => e.DabNazwa)
                .HasMaxLength(128)
                .HasColumnName("DAB_Nazwa");
            entity.Property(e => e.DabNazwaPliku)
                .HasMaxLength(254)
                .HasColumnName("DAB_NazwaPliku");
            entity.Property(e => e.DabOpeModId).HasColumnName("DAB_OpeModID");
            entity.Property(e => e.DabOpeModKod)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("DAB_OpeModKod");
            entity.Property(e => e.DabOpeModNazwisko)
                .HasMaxLength(50)
                .HasDefaultValue("")
                .HasColumnName("DAB_OpeModNazwisko");
            entity.Property(e => e.DabOpeZalId).HasColumnName("DAB_OpeZalID");
            entity.Property(e => e.DabOpeZalKod)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("DAB_OpeZalKod");
            entity.Property(e => e.DabOpeZalNazwisko)
                .HasMaxLength(50)
                .HasDefaultValue("")
                .HasColumnName("DAB_OpeZalNazwisko");
            entity.Property(e => e.DabRozmiar).HasColumnName("DAB_Rozmiar");
            entity.Property(e => e.DabRozmiarWartosci)
                .HasComputedColumnSql("(datalength([DAB_WARTOSC]))", false)
                .HasColumnName("DAB_RozmiarWartosci");
            entity.Property(e => e.DabRozszerzenie)
                .HasMaxLength(4)
                .HasColumnName("DAB_Rozszerzenie");
            entity.Property(e => e.DabSciezka)
                .HasMaxLength(255)
                .HasDefaultValue("")
                .HasColumnName("DAB_Sciezka");
            entity.Property(e => e.DabStaModId).HasColumnName("DAB_StaModId");
            entity.Property(e => e.DabStaZalId).HasColumnName("DAB_StaZalId");
            entity.Property(e => e.DabTsMod)
                .HasColumnType("datetime")
                .HasColumnName("DAB_TS_Mod");
            entity.Property(e => e.DabTsZal)
                .HasColumnType("datetime")
                .HasColumnName("DAB_TS_Zal");
            entity.Property(e => e.DabTwAid).HasColumnName("DAB_TwAID");
            entity.Property(e => e.DabTyp).HasColumnName("DAB_Typ");
            entity.Property(e => e.DabWartosc)
                .HasColumnType("image")
                .HasColumnName("DAB_Wartosc");
            entity.Property(e => e.DabWersja)
                .HasMaxLength(20)
                .HasColumnName("DAB_Wersja");
        });

        modelBuilder.Entity<DeklaracjeDefinicje>(entity =>
        {
            entity.HasKey(e => new { e.DdeResName, e.DdeResType })
                .HasName("DDE_Primary")
                .HasFillFactor(100);

            entity.ToTable("DeklaracjeDefinicje", "CDN");

            entity.Property(e => e.DdeResName)
                .HasMaxLength(20)
                .HasColumnName("DDE_ResName");
            entity.Property(e => e.DdeResType)
                .HasMaxLength(10)
                .HasColumnName("DDE_ResType");
            entity.Property(e => e.DdeRozmiar).HasColumnName("DDE_Rozmiar");
            entity.Property(e => e.DdeSkrot)
                .HasMaxLength(64)
                .HasColumnName("DDE_Skrot");
            entity.Property(e => e.DdeWartosc).HasColumnName("DDE_Wartosc");
        });

        modelBuilder.Entity<DetalFunkcjePrac>(entity =>
        {
            entity.HasKey(e => e.DfpDfpid)
                .HasName("DFP_Primary")
                .HasFillFactor(100);

            entity.ToTable("DetalFunkcjePrac", "CDN", tb =>
                {
                    tb.HasTrigger("DetalFunkcjePrac_Delete_Trigger");
                    tb.HasTrigger("DetalFunkcjePrac_InsertUpdateDelete_Trigger");
                });

            entity.HasIndex(e => e.DfpKod, "DelalFPKod").HasFillFactor(100);

            entity.Property(e => e.DfpDfpid).HasColumnName("DFP_DFPID");
            entity.Property(e => e.DfpEdycjaParagonow).HasColumnName("DFP_EdycjaParagonow");
            entity.Property(e => e.DfpFakturaDoParagonu).HasColumnName("DFP_FakturaDoParagonu");
            entity.Property(e => e.DfpKod)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("DFP_Kod");
            entity.Property(e => e.DfpKonfiguracjaInterfejsu).HasColumnName("DFP_KonfiguracjaInterfejsu");
            entity.Property(e => e.DfpKonfiguracjaProgramu).HasColumnName("DFP_KonfiguracjaProgramu");
            entity.Property(e => e.DfpNieokreslonyPlatOdroczona).HasColumnName("DFP_NieokreslonyPlatOdroczona");
            entity.Property(e => e.DfpOtwarcieZmiany).HasColumnName("DFP_OtwarcieZmiany");
            entity.Property(e => e.DfpPlatnoscInnymiFormami).HasColumnName("DFP_PlatnoscInnymiFormami");
            entity.Property(e => e.DfpPodgladDokWlasnych).HasColumnName("DFP_PodgladDokWlasnych");
            entity.Property(e => e.DfpPodgladDokWszystkich).HasColumnName("DFP_PodgladDokWszystkich");
            entity.Property(e => e.DfpPodgladStanuKasy).HasColumnName("DFP_PodgladStanuKasy");
            entity.Property(e => e.DfpPrawoDoRabatowDokument).HasColumnName("DFP_PrawoDoRabatowDokument");
            entity.Property(e => e.DfpPrawoDoRabatowPozycja).HasColumnName("DFP_PrawoDoRabatowPozycja");
            entity.Property(e => e.DfpPrzekazanieParagonow).HasColumnName("DFP_PrzekazanieParagonow");
            entity.Property(e => e.DfpRaportFiskalny).HasColumnName("DFP_RaportFiskalny");
            entity.Property(e => e.DfpRaportOkresowy).HasColumnName("DFP_RaportOkresowy");
            entity.Property(e => e.DfpReczneOtwarcieSzuflady).HasColumnName("DFP_ReczneOtwarcieSzuflady");
            entity.Property(e => e.DfpStanWszystkieMagazyny).HasColumnName("DFP_StanWszystkieMagazyny");
            entity.Property(e => e.DfpStornoCalegoParagonu).HasColumnName("DFP_StornoCalegoParagonu");
            entity.Property(e => e.DfpStornoOstatniejPozycji).HasColumnName("DFP_StornoOstatniejPozycji");
            entity.Property(e => e.DfpWplataDoKasy).HasColumnName("DFP_WplataDoKasy");
            entity.Property(e => e.DfpWyplataZkasy).HasColumnName("DFP_WyplataZKasy");
            entity.Property(e => e.DfpZamkniecieZmiany).HasColumnName("DFP_ZamkniecieZmiany");
            entity.Property(e => e.DfpZmianaCenySprzedazy).HasColumnName("DFP_ZmianaCenySprzedazy");
            entity.Property(e => e.DfpZmianaJm).HasColumnName("DFP_ZmianaJM");
            entity.Property(e => e.DfpZwrotTowaru).HasColumnName("DFP_ZwrotTowaru");
        });

        modelBuilder.Entity<DietyRyczalty>(entity =>
        {
            entity.HasKey(e => e.DiRDiRid)
                .HasName("DiR_Primary")
                .HasFillFactor(100);

            entity.ToTable("DietyRyczalty", "CDN");

            entity.Property(e => e.DiRDiRid).HasColumnName("DiR_DiRID");
            entity.Property(e => e.DiRData)
                .HasColumnType("datetime")
                .HasColumnName("DiR_Data");
            entity.Property(e => e.DiRDietaI)
                .HasDefaultValueSql("((0.00))")
                .HasColumnType("decimal(15, 2)")
                .HasColumnName("DiR_DietaI");
            entity.Property(e => e.DiRDietaU)
                .HasDefaultValueSql("((0.00))")
                .HasColumnType("decimal(15, 2)")
                .HasColumnName("DiR_DietaU");
            entity.Property(e => e.DiRKodKraju)
                .HasMaxLength(3)
                .HasDefaultValue("PL")
                .HasColumnName("DiR_KodKraju");
            entity.Property(e => e.DiRKraj)
                .HasMaxLength(100)
                .HasDefaultValue("Polska")
                .HasColumnName("DiR_Kraj");
            entity.Property(e => e.DiRRyczaltI)
                .HasDefaultValueSql("((0.00))")
                .HasColumnType("decimal(15, 2)")
                .HasColumnName("DiR_RyczaltI");
            entity.Property(e => e.DiRRyczaltU)
                .HasDefaultValueSql("((0.00))")
                .HasColumnType("decimal(15, 2)")
                .HasColumnName("DiR_RyczaltU");
            entity.Property(e => e.DiRTyp)
                .HasDefaultValue((byte)1)
                .HasColumnName("DiR_Typ");
            entity.Property(e => e.DiRWaluta)
                .HasMaxLength(3)
                .HasDefaultValue("")
                .HasColumnName("DiR_Waluta");
        });

        modelBuilder.Entity<DokDefinicje>(entity =>
        {
            entity.HasKey(e => e.DdfDdfId)
                .HasName("DDf_Primary")
                .HasFillFactor(100);

            entity.ToTable("DokDefinicje", "CDN", tb =>
                {
                    tb.HasTrigger("DokDefinicje_Delete_Trigger");
                    tb.HasTrigger("DokDefinicje_InsertUpdate_Trigger");
                });

            entity.HasIndex(e => e.DdfImportRowId, "DDfGUID")
                .IsUnique()
                .HasFillFactor(100);

            entity.HasIndex(e => new { e.DdfKlasa, e.DdfSymbol }, "DDfKlasa").HasFillFactor(100);

            entity.HasIndex(e => e.DdfSymbol, "DDfSymbol").HasFillFactor(100);

            entity.Property(e => e.DdfDdfId).HasColumnName("DDf_DDfID");
            entity.Property(e => e.DdfImportAppId)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("DDf_ImportAppId");
            entity.Property(e => e.DdfImportRowId)
                .HasMaxLength(36)
                .IsUnicode(false)
                .HasColumnName("DDf_ImportRowId");
            entity.Property(e => e.DdfKatalogObdId).HasColumnName("DDf_KatalogObdId");
            entity.Property(e => e.DdfKierunekOrg)
                .HasComputedColumnSql("(case when [DDF_KLASA]=(650) OR [DDF_KLASA]=(600) OR [DDF_KLASA]=(313) OR [DDF_KLASA]=(307) OR [DDF_KLASA]=(301) OR [DDF_KLASA]=(224) OR [DDF_KLASA]=(201) OR [DDF_KLASA]=(114) OR [DDF_KLASA]=(102) then (-1) when [DDF_KLASA]=(314) OR [DDF_KLASA]=(308) OR [DDF_KLASA]=(306) OR [DDF_KLASA]=(305) OR [DDF_KLASA]=(302) OR [DDF_KLASA]=(221) OR [DDF_KLASA]=(202) OR [DDF_KLASA]=(101) then (1) else (0) end)", false)
                .HasColumnName("DDf_KierunekOrg");
            entity.Property(e => e.DdfKlasa).HasColumnName("DDf_Klasa");
            entity.Property(e => e.DdfNazwa)
                .HasMaxLength(20)
                .HasColumnName("DDf_Nazwa");
            entity.Property(e => e.DdfNieaktywna).HasColumnName("DDf_Nieaktywna");
            entity.Property(e => e.DdfNumeracja)
                .HasMaxLength(50)
                .HasColumnName("DDf_Numeracja");
            entity.Property(e => e.DdfOpeModId).HasColumnName("DDf_OpeModID");
            entity.Property(e => e.DdfOpeModKod)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("DDf_OpeModKod");
            entity.Property(e => e.DdfOpeModNazwisko)
                .HasMaxLength(50)
                .HasDefaultValue("")
                .HasColumnName("DDf_OpeModNazwisko");
            entity.Property(e => e.DdfOpeZalId).HasColumnName("DDf_OpeZalID");
            entity.Property(e => e.DdfOpeZalKod)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("DDf_OpeZalKod");
            entity.Property(e => e.DdfOpeZalNazwisko)
                .HasMaxLength(50)
                .HasDefaultValue("")
                .HasColumnName("DDf_OpeZalNazwisko");
            entity.Property(e => e.DdfPowDdfId).HasColumnName("DDf_PowDDfID");
            entity.Property(e => e.DdfPowSeria)
                .HasMaxLength(5)
                .HasColumnName("DDf_PowSeria");
            entity.Property(e => e.DdfSeriaOperatora).HasColumnName("DDf_SeriaOperatora");
            entity.Property(e => e.DdfStaModId).HasColumnName("DDf_StaModId");
            entity.Property(e => e.DdfStaZalId).HasColumnName("DDf_StaZalId");
            entity.Property(e => e.DdfSymbol)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("DDf_Symbol");
            entity.Property(e => e.DdfTsExport)
                .HasColumnType("datetime")
                .HasColumnName("DDf_TS_Export");
            entity.Property(e => e.DdfTsMod)
                .HasColumnType("datetime")
                .HasColumnName("DDf_TS_Mod");
            entity.Property(e => e.DdfTsZal)
                .HasColumnType("datetime")
                .HasColumnName("DDf_TS_Zal");
        });

        modelBuilder.Entity<DokNag>(entity =>
        {
            entity.HasKey(e => e.DoNDoNid)
                .HasName("DoN_Primary")
                .HasFillFactor(100);

            entity.ToTable("DokNag", "CDN", tb => tb.HasTrigger("DokNag_Delete_Trigger"));

            entity.HasIndex(e => new { e.DoNDataDok, e.DoNNumerString, e.DoNNumerNr }, "DONDataDok")
                .IsUnique()
                .HasFillFactor(100);

            entity.HasIndex(e => new { e.DoNNumerString, e.DoNNumerNr }, "DokNagKeyNumer")
                .IsUnique()
                .HasFillFactor(100);

            entity.HasIndex(e => e.DoNTytul, "DokNagKeyTytul").HasFillFactor(100);

            entity.Property(e => e.DoNDoNid).HasColumnName("DoN_DoNID");
            entity.Property(e => e.DoNDataDok)
                .HasColumnType("datetime")
                .HasColumnName("DoN_DataDok");
            entity.Property(e => e.DoNDdfId).HasColumnName("DoN_DDfId");
            entity.Property(e => e.DoNDotyczy)
                .HasMaxLength(1024)
                .HasColumnName("DoN_Dotyczy");
            entity.Property(e => e.DoNEtapBiezacyLp).HasColumnName("DoN_EtapBiezacyLp");
            entity.Property(e => e.DoNKatalog).HasColumnName("DoN_Katalog");
            entity.Property(e => e.DoNNumerNr).HasColumnName("DoN_NumerNr");
            entity.Property(e => e.DoNNumerObcy)
                .HasMaxLength(256)
                .HasColumnName("DoN_NumerObcy");
            entity.Property(e => e.DoNNumerPelny)
                .HasMaxLength(30)
                .HasComputedColumnSql("([CDN].[FN_NUMERPELNY]([DON_NUMERNR],[DON_NUMERSTRING]))", false)
                .HasColumnName("DoN_NumerPelny");
            entity.Property(e => e.DoNNumerString)
                .HasMaxLength(31)
                .IsUnicode(false)
                .HasColumnName("DoN_NumerString");
            entity.Property(e => e.DoNOpeModId).HasColumnName("DoN_OpeModID");
            entity.Property(e => e.DoNOpeModKod)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("DoN_OpeModKod");
            entity.Property(e => e.DoNOpeModNazwisko)
                .HasMaxLength(50)
                .HasDefaultValue("")
                .HasColumnName("DoN_OpeModNazwisko");
            entity.Property(e => e.DoNOpeZalId).HasColumnName("DoN_OpeZalID");
            entity.Property(e => e.DoNOpeZalKod)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("DoN_OpeZalKod");
            entity.Property(e => e.DoNOpeZalNazwisko)
                .HasMaxLength(50)
                .HasDefaultValue("")
                .HasColumnName("DoN_OpeZalNazwisko");
            entity.Property(e => e.DoNOpiekunId).HasColumnName("DoN_OpiekunID");
            entity.Property(e => e.DoNOpiekunTyp).HasColumnName("DoN_OpiekunTyp");
            entity.Property(e => e.DoNOriginId).HasColumnName("DoN_OriginId");
            entity.Property(e => e.DoNProcesKod)
                .HasMaxLength(20)
                .HasColumnName("DoN_ProcesKod");
            entity.Property(e => e.DoNSsid).HasColumnName("DoN_SSID");
            entity.Property(e => e.DoNStaModId).HasColumnName("DoN_StaModId");
            entity.Property(e => e.DoNStaZalId).HasColumnName("DoN_StaZalId");
            entity.Property(e => e.DoNStatus).HasColumnName("DoN_Status");
            entity.Property(e => e.DoNTsMod)
                .HasColumnType("datetime")
                .HasColumnName("DoN_TS_Mod");
            entity.Property(e => e.DoNTsZal)
                .HasColumnType("datetime")
                .HasColumnName("DoN_TS_Zal");
            entity.Property(e => e.DoNTyp).HasColumnName("DoN_Typ");
            entity.Property(e => e.DoNTytul)
                .HasMaxLength(50)
                .HasColumnName("DoN_Tytul");
        });

        modelBuilder.Entity<DokNagEtapy>(entity =>
        {
            entity.HasKey(e => e.DnEDnEid)
                .HasName("DnE_Primary")
                .HasFillFactor(100);

            entity.ToTable("DokNagEtapy", "CDN");

            entity.HasIndex(e => new { e.DnEDnPrId, e.DnEDnEid }, "DnEProcesEtapy")
                .IsUnique()
                .HasFillFactor(100);

            entity.Property(e => e.DnEDnEid).HasColumnName("DnE_DnEId");
            entity.Property(e => e.DnECzasPrzypomnienia)
                .HasColumnType("datetime")
                .HasColumnName("DnE_CzasPrzypomnienia");
            entity.Property(e => e.DnECzyTerminWykonania).HasColumnName("DnE_CzyTerminWykonania");
            entity.Property(e => e.DnEDnPrId).HasColumnName("DnE_DnPrID");
            entity.Property(e => e.DnEEtapId).HasColumnName("DnE_EtapID");
            entity.Property(e => e.DnEKomentarz)
                .HasMaxLength(1024)
                .HasColumnName("DnE_Komentarz");
            entity.Property(e => e.DnEObowiazkowy).HasColumnName("DnE_Obowiazkowy");
            entity.Property(e => e.DnEOpeId).HasColumnName("DnE_OpeId");
            entity.Property(e => e.DnEPrzypomnienie).HasColumnName("DnE_Przypomnienie");
            entity.Property(e => e.DnERezerwujCzas).HasColumnName("DnE_RezerwujCzas");
            entity.Property(e => e.DnETerminDo)
                .HasColumnType("datetime")
                .HasColumnName("DnE_TerminDo");
            entity.Property(e => e.DnETerminOd)
                .HasColumnType("datetime")
                .HasColumnName("DnE_TerminOd");
            entity.Property(e => e.DnETerminWykonania)
                .HasColumnType("datetime")
                .HasColumnName("DnE_TerminWykonania");
            entity.Property(e => e.DnETyp).HasColumnName("DnE_Typ");
            entity.Property(e => e.DnEWykonany).HasColumnName("DnE_Wykonany");

            entity.HasOne(d => d.DnEDnPr).WithMany(p => p.DokNagEtapies)
                .HasForeignKey(d => d.DnEDnPrId)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK_DnEProcesEtapy");
        });

        modelBuilder.Entity<DokNagEtapyHistorium>(entity =>
        {
            entity.HasKey(e => e.DnEhDnEhid)
                .HasName("DnEH_Primary")
                .HasFillFactor(100);

            entity.ToTable("DokNagEtapyHistoria", "CDN");

            entity.HasIndex(e => new { e.DnEhDoNid, e.DnEhTyp, e.DnEhDnEhid }, "DnEHDokumenty")
                .IsUnique()
                .HasFillFactor(100);

            entity.HasIndex(e => new { e.DnEhDoNid, e.DnEhDataZmiany }, "DnEKDataZmiany").HasFillFactor(100);

            entity.Property(e => e.DnEhDnEhid).HasColumnName("DnEH_DnEHID");
            entity.Property(e => e.DnEhDataZmiany)
                .HasColumnType("datetime")
                .HasColumnName("DnEH_DataZmiany");
            entity.Property(e => e.DnEhDoNid).HasColumnName("DnEH_DoNID");
            entity.Property(e => e.DnEhKomentarz)
                .HasMaxLength(1024)
                .HasColumnName("DnEH_Komentarz");
            entity.Property(e => e.DnEhOpeId).HasColumnName("DnEH_OpeID");
            entity.Property(e => e.DnEhOpeKod)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("DnEH_OpeKod");
            entity.Property(e => e.DnEhSymbolPo)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("DnEH_SymbolPo");
            entity.Property(e => e.DnEhSymbolPrzed)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("DnEH_SymbolPrzed");
            entity.Property(e => e.DnEhTyp).HasColumnName("DnEH_Typ");

            entity.HasOne(d => d.DnEhDoN).WithMany(p => p.DokNagEtapyHistoria)
                .HasForeignKey(d => d.DnEhDoNid)
                .HasConstraintName("FK_DnEHDokumenty");
        });

        modelBuilder.Entity<DokNagEtapyKolejne>(entity =>
        {
            entity.HasKey(e => e.DnEkDnEkId)
                .HasName("DnEK_Primary")
                .HasFillFactor(100);

            entity.ToTable("DokNagEtapyKolejne", "CDN");

            entity.HasIndex(e => new { e.DnEkDnPrId, e.DnEkDnEkId }, "DnEKEtap")
                .IsUnique()
                .HasFillFactor(100);

            entity.HasIndex(e => new { e.DnEkDnPrIdkolejny, e.DnEkDnEkId }, "DnEKKolejny")
                .IsUnique()
                .HasFillFactor(100);

            entity.Property(e => e.DnEkDnEkId).HasColumnName("DnEK_DnEkID");
            entity.Property(e => e.DnEkDnPrId).HasColumnName("DnEK_DnPrID");
            entity.Property(e => e.DnEkDnPrIdkolejny).HasColumnName("DnEK_DnPrIDKolejny");
        });

        modelBuilder.Entity<DokNagPliki>(entity =>
        {
            entity.HasKey(e => e.DnPDnPid)
                .HasName("DnP_Primary")
                .HasFillFactor(100);

            entity.ToTable("DokNagPliki", "CDN", tb => tb.HasTrigger("DokNagPliki_Delete_Trigger"));

            entity.Property(e => e.DnPDnPid).HasColumnName("DnP_DnPID");
            entity.Property(e => e.DnPArchiwalny).HasColumnName("DnP_Archiwalny");
            entity.Property(e => e.DnPDataDok)
                .HasColumnType("datetime")
                .HasColumnName("DnP_DataDok");
            entity.Property(e => e.DnPDlaOcr).HasColumnName("DnP_DlaOcr");
            entity.Property(e => e.DnPDoNid).HasColumnName("DnP_DoNID");
            entity.Property(e => e.DnPFileMode).HasColumnName("DnP_FileMode");
            entity.Property(e => e.DnPNazwaPliku)
                .HasMaxLength(255)
                .HasColumnName("DnP_NazwaPliku");
            entity.Property(e => e.DnPOpeEditId).HasColumnName("DnP_OpeEditId");
            entity.Property(e => e.DnPOpeModId).HasColumnName("DnP_OpeModID");
            entity.Property(e => e.DnPOpeModKod)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("DnP_OpeModKod");
            entity.Property(e => e.DnPOpeModNazwisko)
                .HasMaxLength(50)
                .HasDefaultValue("")
                .HasColumnName("DnP_OpeModNazwisko");
            entity.Property(e => e.DnPOpeZalId).HasColumnName("DnP_OpeZalID");
            entity.Property(e => e.DnPOpeZalKod)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("DnP_OpeZalKod");
            entity.Property(e => e.DnPOpeZalNazwisko)
                .HasMaxLength(50)
                .HasDefaultValue("")
                .HasColumnName("DnP_OpeZalNazwisko");
            entity.Property(e => e.DnPSciezka)
                .HasMaxLength(255)
                .HasColumnName("DnP_Sciezka");
            entity.Property(e => e.DnPStaEditId).HasColumnName("DnP_StaEditId");
            entity.Property(e => e.DnPStaModId).HasColumnName("DnP_StaModId");
            entity.Property(e => e.DnPStaZalId).HasColumnName("DnP_StaZalId");
            entity.Property(e => e.DnPTsMod)
                .HasColumnType("datetime")
                .HasColumnName("DnP_TS_Mod");
            entity.Property(e => e.DnPTsZal)
                .HasColumnType("datetime")
                .HasColumnName("DnP_TS_Zal");
            entity.Property(e => e.DnPTyp).HasColumnName("DnP_Typ");
            entity.Property(e => e.DnPWbazie).HasColumnName("DnP_WBazie");
            entity.Property(e => e.DnPWersja).HasColumnName("DnP_Wersja");

            entity.HasOne(d => d.DnPDoN).WithMany(p => p.DokNagPlikis)
                .HasForeignKey(d => d.DnPDoNid)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK_DnPDoNId");
        });

        modelBuilder.Entity<DokNagProcesEtapy>(entity =>
        {
            entity.HasKey(e => e.DnPrDnPrId)
                .HasName("DnPr_Primary")
                .HasFillFactor(100);

            entity.ToTable("DokNagProcesEtapy", "CDN", tb => tb.HasTrigger("DokNagProcesEtapy_Delete_Trigger"));

            entity.HasIndex(e => new { e.DnPrDoNid, e.DnPrDnPrId }, "DnPrDokNag")
                .IsUnique()
                .HasFillFactor(100);

            entity.HasIndex(e => new { e.DnPrDoNid, e.DnPrLp, e.DnPrPoziom, e.DnPrDnPrId }, "DnPrLp")
                .IsUnique()
                .HasFillFactor(100);

            entity.Property(e => e.DnPrDnPrId).HasColumnName("DnPr_DnPrID");
            entity.Property(e => e.DnPrDoNid).HasColumnName("DnPr_DoNID");
            entity.Property(e => e.DnPrLp).HasColumnName("DnPr_Lp");
            entity.Property(e => e.DnPrPoprzedniLp).HasColumnName("DnPr_PoprzedniLp");
            entity.Property(e => e.DnPrPoziom).HasColumnName("DnPr_Poziom");
            entity.Property(e => e.DnPrTyp).HasColumnName("DnPr_Typ");

            entity.HasOne(d => d.DnPrDoN).WithMany(p => p.DokNagProcesEtapies)
                .HasForeignKey(d => d.DnPrDoNid)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK_DnPrDokNag");
        });

        modelBuilder.Entity<DokPodmioty>(entity =>
        {
            entity.HasKey(e => e.DoPDoPid)
                .HasName("DoP_Primary")
                .HasFillFactor(100);

            entity.ToTable("DokPodmioty", "CDN");

            entity.HasIndex(e => e.DoPDoNid, "DoPDokNag").HasFillFactor(100);

            entity.Property(e => e.DoPDoPid).HasColumnName("DoP_DoPId");
            entity.Property(e => e.DoPDoNid).HasColumnName("DoP_DoNID");
            entity.Property(e => e.DoPPodmiotId).HasColumnName("DoP_PodmiotID");
            entity.Property(e => e.DoPPodmiotTyp).HasColumnName("DoP_PodmiotTyp");
        });

        modelBuilder.Entity<DokRelacje>(entity =>
        {
            entity.HasKey(e => e.DoRDoRid)
                .HasName("DoR_Primary")
                .HasFillFactor(100);

            entity.ToTable("DokRelacje", "CDN");

            entity.HasIndex(e => new { e.DoRFlaga, e.DoRParentTyp, e.DoRParentId, e.DoRDokumentTyp, e.DoRDokumentId }, "DoRUniqueDok")
                .IsUnique()
                .HasFillFactor(100);

            entity.HasIndex(e => new { e.DoRDokumentTyp, e.DoRDokumentId }, "DoSDokument").HasFillFactor(100);

            entity.HasIndex(e => new { e.DoRParentTyp, e.DoRParentId, e.DoRDoRid }, "DosParent").HasFillFactor(100);

            entity.Property(e => e.DoRDoRid).HasColumnName("DoR_DoRId");
            entity.Property(e => e.DoRDokumentId).HasColumnName("DoR_DokumentId");
            entity.Property(e => e.DoRDokumentTyp).HasColumnName("DoR_DokumentTyp");
            entity.Property(e => e.DoRFlaga).HasColumnName("DoR_Flaga");
            entity.Property(e => e.DoRParentId).HasColumnName("DoR_ParentId");
            entity.Property(e => e.DoRParentTyp).HasColumnName("DoR_ParentTyp");
        });

        modelBuilder.Entity<Eteczki>(entity =>
        {
            entity.HasKey(e => e.EteEteId)
                .HasName("PK_ETE_EteId")
                .HasFillFactor(100);

            entity.ToTable("ETeczki", "CDN");

            entity.Property(e => e.EteEteId).HasColumnName("ETE_EteId");
            entity.Property(e => e.EteDomyslna).HasColumnName("ETE_Domyslna");
            entity.Property(e => e.EteNazwa)
                .HasMaxLength(256)
                .HasColumnName("ETE_Nazwa");
        });

        modelBuilder.Entity<EteczkiCertyfikaty>(entity =>
        {
            entity.HasKey(e => e.EtcEtcId)
                .HasName("PK_ETC_EtcId")
                .HasFillFactor(100);

            entity.ToTable("ETeczkiCertyfikaty", "CDN");

            entity.Property(e => e.EtcEtcId).HasColumnName("ETC_EtcId");
            entity.Property(e => e.EtcNazwa)
                .HasMaxLength(256)
                .HasColumnName("ETC_Nazwa");
            entity.Property(e => e.EtcOpeId).HasColumnName("ETC_OpeId");
            entity.Property(e => e.EtcPodpis).HasColumnName("ETC_Podpis");
            entity.Property(e => e.EtcThumbprint)
                .HasMaxLength(256)
                .HasColumnName("ETC_Thumbprint");
        });

        modelBuilder.Entity<Filtry>(entity =>
        {
            entity.HasKey(e => new { e.FilProcId, e.FilListaId, e.FilLp, e.FilStaTyp, e.FilStaFirma, e.FilStaNumer })
                .HasName("FIL_Primary")
                .HasFillFactor(100);

            entity.ToTable("Filtry", "CDN");

            entity.Property(e => e.FilProcId).HasColumnName("FIL_ProcID");
            entity.Property(e => e.FilListaId).HasColumnName("FIL_ListaID");
            entity.Property(e => e.FilLp).HasColumnName("FIL_Lp");
            entity.Property(e => e.FilStaTyp).HasColumnName("FIL_StaTyp");
            entity.Property(e => e.FilStaFirma).HasColumnName("FIL_StaFirma");
            entity.Property(e => e.FilStaNumer).HasColumnName("FIL_StaNumer");
            entity.Property(e => e.FilDomyslny).HasColumnName("FIL_Domyslny");
            entity.Property(e => e.FilFiltrIsam).HasColumnName("FIL_FiltrISAM");
            entity.Property(e => e.FilFiltrSql).HasColumnName("FIL_FiltrSQL");
            entity.Property(e => e.FilFiltrSym).HasColumnName("FIL_FiltrSym");
            entity.Property(e => e.FilNazwa)
                .HasMaxLength(254)
                .HasColumnName("FIL_Nazwa");
            entity.Property(e => e.FilStaLp).HasColumnName("FIL_StaLp");
        });

        modelBuilder.Entity<Grupy>(entity =>
        {
            entity.HasKey(e => e.GruGruId)
                .HasName("Gru_Primary")
                .HasFillFactor(100);

            entity.ToTable("Grupy", "CDN");

            entity.HasIndex(e => new { e.GruTyp, e.GruNazwa }, "GruNazwa")
                .IsUnique()
                .HasFillFactor(100);

            entity.Property(e => e.GruGruId).HasColumnName("Gru_GruID");
            entity.Property(e => e.GruFlaga).HasColumnName("Gru_Flaga");
            entity.Property(e => e.GruKontoMa)
                .HasMaxLength(50)
                .HasColumnName("Gru_KontoMa");
            entity.Property(e => e.GruKontoWn)
                .HasMaxLength(50)
                .HasColumnName("Gru_KontoWn");
            entity.Property(e => e.GruNazwa)
                .HasMaxLength(32)
                .HasColumnName("Gru_Nazwa");
            entity.Property(e => e.GruNazwaPef)
                .HasMaxLength(20)
                .HasDefaultValue("")
                .HasColumnName("Gru_NazwaPEF");
            entity.Property(e => e.GruOpeModId).HasColumnName("Gru_OpeModID");
            entity.Property(e => e.GruOpeModKod)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("Gru_OpeModKod");
            entity.Property(e => e.GruOpeModNazwisko)
                .HasMaxLength(50)
                .HasDefaultValue("")
                .HasColumnName("Gru_OpeModNazwisko");
            entity.Property(e => e.GruOpeZalId).HasColumnName("Gru_OpeZalID");
            entity.Property(e => e.GruOpeZalKod)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("Gru_OpeZalKod");
            entity.Property(e => e.GruOpeZalNazwisko)
                .HasMaxLength(50)
                .HasDefaultValue("")
                .HasColumnName("Gru_OpeZalNazwisko");
            entity.Property(e => e.GruOpis)
                .HasMaxLength(128)
                .HasColumnName("Gru_Opis");
            entity.Property(e => e.GruStaModId).HasColumnName("Gru_StaModId");
            entity.Property(e => e.GruStaZalId).HasColumnName("Gru_StaZalId");
            entity.Property(e => e.GruTsMod)
                .HasColumnType("datetime")
                .HasColumnName("Gru_TS_Mod");
            entity.Property(e => e.GruTsZal)
                .HasColumnType("datetime")
                .HasColumnName("Gru_TS_Zal");
            entity.Property(e => e.GruTyp).HasColumnName("Gru_Typ");
        });

        modelBuilder.Entity<HistoriaPobieraniaWskaznikow>(entity =>
        {
            entity.HasKey(e => e.HpwHpwid)
                .HasName("HPW_Primary")
                .HasFillFactor(100);

            entity.ToTable("HistoriaPobieraniaWskaznikow", "CDN");

            entity.Property(e => e.HpwHpwid).HasColumnName("HPW_HPWID");
            entity.Property(e => e.HpwDataImportu)
                .HasColumnType("datetime")
                .HasColumnName("HPW_DataImportu");
            entity.Property(e => e.HpwNazwa)
                .HasMaxLength(1024)
                .HasColumnName("HPW_Nazwa");
            entity.Property(e => e.HpwObowiazujeOd)
                .HasColumnType("datetime")
                .HasColumnName("HPW_ObowiazujeOd");
            entity.Property(e => e.HpwWartosc)
                .HasMaxLength(256)
                .HasColumnName("HPW_Wartosc");
        });

        modelBuilder.Entity<Informacje>(entity =>
        {
            entity.HasKey(e => e.InfInfId)
                .HasName("Inf_Primary")
                .HasFillFactor(100);

            entity.ToTable("Informacje", "CDN", tb => tb.HasTrigger("Informacje_InsertUpdate_Trigger"));

            entity.HasIndex(e => new { e.InfTypInformacji, e.InfKod }, "InfKod")
                .IsUnique()
                .HasFillFactor(100);

            entity.HasIndex(e => new { e.InfModulId, e.InfLp }, "InfLp").HasFillFactor(100);

            entity.Property(e => e.InfInfId).HasColumnName("Inf_InfId");
            entity.Property(e => e.InfKod)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("Inf_Kod");
            entity.Property(e => e.InfLp).HasColumnName("Inf_Lp");
            entity.Property(e => e.InfModulId).HasColumnName("Inf_ModulId");
            entity.Property(e => e.InfNazwa)
                .HasMaxLength(50)
                .HasColumnName("Inf_Nazwa");
            entity.Property(e => e.InfOpeModId).HasColumnName("Inf_OpeModID");
            entity.Property(e => e.InfOpeModKod)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("Inf_OpeModKod");
            entity.Property(e => e.InfOpeModNazwisko)
                .HasMaxLength(50)
                .HasDefaultValue("")
                .HasColumnName("Inf_OpeModNazwisko");
            entity.Property(e => e.InfOpeZalId).HasColumnName("Inf_OpeZalID");
            entity.Property(e => e.InfOpeZalKod)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("Inf_OpeZalKod");
            entity.Property(e => e.InfOpeZalNazwisko)
                .HasMaxLength(50)
                .HasDefaultValue("")
                .HasColumnName("Inf_OpeZalNazwisko");
            entity.Property(e => e.InfProcId).HasColumnName("Inf_ProcId");
            entity.Property(e => e.InfStaModId).HasColumnName("Inf_StaModId");
            entity.Property(e => e.InfStaZalId).HasColumnName("Inf_StaZalId");
            entity.Property(e => e.InfTerminDomyslny).HasColumnName("Inf_TerminDomyslny");
            entity.Property(e => e.InfTmiId).HasColumnName("Inf_TmiId");
            entity.Property(e => e.InfTmiIdDomyslny).HasColumnName("Inf_TmiIdDomyslny");
            entity.Property(e => e.InfTsMod)
                .HasColumnType("datetime")
                .HasColumnName("Inf_TS_Mod");
            entity.Property(e => e.InfTsZal)
                .HasColumnType("datetime")
                .HasColumnName("Inf_TS_Zal");
            entity.Property(e => e.InfTypDefinicji).HasColumnName("Inf_TypDefinicji");
            entity.Property(e => e.InfTypInformacji).HasColumnName("Inf_TypInformacji");
            entity.Property(e => e.InfTypWykresu).HasColumnName("Inf_TypWykresu");
            entity.Property(e => e.InfWkDid).HasColumnName("Inf_WkDId");
        });

        modelBuilder.Entity<KatalogZakazy>(entity =>
        {
            entity.HasKey(e => e.KtZKtZid)
                .HasName("KtZ_Primary")
                .HasFillFactor(100);

            entity.ToTable("KatalogZakazy", "CDN");

            entity.HasIndex(e => new { e.KtZKtlId, e.KtZOpeId }, "KtZKatalog")
                .IsUnique()
                .HasFillFactor(100);

            entity.Property(e => e.KtZKtZid).HasColumnName("KtZ_KtZId");
            entity.Property(e => e.KtZDodawanie).HasColumnName("KtZ_Dodawanie");
            entity.Property(e => e.KtZKasowanieInne).HasColumnName("KtZ_KasowanieInne");
            entity.Property(e => e.KtZKasowanieWlas).HasColumnName("KtZ_KasowanieWlas");
            entity.Property(e => e.KtZKtlId).HasColumnName("KtZ_KtlId");
            entity.Property(e => e.KtZOpeId).HasColumnName("KtZ_OpeId");
            entity.Property(e => e.KtZPodglad).HasColumnName("KtZ_Podglad");
            entity.Property(e => e.KtZZmianaInne).HasColumnName("KtZ_ZmianaInne");
            entity.Property(e => e.KtZZmianaWlas).HasColumnName("KtZ_ZmianaWlas");
        });

        modelBuilder.Entity<Katalogi>(entity =>
        {
            entity.HasKey(e => e.KtlKtlId)
                .HasName("Ktl_Primary")
                .HasFillFactor(100);

            entity.ToTable("Katalogi", "CDN");

            entity.HasIndex(e => e.KtlSymbol, "KtlSymbol")
                .IsUnique()
                .HasFillFactor(100);

            entity.Property(e => e.KtlKtlId).HasColumnName("Ktl_KtlId");
            entity.Property(e => e.KtlDomyslny).HasColumnName("Ktl_Domyslny");
            entity.Property(e => e.KtlIbard24)
                .HasMaxLength(255)
                .HasColumnName("Ktl_IBard24");
            entity.Property(e => e.KtlIbard24Id).HasColumnName("Ktl_IBard24Id");
            entity.Property(e => e.KtlNazwa)
                .HasMaxLength(50)
                .HasColumnName("Ktl_Nazwa");
            entity.Property(e => e.KtlNumeracja)
                .HasMaxLength(5)
                .HasColumnName("Ktl_Numeracja");
            entity.Property(e => e.KtlOpeModId).HasColumnName("Ktl_OpeModID");
            entity.Property(e => e.KtlOpeModKod)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("Ktl_OpeModKod");
            entity.Property(e => e.KtlOpeModNazwisko)
                .HasMaxLength(50)
                .HasDefaultValue("")
                .HasColumnName("Ktl_OpeModNazwisko");
            entity.Property(e => e.KtlOpeZalId).HasColumnName("Ktl_OpeZalID");
            entity.Property(e => e.KtlOpeZalKod)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("Ktl_OpeZalKod");
            entity.Property(e => e.KtlOpeZalNazwisko)
                .HasMaxLength(50)
                .HasDefaultValue("")
                .HasColumnName("Ktl_OpeZalNazwisko");
            entity.Property(e => e.KtlSsid).HasColumnName("Ktl_SSID");
            entity.Property(e => e.KtlStaModId).HasColumnName("Ktl_StaModId");
            entity.Property(e => e.KtlStaZalId).HasColumnName("Ktl_StaZalId");
            entity.Property(e => e.KtlSymbol)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("Ktl_Symbol");
            entity.Property(e => e.KtlTsMod)
                .HasColumnType("datetime")
                .HasColumnName("Ktl_TS_Mod");
            entity.Property(e => e.KtlTsZal)
                .HasColumnType("datetime")
                .HasColumnName("Ktl_TS_Zal");
        });

        modelBuilder.Entity<Katrybuty>(entity =>
        {
            entity.HasKey(e => e.KawKawid)
                .HasName("KAW_Primary")
                .HasFillFactor(100);

            entity.ToTable("KAtrybuty", "CDN", tb =>
                {
                    tb.HasTrigger("KAtrybutyDeleteTrigger");
                    tb.HasTrigger("KAtrybutyInsertUpdateTrigger");
                });

            entity.HasIndex(e => new { e.KawBazId, e.KawKakid, e.KawRok, e.KawMiesiac, e.KawAktualny }, "KAWBazId").HasFillFactor(100);

            entity.HasIndex(e => e.KawKakid, "KAWKAKId").HasFillFactor(100);

            entity.HasIndex(e => e.KawOpeId, "KAWOpeId").HasFillFactor(100);

            entity.Property(e => e.KawKawid).HasColumnName("KAW_KAWId");
            entity.Property(e => e.KawAktualny).HasColumnName("KAW_Aktualny");
            entity.Property(e => e.KawBazId).HasColumnName("KAW_BazId");
            entity.Property(e => e.KawKakid).HasColumnName("KAW_KAKId");
            entity.Property(e => e.KawMiesiac).HasColumnName("KAW_Miesiac");
            entity.Property(e => e.KawOpeId).HasColumnName("KAW_OpeId");
            entity.Property(e => e.KawRok).HasColumnName("KAW_Rok");
            entity.Property(e => e.KawTstamp)
                .HasColumnType("datetime")
                .HasColumnName("KAW_TStamp");
            entity.Property(e => e.KawWartosc)
                .HasMaxLength(255)
                .HasColumnName("KAW_Wartosc");

            entity.HasOne(d => d.KawBaz).WithMany(p => p.Katrybuties)
                .HasForeignKey(d => d.KawBazId)
                .HasConstraintName("FK_KAWBazId");

            entity.HasOne(d => d.KawKak).WithMany(p => p.Katrybuties)
                .HasForeignKey(d => d.KawKakid)
                .HasConstraintName("FK_KAWKAKId");
        });

        modelBuilder.Entity<KatrybutyGrupy>(entity =>
        {
            entity.HasKey(e => e.KagKagid)
                .HasName("KAG_Primary")
                .HasFillFactor(100);

            entity.ToTable("KAtrybutyGrupy", "CDN");

            entity.HasIndex(e => e.KagNazwa, "KaGNazwa")
                .IsUnique()
                .HasFillFactor(100);

            entity.Property(e => e.KagKagid).HasColumnName("KAG_KAGId");
            entity.Property(e => e.KagNazwa)
                .HasMaxLength(20)
                .HasColumnName("KAG_Nazwa");
        });

        modelBuilder.Entity<KatrybutyKlasy>(entity =>
        {
            entity.HasKey(e => e.KakKakid)
                .HasName("KAK_Primary")
                .HasFillFactor(100);

            entity.ToTable("KAtrybutyKlasy", "CDN");

            entity.HasIndex(e => e.KakKagid, "KAGAtrybutyGrupy").HasFillFactor(100);

            entity.HasIndex(e => e.KakNazwa, "KAKNazwa")
                .IsUnique()
                .HasFillFactor(100);

            entity.Property(e => e.KakKakid).HasColumnName("KAK_KAKId");
            entity.Property(e => e.KakDomyslna)
                .HasMaxLength(255)
                .HasColumnName("KAK_Domyslna");
            entity.Property(e => e.KakFormat)
                .HasMaxLength(20)
                .HasColumnName("KAK_Format");
            entity.Property(e => e.KakHistoria).HasColumnName("KAK_Historia");
            entity.Property(e => e.KakKagid).HasColumnName("KAK_KAGId");
            entity.Property(e => e.KakMiesieczny).HasColumnName("KAK_Miesieczny");
            entity.Property(e => e.KakNazwa)
                .HasMaxLength(50)
                .HasColumnName("KAK_Nazwa");
            entity.Property(e => e.KakNieaktywny).HasColumnName("KAK_Nieaktywny");
            entity.Property(e => e.KakOpis)
                .HasMaxLength(255)
                .HasColumnName("KAK_Opis");
            entity.Property(e => e.KakSql).HasColumnName("KAK_SQL");
            entity.Property(e => e.KakSuma).HasColumnName("KAK_Suma");
            entity.Property(e => e.KakSystemowy).HasColumnName("KAK_Systemowy");
            entity.Property(e => e.KakTyp).HasColumnName("KAK_Typ");

            entity.HasOne(d => d.KakKag).WithMany(p => p.KatrybutyKlasies)
                .HasForeignKey(d => d.KakKagid)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_KAGAtrybutyGrupy");
        });

        modelBuilder.Entity<KatrybutyKlasyElem>(entity =>
        {
            entity.HasKey(e => e.KaeKaeid)
                .HasName("KAE_Primary")
                .HasFillFactor(100);

            entity.ToTable("KAtrybutyKlasyElem", "CDN");

            entity.HasIndex(e => e.KaeKakid, "KAEKAKId").HasFillFactor(100);

            entity.Property(e => e.KaeKaeid).HasColumnName("KAE_KAEId");
            entity.Property(e => e.KaeKakid).HasColumnName("KAE_KAKId");
            entity.Property(e => e.KaeWartosc)
                .HasMaxLength(100)
                .HasColumnName("KAE_Wartosc");

            entity.HasOne(d => d.KaeKak).WithMany(p => p.KatrybutyKlasyElems)
                .HasForeignKey(d => d.KaeKakid)
                .HasConstraintName("FK_KAEKAKId");
        });

        modelBuilder.Entity<KatrybutyKlasyZakaz>(entity =>
        {
            entity.HasKey(e => e.KazKazid)
                .HasName("KAZ_Primary")
                .HasFillFactor(100);

            entity.ToTable("KAtrybutyKlasyZakaz", "CDN");

            entity.HasIndex(e => e.KazKakid, "KAZKAKId").HasFillFactor(100);

            entity.HasIndex(e => new { e.KazOpeId, e.KazKakid }, "KAZOpeId")
                .IsUnique()
                .HasFillFactor(100);

            entity.Property(e => e.KazKazid).HasColumnName("KAZ_KAZId");
            entity.Property(e => e.KazEdycja).HasColumnName("KAZ_Edycja");
            entity.Property(e => e.KazKakid).HasColumnName("KAZ_KAKId");
            entity.Property(e => e.KazOpeId).HasColumnName("KAZ_OpeId");
            entity.Property(e => e.KazPodglad).HasColumnName("KAZ_Podglad");

            entity.HasOne(d => d.KazKak).WithMany(p => p.KatrybutyKlasyZakazs)
                .HasForeignKey(d => d.KazKakid)
                .HasConstraintName("FK_KAZKAKId");

            entity.HasOne(d => d.KazOpe).WithMany(p => p.KatrybutyKlasyZakazs)
                .HasForeignKey(d => d.KazOpeId)
                .HasConstraintName("FK_KAZOpeId");
        });

        modelBuilder.Entity<KatrybutyKolumny>(entity =>
        {
            entity.HasKey(e => e.KacKacid)
                .HasName("KAC_Primary")
                .HasFillFactor(100);

            entity.ToTable("KAtrybutyKolumny", "CDN");

            entity.HasIndex(e => e.KacKakid, "KACAtrKlasy").HasFillFactor(100);

            entity.HasIndex(e => new { e.KacOpeId, e.KacKakid }, "KACOperator")
                .IsUnique()
                .HasFillFactor(100);

            entity.Property(e => e.KacKacid).HasColumnName("KAC_KACId");
            entity.Property(e => e.KacGrupowanie).HasColumnName("KAC_Grupowanie");
            entity.Property(e => e.KacKakid).HasColumnName("KAC_KAKId");
            entity.Property(e => e.KacLp).HasColumnName("KAC_Lp");
            entity.Property(e => e.KacOpeId).HasColumnName("KAC_OpeId");
            entity.Property(e => e.KacSzerokosc).HasColumnName("KAC_Szerokosc");

            entity.HasOne(d => d.KacKak).WithMany(p => p.KatrybutyKolumnies)
                .HasForeignKey(d => d.KacKakid)
                .HasConstraintName("FK_KACAtrKlasy");

            entity.HasOne(d => d.KacOpe).WithMany(p => p.KatrybutyKolumnies)
                .HasForeignKey(d => d.KacOpeId)
                .HasConstraintName("FK_KACOperator");
        });

        modelBuilder.Entity<Kfpiw>(entity =>
        {
            entity.HasKey(e => e.KfpiwKfpiwid)
                .HasName("KFPIW_Primary")
                .HasFillFactor(100);

            entity.ToTable("KFPIW", "CDN");

            entity.HasIndex(e => new { e.KfpiwKod, e.KfpiwOpis }, "KFPIWWgKodu")
                .IsUnique()
                .HasFillFactor(100);

            entity.Property(e => e.KfpiwKfpiwid).HasColumnName("KFPIW_KFPIWID");
            entity.Property(e => e.KfpiwKod)
                .HasMaxLength(3)
                .IsUnicode(false)
                .HasColumnName("KFPIW_Kod");
            entity.Property(e => e.KfpiwOpis)
                .HasMaxLength(350)
                .HasColumnName("KFPIW_Opis");
            entity.Property(e => e.KfpiwTyp).HasColumnName("KFPIW_Typ");
        });

        modelBuilder.Entity<Konfig>(entity =>
        {
            entity.HasKey(e => e.KonKonId)
                .HasName("Kon_Primary")
                .HasFillFactor(100);

            entity.ToTable("Konfig", "CDN", tb => tb.HasTrigger("Konfig_Update_Trigger"));

            entity.HasIndex(e => new { e.KonNumer, e.KonLp }, "KonNumer")
                .IsUnique()
                .HasFillFactor(100);

            entity.Property(e => e.KonKonId).HasColumnName("Kon_KonId");
            entity.Property(e => e.KonLp).HasColumnName("Kon_Lp");
            entity.Property(e => e.KonNumer).HasColumnName("Kon_Numer");
            entity.Property(e => e.KonOpis)
                .HasMaxLength(254)
                .HasColumnName("Kon_Opis");
            entity.Property(e => e.KonWartosc)
                .HasMaxLength(254)
                .HasColumnName("Kon_Wartosc");
        });

        modelBuilder.Entity<KonfigCdn>(entity =>
        {
            entity.HasKey(e => e.SykId)
                .HasName("SYK_Primary")
                .HasFillFactor(100);

            entity.ToTable("KonfigCDN", "CDN");

            entity.Property(e => e.SykId)
                .ValueGeneratedNever()
                .HasColumnName("SYK_ID");
            entity.Property(e => e.SykWartosc)
                .HasMaxLength(254)
                .IsUnicode(false)
                .HasColumnName("SYK_Wartosc");
        });

        modelBuilder.Entity<KonfigText>(entity =>
        {
            entity.HasKey(e => e.KtxKey)
                .HasName("KTx_Primary")
                .HasFillFactor(100);

            entity.ToTable("KonfigText", "CDN");

            entity.Property(e => e.KtxKey)
                .HasMaxLength(49)
                .HasColumnName("KTx_Key");
            entity.Property(e => e.KtxValue).HasColumnName("KTx_Value");
        });

        modelBuilder.Entity<Kraje>(entity =>
        {
            entity.HasKey(e => e.KraKraId)
                .HasName("Kra_Primary")
                .HasFillFactor(100);

            entity.ToTable("Kraje", "CDN");

            entity.HasIndex(e => e.KraNazwa, "UN_Kra_Nazwa")
                .IsUnique()
                .HasFillFactor(100);

            entity.Property(e => e.KraKraId).HasColumnName("Kra_KraID");
            entity.Property(e => e.KraKod)
                .HasMaxLength(240)
                .HasColumnName("Kra_Kod");
            entity.Property(e => e.KraNazwa)
                .HasMaxLength(240)
                .HasColumnName("Kra_Nazwa");
        });

        modelBuilder.Entity<Krst>(entity =>
        {
            entity.HasKey(e => e.KrstKrstid)
                .HasName("KRST_Primary")
                .HasFillFactor(100);

            entity.ToTable("KRST", "CDN");

            entity.HasIndex(e => new { e.KrstStaraWersja, e.KrstStandardowa, e.KrstSymbol, e.KrstNazwa }, "KRSTWgSymbolu")
                .IsUnique()
                .HasFillFactor(100);

            entity.Property(e => e.KrstKrstid).HasColumnName("KRST_KRSTID");
            entity.Property(e => e.KrstNazwa)
                .HasMaxLength(444)
                .HasColumnName("KRST_Nazwa");
            entity.Property(e => e.KrstNieaktywna).HasColumnName("KRST_Nieaktywna");
            entity.Property(e => e.KrstPozycja)
                .HasMaxLength(2)
                .HasColumnName("KRST_Pozycja");
            entity.Property(e => e.KrstStandardowa).HasColumnName("KRST_Standardowa");
            entity.Property(e => e.KrstStaraWersja)
                .HasMaxLength(8)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("KRST_StaraWersja");
            entity.Property(e => e.KrstStawka)
                .HasColumnType("decimal(5, 2)")
                .HasColumnName("KRST_Stawka");
            entity.Property(e => e.KrstSymbol)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("KRST_Symbol");
        });

        modelBuilder.Entity<Kzi>(entity =>
        {
            entity.HasKey(e => e.KzisKzisid)
                .HasName("KZIS_Primary")
                .HasFillFactor(100);

            entity.ToTable("KZIS", "CDN");

            entity.HasIndex(e => new { e.KzisSymbol, e.KzisNazwa }, "KZISWgSymbolu")
                .IsUnique()
                .HasFillFactor(100);

            entity.Property(e => e.KzisKzisid).HasColumnName("KZIS_KZISID");
            entity.Property(e => e.KzisNazwa)
                .HasMaxLength(130)
                .HasColumnName("KZIS_Nazwa");
            entity.Property(e => e.KzisStandardowy).HasColumnName("KZIS_Standardowy");
            entity.Property(e => e.KzisSymbol)
                .HasMaxLength(7)
                .IsUnicode(false)
                .HasColumnName("KZIS_Symbol");
        });

        modelBuilder.Entity<MailFoldery>(entity =>
        {
            entity.HasKey(e => e.MflMflid)
                .HasName("MFL_Primary")
                .HasFillFactor(100);

            entity.ToTable("MailFoldery", "CDN", tb =>
                {
                    tb.HasTrigger("MailFoldery_DeleteHandler");
                    tb.HasTrigger("MailFoldery_UpdateHandler");
                });

            entity.Property(e => e.MflMflid).HasColumnName("MFL_MFLID");
            entity.Property(e => e.MflImapMailBox)
                .HasMaxLength(500)
                .HasColumnName("MFL_ImapMailBox");
            entity.Property(e => e.MflImapMessages).HasColumnName("MFL_ImapMessages");
            entity.Property(e => e.MflImapNoSelect).HasColumnName("MFL_ImapNoSelect");
            entity.Property(e => e.MflImapSubskrypcja).HasColumnName("MFL_ImapSubskrypcja");
            entity.Property(e => e.MflImapTylkoNaglowek).HasColumnName("MFL_ImapTylkoNaglowek");
            entity.Property(e => e.MflImapUidnext).HasColumnName("MFL_ImapUIDNext");
            entity.Property(e => e.MflImapUidvalidity).HasColumnName("MFL_ImapUIDValidity");
            entity.Property(e => e.MflMkeid).HasColumnName("MFL_MKEID");
            entity.Property(e => e.MflNazwa)
                .HasMaxLength(50)
                .HasColumnName("MFL_Nazwa");
            entity.Property(e => e.MflNid).HasColumnName("MFL_NID");
            entity.Property(e => e.MflSystemowy).HasColumnName("MFL_Systemowy");
            entity.Property(e => e.MflTyp).HasColumnName("MFL_Typ");

            entity.HasOne(d => d.MflMke).WithMany(p => p.MailFolderies)
                .HasForeignKey(d => d.MflMkeid)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK_MFL_KontaEMail");
        });

        modelBuilder.Entity<MailIdentyfikatory>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("MailIdentyfikatory", "CDN", tb =>
                {
                    tb.HasTrigger("MailIdentyfikatory_InsertHandler");
                    tb.HasTrigger("MailIdentyfikatory_UpdateHandler");
                });

            entity.HasIndex(e => new { e.MidImapuid, e.MidMflid, e.MidDoUsuniecia }, "IX_MID_IMAPUID_MFLID_DoUsuniecia").HasFillFactor(100);

            entity.HasIndex(e => new { e.MidImapuid, e.MidMkeid }, "IX_MID_IMAPUID_MKEID").HasFillFactor(100);

            entity.HasIndex(e => new { e.MidMwdid, e.MidImapuid, e.MidMflid, e.MidDoUsuniecia }, "IX_MID_MWDID_IMAPUID_MFLID_DoUsuniecia").HasFillFactor(100);

            entity.HasIndex(e => new { e.MidMwdid, e.MidImapIdentity, e.MidMkeid, e.MidDoUsuniecia }, "IX_MID_MWDID_ImapIdentity_MKEID_DoUsuniecia").HasFillFactor(100);

            entity.HasIndex(e => e.MidImapIdentity, "MID_ImapIdentity_IDX").HasFillFactor(100);

            entity.HasIndex(e => new { e.MidMkeid, e.MidMflid }, "MID_KontaEmail_IDX").HasFillFactor(100);

            entity.HasIndex(e => new { e.MidMflid, e.MidMkeid }, "MID_MFLID_IDX").HasFillFactor(100);

            entity.HasIndex(e => e.MidMwdid, "MID_MWDID_IDX").HasFillFactor(100);

            entity.HasIndex(e => e.MidServerId, "MID_ServerId_IDX").HasFillFactor(100);

            entity.HasIndex(e => e.MidUidl, "MID_UIDL_IDX").HasFillFactor(100);

            entity.Property(e => e.MidDoUsuniecia).HasColumnName("MID_DoUsuniecia");
            entity.Property(e => e.MidImapIdentity)
                .HasMaxLength(200)
                .HasColumnName("MID_ImapIdentity");
            entity.Property(e => e.MidImapuid).HasColumnName("MID_IMAPUID");
            entity.Property(e => e.MidMflid).HasColumnName("MID_MFLID");
            entity.Property(e => e.MidMfliddocelowy).HasColumnName("MID_MFLIDDocelowy");
            entity.Property(e => e.MidMkeid).HasColumnName("MID_MKEID");
            entity.Property(e => e.MidMwdid).HasColumnName("MID_MWDID");
            entity.Property(e => e.MidOdebrano)
                .HasColumnType("datetime")
                .HasColumnName("MID_Odebrano");
            entity.Property(e => e.MidServerId)
                .HasMaxLength(200)
                .HasColumnName("MID_ServerId");
            entity.Property(e => e.MidUidl)
                .HasMaxLength(200)
                .HasColumnName("MID_UIDL");

            entity.HasOne(d => d.MidMfl).WithMany()
                .HasForeignKey(d => d.MidMflid)
                .HasConstraintName("FK_MID_MailFoldery");

            entity.HasOne(d => d.MidMke).WithMany()
                .HasForeignKey(d => d.MidMkeid)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK_MID_MailKontaEMail");

            entity.HasOne(d => d.MidMwd).WithMany()
                .HasForeignKey(d => d.MidMwdid)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("FK_MID_Wiadomosci");
        });

        modelBuilder.Entity<MailKontaCertyfikaty>(entity =>
        {
            entity.HasKey(e => e.MkcMkcid)
                .HasName("MKC_Primary")
                .HasFillFactor(100);

            entity.ToTable("MailKontaCertyfikaty", "CDN");

            entity.Property(e => e.MkcMkcid).HasColumnName("MKC_MKCID");
            entity.Property(e => e.MkcCertyfikat)
                .IsUnicode(false)
                .HasColumnName("MKC_Certyfikat");
            entity.Property(e => e.MkcCertyfikatNazwa)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("MKC_CertyfikatNazwa");
            entity.Property(e => e.MkcMkeid).HasColumnName("MKC_MKEID");

            entity.HasOne(d => d.MkcMke).WithMany(p => p.MailKontaCertyfikaties)
                .HasForeignKey(d => d.MkcMkeid)
                .HasConstraintName("FK_MKC_MKE");
        });

        modelBuilder.Entity<MailKontaEmail>(entity =>
        {
            entity.HasKey(e => e.MkeMkeid)
                .HasName("MKE_Primary")
                .HasFillFactor(100);

            entity.ToTable("MailKontaEMail", "CDN", tb =>
                {
                    tb.HasTrigger("MailKontaEmail_DeleteHandler");
                    tb.HasTrigger("MailKontaEmail_InsertHandler");
                    tb.HasTrigger("MailKontaEmail_UpdateHandler");
                });

            entity.HasIndex(e => e.MkeNazwa, "KontaEMail_Nazwa")
                .IsUnique()
                .HasFillFactor(100);

            entity.Property(e => e.MkeMkeid).HasColumnName("MKE_MKEID");
            entity.Property(e => e.MkeBezpieczneUwierzytelnianie).HasColumnName("MKE_BezpieczneUwierzytelnianie");
            entity.Property(e => e.MkeEmail)
                .HasMaxLength(50)
                .HasColumnName("MKE_EMail");
            entity.Property(e => e.MkeHaslo).HasColumnName("MKE_Haslo");
            entity.Property(e => e.MkeImapUsuwanie).HasColumnName("MKE_ImapUsuwanie");
            entity.Property(e => e.MkeImapUsuwanieOkres).HasColumnName("MKE_ImapUsuwanieOkres");
            entity.Property(e => e.MkeImapUsuwanieTs)
                .HasColumnType("datetime")
                .HasColumnName("MKE_ImapUsuwanieTS");
            entity.Property(e => e.MkeNazwa)
                .HasMaxLength(50)
                .HasColumnName("MKE_Nazwa");
            entity.Property(e => e.MkeNieWyswietlaj).HasColumnName("MKE_NieWyswietlaj");
            entity.Property(e => e.MkeNieaktywne).HasColumnName("MKE_Nieaktywne");
            entity.Property(e => e.MkeOdbieranieTs)
                .HasColumnType("datetime")
                .HasColumnName("MKE_OdbieranieTS");
            entity.Property(e => e.MkeOpeId).HasColumnName("MKE_OpeID");
            entity.Property(e => e.MkeOpisOd)
                .HasMaxLength(50)
                .HasColumnName("MKE_OpisOd");
            entity.Property(e => e.MkeOstatnieOdbieranie)
                .HasColumnType("datetime")
                .HasColumnName("MKE_OstatnieOdbieranie");
            entity.Property(e => e.MkeOstatnieWysylanie)
                .HasColumnType("datetime")
                .HasColumnName("MKE_OstatnieWysylanie");
            entity.Property(e => e.MkePodpisujEmail).HasColumnName("MKE_PodpisujEmail");
            entity.Property(e => e.MkePop3)
                .HasMaxLength(100)
                .HasColumnName("MKE_POP3");
            entity.Property(e => e.MkePop3port).HasColumnName("MKE_POP3Port");
            entity.Property(e => e.MkePop3ssl).HasColumnName("MKE_POP3SSL");
            entity.Property(e => e.MkePozostawNaSerwerze)
                .HasDefaultValue((byte)1)
                .HasColumnName("MKE_PozostawNaSerwerze");
            entity.Property(e => e.MkeProtokolTyp).HasColumnName("MKE_ProtokolTyp");
            entity.Property(e => e.MkeRefreshToken)
                .HasDefaultValue("")
                .HasColumnName("MKE_RefreshToken");
            entity.Property(e => e.MkeSmtp)
                .HasMaxLength(100)
                .HasColumnName("MKE_SMTP");
            entity.Property(e => e.MkeSmtpport).HasColumnName("MKE_SMTPPort");
            entity.Property(e => e.MkeSmtpssl).HasColumnName("MKE_SMTPSSL");
            entity.Property(e => e.MkeSmtpuwierzytelnianie).HasColumnName("MKE_SMTPUwierzytelnianie");
            entity.Property(e => e.MkeSynchronizacjaTs)
                .HasColumnType("datetime")
                .HasColumnName("MKE_SynchronizacjaTS");
            entity.Property(e => e.MkeTyp).HasColumnName("MKE_Typ");
            entity.Property(e => e.MkeUsuwajZserweraPrzyUsuwaniuZbazy).HasColumnName("MKE_UsuwajZSerweraPrzyUsuwaniuZBazy");
            entity.Property(e => e.MkeUwierzytelnianieSerwera).HasColumnName("MKE_UwierzytelnianieSerwera");
            entity.Property(e => e.MkeUzytkownik)
                .HasMaxLength(100)
                .HasColumnName("MKE_Uzytkownik");
            entity.Property(e => e.MkeWspieraUidl).HasColumnName("MKE_WspieraUIDL");
        });

        modelBuilder.Entity<MailPodpisy>(entity =>
        {
            entity.HasKey(e => e.MpdMpdid)
                .HasName("MPD_Primary")
                .HasFillFactor(100);

            entity.ToTable("MailPodpisy", "CDN");

            entity.Property(e => e.MpdMpdid).HasColumnName("MPD_MPDID");
            entity.Property(e => e.MpdDomyslny).HasColumnName("MPD_Domyslny");
            entity.Property(e => e.MpdNazwa)
                .HasMaxLength(50)
                .HasColumnName("MPD_Nazwa");
            entity.Property(e => e.MpdOpeId).HasColumnName("MPD_OpeID");
            entity.Property(e => e.MpdPodpis).HasColumnName("MPD_Podpis");
        });

        modelBuilder.Entity<MailSzablony>(entity =>
        {
            entity.HasKey(e => e.MszMszId)
                .HasName("MSz_Primary")
                .HasFillFactor(100);

            entity.ToTable("MailSzablony", "CDN");

            entity.HasIndex(e => new { e.MszNazwa, e.MszMszId }, "MSzWgNazwy")
                .IsUnique()
                .HasFillFactor(100);

            entity.Property(e => e.MszMszId).HasColumnName("MSz_MSzID");
            entity.Property(e => e.MszDo)
                .HasDefaultValue("")
                .HasColumnName("MSz_DO");
            entity.Property(e => e.MszDw)
                .HasDefaultValue("")
                .HasColumnName("MSz_DW");
            entity.Property(e => e.MszEdycja)
                .HasMaxLength(20)
                .HasColumnName("MSz_Edycja");
            entity.Property(e => e.MszGuid)
                .HasDefaultValueSql("(newid())")
                .HasColumnName("MSz_GUID");
            entity.Property(e => e.MszMkeid).HasColumnName("MSz_MKEID");
            entity.Property(e => e.MszNazwa)
                .HasMaxLength(100)
                .HasColumnName("MSz_Nazwa");
            entity.Property(e => e.MszOpeModId).HasColumnName("MSz_OpeModId");
            entity.Property(e => e.MszOpeModKod)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("MSz_OpeModKod");
            entity.Property(e => e.MszOpeModNazwisko)
                .HasMaxLength(50)
                .HasDefaultValue("")
                .HasColumnName("MSz_OpeModNazwisko");
            entity.Property(e => e.MszOpeZalId).HasColumnName("MSz_OpeZalId");
            entity.Property(e => e.MszOpeZalKod)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("MSz_OpeZalKod");
            entity.Property(e => e.MszOpeZalNazwisko)
                .HasMaxLength(50)
                .HasDefaultValue("")
                .HasColumnName("MSz_OpeZalNazwisko");
            entity.Property(e => e.MszOpis)
                .HasMaxLength(500)
                .HasColumnName("MSz_Opis");
            entity.Property(e => e.MszPredefiniowany).HasColumnName("MSz_Predefiniowany");
            entity.Property(e => e.MszTemat)
                .HasMaxLength(500)
                .HasColumnName("MSz_Temat");
            entity.Property(e => e.MszTresc).HasColumnName("MSz_Tresc");
            entity.Property(e => e.MszTrescHtml).HasColumnName("MSz_TrescHTML");
            entity.Property(e => e.MszTsMod)
                .HasColumnType("datetime")
                .HasColumnName("MSz_TS_Mod");
            entity.Property(e => e.MszTsZal)
                .HasColumnType("datetime")
                .HasColumnName("MSz_TS_Zal");
            entity.Property(e => e.MszTyp).HasColumnName("MSz_Typ");
            entity.Property(e => e.MszUdw)
                .HasDefaultValue("")
                .HasColumnName("MSz_UDW");
        });

        modelBuilder.Entity<MailSzablonyDomyslne>(entity =>
        {
            entity.HasKey(e => new { e.MszDProcId, e.MszDOpeId, e.MszDTyp })
                .HasName("MSzD_Primary")
                .HasFillFactor(100);

            entity.ToTable("MailSzablonyDomyslne", "CDN");

            entity.Property(e => e.MszDProcId).HasColumnName("MSzD_ProcID");
            entity.Property(e => e.MszDOpeId).HasColumnName("MSzD_OpeID");
            entity.Property(e => e.MszDTyp).HasColumnName("MSzD_Typ");
            entity.Property(e => e.MszDMszId).HasColumnName("MSzD_MSzID");

            entity.HasOne(d => d.MszDMsz).WithMany(p => p.MailSzablonyDomyslnes)
                .HasForeignKey(d => d.MszDMszId)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK_MSzDMSz");
        });

        modelBuilder.Entity<MailSzablonyPodlaczenium>(entity =>
        {
            entity.HasKey(e => new { e.MszPProcId, e.MszPMszId })
                .HasName("MSzP_Primary")
                .HasFillFactor(100);

            entity.ToTable("MailSzablonyPodlaczenia", "CDN");

            entity.Property(e => e.MszPProcId).HasColumnName("MSzP_ProcID");
            entity.Property(e => e.MszPMszId).HasColumnName("MSzP_MSzID");
            entity.Property(e => e.MszPTyp).HasColumnName("MSzP_Typ");

            entity.HasOne(d => d.MszPMsz).WithMany(p => p.MailSzablonyPodlaczenia)
                .HasForeignKey(d => d.MszPMszId)
                .HasConstraintName("FK_MSzPMSz");
        });

        modelBuilder.Entity<MailUzytkownicyKont>(entity =>
        {
            entity.HasKey(e => e.MukMukid)
                .HasName("MUK_Primary")
                .HasFillFactor(100);

            entity.ToTable("MailUzytkownicyKont", "CDN");

            entity.HasIndex(e => e.MukMkeid, "Muk_KontaEMail").HasFillFactor(100);

            entity.Property(e => e.MukMukid).HasColumnName("MUK_MUKID");
            entity.Property(e => e.MukDomyslne).HasColumnName("MUK_Domyslne");
            entity.Property(e => e.MukMkeid).HasColumnName("MUK_MKEID");
            entity.Property(e => e.MukOpeId).HasColumnName("MUK_OpeID");

            entity.HasOne(d => d.MukMke).WithMany(p => p.MailUzytkownicyKonts)
                .HasForeignKey(d => d.MukMkeid)
                .HasConstraintName("FK_Muk_KontaEMail");
        });

        modelBuilder.Entity<MailWatek>(entity =>
        {
            entity.HasKey(e => e.MwaMwaid)
                .HasName("MWA_Primary")
                .HasFillFactor(100);

            entity.ToTable("MailWatek", "CDN");

            entity.Property(e => e.MwaMwaid).HasColumnName("MWA_MWAID");
            entity.Property(e => e.MwaDomyslny).HasColumnName("MWA_Domyslny");
            entity.Property(e => e.MwaWatek)
                .HasMaxLength(20)
                .HasColumnName("MWA_Watek");
        });

        modelBuilder.Entity<MailWiadomosci>(entity =>
        {
            entity.HasKey(e => e.MwdMwdid)
                .HasName("MWD_Primary")
                .HasFillFactor(100);

            entity.ToTable("MailWiadomosci", "CDN", tb =>
                {
                    tb.HasTrigger("MailWiadomosci_Delete_Trigger");
                    tb.HasTrigger("MailWiadomosci_InsertUpdate_Trigger");
                    tb.HasTrigger("MailWiadomosci_Insert_Trigger");
                });

            entity.HasIndex(e => e.MwdBazaGuid, "IX_MWD_BazaGUID").HasFillFactor(100);

            entity.HasIndex(e => e.MwdMkeid, "IX_MWD_MKEID").HasFillFactor(100);

            entity.HasIndex(e => e.MwdWatekString, "IX_MWD_WatekString").HasFillFactor(100);

            entity.HasIndex(e => e.MwdIdwiadomosci, "MWD_IDWiadomosci_IDX").HasFillFactor(100);

            entity.HasIndex(e => e.MwdImapIdentity, "MWD_ImapIdentity_IDX").HasFillFactor(100);

            entity.HasIndex(e => e.MwdMkeid, "MWD_KontaEMail").HasFillFactor(100);

            entity.HasIndex(e => new { e.MwdOdebrano, e.MwdMwdid, e.MwdMkeid }, "MWD_Odebrano_IDX")
                .IsDescending(true, true, false)
                .HasFillFactor(100);

            entity.HasIndex(e => e.MwdOpeId, "MWD_Operatorzy").HasFillFactor(100);

            entity.HasIndex(e => new { e.MwdStatus, e.MwdOpeId }, "MWD_Statusy").HasFillFactor(100);

            entity.HasIndex(e => e.MwdWatek, "MWD_Watek_IDX").HasFillFactor(100);

            entity.HasIndex(e => new { e.MwdWyslano, e.MwdMwdid, e.MwdMkeid }, "MWD_Wyslano_IDX")
                .IsDescending(true, true, false)
                .HasFillFactor(100);

            entity.HasIndex(e => new { e.MwdNumerString, e.MwdNumerNr }, "MailWaidomosci_NumerDok")
                .IsUnique()
                .HasFillFactor(100);

            entity.Property(e => e.MwdMwdid).HasColumnName("MWD_MWDID");
            entity.Property(e => e.MwdAdresaci).HasColumnName("MWD_Adresaci");
            entity.Property(e => e.MwdArchiwum).HasColumnName("MWD_Archiwum");
            entity.Property(e => e.MwdBazaGuid).HasColumnName("MWD_BazaGUID");
            entity.Property(e => e.MwdDataDok)
                .HasColumnType("datetime")
                .HasColumnName("MWD_DataDok");
            entity.Property(e => e.MwdDdfId).HasColumnName("MWD_DDfID");
            entity.Property(e => e.MwdDoWiadomosci).HasColumnName("MWD_DoWiadomosci");
            entity.Property(e => e.MwdFlaga).HasColumnName("MWD_Flaga");
            entity.Property(e => e.MwdFormat).HasColumnName("MWD_Format");
            entity.Property(e => e.MwdIdwiadomosci)
                .HasDefaultValueSql("(newid())")
                .HasColumnName("MWD_IDWiadomosci");
            entity.Property(e => e.MwdImapIdentity)
                .HasMaxLength(200)
                .HasColumnName("MWD_ImapIdentity");
            entity.Property(e => e.MwdImapTylkoNaglowek).HasColumnName("MWD_ImapTylkoNaglowek");
            entity.Property(e => e.MwdMkeid).HasColumnName("MWD_MKEID");
            entity.Property(e => e.MwdNumerNr).HasColumnName("MWD_NumerNr");
            entity.Property(e => e.MwdNumerPelny)
                .HasMaxLength(30)
                .HasComputedColumnSql("([CDN].[FN_NUMERPELNY]([MWD_NUMERNR],[MWD_NUMERSTRING]))", false)
                .HasColumnName("MWD_NumerPelny");
            entity.Property(e => e.MwdNumerString)
                .HasMaxLength(31)
                .HasColumnName("MWD_NumerString");
            entity.Property(e => e.MwdObjId).HasColumnName("MWD_ObjId");
            entity.Property(e => e.MwdObjSubType).HasColumnName("MWD_ObjSubType");
            entity.Property(e => e.MwdObjType).HasColumnName("MWD_ObjType");
            entity.Property(e => e.MwdOd)
                .HasMaxLength(200)
                .HasColumnName("MWD_Od");
            entity.Property(e => e.MwdOdebrano)
                .HasColumnType("datetime")
                .HasColumnName("MWD_Odebrano");
            entity.Property(e => e.MwdOdebranoData)
                .HasComputedColumnSql("(CONVERT([datetime],floor(CONVERT([decimal](12,5),[MWD_Odebrano],(0))),(0)))", false)
                .HasColumnType("datetime")
                .HasColumnName("MWD_OdebranoData");
            entity.Property(e => e.MwdOdpowiedzDo).HasColumnName("MWD_OdpowiedzDo");
            entity.Property(e => e.MwdOpeId).HasColumnName("MWD_OpeID");
            entity.Property(e => e.MwdParId).HasColumnName("MWD_ParID");
            entity.Property(e => e.MwdPodmiotAdresatId).HasColumnName("MWD_PodmiotAdresatID");
            entity.Property(e => e.MwdPodmiotAdresatKod)
                .HasMaxLength(20)
                .HasColumnName("MWD_PodmiotAdresatKod");
            entity.Property(e => e.MwdPodmiotAdresatNazwa)
                .HasMaxLength(50)
                .HasColumnName("MWD_PodmiotAdresatNazwa");
            entity.Property(e => e.MwdPodmiotAdresatTyp).HasColumnName("MWD_PodmiotAdresatTyp");
            entity.Property(e => e.MwdPodmiotDotyczyId).HasColumnName("MWD_PodmiotDotyczyID");
            entity.Property(e => e.MwdPodmiotDotyczyKod)
                .HasMaxLength(20)
                .HasColumnName("MWD_PodmiotDotyczyKod");
            entity.Property(e => e.MwdPodmiotDotyczyNazwa)
                .HasMaxLength(50)
                .HasColumnName("MWD_PodmiotDotyczyNazwa");
            entity.Property(e => e.MwdPodmiotDotyczyTyp).HasColumnName("MWD_PodmiotDotyczyTyp");
            entity.Property(e => e.MwdPodpis).HasColumnName("MWD_Podpis");
            entity.Property(e => e.MwdPodpisTyp).HasColumnName("MWD_PodpisTyp");
            entity.Property(e => e.MwdPotwierdzenie).HasColumnName("MWD_Potwierdzenie");
            entity.Property(e => e.MwdPriorytet).HasColumnName("MWD_Priorytet");
            entity.Property(e => e.MwdProcId).HasColumnName("MWD_ProcId");
            entity.Property(e => e.MwdRozmiar).HasColumnName("MWD_Rozmiar");
            entity.Property(e => e.MwdSerwerId)
                .HasMaxLength(200)
                .HasColumnName("MWD_SerwerID");
            entity.Property(e => e.MwdSourceMessageId)
                .HasMaxLength(200)
                .HasColumnName("MWD_SourceMessageID");
            entity.Property(e => e.MwdStatus).HasColumnName("MWD_Status");
            entity.Property(e => e.MwdTemat)
                .HasMaxLength(500)
                .HasColumnName("MWD_Temat");
            entity.Property(e => e.MwdTematTresc)
                .HasMaxLength(500)
                .HasComputedColumnSql("([CDN].[MailWiadomosciTematTresc]([MWD_Temat]))", true)
                .HasColumnName("MWD_TematTresc");
            entity.Property(e => e.MwdTresc).HasColumnName("MWD_Tresc");
            entity.Property(e => e.MwdTrescHtml).HasColumnName("MWD_TrescHTML");
            entity.Property(e => e.MwdTypDokumentu).HasColumnName("MWD_TypDokumentu");
            entity.Property(e => e.MwdTypWiadomosci).HasColumnName("MWD_TypWiadomosci");
            entity.Property(e => e.MwdUkrytyDw).HasColumnName("MWD_UkrytyDW");
            entity.Property(e => e.MwdWatek)
                .HasMaxLength(100)
                .HasColumnName("MWD_Watek");
            entity.Property(e => e.MwdWatekNr).HasColumnName("MWD_WatekNr");
            entity.Property(e => e.MwdWatekString)
                .HasMaxLength(100)
                .HasColumnName("MWD_WatekString");
            entity.Property(e => e.MwdWindykacja).HasColumnName("MWD_Windykacja");
            entity.Property(e => e.MwdWyslano)
                .HasColumnType("datetime")
                .HasColumnName("MWD_Wyslano");
            entity.Property(e => e.MwdWyslanoData)
                .HasComputedColumnSql("(CONVERT([datetime],floor(CONVERT([decimal](12,5),[MWD_Wyslano],(0))),(0)))", false)
                .HasColumnType("datetime")
                .HasColumnName("MWD_WyslanoData");
            entity.Property(e => e.MwdZalaczniki).HasColumnName("MWD_Zalaczniki");

            entity.HasOne(d => d.MwdMke).WithMany(p => p.MailWiadomoscis)
                .HasForeignKey(d => d.MwdMkeid)
                .HasConstraintName("FK_Mwd_KontaEMail");
        });

        modelBuilder.Entity<MailWiadomosciHistorium>(entity =>
        {
            entity.HasKey(e => e.MwhMwhid)
                .HasName("MWH_Primary")
                .HasFillFactor(100);

            entity.ToTable("MailWiadomosciHistoria", "CDN");

            entity.HasIndex(e => e.MwhMwdid, "MWH_Wiadomosci").HasFillFactor(100);

            entity.Property(e => e.MwhMwhid).HasColumnName("MWH_MWHID");
            entity.Property(e => e.MwhAkcja)
                .HasMaxLength(100)
                .HasColumnName("MWH_Akcja");
            entity.Property(e => e.MwhData)
                .HasColumnType("datetime")
                .HasColumnName("MWH_Data");
            entity.Property(e => e.MwhKomentarz)
                .HasMaxLength(1000)
                .HasColumnName("MWH_Komentarz");
            entity.Property(e => e.MwhMwdid).HasColumnName("MWH_MWDID");
            entity.Property(e => e.MwhOperatorWykonujacy)
                .HasMaxLength(20)
                .HasColumnName("MWH_OperatorWykonujacy");

            entity.HasOne(d => d.MwhMwd).WithMany(p => p.MailWiadomosciHistoria)
                .HasForeignKey(d => d.MwhMwdid)
                .HasConstraintName("FK_MWH_Wiadomosci");
        });

        modelBuilder.Entity<MailWiadomosciPrzeczytane>(entity =>
        {
            entity.HasKey(e => e.MwpMwpid)
                .HasName("MWP_Primary")
                .HasFillFactor(100);

            entity.ToTable("MailWiadomosciPrzeczytane", "CDN");

            entity.HasIndex(e => e.MwpOpeId, "MWP_Operator").HasFillFactor(100);

            entity.HasIndex(e => new { e.MwpMwdid, e.MwpOpeId }, "MWP_UniqueValues")
                .IsUnique()
                .HasFillFactor(100);

            entity.HasIndex(e => e.MwpMwdid, "MWP_Wiadomosc").HasFillFactor(100);

            entity.Property(e => e.MwpMwpid).HasColumnName("MWP_MWPID");
            entity.Property(e => e.MwpMwdid).HasColumnName("MWP_MWDID");
            entity.Property(e => e.MwpOpeId).HasColumnName("MWP_OpeID");
            entity.Property(e => e.MwpPrzeczytane).HasColumnName("MWP_Przeczytane");

            entity.HasOne(d => d.MwpMwd).WithMany(p => p.MailWiadomosciPrzeczytanes)
                .HasForeignKey(d => d.MwpMwdid)
                .HasConstraintName("FK_MWP_Wiadomosc");
        });

        modelBuilder.Entity<Miastum>(entity =>
        {
            entity.HasKey(e => e.MstMstId)
                .HasName("Mst_Primary")
                .HasFillFactor(100);

            entity.ToTable("Miasta", "CDN");

            entity.HasIndex(e => new { e.MstWojewodztwo, e.MstPowiat, e.MstGmina, e.MstNazwa }, "MstJednAdm")
                .IsUnique()
                .HasFillFactor(100);

            entity.Property(e => e.MstMstId).HasColumnName("Mst_MstID");
            entity.Property(e => e.MstGmina).HasColumnName("Mst_Gmina");
            entity.Property(e => e.MstNazwa)
                .HasMaxLength(127)
                .HasColumnName("Mst_Nazwa");
            entity.Property(e => e.MstPowiat).HasColumnName("Mst_Powiat");
            entity.Property(e => e.MstWojewodztwo).HasColumnName("Mst_Wojewodztwo");
        });

        modelBuilder.Entity<OfertyFrag>(entity =>
        {
            entity.HasKey(e => e.OfeOfeId)
                .HasName("Ofe_Primary")
                .HasFillFactor(100);

            entity.ToTable("OfertyFrag", "CDN");

            entity.HasIndex(e => new { e.OfeTyp, e.OfeNazwa }, "OfeTyp")
                .IsUnique()
                .HasFillFactor(100);

            entity.Property(e => e.OfeOfeId).HasColumnName("Ofe_OfeID");
            entity.Property(e => e.OfeBody).HasColumnName("Ofe_Body");
            entity.Property(e => e.OfeNazwa)
                .HasMaxLength(255)
                .HasColumnName("Ofe_Nazwa");
            entity.Property(e => e.OfeText).HasColumnName("Ofe_Text");
            entity.Property(e => e.OfeTyp)
                .HasMaxLength(50)
                .HasColumnName("Ofe_Typ");
        });

        modelBuilder.Entity<OfertySzablony>(entity =>
        {
            entity.HasKey(e => e.OfdSzaOfdSzaId)
                .HasName("OfdSza_Primary")
                .HasFillFactor(100);

            entity.ToTable("OfertySzablony", "CDN");

            entity.Property(e => e.OfdSzaOfdSzaId).HasColumnName("OfdSza_OfdSzaId");
            entity.Property(e => e.OfdSzaBody).HasColumnName("OfdSza_Body");
            entity.Property(e => e.OfdSzaKopiaEl).HasColumnName("OfdSza_KopiaEl");
            entity.Property(e => e.OfdSzaNazwa)
                .HasMaxLength(50)
                .HasColumnName("OfdSza_Nazwa");
            entity.Property(e => e.OfdSzaPodpisCyfrowy).HasColumnName("OfdSza_PodpisCyfrowy");
            entity.Property(e => e.OfdSzaSystemowy).HasColumnName("OfdSza_Systemowy");
        });

        modelBuilder.Entity<OfertySzablonyDomyslne>(entity =>
        {
            entity.HasKey(e => e.OfdSdOfdSdid)
                .HasName("OfdSD_Primary")
                .HasFillFactor(100);

            entity.ToTable("OfertySzablonyDomyslne", "CDN");

            entity.Property(e => e.OfdSdOfdSdid).HasColumnName("OfdSD_OfdSDId");
            entity.Property(e => e.OfdSdOfdSzaId).HasColumnName("OfdSD_OfdSzaId");
            entity.Property(e => e.OfdSdOpeId).HasColumnName("OfdSD_OpeId");

            entity.HasOne(d => d.OfdSdOfdSza).WithMany(p => p.OfertySzablonyDomyslnes)
                .HasForeignKey(d => d.OfdSdOfdSzaId)
                .HasConstraintName("FK_OfdSD_OfdSza");

            entity.HasOne(d => d.OfdSdOpe).WithMany(p => p.OfertySzablonyDomyslnes)
                .HasForeignKey(d => d.OfdSdOpeId)
                .HasConstraintName("FK_OfdSD_Ope");
        });

        modelBuilder.Entity<OpMailKontaEmail>(entity =>
        {
            entity.HasKey(e => e.SyncId).HasName("DF_OP_MailKontaEmailPrimary");

            entity.ToTable("OP_MailKontaEmail", "EP_SyncFramework");

            entity.Property(e => e.SyncId).HasColumnName("Sync_ID");
            entity.Property(e => e.Akcja).HasDefaultValue((byte)1);
            entity.Property(e => e.Ts)
                .HasDefaultValueSql("(datediff(second,CONVERT([datetime],'2011-01-01',(120)),getdate()))")
                .HasColumnName("TS");
        });

        modelBuilder.Entity<OpMailUzytkownicyKont>(entity =>
        {
            entity.HasKey(e => e.SyncId).HasName("DF_OP_MailUzytkownicyKontPrimary");

            entity.ToTable("OP_MailUzytkownicyKont", "EP_SyncFramework");

            entity.Property(e => e.SyncId).HasColumnName("Sync_ID");
            entity.Property(e => e.Akcja).HasDefaultValue((byte)1);
            entity.Property(e => e.Ts)
                .HasDefaultValueSql("(datediff(second,CONVERT([datetime],'2011-01-01',(120)),getdate()))")
                .HasColumnName("TS");
        });

        modelBuilder.Entity<OpSyncStatus>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("OP_SyncStatus", "EP_SyncFramework");

            entity.Property(e => e.EpMaxFullSyncId).HasColumnName("EP_MaxFullSyncId");
            entity.Property(e => e.EpMaxMapaId).HasColumnName("EP_MaxMapaId");
            entity.Property(e => e.EpMaxSyncedId).HasColumnName("EP_MaxSyncedId");
            entity.Property(e => e.NazwaTabeli).HasDefaultValue("");
            entity.Property(e => e.OpMaxMapaId).HasColumnName("OP_MaxMapaId");
            entity.Property(e => e.OpMaxSyncedId).HasColumnName("OP_MaxSyncedId");
        });

        modelBuilder.Entity<OpeInfoBaza>(entity =>
        {
            entity.HasKey(e => e.OibOibid)
                .HasName("OIB_Primary")
                .HasFillFactor(100);

            entity.ToTable("OpeInfoBaza", "CDN");

            entity.HasIndex(e => e.OibBazId, "OIBBazy").HasFillFactor(100);

            entity.HasIndex(e => new { e.OibOpeId, e.OibBazId }, "OIBOperator")
                .IsUnique()
                .HasFillFactor(100);

            entity.Property(e => e.OibOibid).HasColumnName("OIB_OIBId");
            entity.Property(e => e.OibBazId).HasColumnName("OIB_BazId");
            entity.Property(e => e.OibData)
                .HasColumnType("datetime")
                .HasColumnName("OIB_Data");
            entity.Property(e => e.OibOpeId).HasColumnName("OIB_OpeId");

            entity.HasOne(d => d.OibBaz).WithMany(p => p.OpeInfoBazas)
                .HasForeignKey(d => d.OibBazId)
                .HasConstraintName("FK_OIBBazy");

            entity.HasOne(d => d.OibOpe).WithMany(p => p.OpeInfoBazas)
                .HasForeignKey(d => d.OibOpeId)
                .HasConstraintName("FK_OIBOperator");
        });

        modelBuilder.Entity<OpeInformacje>(entity =>
        {
            entity.HasKey(e => e.OpIOpIid)
                .HasName("OpI_Primary")
                .HasFillFactor(100);

            entity.ToTable("OpeInformacje", "CDN");

            entity.HasIndex(e => e.OpIBazId, "OpIBazy").HasFillFactor(100);

            entity.HasIndex(e => e.OpIInfId, "OpIInformacje").HasFillFactor(100);

            entity.HasIndex(e => new { e.OpIOpeId, e.OpIInfId, e.OpIBazId }, "OpIOperator")
                .IsUnique()
                .HasFillFactor(100);

            entity.Property(e => e.OpIOpIid).HasColumnName("OpI_OpIId");
            entity.Property(e => e.OpIBazId).HasColumnName("OpI_BazId");
            entity.Property(e => e.OpIInfId).HasColumnName("OpI_InfId");
            entity.Property(e => e.OpIKanal).HasColumnName("OpI_Kanal");
            entity.Property(e => e.OpIOpeId).HasColumnName("OpI_OpeId");

            entity.HasOne(d => d.OpIInf).WithMany(p => p.OpeInformacjes)
                .HasForeignKey(d => d.OpIInfId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_OpIInformacje");

            entity.HasOne(d => d.OpIOpe).WithMany(p => p.OpeInformacjes)
                .HasForeignKey(d => d.OpIOpeId)
                .HasConstraintName("FK_OpIOperator");
        });

        modelBuilder.Entity<OpeListaZadan>(entity =>
        {
            entity.HasKey(e => e.OpZOpZid)
                .HasName("OpZ_Primary")
                .HasFillFactor(100);

            entity.ToTable("OpeListaZadan", "CDN");

            entity.HasIndex(e => new { e.OpZTermin, e.OpZOpeId, e.OpZWykonane }, "OlzDoWykonania").HasFillFactor(100);

            entity.HasIndex(e => new { e.OpZOpeId, e.OpZWykonane, e.OpZDataWykonania }, "OlzWykonane").HasFillFactor(100);

            entity.Property(e => e.OpZOpZid).HasColumnName("OpZ_OpZId");
            entity.Property(e => e.OpZAutomat).HasColumnName("OpZ_Automat");
            entity.Property(e => e.OpZBazId).HasColumnName("OpZ_BazId");
            entity.Property(e => e.OpZBazaGuid).HasColumnName("OpZ_BazaGUID");
            entity.Property(e => e.OpZDataWykonania)
                .HasColumnType("datetime")
                .HasColumnName("OpZ_DataWykonania");
            entity.Property(e => e.OpZGrupowanie)
                .HasComputedColumnSql("(case when [OpZ_Wykonane]=(1) then (99) else [cdn].[TodayOrWeekOrMonth]([OpZ_Termin]) end)", false)
                .HasColumnName("OpZ_Grupowanie");
            entity.Property(e => e.OpZLp).HasColumnName("OpZ_Lp");
            entity.Property(e => e.OpZOpeId).HasColumnName("OpZ_OpeId");
            entity.Property(e => e.OpZOpeModId).HasColumnName("OpZ_OpeModId");
            entity.Property(e => e.OpZOpeModKod)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("OpZ_OpeModKod");
            entity.Property(e => e.OpZOpeModNazwisko)
                .HasMaxLength(50)
                .HasColumnName("OpZ_OpeModNazwisko");
            entity.Property(e => e.OpZOpeZalId).HasColumnName("OpZ_OpeZalId");
            entity.Property(e => e.OpZOpeZalKod)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("OpZ_OpeZalKod");
            entity.Property(e => e.OpZOpeZalNazwisko)
                .HasMaxLength(50)
                .HasColumnName("OpZ_OpeZalNazwisko");
            entity.Property(e => e.OpZOpis)
                .HasMaxLength(1024)
                .HasColumnName("OpZ_Opis");
            entity.Property(e => e.OpZPanelInfo).HasColumnName("OpZ_PanelInfo");
            entity.Property(e => e.OpZParentId).HasColumnName("OpZ_ParentId");
            entity.Property(e => e.OpZPodzadanie).HasColumnName("OpZ_Podzadanie");
            entity.Property(e => e.OpZPokazTermin).HasColumnName("OpZ_PokazTermin");
            entity.Property(e => e.OpZStaModId).HasColumnName("OpZ_StaModId");
            entity.Property(e => e.OpZStaZalId).HasColumnName("OpZ_StaZalId");
            entity.Property(e => e.OpZSzablonId).HasColumnName("OpZ_SzablonId");
            entity.Property(e => e.OpZTermin)
                .HasColumnType("datetime")
                .HasColumnName("OpZ_Termin");
            entity.Property(e => e.OpZTsMod)
                .HasColumnType("datetime")
                .HasColumnName("OpZ_TS_Mod");
            entity.Property(e => e.OpZTsZal)
                .HasColumnType("datetime")
                .HasColumnName("OpZ_TS_Zal");
            entity.Property(e => e.OpZWykonane).HasColumnName("OpZ_Wykonane");
            entity.Property(e => e.OpZZlecajacyId).HasColumnName("OpZ_ZlecajacyId");
        });

        modelBuilder.Entity<OpeListaZadanGenerator>(entity =>
        {
            entity.HasKey(e => e.OpZgOpZgid)
                .HasName("OpZG_Primary")
                .HasFillFactor(100);

            entity.ToTable("OpeListaZadanGenerator", "CDN");

            entity.HasIndex(e => e.OpZgTerminZadania, "OpZGDate").HasFillFactor(100);

            entity.Property(e => e.OpZgOpZgid).HasColumnName("OpZG_OpZGId");
            entity.Property(e => e.OpZgBazId).HasColumnName("OpZG_BazId");
            entity.Property(e => e.OpZgBazaGuid).HasColumnName("OpZG_BazaGUID");
            entity.Property(e => e.OpZgDataGen)
                .HasColumnType("datetime")
                .HasColumnName("OpZG_DataGen");
            entity.Property(e => e.OpZgOpeId).HasColumnName("OpZG_OpeId");
            entity.Property(e => e.OpZgSzablonId).HasColumnName("OpZG_SzablonId");
            entity.Property(e => e.OpZgTerminZadania)
                .HasColumnType("datetime")
                .HasColumnName("OpZG_TerminZadania");
        });

        modelBuilder.Entity<OpeListaZadanSzablony>(entity =>
        {
            entity.HasKey(e => e.OpZsOpZsid)
                .HasName("OpZS_Primary")
                .HasFillFactor(100);

            entity.ToTable("OpeListaZadanSzablony", "CDN");

            entity.Property(e => e.OpZsOpZsid).HasColumnName("OpZS_OpZSId");
            entity.Property(e => e.OpZsCykl).HasColumnName("OpZS_Cykl");
            entity.Property(e => e.OpZsCyklCo).HasColumnName("OpZS_CyklCo");
            entity.Property(e => e.OpZsCyklDzien).HasColumnName("OpZS_CyklDzien");
            entity.Property(e => e.OpZsCyklStart)
                .HasColumnType("datetime")
                .HasColumnName("OpZS_CyklStart");
            entity.Property(e => e.OpZsDlaEwid).HasColumnName("OpZS_DlaEwid");
            entity.Property(e => e.OpZsDlaKh).HasColumnName("OpZS_DlaKH");
            entity.Property(e => e.OpZsDlaKp).HasColumnName("OpZS_DlaKP");
            entity.Property(e => e.OpZsNieaktywny).HasColumnName("OpZS_Nieaktywny");
            entity.Property(e => e.OpZsOpeModId).HasColumnName("OpZS_OpeModId");
            entity.Property(e => e.OpZsOpeModKod)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("OpZS_OpeModKod");
            entity.Property(e => e.OpZsOpeModNazwisko)
                .HasMaxLength(50)
                .HasColumnName("OpZS_OpeModNazwisko");
            entity.Property(e => e.OpZsOpeZalId).HasColumnName("OpZS_OpeZalId");
            entity.Property(e => e.OpZsOpeZalKod)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("OpZS_OpeZalKod");
            entity.Property(e => e.OpZsOpeZalNazwisko)
                .HasMaxLength(50)
                .HasColumnName("OpZS_OpeZalNazwisko");
            entity.Property(e => e.OpZsOpis)
                .HasMaxLength(1024)
                .HasColumnName("OpZS_Opis");
            entity.Property(e => e.OpZsStaModId).HasColumnName("OpZS_StaModId");
            entity.Property(e => e.OpZsStaZalId).HasColumnName("OpZS_StaZalId");
            entity.Property(e => e.OpZsTsMod)
                .HasColumnType("datetime")
                .HasColumnName("OpZS_TS_Mod");
            entity.Property(e => e.OpZsTsZal)
                .HasColumnType("datetime")
                .HasColumnName("OpZS_TS_Zal");
        });

        modelBuilder.Entity<OpeListaZadanSzablonyBazy>(entity =>
        {
            entity.HasKey(e => e.OpZsbOpZsbid)
                .HasName("OpZSB_Primary")
                .HasFillFactor(100);

            entity.ToTable("OpeListaZadanSzablonyBazy", "CDN");

            entity.Property(e => e.OpZsbOpZsbid).HasColumnName("OpZSB_OpZSBId");
            entity.Property(e => e.OpZsbBazId).HasColumnName("OpZSB_BazId");
            entity.Property(e => e.OpZsbBazaGuid).HasColumnName("OpZSB_BazaGUID");
            entity.Property(e => e.OpZsbLp).HasColumnName("OpZSB_Lp");
            entity.Property(e => e.OpZsbOpeId).HasColumnName("OpZSB_OpeId");
            entity.Property(e => e.OpZsbSzablonId).HasColumnName("OpZSB_SzablonId");

            entity.HasOne(d => d.OpZsbSzablon).WithMany(p => p.OpeListaZadanSzablonyBazies)
                .HasForeignKey(d => d.OpZsbSzablonId)
                .HasConstraintName("FK_OPZSB_Szablon");
        });

        modelBuilder.Entity<OpeListaZadanSzablonyElem>(entity =>
        {
            entity.HasKey(e => e.OpZseOpZseid)
                .HasName("OpZSE_Primary")
                .HasFillFactor(100);

            entity.ToTable("OpeListaZadanSzablonyElem", "CDN");

            entity.Property(e => e.OpZseOpZseid).HasColumnName("OpZSE_OpZSEId");
            entity.Property(e => e.OpZseLp).HasColumnName("OpZSE_Lp");
            entity.Property(e => e.OpZseOpis)
                .HasMaxLength(1024)
                .HasColumnName("OpZSE_Opis");
            entity.Property(e => e.OpZseSzablonId).HasColumnName("OpZSE_SzablonId");

            entity.HasOne(d => d.OpZseSzablon).WithMany(p => p.OpeListaZadanSzablonyElems)
                .HasForeignKey(d => d.OpZseSzablonId)
                .HasConstraintName("FK_OPZSE_Szablon");
        });

        modelBuilder.Entity<OpeUstawienium>(entity =>
        {
            entity.HasKey(e => e.OpUOpUid)
                .HasName("OpU_Primary")
                .HasFillFactor(100);

            entity.ToTable("OpeUstawienia", "CDN");

            entity.HasIndex(e => new { e.OpUOpeId, e.OpUTyp, e.OpUIndeks }, "OpUOperator")
                .IsUnique()
                .HasFillFactor(100);

            entity.Property(e => e.OpUOpUid).HasColumnName("OpU_OpUID");
            entity.Property(e => e.OpUIndeks)
                .HasMaxLength(30)
                .HasColumnName("OpU_Indeks");
            entity.Property(e => e.OpUOpeId).HasColumnName("OpU_OpeId");
            entity.Property(e => e.OpUTyp).HasColumnName("OpU_Typ");
            entity.Property(e => e.OpUWartosc)
                .HasMaxLength(256)
                .HasColumnName("OpU_Wartosc");

            entity.HasOne(d => d.OpUOpe).WithMany(p => p.OpeUstawienia)
                .HasForeignKey(d => d.OpUOpeId)
                .HasConstraintName("FK_OpUOperator");
        });

        modelBuilder.Entity<Operatorzy>(entity =>
        {
            entity.HasKey(e => e.OpeOpeId)
                .HasName("Ope_Primary")
                .HasFillFactor(100);

            entity.ToTable("Operatorzy", "CDN", tb =>
                {
                    tb.HasTrigger("Operatorzy_Delete_Trigger");
                    tb.HasTrigger("Operatorzy_Insert_Trigger");
                    tb.HasTrigger("Operatorzy_Update_TS_Zgody");
                    tb.HasTrigger("Operatorzy_Update_Trigger");
                });

            entity.HasIndex(e => new { e.OpeGidtyp, e.OpeGidfirma, e.OpeGidnumer }, "OpeGID").HasFillFactor(100);

            entity.HasIndex(e => e.OpeKod, "OpeKod")
                .IsUnique()
                .HasFillFactor(100);

            entity.Property(e => e.OpeOpeId).HasColumnName("Ope_OpeID");
            entity.Property(e => e.OpeAdministrator).HasColumnName("Ope_Administrator");
            entity.Property(e => e.OpeAkceptacjaDelegacji).HasColumnName("Ope_AkceptacjaDelegacji");
            entity.Property(e => e.OpeAktualizacjaKntHaMag).HasColumnName("Ope_AktualizacjaKntHaMag");
            entity.Property(e => e.OpeAnalizyBiAdministrator).HasColumnName("Ope_AnalizyBI_Administrator");
            entity.Property(e => e.OpeAnalizyBiDodawaniePol).HasColumnName("Ope_AnalizyBI_DodawaniePol");
            entity.Property(e => e.OpeAnalizyBiDrukowanie).HasColumnName("Ope_AnalizyBI_Drukowanie");
            entity.Property(e => e.OpeAnalizyBiEksport).HasColumnName("Ope_AnalizyBI_Eksport");
            entity.Property(e => e.OpeAnalizyBiImportRaportu).HasColumnName("Ope_AnalizyBI_ImportRaportu");
            entity.Property(e => e.OpeAnalizyBiModyfikacjaZapytania).HasColumnName("Ope_AnalizyBI_ModyfikacjaZapytania");
            entity.Property(e => e.OpeAnalizyBiSubskrypcje).HasColumnName("Ope_AnalizyBI_Subskrypcje");
            entity.Property(e => e.OpeAnkietyDostepDoAnkietInnychOperatorow).HasColumnName("Ope_AnkietyDostepDoAnkietInnychOperatorow");
            entity.Property(e => e.OpeAnkietyPrawoDoOdblokowaniaAnkietyZatwierdzonej).HasColumnName("Ope_AnkietyPrawoDoOdblokowaniaAnkietyZatwierdzonej");
            entity.Property(e => e.OpeApfinoPrawoDoPrzekazywaniaFaktur).HasColumnName("Ope_Apfino_PrawoDoPrzekazywaniaFaktur");
            entity.Property(e => e.OpeApfinoPrawoDoSprawdzaniaKntWrejDluzn).HasColumnName("Ope_Apfino_PrawoDoSprawdzaniaKntWRejDluzn");
            entity.Property(e => e.OpeApfinoPrawoDoZglaszaniaFinansowania).HasColumnName("Ope_Apfino_PrawoDoZglaszaniaFinansowania");
            entity.Property(e => e.OpeApfinoPrawoDoZglaszaniaWindykacji).HasColumnName("Ope_Apfino_PrawoDoZglaszaniaWindykacji");
            entity.Property(e => e.OpeAutoUruchamianieKalkulatora).HasColumnName("Ope_AutoUruchamianieKalkulatora");
            entity.Property(e => e.OpeAutomatyczneWysylanieFakturDoKseF).HasColumnName("Ope_AutomatyczneWysylanieFakturDoKSeF");
            entity.Property(e => e.OpeBank)
                .HasMaxLength(20)
                .HasDefaultValue("")
                .HasColumnName("Ope_Bank");
            entity.Property(e => e.OpeBlokadaAnulNieobecIzestCzas).HasColumnName("Ope_BlokadaAnulNieobecIZestCzas");
            entity.Property(e => e.OpeBlokadaAnulWyplaty).HasColumnName("Ope_BlokadaAnulWyplaty");
            entity.Property(e => e.OpeBlokadaAnulowaniaHaMag).HasColumnName("Ope_BlokadaAnulowaniaHaMag");
            entity.Property(e => e.OpeBlokadaCzasuPracy).HasColumnName("OPE_BlokadaCzasuPracy");
            entity.Property(e => e.OpeBlokadaDanychPlacowych).HasColumnName("Ope_BlokadaDanychPlacowych");
            entity.Property(e => e.OpeBlokadaDanychPlacowychStawka).HasColumnName("Ope_BlokadaDanychPlacowychStawka");
            entity.Property(e => e.OpeBlokadaDokMmzMagMob)
                .HasDefaultValue((byte)1)
                .HasColumnName("Ope_BlokadaDokMMzMagMob");
            entity.Property(e => e.OpeBlokadaFapadoBufora).HasColumnName("Ope_BlokadaFAPAdoBufora");
            entity.Property(e => e.OpeBlokadaPlac).HasColumnName("Ope_BlokadaPlac");
            entity.Property(e => e.OpeBlokadaPonownejFiskFapa).HasColumnName("Ope_BlokadaPonownejFiskFAPA");
            entity.Property(e => e.OpeBlokadaSeryjnegoUsuwania).HasColumnName("Ope_BlokadaSeryjnegoUsuwania");
            entity.Property(e => e.OpeBlokadaTylkoWynagrodzen).HasColumnName("Ope_BlokadaTylkoWynagrodzen");
            entity.Property(e => e.OpeBlokadaVatDoVat7)
                .HasDefaultValue((byte)1)
                .HasColumnName("Ope_BlokadaVatDoVat7");
            entity.Property(e => e.OpeBlokadaZmianCenFa).HasColumnName("Ope_BlokadaZmianCenFA");
            entity.Property(e => e.OpeBlokadaZmianCenFpf).HasColumnName("Ope_BlokadaZmianCenFPF");
            entity.Property(e => e.OpeBlokadaZmianCenFz).HasColumnName("Ope_BlokadaZmianCenFZ");
            entity.Property(e => e.OpeBlokadaZmianCenPa).HasColumnName("Ope_BlokadaZmianCenPA");
            entity.Property(e => e.OpeBlokadaZmianCenRo).HasColumnName("Ope_BlokadaZmianCenRO");
            entity.Property(e => e.OpeBlokadaZmianCenZd).HasColumnName("Ope_BlokadaZmianCenZD");
            entity.Property(e => e.OpeBlokadaZmianMagazynu).HasColumnName("Ope_BlokadaZmianMagazynu");
            entity.Property(e => e.OpeBlokadaZmianMagazynuListy).HasColumnName("Ope_BlokadaZmianMagazynuListy");
            entity.Property(e => e.OpeBlokadaZmianTowaru).HasColumnName("Ope_BlokadaZmianTowaru");
            entity.Property(e => e.OpeBlokadaZmianyKwotyWplaty).HasColumnName("Ope_BlokadaZmianyKwotyWplaty");
            entity.Property(e => e.OpeBuforAmortyz).HasColumnName("Ope_BuforAmortyz");
            entity.Property(e => e.OpeBuforEwid).HasColumnName("Ope_BuforEwid");
            entity.Property(e => e.OpeBuforKasa).HasColumnName("Ope_BuforKasa");
            entity.Property(e => e.OpeBuforNazwa)
                .HasMaxLength(20)
                .HasColumnName("Ope_BuforNazwa");
            entity.Property(e => e.OpeBuforOkres).HasColumnName("Ope_BuforOkres");
            entity.Property(e => e.OpeBuforPlace).HasColumnName("Ope_BuforPlace");
            entity.Property(e => e.OpeBuforVatspr).HasColumnName("Ope_BuforVATSpr");
            entity.Property(e => e.OpeBuforVatzak).HasColumnName("Ope_BuforVATZak");
            entity.Property(e => e.OpeComarchPpk).HasColumnName("Ope_ComarchPPK");
            entity.Property(e => e.OpeCrmDostepDoZadanInnychOperatorowRo).HasColumnName("Ope_CRM_DostepDoZadanInnychOperatorowRO");
            entity.Property(e => e.OpeCrmUczestnikMaPrawoZmieniacZadanie).HasColumnName("Ope_CRM_UczestnikMaPrawoZmieniacZadanie");
            entity.Property(e => e.OpeDabId).HasColumnName("Ope_DabId");
            entity.Property(e => e.OpeDataRss)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("Ope_DataRSS");
            entity.Property(e => e.OpeDataZmianyHasla)
                .HasColumnType("datetime")
                .HasColumnName("Ope_DataZmianyHasla");
            entity.Property(e => e.OpeDetalFunkcjaPrac).HasColumnName("Ope_DetalFunkcjaPrac");
            entity.Property(e => e.OpeDostepDoKontInnychOperatorow).HasColumnName("Ope_DostepDoKontInnychOperatorow");
            entity.Property(e => e.OpeDostepDoSkrzynkiInnychOperatorow).HasColumnName("Ope_DostepDoSkrzynkiInnychOperatorow");
            entity.Property(e => e.OpeDostepDoZadanInnychOpe).HasColumnName("Ope_DostepDoZadanInnychOpe");
            entity.Property(e => e.OpeDziennikSymbolKomp)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("Ope_DziennikSymbolKomp");
            entity.Property(e => e.OpeDziennikSymbolRk)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("Ope_DziennikSymbolRK");
            entity.Property(e => e.OpeEmail)
                .HasMaxLength(254)
                .HasColumnName("Ope_Email");
            entity.Property(e => e.OpeGidfirma).HasColumnName("Ope_GIDFirma");
            entity.Property(e => e.OpeGidlp).HasColumnName("Ope_GIDLp");
            entity.Property(e => e.OpeGidnumer).HasColumnName("Ope_GIDNumer");
            entity.Property(e => e.OpeGidtyp).HasColumnName("Ope_GIDTyp");
            entity.Property(e => e.OpeHaslo)
                .HasMaxLength(64)
                .HasColumnName("Ope_Haslo");
            entity.Property(e => e.OpeHasloChk)
                .HasMaxLength(2)
                .HasColumnName("Ope_HasloChk");
            entity.Property(e => e.OpeHasloPm)
                .HasMaxLength(40)
                .HasColumnName("Ope_HasloPM");
            entity.Property(e => e.OpeHistTowUstawiajKntMag)
                .HasDefaultValue((byte)1)
                .HasColumnName("Ope_HistTowUstawiajKntMag");
            entity.Property(e => e.OpeHistTowUstawiajTypDok)
                .HasDefaultValue((byte)1)
                .HasColumnName("Ope_HistTowUstawiajTypDok");
            entity.Property(e => e.OpeIKsg24PrawoDoKorespondowaniaZklientamiBiura).HasColumnName("Ope_iKsg24_PrawoDoKorespondowaniaZKlientamiBiura");
            entity.Property(e => e.OpeIKsg24PrawoDoPrzegladaniaIdodawaniaKlientow).HasColumnName("Ope_iKsg24_PrawoDoPrzegladaniaIDodawaniaKlientow");
            entity.Property(e => e.OpeIbard24Haslo)
                .HasMaxLength(1024)
                .HasColumnName("Ope_IBard24Haslo");
            entity.Property(e => e.OpeIbard24Login)
                .HasMaxLength(255)
                .HasDefaultValue("")
                .HasColumnName("Ope_IBard24Login");
            entity.Property(e => e.OpeIbard24Wyloguj).HasColumnName("Ope_IBard24Wyloguj");
            entity.Property(e => e.OpeInfoData)
                .HasColumnType("datetime")
                .HasColumnName("Ope_InfoData");
            entity.Property(e => e.OpeInfoPoUruchomieniu).HasColumnName("Ope_InfoPoUruchomieniu");
            entity.Property(e => e.OpeInfoRazDziennie).HasColumnName("Ope_InfoRazDziennie");
            entity.Property(e => e.OpeKasa)
                .HasMaxLength(20)
                .HasColumnName("Ope_Kasa");
            entity.Property(e => e.OpeKierownik).HasColumnName("Ope_Kierownik");
            entity.Property(e => e.OpeKlasycznaKlawiatura).HasColumnName("Ope_KlasycznaKlawiatura");
            entity.Property(e => e.OpeKod)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("Ope_Kod");
            entity.Property(e => e.OpeKodDlaDf)
                .HasMaxLength(10)
                .HasColumnName("Ope_KodDlaDF");
            entity.Property(e => e.OpeKonfigProgressLoga).HasColumnName("Ope_KonfigProgressLoga");
            entity.Property(e => e.OpeKontoDomenowe)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("Ope_KontoDomenowe");
            entity.Property(e => e.OpeKontoDomenoweSid)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("Ope_KontoDomenoweSID");
            entity.Property(e => e.OpeKontrolaPlatnosciWz).HasColumnName("Ope_KontrolaPlatnosciWZ");
            entity.Property(e => e.OpeKopiaBezpieczenstwa)
                .HasDefaultValue((byte)0)
                .HasColumnName("Ope_KopiaBezpieczenstwa");
            entity.Property(e => e.OpeKotrolaCzesciPobranych).HasColumnName("Ope_KotrolaCzesciPobranych");
            entity.Property(e => e.OpeKrdPobieranieRaportow).HasColumnName("Ope_KRD_PobieranieRaportow");
            entity.Property(e => e.OpeKseFPrawoDoOdbieraniaeFaktur).HasColumnName("Ope_KSeF_PrawoDoOdbieraniaeFaktur");
            entity.Property(e => e.OpeKseFPrawoDoOdbieraniaeFakturSprzedazy).HasColumnName("Ope_KSeF_PrawoDoOdbieraniaeFakturSprzedazy");
            entity.Property(e => e.OpeKseFPrawoDoOdbieraniaeFakturZakupu)
                .HasDefaultValue((byte)1)
                .HasColumnName("Ope_KSeF_PrawoDoOdbieraniaeFakturZakupu");
            entity.Property(e => e.OpeKsiegaGlowna).HasColumnName("Ope_KsiegaGlowna");
            entity.Property(e => e.OpeListaZadanDodanoZadPowitalne).HasColumnName("Ope_ListaZadanDodanoZadPowitalne");
            entity.Property(e => e.OpeListaZadanDostepDoListyZadanInnychOpe).HasColumnName("Ope_ListaZadanDostepDoListyZadanInnychOpe");
            entity.Property(e => e.OpeListaZadanPrawoDoModZadanInnychOpe).HasColumnName("Ope_ListaZadanPrawoDoModZadanInnychOpe");
            entity.Property(e => e.OpeMagazyn)
                .HasMaxLength(20)
                .HasColumnName("Ope_Magazyn");
            entity.Property(e => e.OpeMinMarzaHaMag).HasColumnName("Ope_MinMarzaHaMag");
            entity.Property(e => e.OpeModulAnl).HasColumnName("Ope_ModulANL");
            entity.Property(e => e.OpeModulBiu).HasColumnName("Ope_ModulBIU");
            entity.Property(e => e.OpeModulCrm).HasColumnName("Ope_ModulCRM");
            entity.Property(e => e.OpeModulCrmp).HasColumnName("Ope_ModulCRMP");
            entity.Property(e => e.OpeModulDet).HasColumnName("Ope_ModulDET");
            entity.Property(e => e.OpeModulFa).HasColumnName("Ope_ModulFA");
            entity.Property(e => e.OpeModulHap).HasColumnName("Ope_ModulHAP");
            entity.Property(e => e.OpeModulKb).HasColumnName("Ope_ModulKB");
            entity.Property(e => e.OpeModulKbp).HasColumnName("Ope_ModulKBP");
            entity.Property(e => e.OpeModulKh).HasColumnName("Ope_ModulKH");
            entity.Property(e => e.OpeModulKhp).HasColumnName("Ope_ModulKHP");
            entity.Property(e => e.OpeModulKp).HasColumnName("Ope_ModulKP");
            entity.Property(e => e.OpeModulMag).HasColumnName("Ope_ModulMAG");
            entity.Property(e => e.OpeModulObd).HasColumnName("Ope_ModulOBD");
            entity.Property(e => e.OpeModulPk).HasColumnName("Ope_ModulPK");
            entity.Property(e => e.OpeModulPkxl).HasColumnName("Ope_ModulPKXL");
            entity.Property(e => e.OpeModulSrw).HasColumnName("Ope_ModulSRW");
            entity.Property(e => e.OpeModulSt).HasColumnName("Ope_ModulST");
            entity.Property(e => e.OpeModyfikacjaProcesow).HasColumnName("Ope_ModyfikacjaProcesow");
            entity.Property(e => e.OpeNazwaKomputera)
                .HasMaxLength(64)
                .HasColumnName("Ope_NazwaKomputera");
            entity.Property(e => e.OpeNazwisko)
                .HasMaxLength(50)
                .HasColumnName("Ope_Nazwisko");
            entity.Property(e => e.OpeNieaktywny).HasColumnName("Ope_Nieaktywny");
            entity.Property(e => e.OpeNowosciWwersji)
                .HasMaxLength(20)
                .HasColumnName("Ope_NowosciWWersji");
            entity.Property(e => e.OpeNtkonto)
                .HasMaxLength(40)
                .IsUnicode(false)
                .HasColumnName("Ope_NTKonto");
            entity.Property(e => e.OpeNtlogin).HasColumnName("Ope_NTLogin");
            entity.Property(e => e.OpeNtsid)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("Ope_NTSid");
            entity.Property(e => e.OpeNumerSms)
                .HasMaxLength(20)
                .HasColumnName("Ope_NumerSMS");
            entity.Property(e => e.OpeObdDlaOcrUdostepniajDomyslnie).HasColumnName("Ope_ObdDlaOcrUdostepniajDomyslnie");
            entity.Property(e => e.OpeOdblokowanieZlecen).HasColumnName("Ope_OdblokowanieZlecen");
            entity.Property(e => e.OpeOpeModId).HasColumnName("OPE_OpeModId");
            entity.Property(e => e.OpeOpeModKod)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("OPE_OpeModKod");
            entity.Property(e => e.OpeOpeModNazwisko)
                .HasMaxLength(50)
                .HasDefaultValue("")
                .HasColumnName("OPE_OpeModNazwisko");
            entity.Property(e => e.OpeOpeZalId).HasColumnName("OPE_OpeZalId");
            entity.Property(e => e.OpeOpeZalKod)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("OPE_OpeZalKod");
            entity.Property(e => e.OpeOpeZalNazwisko)
                .HasMaxLength(50)
                .HasDefaultValue("")
                .HasColumnName("OPE_OpeZalNazwisko");
            entity.Property(e => e.OpeOpis)
                .HasMaxLength(254)
                .HasColumnName("Ope_Opis");
            entity.Property(e => e.OpePanelAktualizacjeTsOstatnieOtwarcie)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("Ope_PanelAktualizacje_TS_OstatnieOtwarcie");
            entity.Property(e => e.OpePanelInformacjeTsOstatnieOtwarcie)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("Ope_PanelInformacje_TS_OstatnieOtwarcie");
            entity.Property(e => e.OpeParametr)
                .HasMaxLength(254)
                .HasColumnName("Ope_Parametr");
            entity.Property(e => e.OpePelneMenu).HasColumnName("Ope_PelneMenu");
            entity.Property(e => e.OpePlatnoscNaWz).HasColumnName("Ope_PlatnoscNaWZ");
            entity.Property(e => e.OpePlatnosciSprzedazBufor).HasColumnName("Ope_PlatnosciSprzedazBufor");
            entity.Property(e => e.OpePlatnosciSprzedazTrwaly).HasColumnName("Ope_PlatnosciSprzedazTrwaly");
            entity.Property(e => e.OpePokazOpisKontrahentaNaDokumentach)
                .HasDefaultValue((byte)1)
                .HasColumnName("Ope_PokazOpisKontrahentaNaDokumentach");
            entity.Property(e => e.OpePowiadamianie).HasColumnName("Ope_Powiadamianie");
            entity.Property(e => e.OpePrawoAnonimizacjiDanychOsobowych).HasColumnName("Ope_PrawoAnonimizacjiDanychOsobowych");
            entity.Property(e => e.OpePrawoDoChatErp).HasColumnName("Ope_PrawoDoChatERP");
            entity.Property(e => e.OpePrawoDoListyPropozycjiFakturCykl).HasColumnName("Ope_PrawoDoListyPropozycjiFakturCykl");
            entity.Property(e => e.OpePrawoDoOdblokowaniaEdeklaracji)
                .HasDefaultValue((byte)1)
                .HasColumnName("Ope_PrawoDoOdblokowaniaEDeklaracji");
            entity.Property(e => e.OpePrawoDoPobrCzesciMagLok).HasColumnName("Ope_PrawoDoPobrCzesciMagLok");
            entity.Property(e => e.OpePrawoDoPobrCzesciMagSerw).HasColumnName("Ope_PrawoDoPobrCzesciMagSerw");
            entity.Property(e => e.OpePrawoDoUdostPlikowObdDlaOcr).HasColumnName("Ope_PrawoDoUdostPlikowObdDlaOcr");
            entity.Property(e => e.OpePrawoDoZamianEfaktury).HasColumnName("Ope_PrawoDoZamianEFaktury");
            entity.Property(e => e.OpePrawoDostepuDoRejestrowRodo).HasColumnName("Ope_PrawoDostepuDoRejestrowRODO");
            entity.Property(e => e.OpePrawoEksportuJpk).HasColumnName("Ope_PrawoEksportuJPK");
            entity.Property(e => e.OpePrawoEksportuSprawozdanFinansowych).HasColumnName("Ope_PrawoEksportuSprawozdanFinansowych");
            entity.Property(e => e.OpePrawoGenerowaniaHaselPdf).HasColumnName("Ope_PrawoGenerowaniaHaselPDF");
            entity.Property(e => e.OpePrawoImportuZapKbotwRapKb).HasColumnName("Ope_PrawoImportuZapKBOtwRapKB");
            entity.Property(e => e.OpePrawoOdblokowaniaKontaktu).HasColumnName("Ope_PrawoOdblokowaniaKontaktu");
            entity.Property(e => e.OpePrawoScalaniaKnt).HasColumnName("Ope_PrawoScalaniaKnt");
            entity.Property(e => e.OpePrawoUsuwaniaMaili)
                .HasDefaultValue((byte)1)
                .HasColumnName("Ope_PrawoUsuwaniaMaili");
            entity.Property(e => e.OpePrawoZmianyZapKbzamRapKb).HasColumnName("Ope_PrawoZmianyZapKBZamRapKB");
            entity.Property(e => e.OpeRaportProgressLoga).HasColumnName("Ope_RaportProgressLoga");
            entity.Property(e => e.OpeRozliczanieZlistyHaMag).HasColumnName("Ope_RozliczanieZListyHaMag");
            entity.Property(e => e.OpeSsohash)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("Ope_SSOHash");
            entity.Property(e => e.OpeSsologin)
                .HasMaxLength(128)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("Ope_SSOLogin");
            entity.Property(e => e.OpeSsotoken)
                .HasMaxLength(1024)
                .IsUnicode(false)
                .HasColumnName("Ope_SSOToken");
            entity.Property(e => e.OpeStaModId).HasColumnName("OPE_StaModId");
            entity.Property(e => e.OpeStaZalId).HasColumnName("OPE_StaZalId");
            entity.Property(e => e.OpeStartowa).HasColumnName("Ope_Startowa");
            entity.Property(e => e.OpeSymbolDlaNumeracji)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("Ope_SymbolDlaNumeracji");
            entity.Property(e => e.OpeTelefon)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("Ope_Telefon");
            entity.Property(e => e.OpeTsMod)
                .HasColumnType("datetime")
                .HasColumnName("OPE_TS_Mod");
            entity.Property(e => e.OpeTsZal)
                .HasColumnType("datetime")
                .HasColumnName("OPE_TS_Zal");
            entity.Property(e => e.OpeTylkoStartowa).HasColumnName("Ope_TylkoStartowa");
            entity.Property(e => e.OpeUdostepnianieAnalWpodgladzie).HasColumnName("Ope_UdostepnianieAnalWPodgladzie");
            entity.Property(e => e.OpeUdostepnianieWydrukWpodgladzie).HasColumnName("Ope_UdostepnianieWydrukWPodgladzie");
            entity.Property(e => e.OpeUdostepnianieWydrukowBip).HasColumnName("Ope_UdostepnianieWydrukowBIP");
            entity.Property(e => e.OpeUproszczoneFakturowanie).HasColumnName("Ope_UproszczoneFakturowanie");
            entity.Property(e => e.OpeUwierzytelnienieZaPomocaToken).HasColumnName("Ope_UwierzytelnienieZaPomocaToken");
            entity.Property(e => e.OpeUzywaAnalizBi).HasColumnName("Ope_UzywaAnalizBI");
            entity.Property(e => e.OpeWyswietlajInformacje).HasColumnName("Ope_WyswietlajInformacje");
            entity.Property(e => e.OpeWyswietlajInformacjeTsMod)
                .HasColumnType("datetime")
                .HasColumnName("Ope_WyswietlajInformacje_TS_Mod");
            entity.Property(e => e.OpeWyswietlajOferteComarch)
                .HasDefaultValue((byte)1)
                .HasColumnName("Ope_WyswietlajOferteComarch");
            entity.Property(e => e.OpeWysylanieFakturDoKseF).HasColumnName("Ope_WysylanieFakturDoKSeF");
            entity.Property(e => e.OpeZakazCenyZak).HasColumnName("Ope_ZakazCenyZak");
            entity.Property(e => e.OpeZamkniecieDnia).HasColumnName("Ope_ZamkniecieDnia");
            entity.Property(e => e.OpeZapisFapapoWydruku).HasColumnName("Ope_ZapisFAPApoWydruku");
            entity.Property(e => e.OpeZapisWzpoWydruku).HasColumnName("Ope_ZapisWZpoWydruku");
            entity.Property(e => e.OpeZgodyPodmiotu).HasColumnName("Ope_ZgodyPodmiotu");
            entity.Property(e => e.OpeZmianaAtrNaZatwDok).HasColumnName("Ope_ZmianaAtrNaZatwDok");
            entity.Property(e => e.OpeZmianaKategorii).HasColumnName("Ope_ZmianaKategorii");
            entity.Property(e => e.OpeZmianaLimituKred).HasColumnName("Ope_ZmianaLimituKred");
            entity.Property(e => e.OpeZmianaOpisuHaMag).HasColumnName("Ope_ZmianaOpisuHaMag");
            entity.Property(e => e.OpeZmianaPoprzedniegoCzasu).HasColumnName("Ope_ZmianaPoprzedniegoCzasu");
            entity.Property(e => e.OpeZmianaProcesuDomyslnego).HasColumnName("Ope_ZmianaProcesuDomyslnego");
            entity.Property(e => e.OpeZmianyOffLine).HasColumnName("Ope_ZmianyOffLine");
        });

        modelBuilder.Entity<OrganizacjePp>(entity =>
        {
            entity.HasKey(e => e.OrgPpOrgPpid)
                .HasName("OrgPP_Primary")
                .HasFillFactor(100);

            entity.ToTable("OrganizacjePP", "CDN");

            entity.HasIndex(e => e.OrgPpNumerKrs, "UN_OrgPP_NumerKRS")
                .IsUnique()
                .HasFillFactor(100);

            entity.Property(e => e.OrgPpOrgPpid).HasColumnName("OrgPP_OrgPPID");
            entity.Property(e => e.OrgPpMiejscowosc)
                .HasMaxLength(240)
                .HasColumnName("OrgPP_Miejscowosc");
            entity.Property(e => e.OrgPpNazwa)
                .HasMaxLength(240)
                .HasColumnName("OrgPP_Nazwa");
            entity.Property(e => e.OrgPpNumerKrs)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("OrgPP_NumerKRS");
        });

        modelBuilder.Entity<PodpisCertyfikat>(entity =>
        {
            entity.HasKey(e => e.PcePceId)
                .HasName("PCe_Primary")
                .HasFillFactor(100);

            entity.ToTable("PodpisCertyfikat", "CDN");

            entity.Property(e => e.PcePceId).HasColumnName("PCe_PceId");
            entity.Property(e => e.PceNazwa)
                .HasMaxLength(255)
                .HasColumnName("PCe_Nazwa");
            entity.Property(e => e.PceObjId).HasColumnName("PCe_ObjId");
            entity.Property(e => e.PceOdciskPalca)
                .HasMaxLength(255)
                .HasColumnName("PCe_OdciskPalca");
            entity.Property(e => e.PceOpeId).HasColumnName("PCe_OpeId");
            entity.Property(e => e.PcePytanie).HasColumnName("PCe_Pytanie");
        });

        modelBuilder.Entity<ProZakazy>(entity =>
        {
            entity.HasKey(e => e.PzaPzaId)
                .HasName("PZa_Primary")
                .HasFillFactor(100);

            entity.ToTable("ProZakazy", "CDN");

            entity.HasIndex(e => new { e.PzaOpeId, e.PzaProcId }, "PZaOperator")
                .IsUnique()
                .HasFillFactor(100);

            entity.HasIndex(e => new { e.PzaProcId, e.PzaOpeId }, "PZaZakazy")
                .IsUnique()
                .HasFillFactor(100);

            entity.Property(e => e.PzaPzaId).HasColumnName("PZa_PZaID");
            entity.Property(e => e.PzaMaskaFormy).HasColumnName("PZa_MaskaFormy");
            entity.Property(e => e.PzaOpeId).HasColumnName("PZa_OpeID");
            entity.Property(e => e.PzaProcId).HasColumnName("PZa_ProcID");

            entity.HasOne(d => d.PzaOpe).WithMany(p => p.ProZakazies)
                .HasForeignKey(d => d.PzaOpeId)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK_PZaOperator");
        });

        modelBuilder.Entity<Rckategorie>(entity =>
        {
            entity.HasKey(e => e.RckRckid)
                .HasName("RCK_Primary")
                .HasFillFactor(100);

            entity.ToTable("RCKategorie", "CDN");

            entity.HasIndex(e => e.RckKod, "RCKKod")
                .IsUnique()
                .HasFillFactor(100);

            entity.Property(e => e.RckRckid).HasColumnName("RCK_RCKId");
            entity.Property(e => e.RckKod)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("RCK_Kod");
            entity.Property(e => e.RckNazwa)
                .HasMaxLength(50)
                .HasColumnName("RCK_Nazwa");
            entity.Property(e => e.RckStawka)
                .HasColumnType("decimal(15, 2)")
                .HasColumnName("RCK_Stawka");
        });

        modelBuilder.Entity<Rcsesje>(entity =>
        {
            entity.HasKey(e => e.RcsRcsid)
                .HasName("RCS_Primary")
                .HasFillFactor(100);

            entity.ToTable("RCSesje", "CDN");

            entity.HasIndex(e => e.RcsRckid, "RSCKategoria").HasFillFactor(100);

            entity.Property(e => e.RcsRcsid).HasColumnName("RCS_RCSId");
            entity.Property(e => e.RcsAktywna).HasColumnName("RCS_Aktywna");
            entity.Property(e => e.RcsBazId).HasColumnName("RCS_BazId");
            entity.Property(e => e.RcsOpeId).HasColumnName("RCS_OpeId");
            entity.Property(e => e.RcsRckid).HasColumnName("RCS_RCKId");
            entity.Property(e => e.RcsReczna).HasColumnName("RCS_Reczna");
            entity.Property(e => e.RcsStaId).HasColumnName("RCS_StaId");
            entity.Property(e => e.RcsTsStart)
                .HasColumnType("datetime")
                .HasColumnName("RCS_TS_Start");
            entity.Property(e => e.RcsTsStop)
                .HasColumnType("datetime")
                .HasColumnName("RCS_TS_Stop");

            entity.HasOne(d => d.RcsBaz).WithMany(p => p.Rcsesjes)
                .HasForeignKey(d => d.RcsBazId)
                .HasConstraintName("FK_RCSBaza");

            entity.HasOne(d => d.RcsOpe).WithMany(p => p.Rcsesjes)
                .HasForeignKey(d => d.RcsOpeId)
                .HasConstraintName("FK_RCSOperator");

            entity.HasOne(d => d.RcsRck).WithMany(p => p.Rcsesjes)
                .HasForeignKey(d => d.RcsRckid)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_RSCKategoria");

            entity.HasOne(d => d.RcsSta).WithMany(p => p.Rcsesjes)
                .HasForeignKey(d => d.RcsStaId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_RCSStanowisko");
        });

        modelBuilder.Entity<RejestrOperacji>(entity =>
        {
            entity.HasKey(e => e.RopRopid)
                .HasName("ROP_Primary")
                .HasFillFactor(100);

            entity.ToTable("RejestrOperacji", "CDN");

            entity.HasIndex(e => new { e.RopObiektId, e.RopObiektTyp }, "ROP_IdTypObiektu").HasFillFactor(100);

            entity.Property(e => e.RopRopid).HasColumnName("ROP_ROPID");
            entity.Property(e => e.RopData)
                .HasColumnType("datetime")
                .HasColumnName("ROP_Data");
            entity.Property(e => e.RopObiektId).HasColumnName("ROP_ObiektID");
            entity.Property(e => e.RopObiektNazwa)
                .HasMaxLength(100)
                .HasColumnName("ROP_ObiektNazwa");
            entity.Property(e => e.RopObiektSubTyp).HasColumnName("ROP_ObiektSubTyp");
            entity.Property(e => e.RopObiektTyp).HasColumnName("ROP_ObiektTyp");
            entity.Property(e => e.RopOperacjaTyp).HasColumnName("ROP_OperacjaTyp");
            entity.Property(e => e.RopOperator)
                .HasMaxLength(50)
                .HasColumnName("ROP_Operator");
            entity.Property(e => e.RopOpis)
                .HasMaxLength(1000)
                .HasColumnName("ROP_Opis");
        });

        modelBuilder.Entity<RejestrOperacjiTypyObiektow>(entity =>
        {
            entity.HasKey(e => new { e.RoptobTyp, e.RoptobSubTyp, e.RoptobJezyk })
                .HasName("ROPTOb_Primary")
                .HasFillFactor(100);

            entity.ToTable("RejestrOperacjiTypyObiektow", "CDN");

            entity.Property(e => e.RoptobTyp).HasColumnName("ROPTOb_Typ");
            entity.Property(e => e.RoptobSubTyp).HasColumnName("ROPTOb_SubTyp");
            entity.Property(e => e.RoptobJezyk)
                .HasDefaultValue(1045)
                .HasColumnName("ROPTOb_Jezyk");
            entity.Property(e => e.RoptobNazwa)
                .HasMaxLength(100)
                .HasColumnName("ROPTOb_Nazwa");
        });

        modelBuilder.Entity<RejestrOperacjiTypyOperacji>(entity =>
        {
            entity.HasKey(e => new { e.RoptopTyp, e.RoptopJezyk })
                .HasName("ROPTOp_Primary")
                .HasFillFactor(100);

            entity.ToTable("RejestrOperacjiTypyOperacji", "CDN");

            entity.Property(e => e.RoptopTyp).HasColumnName("ROPTOp_Typ");
            entity.Property(e => e.RoptopJezyk)
                .HasDefaultValue(1045)
                .HasColumnName("ROPTOp_Jezyk");
            entity.Property(e => e.RoptopNazwa)
                .HasMaxLength(100)
                .HasColumnName("ROPTOp_Nazwa");
        });

        modelBuilder.Entity<SekEtapOperatorzy>(entity =>
        {
            entity.HasKey(e => e.SeoSeoid)
                .HasName("SEO_Primary")
                .HasFillFactor(100);

            entity.ToTable("SekEtapOperatorzy", "CDN", tb => tb.HasTrigger("SekEtapOperatorzy_InsertUpdateDelete_Trigger"));

            entity.HasIndex(e => new { e.SeoSeid, e.SeoSeoid }, "SEOEtap")
                .IsUnique()
                .HasFillFactor(100);

            entity.HasIndex(e => new { e.SeoOpeId, e.SeoSeid }, "SEOOperator")
                .IsUnique()
                .HasFillFactor(100);

            entity.Property(e => e.SeoSeoid).HasColumnName("SEO_SEOID");
            entity.Property(e => e.SeoOpeId).HasColumnName("SEO_OpeID");
            entity.Property(e => e.SeoSeid).HasColumnName("SEO_SEID");

            entity.HasOne(d => d.SeoOpe).WithMany(p => p.SekEtapOperatorzies)
                .HasForeignKey(d => d.SeoOpeId)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK_SEOOperator");

            entity.HasOne(d => d.SeoSe).WithMany(p => p.SekEtapOperatorzies)
                .HasForeignKey(d => d.SeoSeid)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK_SEOEtap");
        });

        modelBuilder.Entity<SekEtapy>(entity =>
        {
            entity.HasKey(e => e.SeSeid)
                .HasName("SE_Primary")
                .HasFillFactor(100);

            entity.ToTable("SekEtapy", "CDN", tb => tb.HasTrigger("SekEtapy_InsertUpdateDelete_Trigger"));

            entity.HasIndex(e => e.SeSymbol, "SESymbol")
                .IsUnique()
                .HasFillFactor(100);

            entity.Property(e => e.SeSeid).HasColumnName("SE_SEID");
            entity.Property(e => e.SeCzyDomyslnyCzasRealizacji).HasColumnName("SE_CzyDomyslnyCzasRealizacji");
            entity.Property(e => e.SeCzyKomentarzNieobowiazkowy).HasColumnName("SE_CzyKomentarzNieobowiazkowy");
            entity.Property(e => e.SeDomyslnyCzasRealizacji).HasColumnName("SE_DomyslnyCzasRealizacji");
            entity.Property(e => e.SeNazwa)
                .HasMaxLength(255)
                .HasColumnName("SE_Nazwa");
            entity.Property(e => e.SeSymbol)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("SE_Symbol");
        });

        modelBuilder.Entity<SekSchemEtapy>(entity =>
        {
            entity.HasKey(e => e.SseSseid)
                .HasName("SSE_Primary")
                .HasFillFactor(100);

            entity.ToTable("SekSchemEtapy", "CDN", tb => tb.HasTrigger("SekSchemEtapy_InsertUpdateDelete_Trigger"));

            entity.HasIndex(e => new { e.SseSeid, e.SseSseid }, "SSEEtap")
                .IsUnique()
                .HasFillFactor(100);

            entity.HasIndex(e => new { e.SseSsid, e.SseLp, e.SsePoziom, e.SseSseid }, "SSELp")
                .IsUnique()
                .HasFillFactor(100);

            entity.HasIndex(e => new { e.SseSsid, e.SseSseid }, "SSESchemat")
                .IsUnique()
                .HasFillFactor(100);

            entity.Property(e => e.SseSseid).HasColumnName("SSE_SSEID");
            entity.Property(e => e.SseLp).HasColumnName("SSE_Lp");
            entity.Property(e => e.SseObowiazkowy).HasColumnName("SSE_Obowiazkowy");
            entity.Property(e => e.SsePoziom).HasColumnName("SSE_Poziom");
            entity.Property(e => e.SseSeid).HasColumnName("SSE_SEID");
            entity.Property(e => e.SseSsid).HasColumnName("SSE_SSID");

            entity.HasOne(d => d.SseSe).WithMany(p => p.SekSchemEtapies)
                .HasForeignKey(d => d.SseSeid)
                .HasConstraintName("FK_SSEEtap");

            entity.HasOne(d => d.SseSs).WithMany(p => p.SekSchemEtapies)
                .HasForeignKey(d => d.SseSsid)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK_SSESchemat");
        });

        modelBuilder.Entity<SekSchemEtapyKolejne>(entity =>
        {
            entity.HasKey(e => e.SsekSsekid)
                .HasName("SSEK_Primary")
                .HasFillFactor(100);

            entity.ToTable("SekSchemEtapyKolejne", "CDN");

            entity.HasIndex(e => new { e.SsekSseid, e.SsekSsekid }, "SSEKElem")
                .IsUnique()
                .HasFillFactor(100);

            entity.HasIndex(e => new { e.SsekSseidkolejny, e.SsekSsekid }, "SSEKEtap")
                .IsUnique()
                .HasFillFactor(100);

            entity.Property(e => e.SsekSsekid).HasColumnName("SSEK_SSEKID");
            entity.Property(e => e.SsekSseid).HasColumnName("SSEK_SSEID");
            entity.Property(e => e.SsekSseidkolejny).HasColumnName("SSEK_SSEIDKolejny");

            entity.HasOne(d => d.SsekSse).WithMany(p => p.SekSchemEtapyKolejnes)
                .HasForeignKey(d => d.SsekSseid)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK_SSEKElem");
        });

        modelBuilder.Entity<SekSchematy>(entity =>
        {
            entity.HasKey(e => e.SsSsid)
                .HasName("SS_Primary")
                .HasFillFactor(100);

            entity.ToTable("SekSchematy", "CDN", tb =>
                {
                    tb.HasTrigger("SekSchematy_InsertUpdateDelete_Trigger");
                    tb.HasTrigger("SekSchematy_delete_Trigger");
                });

            entity.HasIndex(e => e.SsKod, "SSKod")
                .IsUnique()
                .HasFillFactor(100);

            entity.Property(e => e.SsSsid).HasColumnName("SS_SSID");
            entity.Property(e => e.SsKod)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("SS_Kod");
            entity.Property(e => e.SsNazwa)
                .HasMaxLength(50)
                .HasColumnName("SS_Nazwa");
            entity.Property(e => e.SsNieaktywny).HasColumnName("SS_Nieaktywny");
        });

        modelBuilder.Entity<SerwerBackup>(entity =>
        {
            entity.HasKey(e => e.SbcSbcId)
                .HasName("SBC_Primary")
                .HasFillFactor(100);

            entity.ToTable("SerwerBackup", "CDN");

            entity.HasIndex(e => e.SbcSerwer, "SBcSerwer")
                .IsUnique()
                .HasFillFactor(100);

            entity.Property(e => e.SbcSbcId).HasColumnName("SBc_SBcID");
            entity.Property(e => e.SbcHaslo)
                .HasMaxLength(256)
                .HasColumnName("SBc_Haslo");
            entity.Property(e => e.SbcNt).HasColumnName("SBc_NT");
            entity.Property(e => e.SbcSerwer)
                .HasMaxLength(256)
                .HasColumnName("SBc_Serwer");
            entity.Property(e => e.SbcUzytkownik)
                .HasMaxLength(256)
                .HasColumnName("SBc_Uzytkownik");
        });

        modelBuilder.Entity<Sm>(entity =>
        {
            entity.HasKey(e => e.SmsSmsId)
                .HasName("SMS_Primary")
                .IsClustered(false)
                .HasFillFactor(100);

            entity.ToTable("Sms", "CDN", tb =>
                {
                    tb.HasTrigger("SMS_Delete_Trigger");
                    tb.HasTrigger("SMS_Insert_Trigger");
                });

            entity.HasIndex(e => e.SmsStatus, "SMS_Statusy").HasFillFactor(100);

            entity.Property(e => e.SmsSmsId).HasColumnName("SMS_SmsId");
            entity.Property(e => e.SmsBazaGuid).HasColumnName("SMS_BazaGUID");
            entity.Property(e => e.SmsDataDok)
                .HasColumnType("datetime")
                .HasColumnName("SMS_DataDok");
            entity.Property(e => e.SmsIdNadawcy).HasColumnName("SMS_IdNadawcy");
            entity.Property(e => e.SmsIdwiadomosci)
                .HasDefaultValueSql("(newid())")
                .HasColumnName("SMS_IDWiadomosci");
            entity.Property(e => e.SmsNazwaNadawcy)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("SMS_NazwaNadawcy");
            entity.Property(e => e.SmsObjId).HasColumnName("SMS_ObjId");
            entity.Property(e => e.SmsObjSubType).HasColumnName("SMS_ObjSubType");
            entity.Property(e => e.SmsObjType).HasColumnName("SMS_ObjType");
            entity.Property(e => e.SmsOpeModId).HasColumnName("SMS_OpeModId");
            entity.Property(e => e.SmsOpeModKod)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("Sms_OpeModKod");
            entity.Property(e => e.SmsOpeModNazwisko)
                .HasMaxLength(50)
                .HasDefaultValue("")
                .HasColumnName("Sms_OpeModNazwisko");
            entity.Property(e => e.SmsOpeZalId).HasColumnName("SMS_OpeZalId");
            entity.Property(e => e.SmsOpeZalKod)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("Sms_OpeZalKod");
            entity.Property(e => e.SmsOpeZalNazwisko)
                .HasMaxLength(50)
                .HasDefaultValue("")
                .HasColumnName("Sms_OpeZalNazwisko");
            entity.Property(e => e.SmsPodmiotAdresatId).HasColumnName("SMS_PodmiotAdresatID");
            entity.Property(e => e.SmsPodmiotAdresatKod)
                .HasMaxLength(20)
                .HasColumnName("SMS_PodmiotAdresatKod");
            entity.Property(e => e.SmsPodmiotAdresatNazwa)
                .HasMaxLength(50)
                .HasColumnName("SMS_PodmiotAdresatNazwa");
            entity.Property(e => e.SmsPodmiotAdresatTyp).HasColumnName("SMS_PodmiotAdresatTyp");
            entity.Property(e => e.SmsProcId).HasColumnName("SMS_ProcId");
            entity.Property(e => e.SmsPrzedstawicielId).HasColumnName("SMS_PrzedstawicielId");
            entity.Property(e => e.SmsStaModId).HasColumnName("SMS_StaModId");
            entity.Property(e => e.SmsStaZalId).HasColumnName("SMS_StaZalId");
            entity.Property(e => e.SmsStatus).HasColumnName("SMS_Status");
            entity.Property(e => e.SmsSzablonId).HasColumnName("SMS_SzablonId");
            entity.Property(e => e.SmsTelefon)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("SMS_Telefon");
            entity.Property(e => e.SmsTresc)
                .HasMaxLength(1024)
                .HasColumnName("SMS_Tresc");
            entity.Property(e => e.SmsTsMod)
                .HasColumnType("datetime")
                .HasColumnName("SMS_TS_Mod");
            entity.Property(e => e.SmsTsZal)
                .HasColumnType("datetime")
                .HasColumnName("SMS_TS_Zal");
            entity.Property(e => e.SmsWindykacja).HasColumnName("SMS_Windykacja");
            entity.Property(e => e.SmsWyslano)
                .HasColumnType("datetime")
                .HasColumnName("SMS_Wyslano");
            entity.Property(e => e.SmsWyslanoUtf8).HasColumnName("Sms_WyslanoUTF8");
        });

        modelBuilder.Entity<SoaLog>(entity =>
        {
            entity.HasKey(e => e.SloGSlogId)
                .HasName("SloG_Primary")
                .HasFillFactor(100);

            entity.ToTable("SoaLogs", "CDN");

            entity.HasIndex(e => e.SloGDatabaseGuid, "SloG_DatabaseGuidIndex").HasFillFactor(100);

            entity.HasIndex(e => e.SloGDate, "SloG_LogDateIndex").HasFillFactor(100);

            entity.HasIndex(e => e.SloGParentId, "SloG_ParentIdIndex").HasFillFactor(100);

            entity.HasIndex(e => e.SloGServiceId, "SloG_ServiceIdIndex").HasFillFactor(100);

            entity.Property(e => e.SloGSlogId).HasColumnName("SloG_SlogId");
            entity.Property(e => e.SloGDatabaseGuid)
                .HasMaxLength(36)
                .IsUnicode(false)
                .HasColumnName("SloG_DatabaseGuid");
            entity.Property(e => e.SloGDatabaseName)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("SloG_DatabaseName");
            entity.Property(e => e.SloGDate)
                .HasColumnType("datetime")
                .HasColumnName("SloG_Date");
            entity.Property(e => e.SloGException).HasColumnName("SloG_Exception");
            entity.Property(e => e.SloGLevel)
                .HasMaxLength(50)
                .HasColumnName("SloG_Level");
            entity.Property(e => e.SloGLogger)
                .HasMaxLength(1024)
                .HasColumnName("SloG_Logger");
            entity.Property(e => e.SloGMessage).HasColumnName("SloG_Message");
            entity.Property(e => e.SloGParentId).HasColumnName("SloG_ParentId");
            entity.Property(e => e.SloGServiceId).HasColumnName("SloG_ServiceId");
            entity.Property(e => e.SloGServiceName)
                .HasMaxLength(512)
                .HasColumnName("SloG_ServiceName");
            entity.Property(e => e.SloGSession).HasColumnName("SloG_Session");
            entity.Property(e => e.SloGThread)
                .HasMaxLength(255)
                .HasColumnName("SloG_Thread");
            entity.Property(e => e.SloGUser)
                .HasMaxLength(512)
                .HasColumnName("SloG_User");
        });

        modelBuilder.Entity<StanowiskaKomp>(entity =>
        {
            entity.HasKey(e => e.StaStaId)
                .HasName("Sta_Primary")
                .HasFillFactor(100);

            entity.ToTable("StanowiskaKomp", "CDN");

            entity.HasIndex(e => e.StaNazwa, "StaNazwa")
                .IsUnique()
                .HasFillFactor(100);

            entity.Property(e => e.StaStaId).HasColumnName("Sta_StaID");
            entity.Property(e => e.StaNazwa)
                .HasMaxLength(254)
                .HasColumnName("Sta_Nazwa");
        });

        modelBuilder.Entity<Statystyki>(entity =>
        {
            entity.HasKey(e => e.SttSttId)
                .HasName("Stt_Primary")
                .HasFillFactor(100);

            entity.ToTable("Statystyki", "CDN");

            entity.HasIndex(e => e.SttData, "SttData").HasFillFactor(100);

            entity.HasIndex(e => new { e.SttOpeId, e.SttFirmGuid }, "SttOpeFirm").HasFillFactor(100);

            entity.Property(e => e.SttSttId).HasColumnName("Stt_SttID");
            entity.Property(e => e.SttData)
                .HasColumnType("datetime")
                .HasColumnName("Stt_Data");
            entity.Property(e => e.SttFirmGuid).HasColumnName("Stt_FirmGuid");
            entity.Property(e => e.SttKontekst).HasColumnName("Stt_Kontekst");
            entity.Property(e => e.SttOpeId).HasColumnName("Stt_OpeId");
            entity.Property(e => e.SttStatystyka).HasColumnName("Stt_Statystyka");
            entity.Property(e => e.SttWartosc)
                .HasMaxLength(50)
                .HasColumnName("Stt_Wartosc");
        });

        modelBuilder.Entity<Sync>(entity =>
        {
            entity.HasKey(e => e.SncSncId)
                .HasName("Snc_Primary")
                .HasFillFactor(100);

            entity.ToTable("Sync", "CDN");

            entity.HasIndex(e => e.SncBazId, "SyncBaza")
                .IsUnique()
                .HasFillFactor(100);

            entity.Property(e => e.SncSncId).HasColumnName("Snc_SncID");
            entity.Property(e => e.SncApfino).HasColumnName("Snc_Apfino");
            entity.Property(e => e.SncApfinoCo).HasColumnName("Snc_ApfinoCo");
            entity.Property(e => e.SncApfinoDo)
                .HasColumnType("datetime")
                .HasColumnName("Snc_ApfinoDo");
            entity.Property(e => e.SncApfinoFakt).HasColumnName("Snc_ApfinoFakt");
            entity.Property(e => e.SncApfinoKnt).HasColumnName("Snc_ApfinoKnt");
            entity.Property(e => e.SncApfinoOd)
                .HasColumnType("datetime")
                .HasColumnName("Snc_ApfinoOd");
            entity.Property(e => e.SncApfinoOpeHaslo)
                .HasMaxLength(256)
                .HasColumnName("Snc_ApfinoOpeHaslo");
            entity.Property(e => e.SncApfinoOpeId).HasColumnName("Snc_ApfinoOpeID");
            entity.Property(e => e.SncApfinoPlat).HasColumnName("Snc_ApfinoPlat");
            entity.Property(e => e.SncApfinoStart)
                .HasColumnType("datetime")
                .HasColumnName("Snc_ApfinoStart");
            entity.Property(e => e.SncBazId).HasColumnName("Snc_BazID");
            entity.Property(e => e.SncDetal).HasColumnName("Snc_Detal");
            entity.Property(e => e.SncDetalCo).HasColumnName("Snc_DetalCo");
            entity.Property(e => e.SncDetalDo)
                .HasColumnType("datetime")
                .HasColumnName("Snc_DetalDo");
            entity.Property(e => e.SncDetalOd)
                .HasColumnType("datetime")
                .HasColumnName("Snc_DetalOd");
            entity.Property(e => e.SncDetalOpeHaslo)
                .HasMaxLength(256)
                .HasColumnName("Snc_DetalOpeHaslo");
            entity.Property(e => e.SncDetalOpeId).HasColumnName("Snc_DetalOpeID");
            entity.Property(e => e.SncEpracownikDaneBinarne).HasColumnName("Snc_EPracownikDaneBinarne");
            entity.Property(e => e.SncEpracownikDaneBinarneCo).HasColumnName("Snc_EPracownikDaneBinarneCo");
            entity.Property(e => e.SncEpracownikDaneBinarneDo)
                .HasColumnType("datetime")
                .HasColumnName("Snc_EPracownikDaneBinarneDo");
            entity.Property(e => e.SncEpracownikDaneBinarneOd)
                .HasColumnType("datetime")
                .HasColumnName("Snc_EPracownikDaneBinarneOd");
            entity.Property(e => e.SncEpracownikDaneKadrowe).HasColumnName("Snc_EPracownikDaneKadrowe");
            entity.Property(e => e.SncEpracownikDaneKadroweCo).HasColumnName("Snc_EPracownikDaneKadroweCo");
            entity.Property(e => e.SncEpracownikDaneKadroweDo)
                .HasColumnType("datetime")
                .HasColumnName("Snc_EPracownikDaneKadroweDo");
            entity.Property(e => e.SncEpracownikDaneKadroweOd)
                .HasColumnType("datetime")
                .HasColumnName("Snc_EPracownikDaneKadroweOd");
            entity.Property(e => e.SncEsklep).HasColumnName("Snc_ESklep");
            entity.Property(e => e.SncEsklepExpKnt).HasColumnName("Snc_ESklepExpKnt");
            entity.Property(e => e.SncEsklepExpSlowCo).HasColumnName("Snc_ESklepExpSlowCo");
            entity.Property(e => e.SncEsklepExpSlowDo)
                .HasColumnType("datetime")
                .HasColumnName("Snc_ESklepExpSlowDo");
            entity.Property(e => e.SncEsklepExpSlowOd)
                .HasColumnType("datetime")
                .HasColumnName("Snc_ESklepExpSlowOd");
            entity.Property(e => e.SncEsklepGenerowanieZnp).HasColumnName("Snc_ESklepGenerowanieZNP");
            entity.Property(e => e.SncEsklepIpeco).HasColumnName("Snc_ESklepIPECo");
            entity.Property(e => e.SncEsklepIpedo)
                .HasColumnType("datetime")
                .HasColumnName("Snc_ESklepIPEDo");
            entity.Property(e => e.SncEsklepIpeod)
                .HasColumnType("datetime")
                .HasColumnName("Snc_ESklepIPEOd");
            entity.Property(e => e.SncEsklepOpeHaslo)
                .HasMaxLength(256)
                .HasColumnName("Snc_ESklepOpeHaslo");
            entity.Property(e => e.SncEsklepOpeId).HasColumnName("Snc_ESklepOpeID");
            entity.Property(e => e.SncEsklepRealizacjaRo).HasColumnName("Snc_ESklepRealizacjaRO");
            entity.Property(e => e.SncEsklepRealizacjaRodata)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("Snc_ESklepRealizacjaROData");
            entity.Property(e => e.SncEsklepWydrukId).HasColumnName("Snc_ESklepWydrukId");
            entity.Property(e => e.SncEsklepWydrukTyp).HasColumnName("Snc_ESklepWydrukTyp");
            entity.Property(e => e.SncOpeModId).HasColumnName("Snc_OpeModId");
            entity.Property(e => e.SncOpeModKod)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("Snc_OpeModKod");
            entity.Property(e => e.SncOpeModNazwisko)
                .HasMaxLength(50)
                .HasDefaultValue("")
                .HasColumnName("Snc_OpeModNazwisko");
            entity.Property(e => e.SncOpeZalId).HasColumnName("Snc_OpeZalId");
            entity.Property(e => e.SncOpeZalKod)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("Snc_OpeZalKod");
            entity.Property(e => e.SncOpeZalNazwisko)
                .HasMaxLength(50)
                .HasDefaultValue("")
                .HasColumnName("Snc_OpeZalNazwisko");
            entity.Property(e => e.SncStaModId).HasColumnName("Snc_StaModId");
            entity.Property(e => e.SncStaZalId).HasColumnName("Snc_StaZalId");
            entity.Property(e => e.SncTsMod)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("Snc_TS_Mod");
            entity.Property(e => e.SncTsZal)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("Snc_TS_Zal");
            entity.Property(e => e.SncXl).HasColumnName("Snc_XL");
            entity.Property(e => e.SncXlco).HasColumnName("Snc_XLCo");
            entity.Property(e => e.SncXldo)
                .HasColumnType("datetime")
                .HasColumnName("Snc_XLDo");
            entity.Property(e => e.SncXlod)
                .HasColumnType("datetime")
                .HasColumnName("Snc_XLOd");
            entity.Property(e => e.SncXlopeHaslo)
                .HasMaxLength(256)
                .HasColumnName("Snc_XLOpeHaslo");
            entity.Property(e => e.SncXlopeId).HasColumnName("Snc_XLOpeID");

            entity.HasOne(d => d.SncApfinoOpe).WithMany(p => p.SyncSncApfinoOpes)
                .HasForeignKey(d => d.SncApfinoOpeId)
                .HasConstraintName("FK_SyncOperatorApfino");

            entity.HasOne(d => d.SncBaz).WithOne(p => p.Sync)
                .HasForeignKey<Sync>(d => d.SncBazId)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK_SyncBaza");

            entity.HasOne(d => d.SncDetalOpe).WithMany(p => p.SyncSncDetalOpes)
                .HasForeignKey(d => d.SncDetalOpeId)
                .HasConstraintName("FK_SyncOperatorDetal");

            entity.HasOne(d => d.SncEsklepOpe).WithMany(p => p.SyncSncEsklepOpes)
                .HasForeignKey(d => d.SncEsklepOpeId)
                .HasConstraintName("FK_SyncOperatorESklep");

            entity.HasOne(d => d.SncXlope).WithMany(p => p.SyncSncXlopes)
                .HasForeignKey(d => d.SncXlopeId)
                .HasConstraintName("FK_SyncOperatorXL");
        });

        modelBuilder.Entity<Terminy>(entity =>
        {
            entity.HasKey(e => e.TmiTmiId)
                .HasName("Tmi_Primary")
                .HasFillFactor(100);

            entity.ToTable("Terminy", "CDN", tb => tb.HasTrigger("Terminy_Delete_Trigger"));

            entity.HasIndex(e => new { e.TmiUser, e.TmiKod }, "TmiKod")
                .IsUnique()
                .HasFillFactor(100);

            entity.Property(e => e.TmiTmiId).HasColumnName("Tmi_TmiId");
            entity.Property(e => e.TmiCz).HasColumnName("Tmi_Cz");
            entity.Property(e => e.TmiCzyGodzina).HasColumnName("Tmi_CzyGodzina");
            entity.Property(e => e.TmiCzyPo).HasColumnName("Tmi_CzyPo");
            entity.Property(e => e.TmiCzyPrzed).HasColumnName("Tmi_CzyPrzed");
            entity.Property(e => e.TmiCzyWarunek).HasColumnName("Tmi_CzyWarunek");
            entity.Property(e => e.TmiDomyslny).HasColumnName("Tmi_Domyslny");
            entity.Property(e => e.TmiGodzina)
                .HasColumnType("datetime")
                .HasColumnName("Tmi_Godzina");
            entity.Property(e => e.TmiKod)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("Tmi_Kod");
            entity.Property(e => e.TmiM01).HasColumnName("Tmi_M01");
            entity.Property(e => e.TmiM02).HasColumnName("Tmi_M02");
            entity.Property(e => e.TmiM03).HasColumnName("Tmi_M03");
            entity.Property(e => e.TmiM04).HasColumnName("Tmi_M04");
            entity.Property(e => e.TmiM05).HasColumnName("Tmi_M05");
            entity.Property(e => e.TmiM06).HasColumnName("Tmi_M06");
            entity.Property(e => e.TmiM07).HasColumnName("Tmi_M07");
            entity.Property(e => e.TmiM08).HasColumnName("Tmi_M08");
            entity.Property(e => e.TmiM09).HasColumnName("Tmi_M09");
            entity.Property(e => e.TmiM10).HasColumnName("Tmi_M10");
            entity.Property(e => e.TmiM11).HasColumnName("Tmi_M11");
            entity.Property(e => e.TmiM12).HasColumnName("Tmi_M12");
            entity.Property(e => e.TmiMcoIle).HasColumnName("Tmi_MCoIle");
            entity.Property(e => e.TmiMczyCoIle).HasColumnName("Tmi_MCzyCoIle");
            entity.Property(e => e.TmiMczyNumerDnia).HasColumnName("Tmi_MCzyNumerDnia");
            entity.Property(e => e.TmiMnumerDnia).HasColumnName("Tmi_MNumerDnia");
            entity.Property(e => e.TmiNazwa)
                .HasMaxLength(50)
                .HasColumnName("Tmi_Nazwa");
            entity.Property(e => e.TmiNi).HasColumnName("Tmi_Ni");
            entity.Property(e => e.TmiOpeModId).HasColumnName("Tmi_OpeModID");
            entity.Property(e => e.TmiOpeModKod)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("Tmi_OpeModKod");
            entity.Property(e => e.TmiOpeModNazwisko)
                .HasMaxLength(50)
                .HasDefaultValue("")
                .HasColumnName("Tmi_OpeModNazwisko");
            entity.Property(e => e.TmiOpeZalId).HasColumnName("Tmi_OpeZalID");
            entity.Property(e => e.TmiOpeZalKod)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("Tmi_OpeZalKod");
            entity.Property(e => e.TmiOpeZalNazwisko)
                .HasMaxLength(50)
                .HasDefaultValue("")
                .HasColumnName("Tmi_OpeZalNazwisko");
            entity.Property(e => e.TmiPi).HasColumnName("Tmi_Pi");
            entity.Property(e => e.TmiPn).HasColumnName("Tmi_Pn");
            entity.Property(e => e.TmiPoIloscDni).HasColumnName("Tmi_PoIloscDni");
            entity.Property(e => e.TmiPrzedIloscDni).HasColumnName("Tmi_PrzedIloscDni");
            entity.Property(e => e.TmiRcoIle).HasColumnName("Tmi_RCoIle");
            entity.Property(e => e.TmiRczyCoIle).HasColumnName("Tmi_RCzyCoIle");
            entity.Property(e => e.TmiRodzaj).HasColumnName("Tmi_Rodzaj");
            entity.Property(e => e.TmiSo).HasColumnName("Tmi_So");
            entity.Property(e => e.TmiSr).HasColumnName("Tmi_Sr");
            entity.Property(e => e.TmiStaModId).HasColumnName("Tmi_StaModId");
            entity.Property(e => e.TmiStaZalId).HasColumnName("Tmi_StaZalId");
            entity.Property(e => e.TmiT1).HasColumnName("Tmi_T1");
            entity.Property(e => e.TmiT2).HasColumnName("Tmi_T2");
            entity.Property(e => e.TmiT3).HasColumnName("Tmi_T3");
            entity.Property(e => e.TmiT4).HasColumnName("Tmi_T4");
            entity.Property(e => e.TmiT5).HasColumnName("Tmi_T5");
            entity.Property(e => e.TmiTcoIle).HasColumnName("Tmi_TCoIle");
            entity.Property(e => e.TmiTczyCoIle).HasColumnName("Tmi_TCzyCoIle");
            entity.Property(e => e.TmiTsMod)
                .HasColumnType("datetime")
                .HasColumnName("Tmi_TS_Mod");
            entity.Property(e => e.TmiTsZal)
                .HasColumnType("datetime")
                .HasColumnName("Tmi_TS_Zal");
            entity.Property(e => e.TmiTyp).HasColumnName("Tmi_Typ");
            entity.Property(e => e.TmiUser).HasColumnName("Tmi_User");
            entity.Property(e => e.TmiWarunekRodzaj).HasColumnName("Tmi_WarunekRodzaj");
            entity.Property(e => e.TmiWt).HasColumnName("Tmi_Wt");
        });

        modelBuilder.Entity<Teryt>(entity =>
        {
            entity.HasKey(e => e.TrtTrtId)
                .HasName("Trt_Primary")
                .HasFillFactor(100);

            entity.ToTable("Teryt", "CDN");

            entity.HasIndex(e => new { e.TrtWojewodztwo, e.TrtPowiat, e.TrtGmina, e.TrtNazwa }, "TrtJednAdm")
                .IsUnique()
                .HasFillFactor(100);

            entity.Property(e => e.TrtTrtId).HasColumnName("Trt_TrtID");
            entity.Property(e => e.TrtGmina).HasColumnName("Trt_Gmina");
            entity.Property(e => e.TrtNazwa)
                .HasMaxLength(127)
                .HasColumnName("Trt_Nazwa");
            entity.Property(e => e.TrtPowiat).HasColumnName("Trt_Powiat");
            entity.Property(e => e.TrtWojewodztwo).HasColumnName("Trt_Wojewodztwo");
        });

        modelBuilder.Entity<UrzRachunkiImport>(entity =>
        {
            entity.HasKey(e => e.UraIUraIid)
                .HasName("URaI_Primary")
                .HasFillFactor(100);

            entity.ToTable("UrzRachunkiImport", "CDN");

            entity.Property(e => e.UraIUraIid).HasColumnName("URaI_URaIId");
            entity.Property(e => e.UraIBnaImportRowId)
                .HasMaxLength(36)
                .HasColumnName("URaI_BNa_ImportRowId");
            entity.Property(e => e.UraIBnaNumer)
                .HasMaxLength(20)
                .HasColumnName("URaI_BNa_Numer");
            entity.Property(e => e.UraIIban).HasColumnName("URaI_IBAN");
            entity.Property(e => e.UraIRachunekNr)
                .HasMaxLength(51)
                .HasColumnName("URaI_RachunekNr");
            entity.Property(e => e.UraITypRach).HasColumnName("URaI_TypRach");
            entity.Property(e => e.UraIUrzIid).HasColumnName("URaI_UrzIId");

            entity.HasOne(d => d.UraIUrzI).WithMany(p => p.UrzRachunkiImports)
                .HasForeignKey(d => d.UraIUrzIid)
                .HasConstraintName("FK_URaIUrzadI");
        });

        modelBuilder.Entity<UrzedyImport>(entity =>
        {
            entity.HasKey(e => e.UrzIUrzIid)
                .HasName("UrzI_Primary")
                .HasFillFactor(100);

            entity.ToTable("UrzedyImport", "CDN");

            entity.HasIndex(e => e.UrzIImportRowId, "UrzI_IX_ImportRowId")
                .IsUnique()
                .HasFillFactor(100);

            entity.Property(e => e.UrzIUrzIid).HasColumnName("UrzI_UrzIId");
            entity.Property(e => e.UrzIAdres2)
                .HasMaxLength(40)
                .HasColumnName("UrzI_Adres2");
            entity.Property(e => e.UrzIAkronim)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("UrzI_Akronim");
            entity.Property(e => e.UrzIEmail)
                .HasMaxLength(40)
                .HasColumnName("UrzI_Email");
            entity.Property(e => e.UrzIFax)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("UrzI_Fax");
            entity.Property(e => e.UrzIGmina)
                .HasMaxLength(40)
                .HasColumnName("UrzI_Gmina");
            entity.Property(e => e.UrzIImportRowId)
                .HasMaxLength(36)
                .IsUnicode(false)
                .HasColumnName("UrzI_ImportRowId");
            entity.Property(e => e.UrzIKatImportRowId)
                .HasMaxLength(36)
                .HasColumnName("UrzI_Kat_ImportRowId");
            entity.Property(e => e.UrzIKatKodSzczegol)
                .HasMaxLength(20)
                .HasColumnName("UrzI_Kat_KodSzczegol");
            entity.Property(e => e.UrzIKod)
                .HasMaxLength(6)
                .IsUnicode(false)
                .HasColumnName("UrzI_Kod");
            entity.Property(e => e.UrzIKodPocztowy)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("UrzI_KodPocztowy");
            entity.Property(e => e.UrzIKraj)
                .HasMaxLength(40)
                .HasColumnName("UrzI_Kraj");
            entity.Property(e => e.UrzIMiasto)
                .HasMaxLength(40)
                .HasColumnName("UrzI_Miasto");
            entity.Property(e => e.UrzINazwa1)
                .HasMaxLength(50)
                .HasColumnName("UrzI_Nazwa1");
            entity.Property(e => e.UrzINazwa2)
                .HasMaxLength(50)
                .HasColumnName("UrzI_Nazwa2");
            entity.Property(e => e.UrzINieRozliczac).HasColumnName("UrzI_NieRozliczac");
            entity.Property(e => e.UrzINieaktywny).HasColumnName("UrzI_Nieaktywny");
            entity.Property(e => e.UrzINrDomu)
                .HasMaxLength(10)
                .HasColumnName("UrzI_NrDomu");
            entity.Property(e => e.UrzINrLokalu)
                .HasMaxLength(10)
                .HasColumnName("UrzI_NrLokalu");
            entity.Property(e => e.UrzIPoczta)
                .HasMaxLength(40)
                .HasColumnName("UrzI_Poczta");
            entity.Property(e => e.UrzIPowiat)
                .HasMaxLength(40)
                .HasColumnName("UrzI_Powiat");
            entity.Property(e => e.UrzITelefon)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("UrzI_Telefon");
            entity.Property(e => e.UrzITypUrzedu).HasColumnName("UrzI_TypUrzedu");
            entity.Property(e => e.UrzIUlica)
                .HasMaxLength(40)
                .HasColumnName("UrzI_Ulica");
            entity.Property(e => e.UrzIUrl)
                .HasMaxLength(254)
                .IsUnicode(false)
                .HasColumnName("UrzI_URL");
            entity.Property(e => e.UrzIWojewodztwo)
                .HasMaxLength(40)
                .HasColumnName("UrzI_Wojewodztwo");
            entity.Property(e => e.UrzIZrdId)
                .HasMaxLength(5)
                .HasColumnName("UrzI_ZrdId");
        });

        modelBuilder.Entity<UstawieniaCustomizacji>(entity =>
        {
            entity.HasKey(e => e.UcuUcuId)
                .HasName("UCu_Primary")
                .HasFillFactor(100);

            entity.ToTable("UstawieniaCustomizacji", "CDN");

            entity.HasIndex(e => new { e.UcuWidok, e.UcuOperator, e.UcuUstawienie }, "UCu_WidokOperatorUstawienie").HasFillFactor(100);

            entity.Property(e => e.UcuUcuId).HasColumnName("UCu_UcuId");
            entity.Property(e => e.UcuNazwa)
                .HasMaxLength(255)
                .HasColumnName("UCu_Nazwa");
            entity.Property(e => e.UcuOperator).HasColumnName("UCu_Operator");
            entity.Property(e => e.UcuUstawienie).HasColumnName("UCu_Ustawienie");
            entity.Property(e => e.UcuWartosc).HasColumnName("UCu_Wartosc");
            entity.Property(e => e.UcuWidok).HasColumnName("UCu_Widok");
        });

        modelBuilder.Entity<UstawieniaGlobalne>(entity =>
        {
            entity.HasKey(e => e.UglUglId)
                .HasName("UGl_Primary")
                .HasFillFactor(100);

            entity.ToTable("UstawieniaGlobalne", "CDN");

            entity.HasIndex(e => e.UglOperator, "UGl_OperatorIndex").HasFillFactor(100);

            entity.Property(e => e.UglUglId).HasColumnName("UGl_UglId");
            entity.Property(e => e.UglNazwa)
                .HasMaxLength(255)
                .HasColumnName("UGl_Nazwa");
            entity.Property(e => e.UglOperator).HasColumnName("UGl_Operator");
            entity.Property(e => e.UglWartosc).HasColumnName("UGl_Wartosc");
        });

        modelBuilder.Entity<UstawieniaWidoku>(entity =>
        {
            entity.HasKey(e => e.UwiUwiId)
                .HasName("Uwi_Primary")
                .HasFillFactor(100);

            entity.ToTable("UstawieniaWidoku", "CDN");

            entity.HasIndex(e => new { e.UwiWidok, e.UwiOperator }, "UWi_WidokOperator").HasFillFactor(100);

            entity.Property(e => e.UwiUwiId).HasColumnName("UWi_UwiId");
            entity.Property(e => e.UwiCzyZmaksymalizowany).HasColumnName("UWi_CzyZmaksymalizowany");
            entity.Property(e => e.UwiOperator).HasColumnName("UWi_Operator");
            entity.Property(e => e.UwiSzerokosc).HasColumnName("UWi_Szerokosc");
            entity.Property(e => e.UwiWidok).HasColumnName("UWi_Widok");
            entity.Property(e => e.UwiWysokosc).HasColumnName("UWi_Wysokosc");
            entity.Property(e => e.UwiX).HasColumnName("UWi_X");
            entity.Property(e => e.UwiY).HasColumnName("UWi_Y");
        });

        modelBuilder.Entity<UstawieniaWidokuSzczegoly>(entity =>
        {
            entity.HasKey(e => e.UwsUwsId)
                .HasName("UWS_Primary")
                .HasFillFactor(100);

            entity.ToTable("UstawieniaWidokuSzczegoly", "CDN");

            entity.HasIndex(e => e.UwsUwiId, "UWS_WidokOperator").HasFillFactor(100);

            entity.Property(e => e.UwsUwsId).HasColumnName("UWS_UwsId");
            entity.Property(e => e.UwsNazwa)
                .HasMaxLength(255)
                .HasColumnName("UWS_Nazwa");
            entity.Property(e => e.UwsUwiId).HasColumnName("UWS_UwiId");
            entity.Property(e => e.UwsWartosc).HasColumnName("UWS_Wartosc");

            entity.HasOne(d => d.UwsUwi).WithMany(p => p.UstawieniaWidokuSzczegolies)
                .HasForeignKey(d => d.UwsUwiId)
                .HasConstraintName("FK_UstawieniaWidoku");
        });

        modelBuilder.Entity<Uwdkonfig>(entity =>
        {
            entity.HasKey(e => e.UknUknId)
                .HasName("UKn_Primary")
                .HasFillFactor(100);

            entity.ToTable("UWDKonfig", "CDN", tb =>
                {
                    tb.HasTrigger("UWDKonfig_Delete_Trigger");
                    tb.HasTrigger("UWDKonfig_Insert_Update_Trigger");
                });

            entity.HasIndex(e => e.UknBazId, "UKnBazID")
                .IsUnique()
                .HasFillFactor(100);

            entity.Property(e => e.UknUknId).HasColumnName("UKn_UKnID");
            entity.Property(e => e.UknAplikacja).HasColumnName("UKn_Aplikacja");
            entity.Property(e => e.UknBazId).HasColumnName("UKn_BazID");
            entity.Property(e => e.UknOddzialId)
                .HasMaxLength(20)
                .HasColumnName("UKn_OddzialID");
            entity.Property(e => e.UknPartnerId).HasColumnName("UKn_PartnerID");
            entity.Property(e => e.UknSoaSync).HasColumnName("UKn_SoaSync");
            entity.Property(e => e.UknTypWymiany).HasColumnName("UKn_TypWymiany");

            entity.HasOne(d => d.UknBaz).WithOne(p => p.Uwdkonfig)
                .HasForeignKey<Uwdkonfig>(d => d.UknBazId)
                .HasConstraintName("FK_UKnBazID");
        });

        modelBuilder.Entity<WalElemView>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("WalElemView", "CDN");

            entity.Property(e => e.WaEKursL)
                .HasColumnType("decimal(15, 4)")
                .HasColumnName("WaE_KursL");
            entity.Property(e => e.WaEKursM)
                .HasColumnType("decimal(5, 0)")
                .HasColumnName("WaE_KursM");
            entity.Property(e => e.WaEKursTs).HasColumnName("WaE_KursTS");
            entity.Property(e => e.WaELp).HasColumnName("WaE_Lp");
            entity.Property(e => e.WaESymbol)
                .HasMaxLength(3)
                .IsUnicode(false)
                .HasColumnName("WaE_Symbol");
        });

        modelBuilder.Entity<WalKursy>(entity =>
        {
            entity.HasKey(e => e.WkuWkuId)
                .HasName("WKu_Primary")
                .HasFillFactor(100);

            entity.ToTable("WalKursy", "CDN", tb =>
                {
                    tb.HasTrigger("WalKursy_Delete_Trigger");
                    tb.HasTrigger("WalKursy_InsertUpdate_Trigger");
                });

            entity.HasIndex(e => e.WkuSymbol, "WKuSymbol")
                .IsUnique()
                .HasFillFactor(100);

            entity.Property(e => e.WkuWkuId).HasColumnName("WKu_WKuID");
            entity.Property(e => e.WkuNazwa)
                .HasMaxLength(45)
                .HasColumnName("WKu_Nazwa");
            entity.Property(e => e.WkuNieAktywny).HasColumnName("WKu_NieAktywny");
            entity.Property(e => e.WkuOpeModId).HasColumnName("WKu_OpeModID");
            entity.Property(e => e.WkuOpeModKod)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("WKu_OpeModKod");
            entity.Property(e => e.WkuOpeModNazwisko)
                .HasMaxLength(50)
                .HasDefaultValue("")
                .HasColumnName("WKu_OpeModNazwisko");
            entity.Property(e => e.WkuOpeZalId).HasColumnName("WKu_OpeZalID");
            entity.Property(e => e.WkuOpeZalKod)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("WKu_OpeZalKod");
            entity.Property(e => e.WkuOpeZalNazwisko)
                .HasMaxLength(50)
                .HasDefaultValue("")
                .HasColumnName("WKu_OpeZalNazwisko");
            entity.Property(e => e.WkuStaModId).HasColumnName("WKu_StaModId");
            entity.Property(e => e.WkuStaZalId).HasColumnName("WKu_StaZalId");
            entity.Property(e => e.WkuSymbol)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("WKu_Symbol");
            entity.Property(e => e.WkuTsExport)
                .HasColumnType("datetime")
                .HasColumnName("WKu_TS_Export");
            entity.Property(e => e.WkuTsMod)
                .HasColumnType("datetime")
                .HasColumnName("WKu_TS_Mod");
            entity.Property(e => e.WkuTsZal)
                .HasColumnType("datetime")
                .HasColumnName("WKu_TS_Zal");
            entity.Property(e => e.WkuUrl)
                .HasMaxLength(254)
                .IsUnicode(false)
                .HasColumnName("WKu_URL");
        });

        modelBuilder.Entity<WalNagView>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("WalNagView", "CDN");

            entity.Property(e => e.WaNAktywna).HasColumnName("WaN_Aktywna");
            entity.Property(e => e.WaNKontoMinus)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("WaN_KontoMinus");
            entity.Property(e => e.WaNKontoPlus)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("WaN_KontoPlus");
            entity.Property(e => e.WaNNazwa)
                .HasMaxLength(40)
                .HasColumnName("WaN_Nazwa");
            entity.Property(e => e.WaNPanstwo)
                .HasMaxLength(40)
                .HasColumnName("WaN_Panstwo");
            entity.Property(e => e.WaNParytet)
                .HasColumnType("decimal(10, 6)")
                .HasColumnName("WaN_Parytet");
            entity.Property(e => e.WaNSlownie1)
                .HasMaxLength(40)
                .HasColumnName("WaN_Slownie1");
            entity.Property(e => e.WaNSlownie2)
                .HasMaxLength(40)
                .HasColumnName("WaN_Slownie2");
            entity.Property(e => e.WaNSymbol)
                .HasMaxLength(3)
                .IsUnicode(false)
                .HasColumnName("WaN_Symbol");
            entity.Property(e => e.WaNSymbolEmu)
                .HasMaxLength(3)
                .IsUnicode(false)
                .HasColumnName("WaN_SymbolEMU");
            entity.Property(e => e.WaNWsk).HasColumnName("WaN_Wsk");
        });

        modelBuilder.Entity<WalNazwy>(entity =>
        {
            entity.HasKey(e => e.WnaWnaId)
                .HasName("WNa_Primary")
                .HasFillFactor(100);

            entity.ToTable("WalNazwy", "CDN", tb =>
                {
                    tb.HasTrigger("WalNazwy_Delete_Trigger");
                    tb.HasTrigger("WalNazwy_InsertUpdate_Trigger");
                    tb.HasTrigger("WalNazwy_Update_Trigger");
                });

            entity.HasIndex(e => e.WnaSymbol, "WaNSymbol")
                .IsUnique()
                .HasFillFactor(100);

            entity.Property(e => e.WnaWnaId).HasColumnName("WNa_WNaID");
            entity.Property(e => e.WnaKontoMa)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("WNa_KontoMa");
            entity.Property(e => e.WnaKontoWn)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("WNa_KontoWn");
            entity.Property(e => e.WnaKraj)
                .HasMaxLength(40)
                .HasColumnName("WNa_Kraj");
            entity.Property(e => e.WnaNazwa)
                .HasMaxLength(40)
                .HasColumnName("WNa_Nazwa");
            entity.Property(e => e.WnaNieaktualizowana).HasColumnName("WNa_Nieaktualizowana");
            entity.Property(e => e.WnaOpeModId).HasColumnName("WNa_OpeModID");
            entity.Property(e => e.WnaOpeModKod)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("WNa_OpeModKod");
            entity.Property(e => e.WnaOpeModNazwisko)
                .HasMaxLength(50)
                .HasDefaultValue("")
                .HasColumnName("WNa_OpeModNazwisko");
            entity.Property(e => e.WnaOpeZalId).HasColumnName("WNa_OpeZalID");
            entity.Property(e => e.WnaOpeZalKod)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("WNa_OpeZalKod");
            entity.Property(e => e.WnaOpeZalNazwisko)
                .HasMaxLength(50)
                .HasDefaultValue("")
                .HasColumnName("WNa_OpeZalNazwisko");
            entity.Property(e => e.WnaParytet)
                .HasColumnType("decimal(10, 6)")
                .HasColumnName("WNa_Parytet");
            entity.Property(e => e.WnaSlownie1)
                .HasMaxLength(40)
                .HasColumnName("WNa_Slownie1");
            entity.Property(e => e.WnaSlownie2)
                .HasMaxLength(40)
                .HasColumnName("WNa_Slownie2");
            entity.Property(e => e.WnaStaModId).HasColumnName("WNa_StaModId");
            entity.Property(e => e.WnaStaZalId).HasColumnName("WNa_StaZalId");
            entity.Property(e => e.WnaSymbol)
                .HasMaxLength(3)
                .IsUnicode(false)
                .HasColumnName("WNa_Symbol");
            entity.Property(e => e.WnaTsExport)
                .HasColumnType("datetime")
                .HasColumnName("WNa_TS_Export");
            entity.Property(e => e.WnaTsMod)
                .HasColumnType("datetime")
                .HasColumnName("WNa_TS_Mod");
            entity.Property(e => e.WnaTsZal)
                .HasColumnType("datetime")
                .HasColumnName("WNa_TS_Zal");
        });

        modelBuilder.Entity<WalNotowanium>(entity =>
        {
            entity.HasKey(e => e.WnoWnoId)
                .HasName("WNo_Primary")
                .HasFillFactor(100);

            entity.ToTable("WalNotowania", "CDN", tb => tb.HasTrigger("WalNotowania_InsertUpdate_Trigger"));

            entity.HasIndex(e => new { e.WnoWkuId, e.WnoTstamp, e.WnoWnaId }, "KeyKurs")
                .IsUnique()
                .HasFillFactor(100);

            entity.HasIndex(e => new { e.WnoWnaId, e.WnoWkuId, e.WnoTstamp }, "WNoWaluta")
                .IsUnique()
                .HasFillFactor(100);

            entity.Property(e => e.WnoWnoId).HasColumnName("WNo_WNoID");
            entity.Property(e => e.WnoAutomatycznie).HasColumnName("WNo_Automatycznie");
            entity.Property(e => e.WnoKursL)
                .HasColumnType("decimal(15, 4)")
                .HasColumnName("WNo_KursL");
            entity.Property(e => e.WnoKursM)
                .HasColumnType("decimal(5, 0)")
                .HasColumnName("WNo_KursM");
            entity.Property(e => e.WnoNrTabeli)
                .HasMaxLength(50)
                .HasDefaultValue("")
                .HasColumnName("WNo_NrTabeli");
            entity.Property(e => e.WnoOpeModId).HasColumnName("WNo_OpeModID");
            entity.Property(e => e.WnoOpeModKod)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("WNo_OpeModKod");
            entity.Property(e => e.WnoOpeModNazwisko)
                .HasMaxLength(50)
                .HasDefaultValue("")
                .HasColumnName("WNo_OpeModNazwisko");
            entity.Property(e => e.WnoOpeZalId).HasColumnName("WNo_OpeZalID");
            entity.Property(e => e.WnoOpeZalKod)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("WNo_OpeZalKod");
            entity.Property(e => e.WnoOpeZalNazwisko)
                .HasMaxLength(50)
                .HasDefaultValue("")
                .HasColumnName("WNo_OpeZalNazwisko");
            entity.Property(e => e.WnoPublikacja)
                .HasColumnType("datetime")
                .HasColumnName("WNo_Publikacja");
            entity.Property(e => e.WnoStaModId).HasColumnName("WNo_StaModId");
            entity.Property(e => e.WnoStaZalId).HasColumnName("WNo_StaZalId");
            entity.Property(e => e.WnoTsExport)
                .HasColumnType("datetime")
                .HasColumnName("WNo_TS_Export");
            entity.Property(e => e.WnoTsMod)
                .HasColumnType("datetime")
                .HasColumnName("WNo_TS_Mod");
            entity.Property(e => e.WnoTsZal)
                .HasColumnType("datetime")
                .HasColumnName("WNo_TS_Zal");
            entity.Property(e => e.WnoTstamp)
                .HasColumnType("datetime")
                .HasColumnName("WNo_TStamp");
            entity.Property(e => e.WnoWkuId).HasColumnName("WNo_WKuID");
            entity.Property(e => e.WnoWnaId).HasColumnName("WNo_WNaID");

            entity.HasOne(d => d.WnoWku).WithMany(p => p.WalNotowania)
                .HasForeignKey(d => d.WnoWkuId)
                .HasConstraintName("FK_KeyKurs");

            entity.HasOne(d => d.WnoWna).WithMany(p => p.WalNotowania)
                .HasForeignKey(d => d.WnoWnaId)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK_WNoWaluta");
        });

        modelBuilder.Entity<WdrAuto>(entity =>
        {
            entity.HasKey(e => new { e.WdAProcId, e.WdAAkcja, e.WdAStandardowy, e.WdAWdrId })
                .HasName("WdA_Primary")
                .HasFillFactor(100);

            entity.ToTable("WdrAuto", "CDN");

            entity.Property(e => e.WdAProcId).HasColumnName("WdA_ProcID");
            entity.Property(e => e.WdAAkcja).HasColumnName("WdA_Akcja");
            entity.Property(e => e.WdAStandardowy).HasColumnName("WdA_Standardowy");
            entity.Property(e => e.WdAWdrId).HasColumnName("WdA_WdrID");
        });

        modelBuilder.Entity<WdrDomyslne>(entity =>
        {
            entity.HasKey(e => new { e.WdDProcId, e.WdDKontId, e.WdDOpeId, e.WdDRodzaj })
                .HasName("WdD_Primary")
                .HasFillFactor(100);

            entity.ToTable("WdrDomyslne", "CDN");

            entity.Property(e => e.WdDProcId).HasColumnName("WdD_ProcID");
            entity.Property(e => e.WdDKontId).HasColumnName("WdD_KontID");
            entity.Property(e => e.WdDOpeId).HasColumnName("WdD_OpeID");
            entity.Property(e => e.WdDRodzaj).HasColumnName("WdD_Rodzaj");
            entity.Property(e => e.WdDStandardowy).HasColumnName("WdD_Standardowy");
            entity.Property(e => e.WdDWdZid).HasColumnName("WdD_WdZId");
            entity.Property(e => e.WdDWdrId).HasColumnName("WdD_WdrId");
        });

        modelBuilder.Entity<WdrPodlaczeniaWydrukow>(entity =>
        {
            entity.HasKey(e => new { e.WdPwWdZid, e.WdPwStandardowy, e.WdPwWdrId })
                .HasName("WdPW_Primary")
                .HasFillFactor(100);

            entity.ToTable("WdrPodlaczeniaWydrukow", "CDN", tb => tb.HasTrigger("WdrPodlaczeniaWydrukow_Delete_Trigger"));

            entity.HasIndex(e => new { e.WdPwStandardowy, e.WdPwWdZid, e.WdPwLp, e.WdPwWdrId }, "WdPWWgLp")
                .IsUnique()
                .HasFillFactor(100);

            entity.HasIndex(e => new { e.WdPwStandardowy, e.WdPwWdrId, e.WdPwWdZid }, "WdPWWgWydruku")
                .IsUnique()
                .HasFillFactor(100);

            entity.Property(e => e.WdPwWdZid).HasColumnName("WdPW_WdZID");
            entity.Property(e => e.WdPwStandardowy).HasColumnName("WdPW_Standardowy");
            entity.Property(e => e.WdPwWdrId).HasColumnName("WdPW_WdrID");
            entity.Property(e => e.WdPwEdycja)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("WdPW_Edycja");
            entity.Property(e => e.WdPwLp).HasColumnName("WdPW_Lp");
            entity.Property(e => e.WdPwWarunek)
                .HasMaxLength(4096)
                .IsUnicode(false)
                .HasColumnName("WdPW_Warunek");
        });

        modelBuilder.Entity<WdrPodlaczeniaZestawow>(entity =>
        {
            entity.HasKey(e => new { e.WdPzProcId, e.WdPzKontId, e.WdPzStandardowy, e.WdPzWdZid })
                .HasName("WdPZ_Primary")
                .HasFillFactor(100);

            entity.ToTable("WdrPodlaczeniaZestawow", "CDN", tb => tb.HasTrigger("WdrPodlaczeniaZestawow_Delete_Trigger"));

            entity.HasIndex(e => new { e.WdPzStandardowy, e.WdPzProcId, e.WdPzKontId, e.WdPzLp, e.WdPzWdZid }, "WdPZWgLp")
                .IsUnique()
                .HasFillFactor(100);

            entity.HasIndex(e => new { e.WdPzWdZid, e.WdPzStandardowy, e.WdPzProcId, e.WdPzKontId }, "WdPZWgZestawu")
                .IsUnique()
                .HasFillFactor(100);

            entity.Property(e => e.WdPzProcId).HasColumnName("WdPZ_ProcID");
            entity.Property(e => e.WdPzKontId).HasColumnName("WdPZ_KontID");
            entity.Property(e => e.WdPzStandardowy).HasColumnName("WdPZ_Standardowy");
            entity.Property(e => e.WdPzWdZid).HasColumnName("WdPZ_WdZID");
            entity.Property(e => e.WdPzEdycja)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("WdPZ_Edycja");
            entity.Property(e => e.WdPzLp).HasColumnName("WdPZ_Lp");
            entity.Property(e => e.WdPzWarunek)
                .HasMaxLength(4096)
                .IsUnicode(false)
                .HasColumnName("WdPZ_Warunek");
        });

        modelBuilder.Entity<WdrZakazyDoWydrukow>(entity =>
        {
            entity.HasKey(e => e.WdZwWdZwid)
                .HasName("WdZW_Primary")
                .HasFillFactor(100);

            entity.ToTable("WdrZakazyDoWydrukow", "CDN");

            entity.HasIndex(e => new { e.WdZwOpeId, e.WdZwStandardowy, e.WdZwWdrId }, "WdZWWgOperatora")
                .IsUnique()
                .HasFillFactor(100);

            entity.HasIndex(e => new { e.WdZwStandardowy, e.WdZwWdrId, e.WdZwOpeId }, "WdZWWgWydruku")
                .IsUnique()
                .HasFillFactor(100);

            entity.Property(e => e.WdZwWdZwid).HasColumnName("WdZW_WdZWID");
            entity.Property(e => e.WdZwOpeId).HasColumnName("WdZW_OpeID");
            entity.Property(e => e.WdZwStandardowy).HasColumnName("WdZW_Standardowy");
            entity.Property(e => e.WdZwWdrId).HasColumnName("WdZW_WdrID");
        });

        modelBuilder.Entity<WdrZakazyDoZestawow>(entity =>
        {
            entity.HasKey(e => e.WdZzWdZzid)
                .HasName("WdZZ_Primary")
                .HasFillFactor(100);

            entity.ToTable("WdrZakazyDoZestawow", "CDN");

            entity.HasIndex(e => new { e.WdZzOpeId, e.WdZzStandardowy, e.WdZzWdZid }, "WdZZWgOperatora")
                .IsUnique()
                .HasFillFactor(100);

            entity.HasIndex(e => new { e.WdZzStandardowy, e.WdZzWdZid, e.WdZzOpeId }, "WdZZWgWydruku")
                .IsUnique()
                .HasFillFactor(100);

            entity.Property(e => e.WdZzWdZzid).HasColumnName("WdZZ_WdZZID");
            entity.Property(e => e.WdZzOpeId).HasColumnName("WdZZ_OpeID");
            entity.Property(e => e.WdZzStandardowy).HasColumnName("WdZZ_Standardowy");
            entity.Property(e => e.WdZzWdZid).HasColumnName("WdZZ_WdZID");
        });

        modelBuilder.Entity<WdrZestawy>(entity =>
        {
            entity.HasKey(e => new { e.WdZStandardowy, e.WdZId })
                .HasName("WdZ_Primary")
                .HasFillFactor(100);

            entity.ToTable("WdrZestawy", "CDN", tb => tb.HasTrigger("Zestawy_Delete_Trigger"));

            entity.HasIndex(e => new { e.WdZRodzaj, e.WdZStandardowy, e.WdZNazwa, e.WdZId }, "WdZWgNazwy")
                .IsUnique()
                .HasFillFactor(100);

            entity.Property(e => e.WdZStandardowy).HasColumnName("WdZ_Standardowy");
            entity.Property(e => e.WdZId).HasColumnName("WdZ_ID");
            entity.Property(e => e.WdZAutor)
                .HasMaxLength(32)
                .IsUnicode(false)
                .HasColumnName("WdZ_Autor");
            entity.Property(e => e.WdZEdycja)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("WdZ_Edycja");
            entity.Property(e => e.WdZHaslo)
                .HasMaxLength(64)
                .HasColumnName("WdZ_Haslo");
            entity.Property(e => e.WdZHasloChk)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("WdZ_Haslo_chk");
            entity.Property(e => e.WdZKopiaEl).HasColumnName("WdZ_KopiaEl");
            entity.Property(e => e.WdZKopiaElGdzie).HasColumnName("WdZ_KopiaElGdzie");
            entity.Property(e => e.WdZNazwa)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("WdZ_Nazwa");
            entity.Property(e => e.WdZOpeModId).HasColumnName("WdZ_OpeModId");
            entity.Property(e => e.WdZOpeModKod)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("WdZ_OpeModKod");
            entity.Property(e => e.WdZOpeModNazwisko)
                .HasMaxLength(50)
                .HasDefaultValue("")
                .HasColumnName("WdZ_OpeModNazwisko");
            entity.Property(e => e.WdZOpeZalId).HasColumnName("WdZ_OpeZalId");
            entity.Property(e => e.WdZOpeZalKod)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("WdZ_OpeZalKod");
            entity.Property(e => e.WdZOpeZalNazwisko)
                .HasMaxLength(50)
                .HasDefaultValue("")
                .HasColumnName("WdZ_OpeZalNazwisko");
            entity.Property(e => e.WdZOpis)
                .HasMaxLength(1024)
                .IsUnicode(false)
                .HasColumnName("WdZ_Opis");
            entity.Property(e => e.WdZPodpisCyfrowy).HasColumnName("WdZ_PodpisCyfrowy");
            entity.Property(e => e.WdZRodzaj).HasColumnName("WdZ_Rodzaj");
            entity.Property(e => e.WdZTsMod)
                .HasColumnType("datetime")
                .HasColumnName("WdZ_TS_Mod");
            entity.Property(e => e.WdZTsZal)
                .HasColumnType("datetime")
                .HasColumnName("WdZ_TS_Zal");
            entity.Property(e => e.WdZWarunek)
                .HasMaxLength(4096)
                .IsUnicode(false)
                .HasColumnName("WdZ_Warunek");
            entity.Property(e => e.WdZWarunekAuto)
                .HasMaxLength(1024)
                .IsUnicode(false)
                .HasColumnName("WdZ_WarunekAuto");
            entity.Property(e => e.WdZWersja)
                .HasMaxLength(16)
                .IsUnicode(false)
                .HasColumnName("WdZ_Wersja");
        });

        modelBuilder.Entity<WebSubtask>(entity =>
        {
            entity.HasKey(e => e.StaStaId)
                .HasName("STaS_Primary")
                .HasFillFactor(100);

            entity.ToTable("Web_Subtasks", "CDN");

            entity.HasIndex(e => e.StaDatabaseGuid, "IX_STa_DatabaseGuid").HasFillFactor(100);

            entity.HasIndex(e => e.StaTasId, "IX_STa_TasID").HasFillFactor(100);

            entity.Property(e => e.StaStaId).HasColumnName("Sta_StaID");
            entity.Property(e => e.StaCommandName).HasColumnName("STa_CommandName");
            entity.Property(e => e.StaCreationDateTime).HasColumnName("STa_CreationDateTime");
            entity.Property(e => e.StaDatabaseGuid).HasColumnName("STa_DatabaseGuid");
            entity.Property(e => e.StaEndDateTime).HasColumnName("STa_EndDateTime");
            entity.Property(e => e.StaInstanceAction).HasColumnName("STa_InstanceAction");
            entity.Property(e => e.StaJsonData).HasColumnName("STa_JsonData");
            entity.Property(e => e.StaStartDateTime).HasColumnName("STa_StartDateTime");
            entity.Property(e => e.StaStatus).HasColumnName("STa_Status");
            entity.Property(e => e.StaTasId).HasColumnName("STa_TasID");

            entity.HasOne(d => d.StaTas).WithMany(p => p.WebSubtasks)
                .HasForeignKey(d => d.StaTasId)
                .HasConstraintName("FK_STa_TasID");
        });

        modelBuilder.Entity<WebSubtasksLog>(entity =>
        {
            entity.HasKey(e => e.StlStlid)
                .HasName("STL_Primary")
                .HasFillFactor(100);

            entity.ToTable("Web_SubtasksLogs", "CDN");

            entity.HasIndex(e => e.StlStaId, "IX_STL_StaID").HasFillFactor(100);

            entity.Property(e => e.StlStlid).HasColumnName("STL_STLID");
            entity.Property(e => e.StlLogLevel).HasColumnName("STL_LogLevel");
            entity.Property(e => e.StlMessage).HasColumnName("STL_Message");
            entity.Property(e => e.StlStaId).HasColumnName("STL_StaID");

            entity.HasOne(d => d.StlSta).WithMany(p => p.WebSubtasksLogs)
                .HasForeignKey(d => d.StlStaId)
                .HasConstraintName("FK_STL_StaID");
        });

        modelBuilder.Entity<WebTask>(entity =>
        {
            entity.HasKey(e => e.TasTasId)
                .HasName("Tas_Primary")
                .HasFillFactor(100);

            entity.ToTable("Web_Tasks", "CDN");

            entity.HasIndex(e => e.TasDeleted, "IX_Tas_Deleted").HasFillFactor(100);

            entity.HasIndex(e => e.TasOperatorId, "IX_Tas_OperatorId").HasFillFactor(100);

            entity.Property(e => e.TasTasId).HasColumnName("Tas_TasID");
            entity.Property(e => e.TasActionIndex).HasColumnName("Tas_ActionIndex");
            entity.Property(e => e.TasActionParams).HasColumnName("Tas_ActionParams");
            entity.Property(e => e.TasCancelled).HasColumnName("Tas_Cancelled");
            entity.Property(e => e.TasCreatedDate).HasColumnName("Tas_CreatedDate");
            entity.Property(e => e.TasDeleted).HasColumnName("Tas_Deleted");
            entity.Property(e => e.TasDeletedDate).HasColumnName("Tas_DeletedDate");
            entity.Property(e => e.TasEndDate).HasColumnName("Tas_EndDate");
            entity.Property(e => e.TasOperatorId).HasColumnName("Tas_OperatorId");
        });

        modelBuilder.Entity<WebViewSetting>(entity =>
        {
            entity.HasKey(e => e.VseVseId)
                .HasName("VSe_Primary")
                .HasFillFactor(100);

            entity.ToTable("Web_ViewSettings", "CDN");

            entity.HasIndex(e => new { e.VseKey, e.VseOpeId }, "IX_VSe_Key_OpeID").HasFillFactor(100);

            entity.Property(e => e.VseVseId).HasColumnName("VSe_VSeID");
            entity.Property(e => e.VseKey).HasColumnName("VSe_Key");
            entity.Property(e => e.VseOpeId).HasColumnName("VSe_OpeID");
            entity.Property(e => e.VseSettings).HasColumnName("VSe_Settings");
        });

        modelBuilder.Entity<WidokiKolumny>(entity =>
        {
            entity.HasKey(e => e.WiCWiCid)
                .HasName("WiC_Primary")
                .HasFillFactor(100);

            entity.ToTable("WidokiKolumny", "CDN");

            entity.HasIndex(e => e.WiCKakid, "WiCAtrKlasy").HasFillFactor(100);

            entity.HasIndex(e => e.WiCWiNid, "WiCWidokiNazwy").HasFillFactor(100);

            entity.Property(e => e.WiCWiCid).HasColumnName("WiC_WiCId");
            entity.Property(e => e.WiCGrupowanie).HasColumnName("WiC_Grupowanie");
            entity.Property(e => e.WiCKakid).HasColumnName("WiC_KAKId");
            entity.Property(e => e.WiCLp).HasColumnName("WiC_Lp");
            entity.Property(e => e.WiCSzerokosc).HasColumnName("WiC_Szerokosc");
            entity.Property(e => e.WiCWiNid).HasColumnName("WiC_WiNId");

            entity.HasOne(d => d.WiCKak).WithMany(p => p.WidokiKolumnies)
                .HasForeignKey(d => d.WiCKakid)
                .HasConstraintName("FK_WiCAtrKlasy");

            entity.HasOne(d => d.WiCWiN).WithMany(p => p.WidokiKolumnies)
                .HasForeignKey(d => d.WiCWiNid)
                .HasConstraintName("FK_WiCWidokiNazwy");
        });

        modelBuilder.Entity<WidokiNazwy>(entity =>
        {
            entity.HasKey(e => e.WiNWiNid)
                .HasName("WiN_Primary")
                .HasFillFactor(100);

            entity.ToTable("WidokiNazwy", "CDN", tb => tb.HasTrigger("WidokiNazwy_Delete_Trigger"));

            entity.HasIndex(e => e.WiNNazwa, "WiNNazwa")
                .IsUnique()
                .HasFillFactor(100);

            entity.Property(e => e.WiNWiNid).HasColumnName("WiN_WiNId");
            entity.Property(e => e.WiNNazwa)
                .HasMaxLength(20)
                .HasColumnName("WiN_Nazwa");
            entity.Property(e => e.WiNSystemowy).HasColumnName("WiN_Systemowy");
        });

        modelBuilder.Entity<Wydruki>(entity =>
        {
            entity.HasKey(e => new { e.WdrStandardowy, e.WdrId })
                .HasName("Wdr_Primary")
                .HasFillFactor(100);

            entity.ToTable("Wydruki", "CDN", tb => tb.HasTrigger("Wydruki_Delete_Trigger"));

            entity.HasIndex(e => new { e.WdrRodzaj, e.WdrStandardowy, e.WdrNazwa, e.WdrId }, "WdrWgNazwy")
                .IsUnique()
                .HasFillFactor(100);

            entity.HasIndex(e => new { e.WdrStandardowy, e.WdrRpWid, e.WdrRpFid, e.WdrId }, "WdrWgRpX")
                .IsUnique()
                .HasFillFactor(100);

            entity.Property(e => e.WdrStandardowy).HasColumnName("Wdr_Standardowy");
            entity.Property(e => e.WdrId).HasColumnName("Wdr_ID");
            entity.Property(e => e.WdrAutor)
                .HasMaxLength(32)
                .IsUnicode(false)
                .HasColumnName("Wdr_Autor");
            entity.Property(e => e.WdrDefinicja)
                .HasColumnType("text")
                .HasColumnName("Wdr_Definicja");
            entity.Property(e => e.WdrDomyslnyFormatEksportu).HasColumnName("Wdr_DomyslnyFormatEksportu");
            entity.Property(e => e.WdrDomyslnyTypUrzadzenia).HasColumnName("Wdr_DomyslnyTypUrzadzenia");
            entity.Property(e => e.WdrDrukarkaDomyslna)
                .HasMaxLength(256)
                .IsUnicode(false)
                .HasColumnName("Wdr_DrukarkaDomyslna");
            entity.Property(e => e.WdrDuplex).HasColumnName("Wdr_Duplex");
            entity.Property(e => e.WdrETeczka).HasColumnName("Wdr_eTeczka");
            entity.Property(e => e.WdrETeczkaCzesc).HasColumnName("Wdr_eTeczkaCzesc");
            entity.Property(e => e.WdrEco).HasColumnName("Wdr_Eco");
            entity.Property(e => e.WdrEdycja)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("Wdr_Edycja");
            entity.Property(e => e.WdrHaslo)
                .HasMaxLength(64)
                .HasColumnName("Wdr_Haslo");
            entity.Property(e => e.WdrHasloChk)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("Wdr_Haslo_chk");
            entity.Property(e => e.WdrIgnorujFiltrApp).HasColumnName("Wdr_IgnorujFiltrApp");
            entity.Property(e => e.WdrIgnorujKluczApp).HasColumnName("Wdr_IgnorujKluczApp");
            entity.Property(e => e.WdrIloscKopii).HasColumnName("Wdr_IloscKopii");
            entity.Property(e => e.WdrKompresja).HasColumnName("Wdr_Kompresja");
            entity.Property(e => e.WdrKopiaEl).HasColumnName("Wdr_KopiaEl");
            entity.Property(e => e.WdrKopiaElGdzie).HasColumnName("Wdr_KopiaElGdzie");
            entity.Property(e => e.WdrLaczPdf).HasColumnName("Wdr_LaczPDF");
            entity.Property(e => e.WdrMarginesG).HasColumnName("Wdr_MarginesG");
            entity.Property(e => e.WdrMarginesL).HasColumnName("Wdr_MarginesL");
            entity.Property(e => e.WdrNazwa)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Wdr_Nazwa");
            entity.Property(e => e.WdrObslugaKolejki).HasColumnName("Wdr_ObslugaKolejki");
            entity.Property(e => e.WdrOdswiezDanePoWykonaniu).HasColumnName("Wdr_OdswiezDanePoWykonaniu");
            entity.Property(e => e.WdrOpeModId).HasColumnName("Wdr_OpeModId");
            entity.Property(e => e.WdrOpeModKod)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("Wdr_OpeModKod");
            entity.Property(e => e.WdrOpeModNazwisko)
                .HasMaxLength(50)
                .HasDefaultValue("")
                .HasColumnName("Wdr_OpeModNazwisko");
            entity.Property(e => e.WdrOpeZalId).HasColumnName("Wdr_OpeZalId");
            entity.Property(e => e.WdrOpeZalKod)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("Wdr_OpeZalKod");
            entity.Property(e => e.WdrOpeZalNazwisko)
                .HasMaxLength(50)
                .HasDefaultValue("")
                .HasColumnName("Wdr_OpeZalNazwisko");
            entity.Property(e => e.WdrOpis)
                .HasMaxLength(1024)
                .IsUnicode(false)
                .HasColumnName("Wdr_Opis");
            entity.Property(e => e.WdrParametry)
                .HasColumnType("text")
                .HasColumnName("Wdr_Parametry");
            entity.Property(e => e.WdrPodTyp).HasColumnName("Wdr_PodTyp");
            entity.Property(e => e.WdrPodpisCyfrowy).HasColumnName("Wdr_PodpisCyfrowy");
            entity.Property(e => e.WdrRodzaj).HasColumnName("Wdr_Rodzaj");
            entity.Property(e => e.WdrRozmiarDefinicji).HasColumnName("Wdr_RozmiarDefinicji");
            entity.Property(e => e.WdrRpFid).HasColumnName("Wdr_RpFID");
            entity.Property(e => e.WdrRpWid).HasColumnName("Wdr_RpWID");
            entity.Property(e => e.WdrSeryjny).HasColumnName("Wdr_Seryjny");
            entity.Property(e => e.WdrSortujKopie).HasColumnName("Wdr_SortujKopie");
            entity.Property(e => e.WdrTsMod)
                .HasColumnType("datetime")
                .HasColumnName("Wdr_TS_Mod");
            entity.Property(e => e.WdrTsZal)
                .HasColumnType("datetime")
                .HasColumnName("Wdr_TS_Zal");
            entity.Property(e => e.WdrTyp).HasColumnName("Wdr_Typ");
            entity.Property(e => e.WdrTypObslugiZaznaczen).HasColumnName("Wdr_TypObslugiZaznaczen");
            entity.Property(e => e.WdrUkryjDefinicje).HasColumnName("Wdr_UkryjDefinicje");
            entity.Property(e => e.WdrWarunek)
                .HasMaxLength(4096)
                .IsUnicode(false)
                .HasColumnName("Wdr_Warunek");
            entity.Property(e => e.WdrWarunekAuto)
                .HasMaxLength(1024)
                .IsUnicode(false)
                .HasColumnName("Wdr_WarunekAuto");
            entity.Property(e => e.WdrWersja)
                .HasMaxLength(16)
                .IsUnicode(false)
                .HasColumnName("Wdr_Wersja");
            entity.Property(e => e.WdrWzorzecNazwyPlikuWynikowego)
                .HasMaxLength(1024)
                .HasColumnName("Wdr_WzorzecNazwyPlikuWynikowego");
            entity.Property(e => e.WdrZrodloDanychFirmy).HasColumnName("Wdr_ZrodloDanychFirmy");
        });

        modelBuilder.Entity<ZadaniaWtle>(entity =>
        {
            entity.HasKey(e => e.ZwtZwtId)
                .HasName("ZWT_Primary")
                .HasFillFactor(100);

            entity.ToTable("ZadaniaWTle", "CDN");

            entity.HasIndex(e => new { e.ZwtOpeId, e.ZwtBazGuid }, "ZWTWgBazy").HasFillFactor(100);

            entity.Property(e => e.ZwtZwtId).HasColumnName("ZWT_ZwtId");
            entity.Property(e => e.ZwtBazGuid).HasColumnName("ZWT_BazGuid");
            entity.Property(e => e.ZwtDataOstatniaAktualizacja)
                .HasColumnType("datetime")
                .HasColumnName("ZWT_DataOstatniaAktualizacja");
            entity.Property(e => e.ZwtDataRekomendowanyStart)
                .HasColumnType("datetime")
                .HasColumnName("ZWT_DataRekomendowanyStart");
            entity.Property(e => e.ZwtOpeId).HasColumnName("ZWT_OpeId");
            entity.Property(e => e.ZwtParametry).HasColumnName("ZWT_Parametry");
            entity.Property(e => e.ZwtTyp).HasColumnName("ZWT_Typ");
            entity.Property(e => e.ZwtWykonywanie).HasColumnName("ZWT_Wykonywanie");

            entity.HasOne(d => d.ZwtOpe).WithMany(p => p.ZadaniaWtles)
                .HasForeignKey(d => d.ZwtOpeId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ZwtOpeId");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}

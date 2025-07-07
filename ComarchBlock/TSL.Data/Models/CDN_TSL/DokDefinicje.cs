using System;
using System.Collections.Generic;

namespace TSL.Data.Models.CDN_TSL;

public partial class DokDefinicje
{
    public int DdfDdfId { get; set; }

    public int DdfKlasa { get; set; }

    public string DdfSymbol { get; set; } = null!;

    public string? DdfPrevSymbol { get; set; }

    public string DdfNazwa { get; set; } = null!;

    public byte DdfNieaktywna { get; set; }

    public string DdfNumeracja { get; set; } = null!;

    public string? DdfPrevNumeracja { get; set; }

    public byte DdfSeriaOperatora { get; set; }

    public int DdfKierunekOrg { get; set; }

    public int? DdfPowDdfId { get; set; }

    public string? DdfPowSeria { get; set; }

    public int? DdfKatalogObdId { get; set; }

    public DateTime? DdfTsExport { get; set; }

    public string? DdfImportAppId { get; set; }

    public string? DdfImportRowId { get; set; }

    public string? DdfImportRowId2 { get; set; }

    public int? DdfImportSchematId { get; set; }

    public int? DdfOpeZalId { get; set; }

    public int? DdfStaZalId { get; set; }

    public DateTime DdfTsZal { get; set; }

    public int? DdfOpeModId { get; set; }

    public int? DdfStaModId { get; set; }

    public DateTime DdfTsMod { get; set; }

    public string DdfOpeModKod { get; set; } = null!;

    public string DdfOpeModNazwisko { get; set; } = null!;

    public string DdfOpeZalKod { get; set; } = null!;

    public string DdfOpeZalNazwisko { get; set; } = null!;

    public virtual ICollection<BnkDokNag> BnkDokNags { get; set; } = new List<BnkDokNag>();

    public virtual ICollection<BnkRachunki> BnkRachunkis { get; set; } = new List<BnkRachunki>();

    public virtual ICollection<BnkRaporty> BnkRaporties { get; set; } = new List<BnkRaporty>();

    public virtual ICollection<BnkRozKwoty> BnkRozKwoties { get; set; } = new List<BnkRozKwoty>();

    public virtual ICollection<BnkRozKwotyMw> BnkRozKwotyMws { get; set; } = new List<BnkRozKwotyMw>();

    public virtual ICollection<BnkZapisy> BnkZapisies { get; set; } = new List<BnkZapisy>();

    public virtual ICollection<BnkZdarzenium> BnkZdarzenia { get; set; } = new List<BnkZdarzenium>();

    public virtual ICollection<Bonag> Bonags { get; set; } = new List<Bonag>();

    public virtual ICollection<Crmkontakty> Crmkontakties { get; set; } = new List<Crmkontakty>();

    public virtual ICollection<DokumentyDostawyNag> DokumentyDostawyNags { get; set; } = new List<DokumentyDostawyNag>();

    public virtual ICollection<EwidDodNag> EwidDodNags { get; set; } = new List<EwidDodNag>();

    public virtual ICollection<KompensatyNag> KompensatyNags { get; set; } = new List<KompensatyNag>();

    public virtual ICollection<KsiDokNag> KsiDokNags { get; set; } = new List<KsiDokNag>();

    public virtual ICollection<ListyPlac> ListyPlacs { get; set; } = new List<ListyPlac>();

    public virtual ICollection<NotyOdsNag> NotyOdsNags { get; set; } = new List<NotyOdsNag>();

    public virtual ICollection<OfertyDok> OfertyDoks { get; set; } = new List<OfertyDok>();

    public virtual ICollection<PracTeczki> PracTeczkis { get; set; } = new List<PracTeczki>();

    public virtual ICollection<SenditZleceniePrzesylki> SenditZleceniePrzesylkis { get; set; } = new List<SenditZleceniePrzesylki>();

    public virtual ICollection<SentZgloszenium> SentZgloszenia { get; set; } = new List<SentZgloszenium>();

    public virtual ICollection<TraNag> TraNags { get; set; } = new List<TraNag>();

    public virtual ICollection<TrwaleAinag> TrwaleAinags { get; set; } = new List<TrwaleAinag>();

    public virtual ICollection<Umowy> Umowies { get; set; } = new List<Umowy>();

    public virtual ICollection<UmowyB2b> UmowyB2bs { get; set; } = new List<UmowyB2b>();

    public virtual ICollection<Wyplaty> Wyplaties { get; set; } = new List<Wyplaty>();

    public virtual ICollection<WyposazenieAinag> WyposazenieAinags { get; set; } = new List<WyposazenieAinag>();
}

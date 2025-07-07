using System;
using System.Collections.Generic;

namespace TSL.Data.Models.CDN_TSL_Szkolenia2;

public partial class BnkNazwy
{
    public int BnaBnaId { get; set; }

    public short? BnaPodmiotTyp { get; set; }

    public string BnaAkronim { get; set; } = null!;

    public string BnaNumer { get; set; } = null!;

    public string BnaCentrala { get; set; } = null!;

    public string BnaSwift { get; set; } = null!;

    public string BnaNazwa1 { get; set; } = null!;

    public string BnaNazwa2 { get; set; } = null!;

    public string BnaKraj { get; set; } = null!;

    public string BnaWojewodztwo { get; set; } = null!;

    public string BnaPowiat { get; set; } = null!;

    public string BnaGmina { get; set; } = null!;

    public string BnaUlica { get; set; } = null!;

    public string BnaNrDomu { get; set; } = null!;

    public string BnaNrLokalu { get; set; } = null!;

    public string BnaMiasto { get; set; } = null!;

    public string BnaKodPocztowy { get; set; } = null!;

    public string BnaPoczta { get; set; } = null!;

    public string BnaAdres2 { get; set; } = null!;

    public string? BnaModem { get; set; }

    public string BnaTelefon { get; set; } = null!;

    public string BnaTelefonSms { get; set; } = null!;

    public string BnaFax { get; set; } = null!;

    public string BnaEmail { get; set; } = null!;

    public string? BnaUrl { get; set; }

    public string? BnaUid { get; set; }

    public string? BnaPwd { get; set; }

    public short BnaFormat { get; set; }

    public short? BnaFormatUs { get; set; }

    public short? BnaFormatZus { get; set; }

    public short? BnaFormatSplitPay { get; set; }

    public short? BnaFormatImp { get; set; }

    public short BnaCzasRealizacji { get; set; }

    public short BnaIban { get; set; }

    public string BnaRachunekNr { get; set; } = null!;

    public short BnaZagraniczny { get; set; }

    public int? BnaKatId { get; set; }

    public byte BnaNieRozliczac { get; set; }

    public byte BnaNieaktywny { get; set; }

    public DateTime? BnaTsExport { get; set; }

    public string? BnaImportAppId { get; set; }

    public string? BnaImportRowId { get; set; }

    public int? BnaOpeZalId { get; set; }

    public int? BnaStaZalId { get; set; }

    public DateTime BnaTsZal { get; set; }

    public int? BnaOpeModId { get; set; }

    public int? BnaStaModId { get; set; }

    public DateTime BnaTsMod { get; set; }

    public string BnaOpeModKod { get; set; } = null!;

    public string BnaOpeModNazwisko { get; set; } = null!;

    public string BnaOpeZalKod { get; set; } = null!;

    public string BnaOpeZalNazwisko { get; set; } = null!;

    public short? BnaGidtyp { get; set; }

    public int? BnaGidfirma { get; set; }

    public int? BnaGidnumer { get; set; }

    public short? BnaGidlp { get; set; }

    public string? BnaCdckontaktOsoba { get; set; }

    public string? BnaCdckontakt { get; set; }

    public byte? BnaCdcoplatyPonosi { get; set; }

    public string? BnaCdcclientId { get; set; }

    public string? BnaCdcsecretKey { get; set; }

    public virtual Kategorie? BnaKat { get; set; }

    public virtual ICollection<BnkCertyfikaty> BnkCertyfikaties { get; set; } = new List<BnkCertyfikaty>();

    public virtual ICollection<BnkRachunki> BnkRachunkis { get; set; } = new List<BnkRachunki>();

    public virtual ICollection<BnkSposobyLogowanium> BnkSposobyLogowania { get; set; } = new List<BnkSposobyLogowanium>();

    public virtual ICollection<BnkZapisy> BnkZapisies { get; set; } = new List<BnkZapisy>();

    public virtual ICollection<BnkZdarzenium> BnkZdarzenia { get; set; } = new List<BnkZdarzenium>();

    public virtual ICollection<Kontrahenci> Kontrahencis { get; set; } = new List<Kontrahenci>();

    public virtual ICollection<PracEtaty> PracEtatyPreBnaIdMikroNavigations { get; set; } = new List<PracEtaty>();

    public virtual ICollection<PracEtaty> PracEtatyPreBnas { get; set; } = new List<PracEtaty>();

    public virtual ICollection<SchematPlatnosci> SchematPlatnoscis { get; set; } = new List<SchematPlatnosci>();

    public virtual ICollection<UrzRachunki> UrzRachunkis { get; set; } = new List<UrzRachunki>();
}

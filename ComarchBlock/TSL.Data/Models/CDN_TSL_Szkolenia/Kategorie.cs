using System;
using System.Collections.Generic;

namespace TSL.Data.Models.CDN_TSL_Szkolenia;

public partial class Kategorie
{
    public int KatKatId { get; set; }

    public short KatTyp { get; set; }

    public short KatPoziom { get; set; }

    public int? KatParentId { get; set; }

    public string KatKodOgolny { get; set; } = null!;

    public string KatKodSzczegol { get; set; } = null!;

    public string KatOpis { get; set; } = null!;

    public byte KatKolumnaKpir { get; set; }

    public byte KatKolumnaRycz { get; set; }

    public short? KatWzId { get; set; }

    public decimal KatStawka { get; set; }

    public short KatFlaga { get; set; }

    public decimal KatZrodlowa { get; set; }

    public short KatOdliczenia { get; set; }

    public short KatRodzajZakupu { get; set; }

    public byte KatFiskalny { get; set; }

    public byte KatDetal { get; set; }

    public decimal KatKwota { get; set; }

    public decimal KatUdzial { get; set; }

    public decimal KatBudzet { get; set; }

    public byte KatNieaktywny { get; set; }

    public string KatKontoSegmentWn { get; set; } = null!;

    public string KatKontoSegmentMa { get; set; } = null!;

    public DateTime? KatTsUzyc { get; set; }

    public string KatElixirO1 { get; set; } = null!;

    public string KatElixirO2 { get; set; } = null!;

    public string KatElixirO3 { get; set; } = null!;

    public string KatElixirO4 { get; set; } = null!;

    public byte KatPodzielOdliczenia { get; set; }

    public decimal KatPodzielOdliczeniaProcent { get; set; }

    public byte KatKsiegujWkoszty { get; set; }

    public decimal KatKsiegujWkosztyProcent { get; set; }

    public DateTime? KatTsExport { get; set; }

    public string? KatImportAppId { get; set; }

    public string? KatImportRowId { get; set; }

    public int? KatOpeZalId { get; set; }

    public int? KatStaZalId { get; set; }

    public DateTime KatTsZal { get; set; }

    public int? KatOpeModId { get; set; }

    public int? KatStaModId { get; set; }

    public DateTime KatTsMod { get; set; }

    public string KatOpeModKod { get; set; } = null!;

    public string KatOpeModNazwisko { get; set; } = null!;

    public string KatOpeZalKod { get; set; } = null!;

    public string KatOpeZalNazwisko { get; set; } = null!;

    public virtual ICollection<AutoKoszty> AutoKoszties { get; set; } = new List<AutoKoszty>();

    public virtual ICollection<AutoRozlicz> AutoRozliczs { get; set; } = new List<AutoRozlicz>();

    public virtual ICollection<BnkDokNag> BnkDokNags { get; set; } = new List<BnkDokNag>();

    public virtual ICollection<BnkNazwy> BnkNazwies { get; set; } = new List<BnkNazwy>();

    public virtual ICollection<BnkZapisy> BnkZapisies { get; set; } = new List<BnkZapisy>();

    public virtual ICollection<BnkZdarzenium> BnkZdarzenia { get; set; } = new List<BnkZdarzenium>();

    public virtual ICollection<Bonag> Bonags { get; set; } = new List<Bonag>();

    public virtual ICollection<DekretyElem> DekretyElems { get; set; } = new List<DekretyElem>();

    public virtual ICollection<DekretyNag> DekretyNags { get; set; } = new List<DekretyNag>();

    public virtual ICollection<EwidDodElem> EwidDodElems { get; set; } = new List<EwidDodElem>();

    public virtual ICollection<EwidDodNag> EwidDodNags { get; set; } = new List<EwidDodNag>();

    public virtual ICollection<KatStawkiVat> KatStawkiVats { get; set; } = new List<KatStawkiVat>();

    public virtual ICollection<KompensatyNag> KompensatyNags { get; set; } = new List<KompensatyNag>();

    public virtual ICollection<Kontrahenci> KontrahenciKntKatZaks { get; set; } = new List<Kontrahenci>();

    public virtual ICollection<Kontrahenci> KontrahenciKntKats { get; set; } = new List<Kontrahenci>();

    public virtual ICollection<KwotyDodatkowe> KwotyDodatkoweKddKat2s { get; set; } = new List<KwotyDodatkowe>();

    public virtual ICollection<KwotyDodatkowe> KwotyDodatkoweKddKats { get; set; } = new List<KwotyDodatkowe>();

    public virtual ICollection<NotyOdsNag> NotyOdsNags { get; set; } = new List<NotyOdsNag>();

    public virtual ICollection<OkresoweElem> OkresoweElems { get; set; } = new List<OkresoweElem>();

    public virtual ICollection<OkresoweNag> OkresoweNags { get; set; } = new List<OkresoweNag>();

    public virtual ICollection<PracEtaty> PracEtaties { get; set; } = new List<PracEtaty>();

    public virtual ICollection<RemanentNag> RemanentNags { get; set; } = new List<RemanentNag>();

    public virtual ICollection<Ryczalt> Ryczalts { get; set; } = new List<Ryczalt>();

    public virtual ICollection<SrsCyklElem> SrsCyklElems { get; set; } = new List<SrsCyklElem>();

    public virtual ICollection<SrsCyklNag> SrsCyklNags { get; set; } = new List<SrsCyklNag>();

    public virtual ICollection<SrsCzesci> SrsCzescis { get; set; } = new List<SrsCzesci>();

    public virtual ICollection<SrsCzynnosci> SrsCzynnoscis { get; set; } = new List<SrsCzynnosci>();

    public virtual ICollection<SrsZlecenium> SrsZlecenia { get; set; } = new List<SrsZlecenium>();

    public virtual ICollection<Towary> TowaryTwrKatZaks { get; set; } = new List<Towary>();

    public virtual ICollection<Towary> TowaryTwrKats { get; set; } = new List<Towary>();

    public virtual ICollection<TraElem> TraElems { get; set; } = new List<TraElem>();

    public virtual ICollection<TraNag> TraNags { get; set; } = new List<TraNag>();

    public virtual ICollection<TrwaleAinag> TrwaleAinags { get; set; } = new List<TrwaleAinag>();

    public virtual ICollection<TrwaleHist> TrwaleHists { get; set; } = new List<TrwaleHist>();

    public virtual ICollection<Trwale> Trwales { get; set; } = new List<Trwale>();

    public virtual ICollection<Urzedy> Urzedies { get; set; } = new List<Urzedy>();

    public virtual ICollection<VatNag> VatNags { get; set; } = new List<VatNag>();

    public virtual ICollection<VatTab> VatTabVaTKat2s { get; set; } = new List<VatTab>();

    public virtual ICollection<VatTab> VatTabVaTKats { get; set; } = new List<VatTab>();

    public virtual ICollection<WypElementy> WypElementies { get; set; } = new List<WypElementy>();

    public virtual ICollection<Wyplaty> Wyplaties { get; set; } = new List<Wyplaty>();

    public virtual ICollection<WyplatyElem> WyplatyElems { get; set; } = new List<WyplatyElem>();

    public virtual ICollection<WyplatyNag> WyplatyNags { get; set; } = new List<WyplatyNag>();

    public virtual ICollection<WyposazenieAinag> WyposazenieAinags { get; set; } = new List<WyposazenieAinag>();

    public virtual ICollection<Wyposazenie> Wyposazenies { get; set; } = new List<Wyposazenie>();

    public virtual ICollection<ZapisyKpr> ZapisyKprs { get; set; } = new List<ZapisyKpr>();
}

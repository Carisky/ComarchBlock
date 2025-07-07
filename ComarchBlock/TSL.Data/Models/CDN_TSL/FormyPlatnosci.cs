using System;
using System.Collections.Generic;

namespace TSL.Data.Models.CDN_TSL;

public partial class FormyPlatnosci
{
    public int FplFplId { get; set; }

    public string FplNazwa { get; set; } = null!;

    public short FplTyp { get; set; }

    public int? FplBraId { get; set; }

    public short? FplPodmiotTyp { get; set; }

    public int? FplPodmiotId { get; set; }

    public short FplTermin { get; set; }

    public short FplNieAktywny { get; set; }

    public DateTime? FplTsExport { get; set; }

    public string? FplImportAppId { get; set; }

    public string? FplImportRowId { get; set; }

    public int? FplXlid { get; set; }

    public decimal FplRabat { get; set; }

    public short FplTerminalPlatniczy { get; set; }

    public int FplKseFid { get; set; }

    public byte? FplDomyslna { get; set; }

    public virtual ICollection<BnkZdarzenium> BnkZdarzenia { get; set; } = new List<BnkZdarzenium>();

    public virtual ICollection<CfgKurierzyPobranieFormyPlat> CfgKurierzyPobranieFormyPlats { get; set; } = new List<CfgKurierzyPobranieFormyPlat>();

    public virtual ICollection<EwidDodNag> EwidDodNags { get; set; } = new List<EwidDodNag>();

    public virtual ICollection<FormyPlatnWaluty> FormyPlatnWaluties { get; set; } = new List<FormyPlatnWaluty>();

    public virtual ICollection<FormyPlatnosciDf> FormyPlatnosciDfs { get; set; } = new List<FormyPlatnosciDf>();

    public virtual BnkRachunki? FplBra { get; set; }

    public virtual ICollection<Kontrahenci> Kontrahencis { get; set; } = new List<Kontrahenci>();

    public virtual ICollection<NotyOdsNag> NotyOdsNags { get; set; } = new List<NotyOdsNag>();

    public virtual ICollection<PracEtaty> PracEtaties { get; set; } = new List<PracEtaty>();

    public virtual ICollection<SchematPlatnosci> SchematPlatnoscis { get; set; } = new List<SchematPlatnosci>();

    public virtual ICollection<TraNag> TraNags { get; set; } = new List<TraNag>();

    public virtual ICollection<VatNag> VatNags { get; set; } = new List<VatNag>();
}

using System;
using System.Collections.Generic;

namespace TSL.Data.Models.CDN_TSL_Szkolenia;

public partial class BnkRaporty
{
    public int BrpBrpId { get; set; }

    public int? BrpBraId { get; set; }

    public int? BrpDdfId { get; set; }

    public int BrpNumerNr { get; set; }

    public string BrpNumerString { get; set; } = null!;

    public string? BrpNumerPelny { get; set; }

    public string BrpNumerObcy { get; set; } = null!;

    public DateTime BrpDataDok { get; set; }

    public DateTime? BrpDataZam { get; set; }

    public byte BrpZamkniety { get; set; }

    public int? BrpDekId { get; set; }

    public int? BrpPreDekId { get; set; }

    public decimal BrpSaldoBo { get; set; }

    public decimal BrpPrzychody { get; set; }

    public decimal BrpRozchody { get; set; }

    public decimal BrpSaldoBosys { get; set; }

    public decimal BrpPrzychodySys { get; set; }

    public decimal BrpRozchodySys { get; set; }

    public decimal BrpRoznicaKursowaSysMw { get; set; }

    public byte? BrpCdcwb { get; set; }

    public DateTime? BrpTsExport { get; set; }

    public string? BrpImportAppId { get; set; }

    public string? BrpImportRowId { get; set; }

    public int? BrpOpeZalId { get; set; }

    public int? BrpStaZalId { get; set; }

    public DateTime BrpTsZal { get; set; }

    public int? BrpOpeModId { get; set; }

    public int? BrpStaModId { get; set; }

    public DateTime BrpTsMod { get; set; }

    public string BrpOpeModKod { get; set; } = null!;

    public string BrpOpeModNazwisko { get; set; } = null!;

    public string BrpOpeZalKod { get; set; } = null!;

    public string BrpOpeZalNazwisko { get; set; } = null!;

    public short? BrpGidtyp { get; set; }

    public int? BrpGidfirma { get; set; }

    public int? BrpGidnumer { get; set; }

    public short? BrpGidlp { get; set; }

    public virtual ICollection<BnkZapisy> BnkZapisies { get; set; } = new List<BnkZapisy>();

    public virtual ICollection<BrpAgregaty> BrpAgregaties { get; set; } = new List<BrpAgregaty>();

    public virtual BnkRachunki? BrpBra { get; set; }

    public virtual DokDefinicje? BrpDdf { get; set; }
}

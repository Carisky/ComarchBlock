using System;
using System.Collections.Generic;

namespace TSL.Data.Models.CDN_TSL_GROUP;

public partial class Pieczatki
{
    public int PcPcid { get; set; }

    public int PcAktualna { get; set; }

    public DateTime PcDataOd { get; set; }

    public DateTime PcDataDo { get; set; }

    public string? PcNazwa1 { get; set; }

    public string? PcNazwa2 { get; set; }

    public string? PcNazwa3 { get; set; }

    public string? PcNipKraj { get; set; }

    public string? PcNipE { get; set; }

    public string? PcRegon { get; set; }

    public string? PcKraj { get; set; }

    public string? PcKrajIso { get; set; }

    public string? PcWojewodztwo { get; set; }

    public string? PcPowiat { get; set; }

    public string? PcGmina { get; set; }

    public string? PcKodGminy { get; set; }

    public string? PcMiasto { get; set; }

    public string? PcUlica { get; set; }

    public string? PcNrDomu { get; set; }

    public string? PcNrLokalu { get; set; }

    public string? PcUlicaNrDomLok { get; set; }

    public string? PcKodP { get; set; }

    public string? PcPoczta { get; set; }

    public string? PcTelefon { get; set; }

    public string? PcEmail { get; set; }

    public string? PcUrl { get; set; }

    public string? PcOpis { get; set; }

    public string? PcKrsSad { get; set; }

    public string? PcKrsNumer { get; set; }

    public string? PcKrsKapitalZak { get; set; }

    public string? PcKrsKapitalWpl { get; set; }

    public string? PcIlnglnwlasny { get; set; }

    public string? PcIlnglncentrali { get; set; }

    public string? PcPuesc { get; set; }

    public string? PcBdo { get; set; }

    public byte? PcAktDok { get; set; }

    public DateTime? PcTsExport { get; set; }

    public string? PcImportAppId { get; set; }

    public string? PcImportRowId { get; set; }

    public int? PcOpeZalId { get; set; }

    public int? PcStaZalId { get; set; }

    public DateTime PcTsZal { get; set; }

    public int? PcOpeModId { get; set; }

    public int? PcStaModId { get; set; }

    public DateTime PcTsMod { get; set; }

    public string PcOpeModKod { get; set; } = null!;

    public string PcOpeModNazwisko { get; set; } = null!;

    public string PcOpeZalKod { get; set; } = null!;

    public string PcOpeZalNazwisko { get; set; } = null!;

    public virtual ICollection<TraNag> TraNags { get; set; } = new List<TraNag>();
}

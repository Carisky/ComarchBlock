using System;
using System.Collections.Generic;

namespace TSL.Data.Models.CDN_TSL_Szkolenia2;

public partial class PieczatkiJ
{
    public int PcjsPcjsid { get; set; }

    public int PcjsAktualna { get; set; }

    public DateTime PcjsDataOd { get; set; }

    public DateTime PcjsDataDo { get; set; }

    public string? PcjsNazwa1 { get; set; }

    public string? PcjsNazwa2 { get; set; }

    public string? PcjsNazwa3 { get; set; }

    public string? PcjsNipKraj { get; set; }

    public string? PcjsNipE { get; set; }

    public string? PcjsRegon { get; set; }

    public string? PcjsKraj { get; set; }

    public string? PcjsKrajIso { get; set; }

    public string? PcjsWojewodztwo { get; set; }

    public string? PcjsPowiat { get; set; }

    public string? PcjsGmina { get; set; }

    public string? PcjsKodGminy { get; set; }

    public string? PcjsMiasto { get; set; }

    public string? PcjsUlica { get; set; }

    public string? PcjsNrDomu { get; set; }

    public string? PcjsNrLokalu { get; set; }

    public string? PcjsKodP { get; set; }

    public string? PcjsPoczta { get; set; }

    public string? PcjsUlicaNrDomLok { get; set; }

    public string? PcjsTelefon { get; set; }

    public string? PcjsEmail { get; set; }

    public string? PcjsUrl { get; set; }

    public byte? PcjsAktDok { get; set; }

    public DateTime? PcjsTsExport { get; set; }

    public string? PcjsImportAppId { get; set; }

    public string? PcjsImportRowId { get; set; }

    public int? PcjsOpeZalId { get; set; }

    public int? PcjsStaZalId { get; set; }

    public DateTime PcjsTsZal { get; set; }

    public int? PcjsOpeModId { get; set; }

    public int? PcjsStaModId { get; set; }

    public DateTime PcjsTsMod { get; set; }

    public string PcjsOpeModKod { get; set; } = null!;

    public string PcjsOpeModNazwisko { get; set; } = null!;

    public string PcjsOpeZalKod { get; set; } = null!;

    public string PcjsOpeZalNazwisko { get; set; } = null!;

    public virtual ICollection<TraNag> TraNags { get; set; } = new List<TraNag>();
}

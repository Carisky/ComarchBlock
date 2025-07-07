using System;
using System.Collections.Generic;

namespace TSL.Data.Models.CDN_TSL_Szkolenia;

public partial class Urzedy
{
    public int UrzUrzId { get; set; }

    public short? UrzPodmiotTyp { get; set; }

    public string UrzAkronim { get; set; } = null!;

    public string? UrzKod { get; set; }

    public short UrzTypUrzedu { get; set; }

    public short UrzStandardowy { get; set; }

    public string UrzNazwa1 { get; set; } = null!;

    public string UrzNazwa2 { get; set; } = null!;

    public string UrzKraj { get; set; } = null!;

    public string UrzWojewodztwo { get; set; } = null!;

    public string UrzPowiat { get; set; } = null!;

    public string UrzGmina { get; set; } = null!;

    public string UrzUlica { get; set; } = null!;

    public string UrzNrDomu { get; set; } = null!;

    public string UrzNrLokalu { get; set; } = null!;

    public string UrzMiasto { get; set; } = null!;

    public string UrzKodPocztowy { get; set; } = null!;

    public string UrzPoczta { get; set; } = null!;

    public string UrzAdres2 { get; set; } = null!;

    public string UrzTelefon { get; set; } = null!;

    public string UrzTelefonSms { get; set; } = null!;

    public string UrzFax { get; set; } = null!;

    public string UrzEmail { get; set; } = null!;

    public string UrzUrl { get; set; } = null!;

    public int? UrzKatId { get; set; }

    public byte UrzNieRozliczac { get; set; }

    public byte UrzNieaktywny { get; set; }

    public DateTime? UrzTsExport { get; set; }

    public string? UrzImportAppId { get; set; }

    public string? UrzImportRowId { get; set; }

    public int? UrzOpeZalId { get; set; }

    public int? UrzStaZalId { get; set; }

    public DateTime UrzTsZal { get; set; }

    public int? UrzOpeModId { get; set; }

    public int? UrzStaModId { get; set; }

    public DateTime UrzTsMod { get; set; }

    public string UrzOpeModKod { get; set; } = null!;

    public string UrzOpeModNazwisko { get; set; } = null!;

    public string UrzOpeZalKod { get; set; } = null!;

    public string UrzOpeZalNazwisko { get; set; } = null!;

    public virtual Kategorie? UrzKat { get; set; }

    public virtual ICollection<UrzRachunki> UrzRachunkis { get; set; } = new List<UrzRachunki>();
}

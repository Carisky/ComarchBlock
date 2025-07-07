using System;
using System.Collections.Generic;

namespace TSL.Data.Models.CDN_KNF_Konfiguracja;

public partial class UrzedyImport
{
    public int UrzIUrzIid { get; set; }

    public string? UrzIImportRowId { get; set; }

    public string UrzIAkronim { get; set; } = null!;

    public short UrzITypUrzedu { get; set; }

    public string UrzINazwa1 { get; set; } = null!;

    public string UrzINazwa2 { get; set; } = null!;

    public string UrzIKraj { get; set; } = null!;

    public string UrzIWojewodztwo { get; set; } = null!;

    public string UrzIPowiat { get; set; } = null!;

    public string UrzIGmina { get; set; } = null!;

    public string UrzIKodPocztowy { get; set; } = null!;

    public string UrzIPoczta { get; set; } = null!;

    public string UrzIMiasto { get; set; } = null!;

    public string UrzIUlica { get; set; } = null!;

    public string UrzINrDomu { get; set; } = null!;

    public string UrzINrLokalu { get; set; } = null!;

    public string UrzIAdres2 { get; set; } = null!;

    public string UrzITelefon { get; set; } = null!;

    public string UrzIFax { get; set; } = null!;

    public string UrzIUrl { get; set; } = null!;

    public byte UrzINieRozliczac { get; set; }

    public string? UrzIKod { get; set; }

    public string UrzIEmail { get; set; } = null!;

    public string? UrzIKatKodSzczegol { get; set; }

    public string? UrzIKatImportRowId { get; set; }

    public byte UrzINieaktywny { get; set; }

    public string UrzIZrdId { get; set; } = null!;

    public virtual ICollection<UrzRachunkiImport> UrzRachunkiImports { get; set; } = new List<UrzRachunkiImport>();
}

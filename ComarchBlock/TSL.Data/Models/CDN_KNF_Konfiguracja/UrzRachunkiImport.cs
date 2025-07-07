using System;
using System.Collections.Generic;

namespace TSL.Data.Models.CDN_KNF_Konfiguracja;

public partial class UrzRachunkiImport
{
    public int UraIUraIid { get; set; }

    public int UraIUrzIid { get; set; }

    public int? UraITypRach { get; set; }

    public string? UraIBnaNumer { get; set; }

    public string? UraIBnaImportRowId { get; set; }

    public string UraIRachunekNr { get; set; } = null!;

    public short UraIIban { get; set; }

    public virtual UrzedyImport UraIUrzI { get; set; } = null!;
}

using System;
using System.Collections.Generic;

namespace TSL.Data.Models.CDN_TSL_GROUP;

public partial class SchematyOpakNag
{
    public int SonSonid { get; set; }

    public byte SonNieaktywny { get; set; }

    public DateTime? SonTsXl { get; set; }

    public string SonKod { get; set; } = null!;

    public string SonNazwa { get; set; } = null!;

    public int? SonOpeZalId { get; set; }

    public int? SonStaZalId { get; set; }

    public DateTime SonTsZal { get; set; }

    public int? SonOpeModId { get; set; }

    public int? SonStaModId { get; set; }

    public DateTime SonTsMod { get; set; }

    public string SonOpeModKod { get; set; } = null!;

    public string SonOpeModNazwisko { get; set; } = null!;

    public string SonOpeZalKod { get; set; } = null!;

    public string SonOpeZalNazwisko { get; set; } = null!;

    public virtual ICollection<SchematyOpakElem> SchematyOpakElems { get; set; } = new List<SchematyOpakElem>();
}

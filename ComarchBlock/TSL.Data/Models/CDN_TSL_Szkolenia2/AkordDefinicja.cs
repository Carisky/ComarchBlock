using System;
using System.Collections.Generic;

namespace TSL.Data.Models.CDN_TSL_Szkolenia2;

public partial class AkordDefinicja
{
    public int AdfAdfId { get; set; }

    public int AdfTwpId { get; set; }

    public string AdfNazwa { get; set; } = null!;

    public string AdfSkrot { get; set; } = null!;

    public string AdfJednostka { get; set; } = null!;

    public byte AdfNieaktywny { get; set; }

    public byte AdfPomniejszenie { get; set; }

    public short AdfRodzaj { get; set; }

    public byte AdfGodzinowe { get; set; }

    public decimal AdfStawka { get; set; }

    public byte AdfProgresywny { get; set; }

    public byte AdfWgNajwStawki { get; set; }

    public string? AdfImportRowId { get; set; }

    public int? AdfOpeZalId { get; set; }

    public int? AdfStaZalId { get; set; }

    public DateTime AdfTsZal { get; set; }

    public int? AdfOpeModId { get; set; }

    public int? AdfStaModId { get; set; }

    public DateTime AdfTsMod { get; set; }

    public string AdfOpeModKod { get; set; } = null!;

    public string AdfOpeModNazwisko { get; set; } = null!;

    public string AdfOpeZalKod { get; set; } = null!;

    public string AdfOpeZalNazwisko { get; set; } = null!;

    public virtual TypWyplatum AdfTwp { get; set; } = null!;

    public virtual ICollection<AkordProgre> AkordProgres { get; set; } = new List<AkordProgre>();

    public virtual ICollection<AkordyHist> AkordyHists { get; set; } = new List<AkordyHist>();
}

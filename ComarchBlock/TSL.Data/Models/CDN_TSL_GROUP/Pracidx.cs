using System;
using System.Collections.Generic;

namespace TSL.Data.Models.CDN_TSL_GROUP;

public partial class Pracidx
{
    public int PriPriId { get; set; }

    public int PriTyp { get; set; }

    public int? PriDzlId { get; set; }

    public int PriPraId { get; set; }

    public string PriKod { get; set; } = null!;

    public string? PriNazwisko { get; set; }

    public string? PriImie1 { get; set; }

    public string? PriPesel { get; set; }

    public DateTime? PriDataOd { get; set; }

    public DateTime? PriDataDo { get; set; }

    public string PriAdresDzialu { get; set; } = null!;

    public string PriAdresCentrum { get; set; } = null!;

    public int? PriCntId { get; set; }

    public string PriOpis { get; set; } = null!;

    public byte PriArchiwalny { get; set; }

    public int? PriParentId { get; set; }

    public byte PriNadrzedny { get; set; }

    public string? PriImportRowId { get; set; }

    public virtual Dzialy? PriDzl { get; set; }

    public virtual PracKod PriPra { get; set; } = null!;
}

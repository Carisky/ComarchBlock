using System;
using System.Collections.Generic;

namespace TSL.Data.Models.CDN_TSL_Szkolenia2;

public partial class PaczkiPrzelewowNag
{
    public int PcPnPcPnid { get; set; }

    public int PcPnBraId { get; set; }

    public string PcPnNazwa { get; set; } = null!;

    public string? PcPnOpis { get; set; }

    public string PcPnBnkIdentyfikator { get; set; } = null!;

    public byte PcPnStatus { get; set; }

    public string? PcPnPodpisy { get; set; }

    public int? PcPnOpeZalId { get; set; }

    public int? PcPnStaZalId { get; set; }

    public DateTime PcPnTsZal { get; set; }

    public string PcPnOpeZalKod { get; set; } = null!;

    public string PcPnOpeZalNazwisko { get; set; } = null!;

    public int? PcPnOpeModId { get; set; }

    public int? PcPnStaModId { get; set; }

    public DateTime PcPnTsMod { get; set; }

    public string PcPnOpeModKod { get; set; } = null!;

    public string PcPnOpeModNazwisko { get; set; } = null!;

    public virtual ICollection<PaczkiPrzelewowAkceptacje> PaczkiPrzelewowAkceptacjes { get; set; } = new List<PaczkiPrzelewowAkceptacje>();

    public virtual ICollection<PaczkiPrzelewowElem> PaczkiPrzelewowElems { get; set; } = new List<PaczkiPrzelewowElem>();

    public virtual BnkRachunki PcPnBra { get; set; } = null!;
}

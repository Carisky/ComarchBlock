using System;
using System.Collections.Generic;

namespace TSL.Data.Models.CDN_TSL_GROUP;

public partial class SrsUrzadzenium
{
    public int SrUSrUid { get; set; }

    public string SrUKod { get; set; } = null!;

    public string SrUNazwa { get; set; } = null!;

    public string? SrUEan { get; set; }

    public short? SrUPodmiotTyp { get; set; }

    public int? SrUPodmiotId { get; set; }

    public short? SrUOdbiorcaTyp { get; set; }

    public int? SrUOdbId { get; set; }

    public int? SrUSrRid { get; set; }

    public int? SrUTwRid { get; set; }

    public string SrUOpis { get; set; } = null!;

    public byte SrUFczynnosci { get; set; }

    public byte SrUFczesci { get; set; }

    public int? SrUOpeZalId { get; set; }

    public int? SrUStaZalId { get; set; }

    public DateTime SrUTsZal { get; set; }

    public int? SrUOpeModId { get; set; }

    public int? SrUStaModId { get; set; }

    public DateTime SrUTsMod { get; set; }

    public string SrUOpeModKod { get; set; } = null!;

    public string SrUOpeModNazwisko { get; set; } = null!;

    public string SrUOpeZalKod { get; set; } = null!;

    public string SrUOpeZalNazwisko { get; set; } = null!;

    public virtual PodmiotyView? PodmiotyView { get; set; }

    public virtual PodmiotyView? PodmiotyViewNavigation { get; set; }

    public virtual ICollection<TwrAtrybuty> TwrAtrybuties { get; set; } = new List<TwrAtrybuty>();
}

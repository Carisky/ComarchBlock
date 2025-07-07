using System;
using System.Collections.Generic;

namespace TSL.Data.Models.CDN_TSL_GROUP;

public partial class OfertyKnt
{
    public int OfKOfKid { get; set; }

    public int? OfKOfDid { get; set; }

    public string? OfKKod { get; set; }

    public int OfKLp { get; set; }

    public short? OfKPodmiotTyp { get; set; }

    public int? OfKPodId { get; set; }

    public string OfKPodNazwa1 { get; set; } = null!;

    public string OfKPodNazwa2 { get; set; } = null!;

    public string OfKPodNazwa3 { get; set; } = null!;

    public string OfKPodKraj { get; set; } = null!;

    public string OfKPodWojewodztwo { get; set; } = null!;

    public string OfKPodPowiat { get; set; } = null!;

    public string OfKPodGmina { get; set; } = null!;

    public string OfKPodUlica { get; set; } = null!;

    public string OfKPodNrDomu { get; set; } = null!;

    public string OfKPodNrLokalu { get; set; } = null!;

    public string OfKPodMiasto { get; set; } = null!;

    public string OfKPodKodPocztowy { get; set; } = null!;

    public string OfKPodPoczta { get; set; } = null!;

    public string OfKPodAdres2 { get; set; } = null!;

    public string OfKPodNipKraj { get; set; } = null!;

    public string OfKPodNipE { get; set; } = null!;

    public string OfKPodmiotGln { get; set; } = null!;

    public string OfKPodEmail { get; set; } = null!;

    public int? OfKKnOKnOid { get; set; }

    public virtual OfertyDok? OfKOfD { get; set; }

    public virtual PodmiotyView? PodmiotyView { get; set; }
}

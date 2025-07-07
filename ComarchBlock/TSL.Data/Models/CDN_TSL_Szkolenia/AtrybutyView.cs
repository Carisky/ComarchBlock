using System;
using System.Collections.Generic;

namespace TSL.Data.Models.CDN_TSL_Szkolenia;

public partial class AtrybutyView
{
    public int? AtrAtrId { get; set; }

    public string AtrKod { get; set; } = null!;

    public string? AtrWartoscTxt { get; set; }

    public byte AtrCzyKod { get; set; }

    public int? AtrPodmiotTyp { get; set; }

    public int? AtrPodmiotId { get; set; }

    public int? AtrTwrId { get; set; }
}

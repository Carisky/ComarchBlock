using System;
using System.Collections.Generic;

namespace TSL.Data.Models.CDN_TSL;

public partial class DeklWydr
{
    public int DkWDkWid { get; set; }

    public int DkWDkNid { get; set; }

    public int DkWRubryka { get; set; }

    public short DkWSubRubryka { get; set; }

    public string DkWWartosc { get; set; } = null!;

    public string DkWOpis { get; set; } = null!;

    public virtual DeklNag DkWDkN { get; set; } = null!;
}

using System;
using System.Collections.Generic;

namespace TSL.Data.Models.CDN_TSL_Szkolenia;

public partial class DeklCuk
{
    public int CukCukid { get; set; }

    public int CukDkNid { get; set; }

    public int CukLpFaktury { get; set; }

    public string CukNrFaktury { get; set; } = null!;

    public DateOnly CukDataFaktury { get; set; }

    public string CukNipdostawcy { get; set; } = null!;

    public string CukNipnabywcy { get; set; } = null!;

    public string CukNrPartiiTowaru { get; set; } = null!;

    public virtual DeklNag CukDkN { get; set; } = null!;
}

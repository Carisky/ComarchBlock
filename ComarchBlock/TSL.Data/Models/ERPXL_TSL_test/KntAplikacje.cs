using System;
using System.Collections.Generic;

namespace TSL.Data.Models.ERPXL_TSL_test;

public partial class KntAplikacje
{
    public short KapKntTyp { get; set; }

    public int KapKntNumer { get; set; }

    public int? KapOpeNumer { get; set; }

    public string? KapOpeHaslo { get; set; }

    public int? KapOpeOnumer { get; set; }

    public short? KapMagTyp { get; set; }

    public int? KapMagFirma { get; set; }

    public int? KapMagNumer { get; set; }

    public short? KapMagLp { get; set; }

    public string? KapSeria { get; set; }

    public int? KapTwrGrupaNumer { get; set; }

    public byte? KapCzyPotwierdzone { get; set; }

    public string? KapPrefiksObcy { get; set; }

    public short? KapMagMstyp { get; set; }

    public int? KapMagMsfirma { get; set; }

    public int? KapMagMsnumer { get; set; }

    public short? KapMagMslp { get; set; }

    public virtual ICollection<KntAplikacjeObiekty> KntAplikacjeObiekties { get; set; } = new List<KntAplikacjeObiekty>();
}

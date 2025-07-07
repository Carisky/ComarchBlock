using System;
using System.Collections.Generic;

namespace TSL.Data.Models.ERPXL_TSL_GROUP;

public partial class KntKontakty
{
    public short KnKKntTyp { get; set; }

    public int? KnKKntFirma { get; set; }

    public int KnKKntNumer { get; set; }

    public short KnKKntLp { get; set; }

    public short? KnKOpeTyp { get; set; }

    public int? KnKOpeFirma { get; set; }

    public int? KnKOpeNumer { get; set; }

    public short? KnKOpeLp { get; set; }

    public int? KnKTermin { get; set; }

    public short? KnKPriorytet { get; set; }

    public short? KnKZakonczone { get; set; }

    public short? KnKKontaktZa { get; set; }

    public byte? KnKKontaktJc { get; set; }

    public byte? KnKOkresowy { get; set; }

    public short? KnKLicznik { get; set; }

    public string? KnKNotatki { get; set; }

    public short? KnKKnStyp { get; set; }

    public int? KnKKnSfirma { get; set; }

    public int? KnKKnSnumer { get; set; }

    public int? KnKKnSlp { get; set; }

    public virtual OpeKarty? KnKOpeNumerNavigation { get; set; }
}

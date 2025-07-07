using System;
using System.Collections.Generic;

namespace TSL.Data.Models.ERPXL_TSL_GROUP;

public partial class InwMag
{
    public int InMId { get; set; }

    public int? InMInNid { get; set; }

    public short? InMPozycja { get; set; }

    public short? InMMagTyp { get; set; }

    public int? InMMagFirma { get; set; }

    public int? InMMagNumer { get; set; }

    public short? InMMagLp { get; set; }

    public short? InMRwtyp { get; set; }

    public int? InMRwfirma { get; set; }

    public int? InMRwnumer { get; set; }

    public short? InMRwlp { get; set; }

    public short? InMPwtyp { get; set; }

    public int? InMPwfirma { get; set; }

    public int? InMPwnumer { get; set; }

    public short? InMPwlp { get; set; }

    public int? InMWmnumer { get; set; }

    public int? InMPmnumer { get; set; }

    public int? InMMpnumer { get; set; }

    public virtual InwNag? InMInN { get; set; }

    public virtual Magazyny? InMMagNumerNavigation { get; set; }
}

using System;
using System.Collections.Generic;

namespace TSL.Data.Models.ERPXL_TSL_LMT;

public partial class InwTwr
{
    public int InTId { get; set; }

    public int? InTInNid { get; set; }

    public short? InTTwrTyp { get; set; }

    public int? InTTwrFirma { get; set; }

    public int? InTTwrNumer { get; set; }

    public short? InTTwrLp { get; set; }

    public decimal? InTIloscMag { get; set; }

    public decimal? InTCena { get; set; }

    public short? InTCckTyp { get; set; }

    public int? InTCckFirma { get; set; }

    public int? InTCckNumer { get; set; }

    public short? InTCckLp { get; set; }

    public string? InTCecha { get; set; }

    public int? InTMgaId { get; set; }

    public int? InTTpaId { get; set; }

    public string? InTGuid { get; set; }

    public virtual InwNag? InTInN { get; set; }

    public virtual ICollection<InwMagTwr> InwMagTwrs { get; set; } = new List<InwMagTwr>();

    public virtual ICollection<InwOdcTwr> InwOdcTwrs { get; set; } = new List<InwOdcTwr>();
}

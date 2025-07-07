using System;
using System.Collections.Generic;

namespace TSL.Data.Models.ERPXL_TSL_LMT;

public partial class SrwSruHistoriaDok
{
    public int SshdId { get; set; }

    public int? SshdSruId { get; set; }

    public int? SshdDokNumer { get; set; }

    public short? SshdDokTyp { get; set; }

    public virtual ICollection<SrwSruHistoriaDokLinki> SrwSruHistoriaDokLinkis { get; set; } = new List<SrwSruHistoriaDokLinki>();
}

using System;
using System.Collections.Generic;

namespace TSL.Data.Models.CDN_TSL_Szkolenia;

public partial class TypWyplataGrupaSkladniki
{
    public int TwkTwkId { get; set; }

    public int TwkTwyId { get; set; }

    public int TwkTwpId { get; set; }

    public virtual TypWyplatum TwkTwp { get; set; } = null!;

    public virtual TypWyplataGrupa TwkTwy { get; set; } = null!;
}

using System;
using System.Collections.Generic;

namespace TSL.Data.Models.CDN_TSL_Szkolenia2;

public partial class RejestracjaZgodTrescEsklepy
{
    public int RztesRztesid { get; set; }

    public int RztesRztid { get; set; }

    public int RztesESklepId { get; set; }

    public byte RztesESklepWyslana { get; set; }

    public byte RztesPrzyszlaZeSklep { get; set; }

    public virtual ESklepStanowiska RztesESklep { get; set; } = null!;

    public virtual RejestracjaZgodTresc RztesRzt { get; set; } = null!;
}

using System;
using System.Collections.Generic;

namespace TSL.Data.Models.CDN_TSL_Szkolenia2;

public partial class KntZamknMy
{
    public int KzmKzmid { get; set; }

    public int? KzmKntId { get; set; }

    public short KzmRok { get; set; }

    public byte KzmMies { get; set; }

    public byte KzmStatus { get; set; }

    public DateTime? KzmDataZamkn { get; set; }

    public byte KzmWyslano { get; set; }

    public virtual Kontrahenci? KzmKnt { get; set; }
}

using System;
using System.Collections.Generic;

namespace TSL.Data.Models.CDN_TSL_GROUP;

public partial class Obroty
{
    public int ObrAccId { get; set; }

    public int? ObrRokMies { get; set; }

    public byte ObrTyp { get; set; }

    public decimal ObrObrotyWn { get; set; }

    public decimal ObrObrotyMa { get; set; }

    public decimal ObrObrotyWnBufor { get; set; }

    public decimal ObrObrotyMaBufor { get; set; }

    public decimal ObrObrotyWnWal { get; set; }

    public decimal ObrObrotyMaWal { get; set; }

    public decimal ObrObrotyWnBuforWal { get; set; }

    public decimal ObrObrotyMaBuforWal { get; set; }

    public virtual Kontum ObrAcc { get; set; } = null!;
}

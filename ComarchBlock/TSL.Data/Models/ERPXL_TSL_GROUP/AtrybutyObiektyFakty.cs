using System;
using System.Collections.Generic;

namespace TSL.Data.Models.ERPXL_TSL_GROUP;

public partial class AtrybutyObiektyFakty
{
    public int AofAtOtyp { get; set; }

    public short AofAtOelement { get; set; }

    public int AofAtOatkId { get; set; }

    public int AofKosId { get; set; }

    public int AofFakId { get; set; }

    public virtual AtrybutyFakty AtrybutyFakty { get; set; } = null!;

    public virtual AtrybutyObiekty AtrybutyObiekty { get; set; } = null!;
}

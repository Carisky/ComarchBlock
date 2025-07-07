using System;
using System.Collections.Generic;

namespace TSL.Data.Models.ERPXL_TSL;

public partial class Kostki
{
    public int KosId { get; set; }

    public string? KosBiid { get; set; }

    public int? KosTranslationId { get; set; }

    public string? KosInternalName { get; set; }

    public virtual ICollection<AtrybutyFakty> AtrybutyFakties { get; set; } = new List<AtrybutyFakty>();
}

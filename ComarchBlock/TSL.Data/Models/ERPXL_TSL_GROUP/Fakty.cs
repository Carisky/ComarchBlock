using System;
using System.Collections.Generic;

namespace TSL.Data.Models.ERPXL_TSL_GROUP;

public partial class Fakty
{
    public int FakId { get; set; }

    public int? FakBiid { get; set; }

    public int? FakTranslationId { get; set; }

    public string? FakInternalName { get; set; }

    public virtual ICollection<AtrybutyFakty> AtrybutyFakties { get; set; } = new List<AtrybutyFakty>();
}

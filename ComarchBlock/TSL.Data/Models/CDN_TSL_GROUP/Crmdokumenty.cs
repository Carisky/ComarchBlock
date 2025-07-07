using System;
using System.Collections.Generic;

namespace TSL.Data.Models.CDN_TSL_GROUP;

public partial class Crmdokumenty
{
    public int CrdCrdid { get; set; }

    public int CrdCrkid { get; set; }

    public byte CrdRodzajDokumentu { get; set; }

    public short? CrdTypDokumentu { get; set; }

    public int? CrdDokumentId { get; set; }

    public string? CrdSciezkaDostepu { get; set; }

    public int? CrdPolozeniePliku { get; set; }

    public long? CrdIbardId { get; set; }

    public virtual Crmkontakty CrdCrk { get; set; } = null!;
}

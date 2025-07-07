using System;
using System.Collections.Generic;

namespace TSL.Data.Models.ERPXL_TSL_LMT;

public partial class KompNag
{
    public int KmnId { get; set; }

    public short? KmnRok { get; set; }

    public string? KmnSeria { get; set; }

    public int? KmnNumer { get; set; }

    public byte? KmnStatus { get; set; }

    public int? KmnDataDokumentu { get; set; }

    public int? KmnDataKompensaty { get; set; }

    public short? KmnKnttyp { get; set; }

    public int? KmnKntnumer { get; set; }

    public string? KmnNumerDokumentu { get; set; }

    public string? KmnTresc { get; set; }

    public string? KmnDziennik { get; set; }

    public byte? KmnZaksiegowano { get; set; }

    public byte? KmnNieKsiegowac { get; set; }

    public int? KmnDataKsiegowania { get; set; }

    public int? KmnOpeWnumer { get; set; }

    public int? KmnOpeMnumer { get; set; }

    public int? KmnOpeZnumer { get; set; }

    public string? KmnCechaOpis { get; set; }

    public string? KmnUrl { get; set; }

    public string? KmnUwagi { get; set; }

    public int? KmnAktywny { get; set; }

    public byte? KmnBylaProponowana { get; set; }

    public byte? KmnAkcjaGenerowanie { get; set; }

    public virtual ICollection<KompElem> KompElems { get; set; } = new List<KompElem>();
}

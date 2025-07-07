using System;
using System.Collections.Generic;

namespace TSL.Data.Models.ERPXL_TSL_Szkoleniowa;

public partial class KluczeNag
{
    public int KlnId { get; set; }

    public string? KlnNazwa { get; set; }

    public string? KlnOpis { get; set; }

    public byte? KlnTyp { get; set; }

    public string? KlnDefinicja { get; set; }

    public byte? KlnArchiwalny { get; set; }

    public virtual ICollection<KluczeElem> KluczeElems { get; set; } = new List<KluczeElem>();

    public virtual ICollection<KluczeParametry> KluczeParametries { get; set; } = new List<KluczeParametry>();
}

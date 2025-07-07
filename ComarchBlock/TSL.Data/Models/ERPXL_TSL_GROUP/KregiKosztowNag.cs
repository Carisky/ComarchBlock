using System;
using System.Collections.Generic;

namespace TSL.Data.Models.ERPXL_TSL_GROUP;

public partial class KregiKosztowNag
{
    public int KknId { get; set; }

    public string? KknNazwa { get; set; }

    public int? KknOkres { get; set; }

    public byte? KknReakcja { get; set; }

    public string? KknDziennik { get; set; }

    public byte? KknArchiwalny { get; set; }

    public byte? KknUwzgledniaStrony { get; set; }

    public virtual ICollection<KregiKosztowElem> KregiKosztowElems { get; set; } = new List<KregiKosztowElem>();
}

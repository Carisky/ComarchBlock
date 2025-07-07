using System;
using System.Collections.Generic;

namespace TSL.Data.Models.ERPXL_TSL_LMT;

public partial class SfslownikiNag
{
    public int SfsnId { get; set; }

    public string? SfsnKodSystemowy { get; set; }

    public string? SfsnWersjaSchemy { get; set; }

    public short? SfsnWersjaSlownika { get; set; }

    public string? SfsnNazwa { get; set; }

    public byte? SfsnJednostka { get; set; }

    public byte? SfsnZestawienie { get; set; }

    public virtual ICollection<SfslownikiElem> SfslownikiElems { get; set; } = new List<SfslownikiElem>();
}

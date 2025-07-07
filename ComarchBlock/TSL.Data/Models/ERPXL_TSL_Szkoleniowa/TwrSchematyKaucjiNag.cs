using System;
using System.Collections.Generic;

namespace TSL.Data.Models.ERPXL_TSL_Szkoleniowa;

public partial class TwrSchematyKaucjiNag
{
    public int SknId { get; set; }

    public string? SknKod { get; set; }

    public string? SknNazwa { get; set; }

    public int? SknLastMod { get; set; }

    public byte? SknOddzialowy { get; set; }

    public byte? SknArchiwalny { get; set; }

    public virtual ICollection<TwrSchematyKaucjiElem> TwrSchematyKaucjiElems { get; set; } = new List<TwrSchematyKaucjiElem>();
}

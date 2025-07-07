using System;
using System.Collections.Generic;

namespace TSL.Data.Models.ERPXL_TSL_test;

public partial class DtsDeklaracjeNag
{
    public int DdnId { get; set; }

    public int? DdnProgramId { get; set; }

    public byte? DdnXl { get; set; }

    public int? DdnDkNid { get; set; }

    public short? DdnTypDeklar { get; set; }

    public int? DdnRokMiesiac { get; set; }

    public int? DdnIdentyfikator { get; set; }

    public byte? DdnWersja { get; set; }

    public int? DdnTstamp { get; set; }

    public virtual ICollection<DtsDeklaracjeElem> DtsDeklaracjeElems { get; set; } = new List<DtsDeklaracjeElem>();
}

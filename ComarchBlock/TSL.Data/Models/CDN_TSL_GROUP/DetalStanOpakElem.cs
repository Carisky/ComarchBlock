using System;
using System.Collections.Generic;

namespace TSL.Data.Models.CDN_TSL_GROUP;

public partial class DetalStanOpakElem
{
    public int DsoeDsoeid { get; set; }

    public int? DsoeDsonid { get; set; }

    public int DsoeLp { get; set; }

    public int DsoeDstwrId { get; set; }

    public decimal DsoeIlosc { get; set; }

    public virtual DetalStanOpakNag? DsoeDson { get; set; }
}

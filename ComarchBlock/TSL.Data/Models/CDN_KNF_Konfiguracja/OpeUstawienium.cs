using System;
using System.Collections.Generic;

namespace TSL.Data.Models.CDN_KNF_Konfiguracja;

public partial class OpeUstawienium
{
    public int OpUOpUid { get; set; }

    public int OpUOpeId { get; set; }

    public short OpUTyp { get; set; }

    public string OpUIndeks { get; set; } = null!;

    public string OpUWartosc { get; set; } = null!;

    public virtual Operatorzy OpUOpe { get; set; } = null!;
}

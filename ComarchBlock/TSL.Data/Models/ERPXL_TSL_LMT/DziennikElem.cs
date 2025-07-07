using System;
using System.Collections.Generic;

namespace TSL.Data.Models.ERPXL_TSL_LMT;

public partial class DziennikElem
{
    public short? DelGidtyp { get; set; }

    public int? DelGidfirma { get; set; }

    public int DelGidnumer { get; set; }

    public short DelGidlp { get; set; }

    public short? DelPozycja { get; set; }

    public int? DelDataWyst { get; set; }

    public int? DelDataOper { get; set; }

    public int? DelTsmodyf { get; set; }

    public string? DelOpis { get; set; }

    public string? DelDokumentZrodlowy { get; set; }

    public int? DelTs { get; set; }

    public short? DelTypKwoty { get; set; }

    public int? DelOpeWnumer { get; set; }

    public int? DelOpeZnumer { get; set; }

    public int? DelOpeMnumer { get; set; }

    public int? DelWycenaParId { get; set; }

    public int? DelKpddelnumer { get; set; }

    public short? DelKpddellp { get; set; }

    public byte? DelKpddeldc { get; set; }

    public short? DelKpddellpKpd { get; set; }

    public virtual ICollection<Dekrety> Dekreties { get; set; } = new List<Dekrety>();

    public virtual Dziennik DelGidnumerNavigation { get; set; } = null!;
}

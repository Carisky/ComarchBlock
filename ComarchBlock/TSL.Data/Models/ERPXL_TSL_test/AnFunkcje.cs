using System;
using System.Collections.Generic;

namespace TSL.Data.Models.ERPXL_TSL_test;

public partial class AnFunkcje
{
    public short AnFAnRtyp { get; set; }

    public int? AnFAnRfirma { get; set; }

    public int AnFAnRnumer { get; set; }

    public short AnFAnRlp { get; set; }

    public string? AnFAkronim { get; set; }

    public string? AnFZapisSymb { get; set; }

    public string? AnFWyrazenie { get; set; }

    public string? AnFFiltr { get; set; }

    public string? AnFQuery { get; set; }

    public string? AnFOpis { get; set; }

    public virtual AnRaporty AnFAnRnumerNavigation { get; set; } = null!;

    public virtual ICollection<AnZestawy> AnZestawies { get; set; } = new List<AnZestawy>();
}

using System;
using System.Collections.Generic;

namespace TSL.Data.Models.CDN_TSL_Szkolenia2;

public partial class DetalKntOsoby
{
    public int DknODknOid { get; set; }

    public int DknOOptimaId { get; set; }

    public int DknODsknOid { get; set; }

    public int DknODskntId { get; set; }

    public int DknOStanDetalId { get; set; }

    public string DknOTelefon { get; set; } = null!;

    public string DknOGsm { get; set; } = null!;

    public byte DknOInformacje { get; set; }

    public string DknOEmail { get; set; } = null!;

    public string DknONazwisko { get; set; } = null!;
}

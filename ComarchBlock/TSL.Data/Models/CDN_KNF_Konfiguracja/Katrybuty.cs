using System;
using System.Collections.Generic;

namespace TSL.Data.Models.CDN_KNF_Konfiguracja;

public partial class Katrybuty
{
    public int KawKawid { get; set; }

    public int KawBazId { get; set; }

    public int KawKakid { get; set; }

    public short KawRok { get; set; }

    public byte KawMiesiac { get; set; }

    public string KawWartosc { get; set; } = null!;

    public int? KawOpeId { get; set; }

    public DateTime KawTstamp { get; set; }

    public byte KawAktualny { get; set; }

    public virtual Bazy KawBaz { get; set; } = null!;

    public virtual KatrybutyKlasy KawKak { get; set; } = null!;
}

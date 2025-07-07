using System;
using System.Collections.Generic;

namespace TSL.Data.Models.CDN_TSL_GROUP;

public partial class AtrybutWartoscView
{
    public string KakNazwa { get; set; } = null!;

    public string KawWartosc { get; set; } = null!;

    public int KawBazId { get; set; }

    public short KawRok { get; set; }

    public byte KawMiesiac { get; set; }
}

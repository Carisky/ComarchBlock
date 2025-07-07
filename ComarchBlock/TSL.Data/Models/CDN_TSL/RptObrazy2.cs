using System;
using System.Collections.Generic;

namespace TSL.Data.Models.CDN_TSL;

public partial class RptObrazy2
{
    public int Rpo2Rpo2id { get; set; }

    public int Rpo2ZrodloId { get; set; }

    public int Rpo2RpWid { get; set; }

    public int Rpo2RpFid { get; set; }

    public int Rpo2DokumentTyp { get; set; }

    public int Rpo2DokumentId { get; set; }

    public byte[]? Rpo2Wartosc { get; set; }

    public int? Rpo2Rozmiar { get; set; }
}

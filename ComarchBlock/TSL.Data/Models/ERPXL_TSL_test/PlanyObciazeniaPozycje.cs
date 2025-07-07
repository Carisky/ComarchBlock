using System;
using System.Collections.Generic;

namespace TSL.Data.Models.ERPXL_TSL_test;

public partial class PlanyObciazeniaPozycje
{
    public int PpoId { get; set; }

    public short? PpoLp { get; set; }

    public int? PpoPogid { get; set; }

    public short? PpoTwrTyp { get; set; }

    public int? PpoTwrNumer { get; set; }

    public short? PpoDokZrdTyp { get; set; }

    public int? PpoDokZrdFirma { get; set; }

    public int? PpoDokZrdNumer { get; set; }

    public short? PpoDokZrdLp { get; set; }

    public decimal? PpoIloscMps { get; set; }

    public decimal? PpoIloscDoProdukcji { get; set; }

    public int? PpoTerminMps { get; set; }

    public int? PpoTerminWgObciazenia { get; set; }

    public int? PpoTerminWgZp { get; set; }

    public virtual ICollection<PlanyPozycjeSkladniki> PlanyPozycjeSkladnikis { get; set; } = new List<PlanyPozycjeSkladniki>();

    public virtual PlanyObciazeniaGniazd? PpoPog { get; set; }
}

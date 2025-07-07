using System;
using System.Collections.Generic;

namespace TSL.Data.Models.ERPXL_TSL_GROUP;

public partial class WydatkiPracownikow
{
    public int WprId { get; set; }

    public int? WprPrcNumer { get; set; }

    public int? WprData { get; set; }

    public int? WprOpeNumer { get; set; }

    public int? WprRodzajWydatku { get; set; }

    public int? WprTypWydatku { get; set; }

    public decimal? WprWartosc { get; set; }

    public int? WprSamId { get; set; }

    public short? WprDokTyp { get; set; }

    public int? WprDokFirma { get; set; }

    public int? WprDokNumer { get; set; }

    public short? WprDokLp { get; set; }

    public decimal? WprProcent { get; set; }

    public decimal? WprKwota { get; set; }

    public short? WprKntTyp { get; set; }

    public int? WprKntNumer { get; set; }

    public int? WprCwnid { get; set; }

    public string? WprOpis { get; set; }

    public int? WprRokMiesiac { get; set; }

    public int? WprZewnetrznyId { get; set; }

    public int? WprZewnetrznySys { get; set; }

    public string? WprWaluta { get; set; }

    public byte? WprZaakceptowano { get; set; }

    public int? WprDgenumer { get; set; }

    public short? WprDgelp { get; set; }

    public byte? WprDokZmianaPoAkcept { get; set; }

    public int? WprSaPid { get; set; }

    public byte? WprPredefiniowany { get; set; }

    public int? WprPozycja { get; set; }

    public virtual ICollection<WydatkiPrcPlatnosci> WydatkiPrcPlatnoscis { get; set; } = new List<WydatkiPrcPlatnosci>();
}
